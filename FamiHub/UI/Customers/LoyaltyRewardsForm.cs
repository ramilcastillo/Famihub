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
    public partial class LoyaltyRewardsForm : FHFormTab
    {
        FHFormTab _caller;
        Models.Customers.LoyaltyRewards _reward;
        public LoyaltyRewardsForm(FHFormTab caller, Models.Customers.LoyaltyRewards rewards)
        {
            InitializeComponent();
            _caller = caller;
            _reward = rewards;
            if (_reward == null) _reward = new Models.Customers.LoyaltyRewards();

            LoadData();
        }

        private void LoadData()
        {
            txtDutchDesc.Text = _reward.DescriptionDutch;
            txtFrenchDesc.Text = _reward.DescriptionFrench;
            txtProdInfoDutch.Text = _reward.ProductInfoDutch;
            txtProdInfoFrench.Text = _reward.ProductInfoFrench;
            txtPoints.Text = Convert.ToString(_reward.Points);
            dtpAvailableFrom.Value = _reward.ValidFromDate;
            dtpAvailableTo.Value = _reward.ValidToDate;
            txtExternalProductId.Text = Convert.ToString(_reward.ExternalProductId);
        }

        public override void ButtonState()
        {
            Core.Actions.SaveBtn(true);
        }

        public override void Save()
        {
            _reward.DescriptionDutch = txtDutchDesc.Text;
            _reward.DescriptionFrench = txtFrenchDesc.Text;
            _reward.ProductInfoDutch = txtProdInfoDutch.Text;
            _reward.ProductInfoFrench = txtProdInfoFrench.Text;
            _reward.Points = Convert.ToInt64(txtPoints.Text);
            _reward.ValidFromDate = dtpAvailableFrom.Value;
            _reward.ValidToDate = dtpAvailableTo.Value;
            _reward.ExternalProductId = txtExternalProductId.Text;

            Crud.Put(_reward);
            _caller.RefreshData();
            Close();
        }
    }
}