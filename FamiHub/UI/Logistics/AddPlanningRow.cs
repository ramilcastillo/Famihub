#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Common.Interfaces;
using Gizmox.WebGUI.Forms;
using NHibernate.Criterion;

#endregion

namespace FamiHub.UI.Logistics
{
    public partial class AddPlanningRow : FHFormTab
    {
        FHFormTab _caller;
        Models.Logistics.Planning _planning;
        Models.Logistics.PlanningLocation _planningLocation;

        public AddPlanningRow(FHFormTab caller, Models.Logistics.Planning planning)
        {
            InitializeComponent();

            _caller = caller;
            _planning = planning;
            if (_planning == null) _planning = new Models.Logistics.Planning();

            if (_caller is PlanningList)
            {
                var c = (PlanningList)_caller;
                _planningLocation = (Models.Logistics.PlanningLocation)c.cmbLocation.SelectedItem;
                btnSave.Visible = false;
            }
            else if (_caller is PlanningDashboard)
            {
                var c = (PlanningDashboard)_caller;
                _planningLocation = c._location;
                _planning.NoAppointment = true;
            }

            if (!_planningLocation.ContainerLocation)
            {
                chbConfirmed.Visible = false;
                gbxContainerInfo.Visible = false;
            }

            GetTransporters();
            GetSuppliers();

            cmbDeliveryMethod.DataSource = GetDeliveryMethods();
            cmbDeliveryMethod.ValueMember = "Item1";
            cmbDeliveryMethod.DisplayMember = "Item2";

            LoadData();
        }
        
        internal static IList<Tuple<string, string>> GetDeliveryMethods()
        {
            IList<Tuple<string, string>> meth = new List<Tuple<string, string>>();

            var meth1 = new Tuple<string, string>("Truck", Common.Localization.Translate("Truck", "ContainerDeliveryMethods"));
            meth.Add(meth1);

            var meth2 = new Tuple<string, string>("ContainerAvecDecroche", Common.Localization.Translate("Container avec décroche", "ContainerDeliveryMethods"));
            meth.Add(meth2);

            var meth3 = new Tuple<string, string>("ContainerSansDecroche", Common.Localization.Translate("Container sans décroche", "ContainerDeliveryMethods"));
            meth.Add(meth3);

            return meth;
        }

        private void GetTransporters()
        {
            var session = DataConnector.NHibernateConnector.OpenSession();
            NHibernate.ICriteria criteria = session.CreateCriteria(typeof(Models.Logistics.Planning));
            criteria.SetProjection(
                    Projections.Distinct(Projections.ProjectionList()
                        .Add(Projections.Alias(Projections.Property("Transporter"), "Transporter"))
                            ));

            criteria.SetResultTransformer(
                    new NHibernate.Transform.AliasToBeanResultTransformer(typeof(Models.Logistics.Planning)));
            var res = criteria.List<Models.Logistics.Planning>();

            cmbTransporter.DataSource = res;
            cmbTransporter.DisplayMember = "Transporter";
        }

        private void GetSuppliers()
        {
            var session = DataConnector.NHibernateConnector.OpenSession();
            NHibernate.ICriteria criteria = session.CreateCriteria(typeof(Models.Logistics.Planning));
            criteria.SetProjection(
                    Projections.Distinct(Projections.ProjectionList()
                        .Add(Projections.Alias(Projections.Property("Supplier"), "Supplier"))
                            ));

            criteria.SetResultTransformer(
                    new NHibernate.Transform.AliasToBeanResultTransformer(typeof(Models.Logistics.Planning)));
            var res = criteria.List<Models.Logistics.Planning>();

            cmbSupplier.DataSource = res;
            cmbSupplier.DisplayMember = "Supplier";
        }

        private void LoadData()
        {
            cmbTransporter.Text = _planning.Transporter;
            cmbSupplier.Text = _planning.Supplier;
            txtOrderNumber.Text = _planning.OrderNumber;
            txtQuantity.Text = _planning.Quantity;
            txtDock.Text = _planning.Dock;
            txtRayon.Text = _planning.Rayon;
            dtpPlannedOn.Value = _planning.PlannedOn;
            txtComments.Text = _planning.Comments;
            txtAttachmentName.Text = _planning.AttachmentName;
            txtHour.Text = _planning.PlannedOnHour ?? "00:00";
            txtSupplierReference.Text = _planning.SupplierReference;
            txtTrackTraceLink.Text = _planning.TrackTraceLink;
            chbNoAppointment.Checked = _planning.NoAppointment;
            chbConfirmed.Checked = _planning.Confirmed;
            txtContainerNumber.Text = _planning.ContainerNumber;
            dtpDeliveryAtPort.Value = _planning.DeliveryAtPort ?? DateTime.Now;
            cmbDeliveryMethod.SelectedValue = _planning.DeliveryMethod ?? "Truck";
            chbContainerInfo.Checked = _planning.AllContainerInfoReceived;
            chbNeedPeople.Checked = _planning.NeedPeopleUnloading;
            chbPeopleConfirmed.Checked = _planning.NeedPeopleUnloadingConfirmed;
            chbReceived.Checked = _planning.Received;
        }

        public override void ButtonState()
        {
            Core.Actions.SaveBtn(true);
        }

        public override void Save()
        {
            _planning.Transporter = cmbTransporter.Text;
            _planning.Supplier = cmbSupplier.Text;
            _planning.OrderNumber = txtOrderNumber.Text;
            _planning.Quantity = txtQuantity.Text;
            _planning.Dock = txtDock.Text;
            _planning.Rayon = txtRayon.Text;
            _planning.PlannedOn = new DateTime(dtpPlannedOn.Value.Year, dtpPlannedOn.Value.Month, dtpPlannedOn.Value.Day, 0, 0, 0);
            _planning.Comments = txtComments.Text;
            _planning.PlanningLocation = _planningLocation;
            _planning.PlannedOnHour = txtHour.Text;
            _planning.SupplierReference = txtSupplierReference.Text;
            _planning.TrackTraceLink = txtTrackTraceLink.Text;
            _planning.NoAppointment = chbNoAppointment.Checked;
            _planning.Confirmed = chbConfirmed.Checked;
            _planning.ContainerNumber = txtContainerNumber.Text;
            _planning.DeliveryAtPort = new DateTime(dtpDeliveryAtPort.Value.Year, dtpDeliveryAtPort.Value.Month, dtpDeliveryAtPort.Value.Day, 0, 0, 0);
            _planning.DeliveryMethod = cmbDeliveryMethod.SelectedValue.ToString();
            _planning.AllContainerInfoReceived = chbContainerInfo.Checked;
            _planning.NeedPeopleUnloading = chbNeedPeople.Checked;
            _planning.NeedPeopleUnloadingConfirmed = chbPeopleConfirmed.Checked;
            _planning.Received = chbReceived.Checked;

            Crud.Put(_planning);

            if (_caller is PlanningList)
                ((PlanningList)_caller).RefreshData();
            if (_caller is PlanningDashboard)
                ((PlanningDashboard)_caller).RefreshData();
            Close();
        }

        private void AddPlanningRow_Load(object sender, EventArgs e)
        {
            if (_planning.Id != Guid.Empty)
            {
                txtPlanningMadeBy.Visible = true;
                txtPlanningModifiedBy.Visible = true;

                txtPlanningMadeBy.Text = String.Format(Common.Localization.Translate("Planned by {0} on {1}", "PlanningDashboard"),
                    _planning.PlanningMadeBy.FirstName + " " + _planning.PlanningMadeBy.LastName, _planning.PlanningMadeOn.ToShortDateString() + " " + _planning.PlanningMadeOn.ToLongTimeString());
                
                txtPlanningModifiedBy.Text = String.Format(Common.Localization.Translate("Modified by {0} on {1}", "PlanningDashboard"),
                    _planning.PlanningModifiedBy.FirstName + " " + _planning.PlanningModifiedBy.LastName, _planning.PlanningModifiedOn.ToShortDateString() + " " + _planning.PlanningModifiedOn.ToLongTimeString());
            }
            else
            {
                _planning.PlanningMadeBy = Common.Session.CurrentUser;
                _planning.PlanningMadeOn = DateTime.Now;
            }

            _planning.PlanningModifiedBy = Common.Session.CurrentUser;
            _planning.PlanningModifiedOn = DateTime.Now;
        }

        private void uplAttachment_UploadFileCompleted(object sender, UploadCompletedEventArgs e)
        {
            UploadFileResult result = e.Result;
            txtAttachmentName.Text = result.Name;
            _planning.Attachment = System.IO.File.ReadAllBytes(result.TempFileFullName);
            _planning.AttachmentName = result.Name;
            System.IO.File.Delete(result.TempFileFullName);
        }

        private void txtAttachmentName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_planning.Attachment != null)
            {
                Common.Interaction.DownloadFromStream(this, _planning.Attachment, _planning.AttachmentName);
            }
        }

        private void btnUploadAttachment_Click(object sender, EventArgs e)
        {
            ofdAttachment.ShowDialog();
        }

        private void ofdAttachment_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog objOFD = sender as OpenFileDialog;
            if (objOFD == null)
            {
                return;
            }

            Gizmox.WebGUI.Common.Resources.FileHandle objFile = null;
            if (objOFD.Files[0] == null || !(objOFD.Files[0] is Gizmox.WebGUI.Common.Resources.FileHandle))
            {
                return;
            }
            objFile = objOFD.Files[0] as Gizmox.WebGUI.Common.Resources.FileHandle;
            
            if (objOFD.Files.Count > 1)
            {
                Common.Interaction.ThrowMessage(this, "Only 1 file allowed. Please try again.");
                return;
            }

            txtAttachmentName.Text = objFile.OriginalFileName;
            _planning.AttachmentName = txtAttachmentName.Text;

            byte[] buffer = new byte[16 * 1024];
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                int read;
                while ((read = objFile.InputStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                _planning.Attachment = ms.ToArray();
            }
        }

        private void btnOpenTTLink_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTrackTraceLink.Text)) Link.Open(txtTrackTraceLink.Text);
        }

        private void chbNoAppointment_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNoAppointment.Checked)
            {
                txtHour.Text = "00:00";
                txtHour.Enabled = false;
            }
            else
            {
                txtHour.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}