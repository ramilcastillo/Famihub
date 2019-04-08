using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamiHubAPI.DAL
{
    public static class Generic
    {
        public static long CheckBalance(FamiHub.Models.Customers.Customer customer)
        {
            return FamiHub.BusinessLayer.Loyalty.Transactions.CheckBalance(customer);

        }

    }
}