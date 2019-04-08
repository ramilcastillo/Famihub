#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using NHibernate.Criterion;

#endregion

namespace FamiHub.UI.Logistics
{
    public partial class PlanningDashboard : FHFormTab
    {
        internal Models.Logistics.PlanningLocation _location;
        DateTime _currentPlanningDate;
        internal DateTime currentPlanningDate
        {
            get { return _currentPlanningDate; }
            set
            {
                _currentPlanningDate = new DateTime(value.Year, value.Month, value.Day, 0, 0, 0);
                txtDate.Text = _currentPlanningDate.ToString("dd/MM/yyyy");
                RefreshPlanning();
            }
        }

        public override void ButtonState()
        {
            Core.Actions.NewBtn(true);
        }

        public override void Add()
        {
            AddPlanningRow addPlanning = new AddPlanningRow(this, null);
            addPlanning.ShowDialog();
        }

        public PlanningDashboard()
        {
            InitializeComponent();

            Common.FormHandling.SetGridEdit(dgvPlanning, false);
            PlanningDashboardLocationSelector locSelector = new PlanningDashboardLocationSelector(this);
            locSelector.ShowDialog();
        }

        public override void RefreshData()
        {
            RefreshPlanning();
        }

        internal void RefreshPlanning()
        {
            var session = DataConnector.NHibernateConnector.OpenSession();

            var planning = session.CreateCriteria(typeof(Models.Logistics.Planning))
                                        .Add(Expression.Ge("PlannedOn", currentPlanningDate))
                                        .Add(Expression.Eq("PlanningLocation", _location))
                                        .AddOrder(Order.Asc("PlannedOn"))
                                        .AddOrder(Order.Asc("PlannedOnHour"))
                                        .AddOrder(Order.Asc("Dock"))
                                        .List<Models.Logistics.Planning>();

            dgvPlanning.DataSource = planning;

            foreach (DataGridViewRow row in dgvPlanning.Rows)
            {
                var dbi = (Models.Logistics.Planning)row.DataBoundItem;
                if (dbi.NoAppointment)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dbi.Received)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (dbi.PlanningLocation.ContainerLocation)
                {
                    if (!dbi.Confirmed)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSlateGray;
                    }
                    if (!dbi.AllContainerInfoReceived)
                    {
                        row.DefaultCellStyle.BackColor = Color.Orange;
                    }
                    if (dbi.NeedPeopleUnloading && !dbi.NeedPeopleUnloadingConfirmed)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                }
            }
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            tmrRefresh.Stop();
            RefreshPlanning();
            tmrRefresh.Start();
        }

        private void btnPlusDay_Click(object sender, EventArgs e)
        {
            currentPlanningDate = currentPlanningDate.AddDays(1);
        }

        private void btnMinDay_Click(object sender, EventArgs e)
        {
            currentPlanningDate = currentPlanningDate.AddDays(-1);
        }

        private string BoolYesNo(bool value)
        {
            if (value)
                return Common.Localization.Translate("Yes");
            else
                return Common.Localization.Translate("No");
        }

        private void dgvPlanning_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlanning.SelectedRows.Count == 1)
            {
                Models.Logistics.Planning planning = (Models.Logistics.Planning)dgvPlanning.SelectedRows[0].DataBoundItem;
                var container = planning.PlanningLocation.ContainerLocation;

                #region info text
                // Create info text
                string info = "";

                if (planning.NoAppointment)
                    info += "**********     " + Common.Localization.Translate("NO APPOINTMENT MADE BY SUPPLIER", "PlanningDashboard") + "     **********\r\n\r\n";

                info += String.Format(Common.Localization.Translate("Planned by {0} on {1}"),
                    planning.PlanningMadeBy.FirstName + " " + planning.PlanningMadeBy.LastName, planning.PlanningMadeOn.ToShortDateString() + " " + planning.PlanningMadeOn.ToLongTimeString());

                info += "\r\n" + String.Format(Common.Localization.Translate("Modified by {0} on {1}"),
                    planning.PlanningModifiedBy.FirstName + " " + planning.PlanningModifiedBy.LastName, planning.PlanningModifiedOn.ToShortDateString() + " " + planning.PlanningModifiedOn.ToLongTimeString());

                info += "\r\n\r\n";
                info += Common.Localization.Translate("PLANNED ON", "PlanningDashboard") + ": " + planning.PlannedOn.ToShortDateString() + " at " + planning.PlannedOnHour;
                if (container && !planning.Confirmed) info += " - " + Common.Localization.Translate("NOT CONFIRMED", "PlanningDashboard");
                if (container) info += "\r\n" + Common.Localization.Translate("DELIVERY AT PORT ON", "PlanningDashboard") + ": " + planning.DeliveryAtPort;

                info += "\r\n\r\n";
                info += Common.Localization.Translate("Transporter", "PlanningDashboard") + ": " + planning.Transporter + "\r\n";
                info += Common.Localization.Translate("Supplier", "PlanningDashboard") + ": " + planning.Supplier + "\r\n";
                info += Common.Localization.Translate("Supplier reference", "PlanningDashboard") + ": " + planning.SupplierReference + "\r\n";

                if (container) info += Common.Localization.Translate("Container number", "PlanningDashboard") + ": " + planning.ContainerNumber + "\r\n";

                info += Common.Localization.Translate("Ordernumber", "PlanningDashboard") + ": " + planning.OrderNumber + "\r\n";
                info += Common.Localization.Translate("Quantity", "PlanningDashboard") + ": " + planning.Quantity + "\r\n";
                info += Common.Localization.Translate("Dock", "PlanningDashboard") + ": " + planning.Dock + "\r\n";
                info += Common.Localization.Translate("Rayon", "PlanningDashboard") + ": " + planning.Rayon + "\r\n";

                if (container)
                {
                    info += Common.Localization.Translate("Delivery method", "PlanningDashboard") + ": " + AddPlanningRow.GetDeliveryMethods().FirstOrDefault(x => x.Item1 == planning.DeliveryMethod).Item2 + "\r\n";
                    info += Common.Localization.Translate("All container information received", "PlanningDashboard") + ": " + BoolYesNo(planning.AllContainerInfoReceived) + "\r\n";
                    info += Common.Localization.Translate("Need people for unloading", "PlanningDasboard") + ": " + BoolYesNo(planning.NeedPeopleUnloading) + "\r\n";
                    info += Common.Localization.Translate("Presence for unloading confirmed", "PlanningDashboard") + ": " + BoolYesNo(planning.NeedPeopleUnloadingConfirmed) + "\r\n";
                }

                info += "\r\n" + planning.Comments;
                txtSelectedPlanningInfo.Text = info;

                // End of creating info text
                #endregion

                btnAttachment.Enabled = planning.Attachment != null;
                btnTrackTrace.Enabled = !string.IsNullOrEmpty(planning.TrackTraceLink);
                btnReceived.Enabled = !planning.Received;
            }
            else
            {
                txtSelectedPlanningInfo.Text = "";
            }
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            var planning = ((Models.Logistics.Planning)dgvPlanning.SelectedRows[0].DataBoundItem);
            if (planning.Attachment != null)
            {
                Common.Interaction.DownloadFromStream(this, planning.Attachment, planning.AttachmentName);
            }
        }

        private void btnTrackTrace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(((Models.Logistics.Planning)dgvPlanning.SelectedRows[0].DataBoundItem).TrackTraceLink))
                Link.Open(((Models.Logistics.Planning)dgvPlanning.SelectedRows[0].DataBoundItem).TrackTraceLink);
        }

        private void btnReceived_Click(object sender, EventArgs e)
        {
            var planning = ((Models.Logistics.Planning)dgvPlanning.SelectedRows[0].DataBoundItem);
            planning.Received = true;
            Crud.Put(planning);
            RefreshPlanning();
        }
    }
}