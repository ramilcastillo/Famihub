using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FamiHub.BusinessLayer.Loyalty
{
    public static class Transactions
    {
        public static long CheckBalance(Models.Customers.Customer customer)
        {
            var session = DataConnector.NHibernateConnector.OpenSession();
            var bal = session.CreateCriteria(typeof(Models.Customers.LoyaltyBalance))
                        .Add(Expression.Eq("Customer", customer))
                        .List<Models.Customers.LoyaltyBalance>();

            long totalBalance = 0;
            foreach (var balItem in bal)
            {
                totalBalance = totalBalance + balItem.Points;
            }

            return totalBalance;
        }

        public static IEnumerable<Models.Customers.LoyaltyTransaction> GetAllTransactions(Models.Customers.Customer customer)
        {
            var session = DataConnector.NHibernateConnector.OpenSession();
            var trans = session.CreateCriteria(typeof(Models.Customers.LoyaltyTransaction))
                        .Add(Expression.Eq("Customer", customer))
                        .List<Models.Customers.LoyaltyTransaction>();

            return trans;
        }
        public static void AddPoints(Models.Customers.Customer customer, Models.Customers.LoyaltyPartner partner, long points)
        {
            AddPoints(customer, partner, points, null, null);
        }
        public static void AddPoints(Models.Customers.Customer customer, Models.Customers.LoyaltyPartner partner, long points, Models.Core.User user)
        {
            AddPoints(customer, partner, points, null, user);
        }
        public static void AddPoints(Models.Customers.Customer customer, Models.Customers.LoyaltyPartner partner, long points, string comments)
        {
            AddPoints(customer, partner, points, comments, null);
        }
        public static void AddPoints(Models.Customers.Customer customer, Models.Customers.LoyaltyPartner partner, long points, string comments, Models.Core.User user)
        {
            if (points > 0)
            {
                using (var session = DataConnector.NHibernateConnector.OpenSession())
                {
                    using (var dbTransaction = session.BeginTransaction())
                    {
                        try
                        {
                            Models.Customers.LoyaltyTransaction transaction = new Models.Customers.LoyaltyTransaction();

                            transaction.TransactionDate = DateTime.Now;
                            if (points > 0) transaction.PointsDestination = partner;
                            if (points < 0) transaction.PointsOrigin = partner;
                            transaction.Points = points;
                            transaction.User = user;
                            transaction.Comments = comments;
                            transaction.Customer = customer;

                            session.Save(transaction);

                            var balanceObject = session.CreateCriteria(typeof(Models.Customers.LoyaltyBalance))
                                                    .Add(Expression.Eq("Customer", customer))
                                                    .Add(Expression.Eq("Partner", partner))
                                                    .UniqueResult<Models.Customers.LoyaltyBalance>();

                            if (balanceObject == null)
                            {
                                balanceObject = new Models.Customers.LoyaltyBalance();
                                balanceObject.Customer = customer;
                                balanceObject.Partner = partner;
                                balanceObject.Points = 0;
                            }

                            balanceObject.Points = balanceObject.Points + points;

                            session.SaveOrUpdate(balanceObject);

                            dbTransaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            dbTransaction.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            else if (points < 0)
            {
                UsePoints(customer, partner, points, comments);
            }
        }
        public static void UsePoints(Models.Customers.Customer customer, Models.Customers.LoyaltyPartner partner, long points, string info)
        {
            using (var session = DataConnector.NHibernateConnector.OpenSession())
            {
                try
                {
                    var balanceObject = session.CreateCriteria(typeof(Models.Customers.LoyaltyBalance))
                                            .Add(Expression.Eq("Customer", customer))
                                            .Add(Expression.Eq("Partner", partner))
                                            .UniqueResult<Models.Customers.LoyaltyBalance>();

                    if (balanceObject == null)
                    {
                        balanceObject = new Models.Customers.LoyaltyBalance();
                        balanceObject.Customer = customer;
                        balanceObject.Partner = partner;
                        balanceObject.Points = 0;
                        session.Save(balanceObject);
                    }

                    if (balanceObject.Points < points)
                    {
                        TopUpPointsFromOtherPartner(customer, partner, points - balanceObject.Points);

                        balanceObject = session.CreateCriteria(typeof(Models.Customers.LoyaltyBalance))
                                            .Add(Expression.Eq("Customer", customer))
                                            .Add(Expression.Eq("Partner", partner))
                                            .UniqueResult<Models.Customers.LoyaltyBalance>();
                    }

                    AddPoints(customer, partner, -points, info);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public static void MovePoints(Models.Customers.Customer customer, Models.Customers.LoyaltyPartner fromPartner, Models.Customers.LoyaltyPartner toPartner, long points)
        {
            if (points != 0)
            {
                using (var session = DataConnector.NHibernateConnector.OpenSession())
                {
                    using (var dbTransaction = session.BeginTransaction())
                    {
                        try
                        {
                            Models.Customers.LoyaltyTransaction transaction = new Models.Customers.LoyaltyTransaction();

                            transaction.TransactionDate = DateTime.Now;
                            transaction.PointsOrigin = fromPartner;
                            transaction.PointsDestination = toPartner;
                            transaction.Points = points;
                            transaction.Customer = customer;

                            session.Save(transaction);

                            // Add points to destination partner balance

                            var balanceObjectDestination = session.CreateCriteria(typeof(Models.Customers.LoyaltyBalance))
                                                    .Add(Expression.Eq("Customer", customer))
                                                    .Add(Expression.Eq("Partner", toPartner))
                                                    .UniqueResult<Models.Customers.LoyaltyBalance>();

                            if (balanceObjectDestination == null)
                            {
                                balanceObjectDestination = new Models.Customers.LoyaltyBalance();
                                balanceObjectDestination.Customer = customer;
                                balanceObjectDestination.Partner = toPartner;
                                balanceObjectDestination.Points = 0;
                            }

                            balanceObjectDestination.Points = balanceObjectDestination.Points + points;
                            session.SaveOrUpdate(balanceObjectDestination);

                            // Take points from origin partner balance

                            var balanceObjectOrigin = session.CreateCriteria(typeof(Models.Customers.LoyaltyBalance))
                                                    .Add(Expression.Eq("Customer", customer))
                                                    .Add(Expression.Eq("Partner", fromPartner))
                                                    .UniqueResult<Models.Customers.LoyaltyBalance>();

                            if (balanceObjectOrigin == null)
                            {
                                balanceObjectOrigin = new Models.Customers.LoyaltyBalance();
                                balanceObjectOrigin.Customer = customer;
                                balanceObjectOrigin.Partner = fromPartner;
                                balanceObjectOrigin.Points = 0;
                            }

                            balanceObjectOrigin.Points = balanceObjectOrigin.Points - points;
                            session.SaveOrUpdate(balanceObjectOrigin);

                            dbTransaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            dbTransaction.Rollback();
                            throw ex;
                        }
                    }
                }
            }
        }
        public static void TopUpPointsFromOtherPartner(Models.Customers.Customer customer, Models.Customers.LoyaltyPartner partner, long topupPoints)
        {
            using (var session = DataConnector.NHibernateConnector.OpenSession())
            {
                var partners = session.CreateCriteria(typeof(Models.Customers.LoyaltyPartner))
                                        .Add(Expression.Not(Expression.Eq("Id", partner.Id)))
                                        .AddOrder(Order.Desc("ShortageFillerIndex"))
                                        .List<Models.Customers.LoyaltyPartner>();

                var balanceObjects = new List<Models.Customers.LoyaltyBalance>();
                foreach (var partnerObject in partners)
                {
                    var balanceObject = session.CreateCriteria(typeof(Models.Customers.LoyaltyBalance))
                                        .Add(Expression.Eq("Customer", customer))
                                        .Add(Expression.Eq("Partner", partnerObject))
                                        .UniqueResult<Models.Customers.LoyaltyBalance>();
                    balanceObjects.Add(balanceObject);
                }

                foreach (var balance in balanceObjects)
                {
                    if (balance.Points > 0)
                    {
                        if (balance.Points >= topupPoints)
                        {
                            MovePoints(customer, balance.Partner, partner, topupPoints);
                            topupPoints = 0;
                        }
                        else
                        {
                            MovePoints(customer, balance.Partner, partner, balance.Points);
                            topupPoints = topupPoints - balance.Points;
                        }
                    }
                }
            }
        }
    }
}
