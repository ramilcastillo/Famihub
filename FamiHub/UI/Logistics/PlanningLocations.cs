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
    public partial class PlanningLocations : FHFormTab
    {
        public PlanningLocations()
        {
            InitializeComponent();
        }

        private void PlanningLocations_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        public override void RefreshData()
        {
            lbxLocations.DataSource = Crud.GetAll<Models.Logistics.PlanningLocation>();
            lbxLocations.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Models.Logistics.PlanningLocation location = new Models.Logistics.PlanningLocation();
            location.Name = txtLocation.Text;
            location.ContainerLocation = chbContainers.Checked;
            Crud.Put(location);
            RefreshData();
            txtLocation.Text = "";
            txtLocation.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Crud.Delete((Models.Logistics.PlanningLocation)lbxLocations.SelectedItem);
            RefreshData();
            txtLocation.Focus();
        }
    }
}