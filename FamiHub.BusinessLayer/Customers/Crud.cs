using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiHub.BusinessLayer.Customers
{
    public static class Crud
    {
        public static Models.Customers.Customer Put(Models.Customers.Customer customer)
        {
            if (string.IsNullOrEmpty(customer.LoyaltyCardNumber)) customer.LoyaltyCardNumber = Loyalty.Card.GetNextLoyaltyCardNumber(true);
            if (customer.Id == Guid.Empty)
            {
                FamiHub.Crud.Put(customer);
                if (CustomerDataPush.Becosoft.CustomerLinkActive) CustomerDataPush.Becosoft.Create(customer);
            }
            else
            {
                FamiHub.Crud.Put(customer);
                if (CustomerDataPush.Becosoft.CustomerLinkActive) CustomerDataPush.Becosoft.Update(customer);
            }

            return customer;
        }
    }
}
