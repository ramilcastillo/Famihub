using System;

namespace FamiHub.BusinessLayer.Customers.CustomerDataPush
{
    public static class Becosoft
    {
        public static bool CustomerLinkActive
        {
            get
            {
                Models.Core.Property state = FamiHub.Crud.GetById<Models.Core.Property, string>("Becosoft:CustomerLinkActive");
                if (state.Value == "1")
                    return true;
                else
                    return false;
            }
        }
        public static void Create(Models.Customers.Customer customer)
        {
            BECO_Pro_FAM_CCLink.Customers customers = new BECO_Pro_FAM_CCLink.Customers();
            long becosoftCustomerId = customers.Add(customer.LastName, customer.FirstName, customer.Street, customer.Number, 
                                                        customer.Box, String.Empty, 0, customer.Zip, customer.City, 0, 
                                                        customer.Phone, customer.MobilePhone, customer.LoyaltyCardNumber);

            General.ExternalReferences.PutReference("Customer:Becosoft", customer.Id, becosoftCustomerId);
        }

        public static void Update(Models.Customers.Customer customer)
        {
            BECO_Pro_FAM_CCLink.Customers customers = new BECO_Pro_FAM_CCLink.Customers();
            long becosoftCustomerId = Convert.ToInt64(General.ExternalReferences.GetReference("Customer:Becosoft", customer.Id));
            customers.Update(becosoftCustomerId, customer.LastName, customer.FirstName, customer.Street, customer.Number, 
                                 customer.Box, String.Empty, 0, customer.Zip, customer.City, 0, 
                                 customer.Phone, customer.MobilePhone, customer.LoyaltyCardNumber);
        }
    }
}