using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiHub.BusinessLayer.Loyalty
{
    public static class Invoicing
    {
        internal static long GetNextInvoiceNumber(Guid loyaltyPartnerId)
        {
            var session = DataConnector.NHibernateConnector.OpenSession();
            var partnerObject = session.CreateCriteria(typeof(Models.Customers.LoyaltyPartner))
                                                    .Add(Expression.Eq("Id", loyaltyPartnerId))
                                                    .UniqueResult<Models.Customers.LoyaltyPartner>();

            var invoiceNumber = partnerObject.LastInvoiceNumber++;
            Crud.Put(partnerObject);

            return invoiceNumber;
        }
        internal static IList<Models.Customers.LoyaltyInvoice> CalculateInvoices(DateTime fromDate, DateTime toDate)
        {
            IList<Models.Customers.LoyaltyInvoice> invoices = new List<Models.Customers.LoyaltyInvoice>();
            var session = DataConnector.NHibernateConnector.OpenSession();
            var transactions = session.CreateCriteria(typeof(Models.Customers.LoyaltyTransaction))
                                                    .Add(Expression.Eq("Invoiced", false))
                                                    .Add(Expression.Ge("TransactionDate", fromDate))
                                                    .Add(Expression.Le("TransactionDate", toDate))
                                                    .List<Models.Customers.LoyaltyTransaction>();

            var totals = transactions.Where(i => i.Invoiced == false)
                                    .GroupBy(i => new { i.PointsOrigin, i.PointsDestination })
                                    .Select(g => new Models.Customers.LoyaltyInvoice
                                    {
                                        InvoicingPartner = g.Key.PointsOrigin,
                                        InvoicedPartner = g.Key.PointsDestination,
                                        Points = g.Sum(i => i.Points)
                                    })
                                    .ToList();

            using (var tx = session.BeginTransaction())
            {
                try
                {
                    foreach (var total in totals)
                    {
                        foreach (var total2 in totals)
                        {
                            if (total.InvoicedPartner == total2.InvoicingPartner && total.InvoicingPartner == total2.InvoicedPartner)
                            {
                                total.Points = total.Points - total2.Points;
                                totals.Remove(total2);
                            }
                        }
                    }

                    foreach (var total in totals)
                    {
                        var invoicingPartner = total.InvoicingPartner;
                        var invoicedPartner = total.InvoicedPartner;

                        if (total.Points < 0)
                        {
                            total.InvoicedPartner = invoicingPartner;
                            total.InvoicingPartner = invoicedPartner;
                            total.Points = -total.Points;
                        }

                        if (total.Points == 0)
                            totals.Remove(total);
                    }

                    foreach (var total in totals)
                    {
                        var invoice = new Models.Customers.LoyaltyInvoice();
                        invoice.InvoicingPartner = total.InvoicingPartner;
                        invoice.InvoicedPartner = total.InvoicedPartner;
                        invoice.InvoiceDate = DateTime.Now;
                        invoice.InvoiceNumber = GetNextInvoiceNumber(total.InvoicingPartner.Id);
                        invoice.PeriodFrom = fromDate;
                        invoice.PeriodTo = toDate;
                        invoice.Points = total.Points;
                        invoice.PointValue = 1;
                        invoice.TaxPercentage = 21;
                        invoice.PointValueTaxIncluded = invoice.PointValue * (1 + (invoice.TaxPercentage / 100));
                        invoice.TotalAmount = invoice.PointValue * invoice.Points;
                        invoice.TotalAmountTaxIncluded = invoice.PointValueTaxIncluded * invoice.Points;

                        Crud.Put(invoice);
                        invoices.Add(invoice);
                    }

                    foreach (var transaction in transactions)
                    {
                        transaction.Invoiced = true;
                        Crud.Put(transaction);
                    }

                    tx.Commit();
                    return invoices;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw ex;
                }
            }
        }
    }
}