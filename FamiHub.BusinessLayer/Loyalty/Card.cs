using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiHub.BusinessLayer.Loyalty
{
    public static class Card
    {
        public static string GetNextLoyaltyCardNumber(bool virtualCard)
        {
            var session = DataConnector.NHibernateConnector.OpenSession();
            Random rnd = new Random();
            bool used = true;
            string loyaltyCardNumber = "";

            while (used)
            {
                if (virtualCard)
                {
                    loyaltyCardNumber = "2910" + (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString("0000000000");
                    loyaltyCardNumber = loyaltyCardNumber + GetCheckDigit(loyaltyCardNumber);
                }
                else
                {
                    loyaltyCardNumber = NextPhysicalCardNumber.ToString();
                    loyaltyCardNumber = loyaltyCardNumber + GetCheckDigit(loyaltyCardNumber);
                }

                var loyaltyCardObject = session.CreateCriteria(typeof(Models.Customers.UsedLoyaltyCardNumber))
                                                    .Add(Expression.Eq("CardNumber", loyaltyCardNumber))
                                                    .UniqueResult<Models.Customers.UsedLoyaltyCardNumber>();

                if (loyaltyCardObject == null) used = false;
            }

            Models.Customers.UsedLoyaltyCardNumber usedCardNumberObject = new Models.Customers.UsedLoyaltyCardNumber();
            usedCardNumberObject.CardNumber = loyaltyCardNumber;
            Crud.Put(usedCardNumberObject);

            return loyaltyCardNumber;
        }
        public static IList<string> GeneratePhysicalCardNumbers(int numberOfCardsToCreate)
        {
            IList<string> cards = new List<string>();

            for (int i = 0; i < numberOfCardsToCreate; i++)
            {
                Models.Customers.Customer customer = new Models.Customers.Customer();
                customer.LoyaltyCardNumber = GetNextLoyaltyCardNumber(false);
                customer.FirstName = "Loyalty card (not activated) - " + customer.LoyaltyCardNumber;
                Customers.Crud.Put(customer);
                cards.Add(customer.LoyaltyCardNumber);
            }

            return cards;
        }
        public static int GetCheckDigit(string cardNumber)
        {
            int sum = 0;
            for (int i = 0; i < cardNumber.Length; i++)
            {
                int n = int.Parse(cardNumber.Substring(cardNumber.Length - 1 - i, 1));
                sum += i % 2 == 0 ? n * 3 : n;
            }

            return sum % 10 == 0 ? 0 : 10 - sum % 10;
        }
        public static long NextPhysicalCardNumber
        {
            get
            {
                Models.Core.Property cardNumber = Crud.GetById<Models.Core.Property, string>("Loyalty:LastPhysicalCard");
                if (cardNumber == null)
                {
                    cardNumber = new Models.Core.Property();
                    cardNumber.Key = "Loyalty:LastPhysicalCard";
                    cardNumber.Value = "29110000000000";
                    Crud.Put(cardNumber);
                }

                long number = Convert.ToInt64(cardNumber.Value) + 1;
                cardNumber.Value = number.ToString();
                Crud.Put(cardNumber);

                return number;
            }
        }
        public static Models.Customers.Customer GetCustomerByCardNumber(string loyaltyCardNumber)
        {
            var session = DataConnector.NHibernateConnector.OpenSession();
            var customer = session.CreateCriteria(typeof(Models.Customers.Customer))
                                                    .Add(Expression.Eq("LoyaltyCardNumber", loyaltyCardNumber))
                                                    .UniqueResult<Models.Customers.Customer>();
            return customer;
        }

        public static Models.Customers.LoyaltyPartner GetLoyaltyPartnerById(Guid loyaltyPartnerId)
        {
            var session = DataConnector.NHibernateConnector.OpenSession();
            var loyaltyPartner = session.CreateCriteria(typeof(Models.Customers.LoyaltyPartner))
                                                    .Add(Expression.Eq("Id", loyaltyPartnerId))
                                                    .UniqueResult<Models.Customers.LoyaltyPartner>();
            return loyaltyPartner;
        }
        public static bool IsValidCardNumber(string loyaltyCardNumber)
        {
            var session = DataConnector.NHibernateConnector.OpenSession();
            var loyaltyCardObject = session.CreateCriteria(typeof(Models.Customers.UsedLoyaltyCardNumber))
                                                    .Add(Expression.Eq("CardNumber", loyaltyCardNumber))
                                                    .UniqueResult<Models.Customers.UsedLoyaltyCardNumber>();

            if (loyaltyCardObject == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
