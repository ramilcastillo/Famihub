using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiHub.Models.Customers
{
    public class UsedLoyaltyCardNumber
    {
        public virtual string CardNumber { get; set; }
    }
    public class LoyaltyPartner
    {
        public LoyaltyPartner()
        {
            ShortageFillerIndex = 0;
            LastInvoiceNumber = 0;
            PointValue = 1;
            PointTaxPercentage = 0;
        }
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string Zip { get; set; }
        public virtual string City { get; set; }
        public virtual Core.Country Country { get; set; }
        public virtual string VatNumber { get; set; }
        public virtual int ShortageFillerIndex { get; set; }
        public virtual long LastInvoiceNumber { get; set; }
        public virtual double PointValue { get; set; }
        public virtual double PointTaxPercentage { get; set; }
    }
    public class LoyaltyInvoice
    {
        public virtual Guid Id { get; set; }
        public virtual LoyaltyPartner InvoicingPartner { get; set; }
        public virtual LoyaltyPartner InvoicedPartner { get; set; }
        public virtual long InvoiceNumber { get; set; }
        public virtual DateTime InvoiceDate { get; set; }
        public virtual long Points { get; set; }
        public virtual double PointValue { get; set; }
        public virtual double TotalAmount { get; set; }
        public virtual double PointValueTaxIncluded { get; set; }
        public virtual double TotalAmountTaxIncluded { get; set; }
        public virtual double TaxPercentage { get; set; }
        public virtual DateTime PeriodFrom { get; set; }
        public virtual DateTime PeriodTo { get; set; }
    }
    public class LoyaltyTransaction
    {
        public LoyaltyTransaction()
        {
            Invoiced = false;
        }
        public virtual Guid Id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual DateTime TransactionDate { get; set; }
        public virtual LoyaltyPartner PointsOrigin { get; set; }
        public virtual LoyaltyPartner PointsDestination { get; set; }
        public virtual long Points { get; set; }
        public virtual string Comments { get; set; }
        public virtual Core.User User { get; set; }
        public virtual long TransactionNumber { get; set; }
        public virtual bool Invoiced { get; set; }
    }
    public class LoyaltyBalance
    {
        public virtual Customer Customer { get; set; }
        public virtual LoyaltyPartner Partner { get; set; }
        public virtual long Points { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            LoyaltyBalance LoyaltyBalanceObj = (LoyaltyBalance)obj;
            if (LoyaltyBalanceObj == null)
                return false;

            if (Customer == LoyaltyBalanceObj.Customer && Partner == LoyaltyBalanceObj.Partner)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return (Customer + "|" + Partner).GetHashCode();
        }
    }

    public class LoyaltyRewards
    {
        public virtual Guid Id { get; set; }
        public virtual string DescriptionDutch { get; set; }
        public virtual string DescriptionFrench { get; set; }
        public virtual string ProductInfoDutch { get; set; }
        public virtual string ProductInfoFrench { get; set; }
        public virtual long Points { get; set; }
        public virtual byte[] Image { get; set; }
        public virtual DateTime ValidFromDate { get; set; }
        public virtual DateTime ValidToDate { get; set; }
        public virtual LoyaltyPartner Partner { get; set; }
        public virtual string ExternalProductId { get; set; }
    }
}
