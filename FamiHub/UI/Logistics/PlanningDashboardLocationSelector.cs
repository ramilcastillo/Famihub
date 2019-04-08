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

namespace FamiHub.UI.Logistics
{
    public partial class PlanningDashboardLocationSelector : FHFormTab
    {
        PlanningDashboard _caller;
        bool closedWithoutInfo = true;
        public PlanningDashboardLocationSelector(PlanningDashboard caller)
        {
            InitializeComponent();
            _caller = caller;
            cmbLocation.DataSource = Crud.GetAll<Models.Logistics.PlanningLocation>();
            cmbLocation.DisplayMember = "Name";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _caller._location = (Models.Logistics.PlanningLocation)cmbLocation.SelectedItem;
            _caller.txtLocation.Text = _caller._location.Name;
            _caller.currentPlanningDate = DateTime.Now;
            _caller.tmrRefresh.Start();
            closedWithoutInfo = false;
            Close();
        }

        public override void BeforeClose()
        {
            if (closedWithoutInfo)
            {
                _caller._location = (Models.Logistics.PlanningLocation)cmbLocation.SelectedItem;
                _caller.txtLocation.Text = _caller._location.Name;
                _caller.currentPlanningDate = DateTime.Now;
                _caller.tmrRefresh.Start();
            }
        }
    }
}