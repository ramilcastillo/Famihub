using FluentNHibernate.Mapping;

namespace FamiHub.Models.Customers
{
    class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.Id);
            References(x => x.Salutation);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.MailAddress);
            Map(x => x.Street);
            Map(x => x.Number);
            Map(x => x.Box);
            Map(x => x.Zip);
            Map(x => x.City);
            References(x => x.Country);
            Map(x => x.Phone);
            Map(x => x.MobilePhone);
            Map(x => x.BirthDate);
            Map(x => x.UserName);
            Map(x => x.Password);
            Map(x => x.LoyaltyCardNumber).Unique();
            Map(x => x.EnrolledInLoyaltyProgram);
            Table("btc_customers");
        }
    }
}
