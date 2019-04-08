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
    public partial class LoyaltyPartnerForm : FHFormTab
    {
        FHFormTab _caller;
        Models.Customers.LoyaltyPartner _partner;
        public LoyaltyPartnerForm(FHFormTab caller, Models.Customers.LoyaltyPartner partner)
        {
            InitializeComponent();

            _caller = caller;
            _partner = partner;
            if (_partner == null) _partner = new Models.Customers.LoyaltyPartner();

            Common.ComboBoxFiller.CountryComboBox(cmbCountry);

            LoadData();
        }

        private void LoadData()
        {
            txtName.Text = _partner.Name;
            txtAddress.Text = _partner.Address;
            txtZip.Text = _partner.Zip;
            txtCity.Text = _partner.City;
            txtVat.Text = _partner.VatNumber;
            if (_partner.Country != null) cmbCountry.SelectedValue = _partner.Country.Id;
            nudShortageFillerIndex.Value = _partner.ShortageFillerIndex;
            txtPointValue.Text = _partner.PointValue.ToString();
            txtTaxPoint.Text = _partner.PointTaxPercentage.ToString();
            txtLastInvoiceNumber.Text = _partner.LastInvoiceNumber.ToString();

            if (string.IsNullOrEmpty(txtPointValue.Text)) txtPointValue.Text = "0";
            if (string.IsNullOrEmpty(txtTaxPoint.Text)) txtTaxPoint.Text = "0";
            if (string.IsNullOrEmpty(txtLastInvoiceNumber.Text)) txtLastInvoiceNumber.Text = "0";
        }

        public override void ButtonState()
        {
            Core.Actions.SaveBtn(true);
        }

        public override void Save()
        {
            _partner.Name = txtName.Text;
            _partner.Address = txtAddress.Text;
            _partner.Zip = txtZip.Text;
            _partner.City = txtCity.Text;
            _partner.Country = (Models.Core.Country)cmbCountry.SelectedItem;
            _partner.VatNumber = txtVat.Text;
            _partner.ShortageFillerIndex = Convert.ToInt16(nudShortageFillerIndex.Value);
            _partner.PointValue = Convert.ToDouble(txtPointValue.Text);
            _partner.PointTaxPercentage = Convert.ToDouble(txtTaxPoint.Text);
            _partner.LastInvoiceNumber = Convert.ToInt64(txtLastInvoiceNumber.Text);

            Crud.Put(_partner);
            _caller.RefreshData();
            Close();
        }

        private void DoubleValidation(object sender, EventArgs e)
        {
            Common.Validations.ValidateDouble((TextBox)sender);
        }

        private void txtLastInvoiceNumber_Leave(object sender, EventArgs e)
        {
            Common.Validations.ValidateLong((TextBox)sender);
        }
    }
}