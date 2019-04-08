#region Using

using NHibernate.Criterion;
using System;
using System.Collections.Generic;

#endregion

namespace FamiHub.UI.Customers
{
    public partial class CustomerForm : FHFormTab
    {
        FHFormTab _caller;
        Models.Customers.Customer _customer;

        public CustomerForm(FHFormTab caller, Models.Customers.Customer customer)
        {
            InitializeComponent();

            _caller = caller;
            _customer = customer;
            if (_customer == null) _customer = new Models.Customers.Customer();

            Common.ComboBoxFiller.CountryComboBox(cmbCountry);
            Common.ComboBoxFiller.SalutationComboBox(cmbSalutation);

            LoadData();
        }

        private void btnAddLoyaltyTransaction_Click(object sender, EventArgs e)
        {
            AddLoyaltyTransaction addLoyaltyTransactionForm = new AddLoyaltyTransaction(this, _customer);
            addLoyaltyTransactionForm.ShowDialog();
        }

        private void btnUsePoints_Click(object sender, EventArgs e)
        {
            UseLoyaltyPoints useLoyaltyPointsForm = new UseLoyaltyPoints(this, _customer);
            useLoyaltyPointsForm.ShowDialog();
        }
        
        private void LoadData()
        {
            txtName.Text = _customer.LastName;
            txtFirstName.Text = _customer.FirstName;
            if (_customer.Salutation != null) cmbSalutation.SelectedValue = _customer.Salutation.Id;
            dtpBirthDate.Value = _customer.BirthDate;

            // Tab 'Contact details'
            txtStreet.Text = _customer.Street;
            txtNumber.Text = _customer.Number;
            txtBox.Text = _customer.Box;
            txtZip.Text = _customer.Zip;
            txtCity.Text = _customer.City;
            if (_customer.Country != null) cmbCountry.SelectedValue = _customer.Country.Id;
            txtMailAddress.Text = _customer.MailAddress;
            txtPhone.Text = _customer.Phone;
            txtMobilePhone.Text = _customer.MobilePhone;

            // Tab 'Loyalty program info'
            txtLoyaltyCardNumber.Text = _customer.LoyaltyCardNumber;

            // Tab 'Loyalty program info' : Tab 'Balance overview'
            if (_customer.Id != Guid.Empty)
            {
                Common.FormHandling.SetGridEdit(dgvLoyaltyBalances, false);
                FillLoyaltyBalances();

                Common.FormHandling.SetGridEdit(dgvLoyaltyTransactions, false);
                FillLoyaltyTransactions();
            }
            else
            {
                wstLoyalty.Hide();

                btnUsePoints.Hide();
                btnAddLoyaltyTransaction.Hide();
            }
        }

        internal void FillLoyaltyBalances()
        {
            IList<LoyaltyBalanceItem> items = new List<LoyaltyBalanceItem>();
            var session = Common.Session.DatabaseConnection;
            var bal = session.CreateCriteria(typeof(Models.Customers.LoyaltyBalance))
                        .Add(Expression.Eq("Customer", _customer))
                        .List<Models.Customers.LoyaltyBalance>();
            long totalBalance = 0;

            foreach (var balItem in bal)
            {
                LoyaltyBalanceItem item = new LoyaltyBalanceItem();
                item.LoyaltyBalance = balItem;
                items.Add(item);
                totalBalance = totalBalance + balItem.Points;
            }

            dgvLoyaltyBalances.DataSource = null;
            dgvLoyaltyBalances.DataSource = items;
            txtTotalBalance.Text = BusinessLayer.Loyalty.Transactions.CheckBalance(_customer).ToString() + " pts";
        }

        internal void FillLoyaltyTransactions()
        {
            IList<LoyaltyTransactionItem> items = new List<LoyaltyTransactionItem>();
            var session = Common.Session.DatabaseConnection;
            var tran = session.CreateCriteria(typeof(Models.Customers.LoyaltyTransaction))
                            .Add(Expression.Eq("Customer", _customer))
                            .List<Models.Customers.LoyaltyTransaction>();

            foreach (var tranItem in tran)
            {
                LoyaltyTransactionItem item = new LoyaltyTransactionItem();
                item.LoyaltyTransaction = tranItem;
                items.Add(item);
            }

            dgvLoyaltyTransactions.DataSource = null;
            dgvLoyaltyTransactions.DataSource = items;
        }

        public override void ButtonState()
        {
            Core.Actions.SaveBtn(true);
        }

        public override void Save()
        {
            _customer.LastName = txtName.Text;
            _customer.FirstName = txtFirstName.Text;
            _customer.Salutation = (Models.Core.Salutation)cmbSalutation.SelectedItem;
            _customer.BirthDate = new DateTime(dtpBirthDate.Value.Year, dtpBirthDate.Value.Month, dtpBirthDate.Value.Day, 0, 0, 0);

            // Tab 'Contact details'
            _customer.Street = txtStreet.Text;
            _customer.Number = txtNumber.Text;
            _customer.Box = txtBox.Text;
            _customer.Zip = txtZip.Text;
            _customer.City = txtCity.Text;
            _customer.Country = (Models.Core.Country)cmbCountry.SelectedItem;
            _customer.MailAddress = txtMailAddress.Text;
            _customer.Phone = txtPhone.Text;
            _customer.MobilePhone = txtMobilePhone.Text;

            // Tab 'Loyalty program info'
            _customer.LoyaltyCardNumber = txtLoyaltyCardNumber.Text;

            //Crud.Put(_customer);
            BusinessLayer.Customers.Crud.Put(_customer);
            _caller.RefreshData();
            Close();
        }

        private class LoyaltyBalanceItem
        {
            public Models.Customers.LoyaltyBalance LoyaltyBalance { get; set; }
            public string PartnerName { get { return LoyaltyBalance.Partner.Name; } }
            public string PointsText { get { return LoyaltyBalance.Points.ToString() + " pts"; } }
            public long PointsValue { get { return LoyaltyBalance.Points; } }
        }

        private class LoyaltyTransactionItem
        {
            public string Destination { get { return LoyaltyTransaction.PointsDestination?.Name; } }
            public string Info { get { return LoyaltyTransaction.Comments; } }
            public Models.Customers.LoyaltyTransaction LoyaltyTransaction { get; set; }
            public string Origin { get { return LoyaltyTransaction.PointsOrigin?.Name; } }
            public string Points { get { return LoyaltyTransaction.Points.ToString() + " pts"; } }
            public DateTime TransactionDate { get { return LoyaltyTransaction.TransactionDate; } }
        }
    }
}