#region Using

using System;
using System.Collections.Generic;

#endregion

namespace FamiHub.UI.Customers
{
    public partial class UseLoyaltyPoints : FHFormTab
    {
        Models.Customers.Customer _customer;
        CustomerForm _parentCustomerForm;

        public UseLoyaltyPoints(CustomerForm parentCustomerForm, Models.Customers.Customer customer)
        {
            InitializeComponent();

            _parentCustomerForm = parentCustomerForm;
            _customer = customer;

            LoadPartners();
        }

        private void LoadPartners()
        {
            IList<Models.Customers.LoyaltyPartner> partners = Crud.GetAll<Models.Customers.LoyaltyPartner>();

            cmbPartner.DataSource = partners;
            cmbPartner.DisplayMember = "Name";
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            if (BusinessLayer.Loyalty.Transactions.CheckBalance(_customer) >= Convert.ToInt64(txtPoints.Text))
            {
                string infoText = txtComments.Text;
                if (!string.IsNullOrEmpty(infoText)) infoText = infoText + " - ";
                infoText = infoText + "Manually by user '" + Common.Session.CurrentUser.UserName + "'";

                BusinessLayer.Loyalty.Transactions.UsePoints(_customer, (Models.Customers.LoyaltyPartner)cmbPartner.SelectedItem, Convert.ToInt64(txtPoints.Text), infoText);

                _parentCustomerForm.FillLoyaltyBalances();
                _parentCustomerForm.FillLoyaltyTransactions();

                Close();
            }
            else
            {
                Common.Interaction.ThrowMessage(this, "Not enough points to perform this transaction. Current balance is {0} points.", BusinessLayer.Loyalty.Transactions.CheckBalance(_customer).ToString());
            }
        }
    }
}