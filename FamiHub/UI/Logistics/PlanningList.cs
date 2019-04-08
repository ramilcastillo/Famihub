#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

using NHibernate.Criterion;

#endregion

namespace FamiHub.UI.Logistics
{
    public partial class PlanningList : FHList<Models.Logistics.Planning, AddPlanningRow>
    {
        internal ComboBox cmbLocation = new ComboBox();
        internal CheckBox chbShowOnlyNoAppointment = new CheckBox();
        internal CheckBox chbShowDeliveredToo = new CheckBox();
        public PlanningList()
        {
            InitializeComponent();

            AddColumn("PlannedOn", "Planned on", 20, true);
            AddColumn("PlannedOnHour", "Hour", 10, false);
            AddColumn("Transporter", "Transporter", 50, true);
            AddColumn("Supplier", "Supplier", 50, true);
            AddColumn("SupplierReference", "Supplier reference", 50, true);
            AddColumn("OrderNumber", "Ordernumber", 20, true);
            AddColumn("Quantity", "Quantity", 20, false);
            AddColumn("Dock", "Dock", 10, false);
            AddColumn("Rayon", "Rayon", 50, false);

            cmbLocation.DataSource = Crud.GetAll<Models.Logistics.PlanningLocation>();
            cmbLocation.ValueMember = "Id";
            cmbLocation.DisplayMember = "Name";
            cmbLocation.Location = new Point(Size.Width - 200, 12);
            cmbLocation.Anchor = AnchorStyles.Right;
            cmbLocation.Size = new Size(185, 21);
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.SelectedValueChanged += CmbLocation_SelectedValueChanged;
            pnlTop.Controls.Add(cmbLocation);

            chbShowOnlyNoAppointment.Location = new Point(Size.Width - 500, 12);
            chbShowOnlyNoAppointment.Anchor = AnchorStyles.Right;
            chbShowOnlyNoAppointment.Size = new Size(250, 21);
            chbShowOnlyNoAppointment.Text = "Show only without appointment";
            chbShowOnlyNoAppointment.Name = "chbShowOnlyNoAppointment";
            chbShowOnlyNoAppointment.CheckedChanged += ChbShowOnlyNoAppointment_CheckedChanged; ;
            pnlTop.Controls.Add(chbShowOnlyNoAppointment);

            chbShowDeliveredToo.Location = new Point(Size.Width - 500, 28);
            chbShowDeliveredToo.Anchor = AnchorStyles.Right;
            chbShowDeliveredToo.Size = new Size(250, 21);
            chbShowDeliveredToo.Text = "Show also delivered records";
            chbShowDeliveredToo.Name = "chbShowDeliveredToo";
            chbShowDeliveredToo.CheckedChanged += ChbShowDeliveredToo_CheckedChanged; ; ;
            pnlTop.Controls.Add(chbShowDeliveredToo);
        }

        private void ChbShowDeliveredToo_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void ChbShowOnlyNoAppointment_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void CmbLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        public override void RefreshData()
        {
            DateTime fromDate = DateTime.Now.AddDays(-365);
            var session = DataConnector.NHibernateConnector.OpenSession();
            IList<Models.Logistics.Planning> items = session.CreateCriteria(typeof(Models.Logistics.Planning))
                                                            .Add(Expression.Ge("PlannedOn", new DateTime(fromDate.Year, fromDate.Month, fromDate.Day, 0, 0, 0)))
                                                            .Add(Expression.Eq("PlanningLocation", cmbLocation.SelectedItem))
                                                            .Add(Expression.Or(Expression.Eq("NoAppointment", true), Expression.Eq("NoAppointment", chbShowOnlyNoAppointment.Checked)))
                                                            .Add(Expression.Or(Expression.Eq("Received", false), Expression.Eq("Received", chbShowDeliveredToo.Checked)))
                                                            .AddOrder(Order.Asc("PlannedOn"))
                                                            .AddOrder(Order.Asc("PlannedOnHour"))
                                                            .AddOrder(Order.Asc("Dock"))
                                                            .List<Models.Logistics.Planning>();
            dgvList.DataSource = items;

            foreach (DataGridViewRow row in dgvList.Rows)
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

            Search();
        }
    }
}