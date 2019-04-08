using System;
using System.Runtime.Serialization;

namespace FamiHub.Models.Customers
{
    public class Customer
    {
        public Customer()
        {
            BirthDate = DateTime.Now;
            EnrolledInLoyaltyProgram = DateTime.Now;
        }
        public virtual Guid Id { get; set; }
        public virtual Core.Salutation Salutation { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string MailAddress { get; set; }
        public virtual string Street { get; set; }
        public virtual string Number { get; set; }
        public virtual string Box { get; set; }
        public virtual string Zip { get; set; }
        public virtual string City { get; set; }
        public virtual Core.Country Country { get; set; }
        public virtual string Phone { get; set; }
        public virtual string MobilePhone { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string LoyaltyCardNumber { get; set; }
        public virtual DateTime EnrolledInLoyaltyProgram { get; set; }
    }
}
