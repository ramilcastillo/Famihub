#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

#endregion

namespace FamiHub.UI.Customers
{
    public partial class AddLoyaltyTransaction : FHFormTab
    {
        Models.Customers.Customer _customer;
        CustomerForm _parentCustomerForm;

        public AddLoyaltyTransaction(CustomerForm parentCustomerForm, Models.Customers.Customer customer)
        {
            InitializeComponent();

            _parentCustomerForm = parentCustomerForm;
            _customer = customer;

            LoadPartners();
        }

        private void LoadPartners()
        {
            IList<Models.Customers.LoyaltyPartner> partners = Crud.GetAll<Models.Customers.LoyaltyPartner>();

            cmbDestination.DataSource = partners;
            cmbDestination.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BusinessLayer.Loyalty.Transactions.AddPoints(_customer, (Models.Customers.LoyaltyPartner)cmbDestination.SelectedItem, 
                                                          Convert.ToInt64(txtPoints.Text), txtComments.Text, Common.Session.CurrentUser);

            _parentCustomerForm.FillLoyaltyBalances();
            _parentCustomerForm.FillLoyaltyTransactions();

            Close();
        }
    }
}