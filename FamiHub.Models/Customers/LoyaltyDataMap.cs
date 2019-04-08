using FluentNHibernate.Mapping;

namespace FamiHub.Models.Customers
{
    class UsedLoyaltyCardNumberMap : ClassMap<UsedLoyaltyCardNumber>
    {
        public UsedLoyaltyCardNumberMap()
        {
            Id(x => x.CardNumber);
            Table("btc_loyaltycardnumbers_used");
        }
    }
    class LoyaltyRewadsMap : ClassMap<LoyaltyRewards>
    {
        public LoyaltyRewadsMap()
        {
            Id(x => x.Id);
            Map(x => x.DescriptionDutch);
            Map(x => x.DescriptionFrench);
            Map(x => x.ProductInfoDutch);
            Map(x => x.ProductInfoFrench);
            Map(x => x.Points);
            Map(x => x.Image);
            Map(x => x.ValidFromDate);
            Map(x => x.ValidToDate);
            References(x => x.Partner);
            Map(x => x.ExternalProductId);

            Table("btc_loyaltyrewards");
        }
    }
    class LoyaltyPartnerMap : ClassMap<LoyaltyPartner>
    {
        public LoyaltyPartnerMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Address);
            Map(x => x.Zip);
            Map(x => x.City);
            References(x => x.Country);
            Map(x => x.VatNumber);
            Map(x => x.ShortageFillerIndex);
            Map(x => x.LastInvoiceNumber);
            Map(x => x.PointValue);
            Map(x => x.PointTaxPercentage);
            Table("btc_loyaltypartners");
        }
    }
    class LoyaltyInvoiceMap : ClassMap<LoyaltyInvoice>
    {
        public LoyaltyInvoiceMap()
        {
            Id(x => x.Id);
            References(x => x.InvoicingPartner);
            References(x => x.InvoicedPartner);
            Map(x => x.InvoiceNumber);
            Map(x => x.InvoiceDate);
            Map(x => x.Points);
            Map(x => x.PointValue);
            Map(x => x.TotalAmount);
            Map(x => x.PointValueTaxIncluded);
            Map(x => x.TotalAmountTaxIncluded);
            Map(x => x.TaxPercentage);
            Map(x => x.PeriodFrom);
            Map(x => x.PeriodTo);
            Table("btc_loyalty_invoices");
        }
    }
    class LoyaltyTransactionMap : ClassMap<LoyaltyTransaction>
    {
        public LoyaltyTransactionMap()
        {
            Id(x => x.Id);
            References(x => x.Customer);
            Map(x => x.TransactionDate);
            References(x => x.PointsOrigin);
            References(x => x.PointsDestination);
            Map(x => x.Points);
            Map(x => x.Comments);
            References(x => x.User);
            Table("btc_loyaltytransactions");
        }
    }
    class LoyaltyBalanceMap : ClassMap<LoyaltyBalance>
    {
        public LoyaltyBalanceMap()
        {
            CompositeId()
                .KeyReference(x => x.Customer)
                .KeyReference(x => x.Partner);
            Map(x => x.Points);
            Table("btc_loyaltybalances");
        }
    }
}
