using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.Logistics
{
    partial class AddPlanningRow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Visual WebGui UserControl Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlanningRow));
            this.cmbTransporter = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblTransporter = new Gizmox.WebGUI.Forms.Label();
            this.cmbSupplier = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblSupplier = new Gizmox.WebGUI.Forms.Label();
            this.txtOrderNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.lblOrderNumber = new Gizmox.WebGUI.Forms.Label();
            this.txtQuantity = new Gizmox.WebGUI.Forms.TextBox();
            this.lblQuantity = new Gizmox.WebGUI.Forms.Label();
            this.txtDock = new Gizmox.WebGUI.Forms.TextBox();
            this.lblDock = new Gizmox.WebGUI.Forms.Label();
            this.txtRayon = new Gizmox.WebGUI.Forms.TextBox();
            this.lblRayon = new Gizmox.WebGUI.Forms.Label();
            this.dtpPlannedOn = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.lblPlannedOn = new Gizmox.WebGUI.Forms.Label();
            this.txtComments = new Gizmox.WebGUI.Forms.TextBox();
            this.lblComments = new Gizmox.WebGUI.Forms.Label();
            this.txtPlanningMadeBy = new Gizmox.WebGUI.Forms.Label();
            this.txtPlanningModifiedBy = new Gizmox.WebGUI.Forms.Label();
            this.lblAttachment = new Gizmox.WebGUI.Forms.Label();
            this.txtAttachmentName = new Gizmox.WebGUI.Forms.LinkLabel();
            this.btnUploadAttachment = new Gizmox.WebGUI.Forms.Button();
            this.ofdAttachment = new Gizmox.WebGUI.Forms.OpenFileDialog();
            this.txtHour = new Gizmox.WebGUI.Forms.MaskedTextBox();
            this.lblSupplierReference = new Gizmox.WebGUI.Forms.Label();
            this.txtSupplierReference = new Gizmox.WebGUI.Forms.TextBox();
            this.txtTrackTraceLink = new Gizmox.WebGUI.Forms.TextBox();
            this.lblTrackTraceLink = new Gizmox.WebGUI.Forms.Label();
            this.btnOpenTTLink = new Gizmox.WebGUI.Forms.Button();
            this.chbNoAppointment = new Gizmox.WebGUI.Forms.CheckBox();
            this.chbConfirmed = new Gizmox.WebGUI.Forms.CheckBox();
            this.gbxContainerInfo = new Gizmox.WebGUI.Forms.GroupBox();
            this.txtContainerNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.lblContainerNumber = new Gizmox.WebGUI.Forms.Label();
            this.dtpDeliveryAtPort = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.lblDeliveryPort = new Gizmox.WebGUI.Forms.Label();
            this.cmbDeliveryMethod = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblDeliveryMethod = new Gizmox.WebGUI.Forms.Label();
            this.chbContainerInfo = new Gizmox.WebGUI.Forms.CheckBox();
            this.chbNeedPeople = new Gizmox.WebGUI.Forms.CheckBox();
            this.chbPeopleConfirmed = new Gizmox.WebGUI.Forms.CheckBox();
            this.chbReceived = new Gizmox.WebGUI.Forms.CheckBox();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.gbxContainerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTransporter
            // 
            this.cmbTransporter.AutoCompleteMode = Gizmox.WebGUI.Forms.AutoCompleteMode.Append;
            this.cmbTransporter.AutoCompleteSource = Gizmox.WebGUI.Forms.AutoCompleteSource.ListItems;
            this.cmbTransporter.ExcludeFromUniqueId = false;
            this.cmbTransporter.FormattingEnabled = true;
            this.cmbTransporter.Location = new System.Drawing.Point(169, 7);
            this.cmbTransporter.Name = "cmbTransporter";
            this.cmbTransporter.NextFocusId = ((long)(0));
            this.cmbTransporter.PerformLayoutEnabled = true;
            this.cmbTransporter.PreviousFocusId = ((long)(0));
            this.cmbTransporter.Size = new System.Drawing.Size(368, 21);
            this.cmbTransporter.TabIndex = 0;
            // 
            // lblTransporter
            // 
            this.lblTransporter.AutoSize = true;
            this.lblTransporter.ExcludeFromUniqueId = false;
            this.lblTransporter.Location = new System.Drawing.Point(3, 10);
            this.lblTransporter.Name = "lblTransporter";
            this.lblTransporter.NextFocusId = ((long)(0));
            this.lblTransporter.PerformLayoutEnabled = true;
            this.lblTransporter.PreviousFocusId = ((long)(0));
            this.lblTransporter.Size = new System.Drawing.Size(35, 13);
            this.lblTransporter.TabIndex = 1;
            this.lblTransporter.Text = "Transporter";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.AutoCompleteMode = Gizmox.WebGUI.Forms.AutoCompleteMode.Append;
            this.cmbSupplier.AutoCompleteSource = Gizmox.WebGUI.Forms.AutoCompleteSource.ListItems;
            this.cmbSupplier.ExcludeFromUniqueId = false;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(169, 34);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.NextFocusId = ((long)(0));
            this.cmbSupplier.PerformLayoutEnabled = true;
            this.cmbSupplier.PreviousFocusId = ((long)(0));
            this.cmbSupplier.Size = new System.Drawing.Size(368, 21);
            this.cmbSupplier.TabIndex = 3;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.ExcludeFromUniqueId = false;
            this.lblSupplier.Location = new System.Drawing.Point(3, 37);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.NextFocusId = ((long)(0));
            this.lblSupplier.PerformLayoutEnabled = true;
            this.lblSupplier.PreviousFocusId = ((long)(0));
            this.lblSupplier.Size = new System.Drawing.Size(35, 13);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.ExcludeFromUniqueId = false;
            this.txtOrderNumber.Location = new System.Drawing.Point(169, 61);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.NextFocusId = ((long)(0));
            this.txtOrderNumber.PerformLayoutEnabled = true;
            this.txtOrderNumber.PreviousFocusId = ((long)(0));
            this.txtOrderNumber.Size = new System.Drawing.Size(100, 20);
            this.txtOrderNumber.TabIndex = 5;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.ExcludeFromUniqueId = false;
            this.lblOrderNumber.Location = new System.Drawing.Point(3, 64);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.NextFocusId = ((long)(0));
            this.lblOrderNumber.PerformLayoutEnabled = true;
            this.lblOrderNumber.PreviousFocusId = ((long)(0));
            this.lblOrderNumber.Size = new System.Drawing.Size(35, 13);
            this.lblOrderNumber.TabIndex = 6;
            this.lblOrderNumber.Text = "Ordernumber";
            // 
            // txtQuantity
            // 
            this.txtQuantity.ExcludeFromUniqueId = false;
            this.txtQuantity.Location = new System.Drawing.Point(169, 87);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.NextFocusId = ((long)(0));
            this.txtQuantity.PerformLayoutEnabled = true;
            this.txtQuantity.PreviousFocusId = ((long)(0));
            this.txtQuantity.Size = new System.Drawing.Size(368, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ExcludeFromUniqueId = false;
            this.lblQuantity.Location = new System.Drawing.Point(3, 90);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.NextFocusId = ((long)(0));
            this.lblQuantity.PerformLayoutEnabled = true;
            this.lblQuantity.PreviousFocusId = ((long)(0));
            this.lblQuantity.Size = new System.Drawing.Size(35, 13);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtDock
            // 
            this.txtDock.ExcludeFromUniqueId = false;
            this.txtDock.Location = new System.Drawing.Point(169, 113);
            this.txtDock.Name = "txtDock";
            this.txtDock.NextFocusId = ((long)(0));
            this.txtDock.PerformLayoutEnabled = true;
            this.txtDock.PreviousFocusId = ((long)(0));
            this.txtDock.Size = new System.Drawing.Size(100, 20);
            this.txtDock.TabIndex = 9;
            // 
            // lblDock
            // 
            this.lblDock.AutoSize = true;
            this.lblDock.ExcludeFromUniqueId = false;
            this.lblDock.Location = new System.Drawing.Point(3, 116);
            this.lblDock.Name = "lblDock";
            this.lblDock.NextFocusId = ((long)(0));
            this.lblDock.PerformLayoutEnabled = true;
            this.lblDock.PreviousFocusId = ((long)(0));
            this.lblDock.Size = new System.Drawing.Size(35, 13);
            this.lblDock.TabIndex = 10;
            this.lblDock.Text = "Dock";
            // 
            // txtRayon
            // 
            this.txtRayon.ExcludeFromUniqueId = false;
            this.txtRayon.Location = new System.Drawing.Point(169, 139);
            this.txtRayon.Name = "txtRayon";
            this.txtRayon.NextFocusId = ((long)(0));
            this.txtRayon.PerformLayoutEnabled = true;
            this.txtRayon.PreviousFocusId = ((long)(0));
            this.txtRayon.Size = new System.Drawing.Size(368, 20);
            this.txtRayon.TabIndex = 12;
            // 
            // lblRayon
            // 
            this.lblRayon.AutoSize = true;
            this.lblRayon.ExcludeFromUniqueId = false;
            this.lblRayon.Location = new System.Drawing.Point(3, 142);
            this.lblRayon.Name = "lblRayon";
            this.lblRayon.NextFocusId = ((long)(0));
            this.lblRayon.PerformLayoutEnabled = true;
            this.lblRayon.PreviousFocusId = ((long)(0));
            this.lblRayon.Size = new System.Drawing.Size(35, 13);
            this.lblRayon.TabIndex = 13;
            this.lblRayon.Text = "Rayon";
            // 
            // dtpPlannedOn
            // 
            this.dtpPlannedOn.CustomFormat = "";
            this.dtpPlannedOn.ExcludeFromUniqueId = false;
            this.dtpPlannedOn.IsEmpty = false;
            this.dtpPlannedOn.IsEmptyAllowed = false;
            this.dtpPlannedOn.Location = new System.Drawing.Point(169, 165);
            this.dtpPlannedOn.Name = "dtpPlannedOn";
            this.dtpPlannedOn.NextFocusId = ((long)(0));
            this.dtpPlannedOn.PerformLayoutEnabled = true;
            this.dtpPlannedOn.PreviousFocusId = ((long)(0));
            this.dtpPlannedOn.Size = new System.Drawing.Size(197, 21);
            this.dtpPlannedOn.TabIndex = 14;
            this.dtpPlannedOn.Value = new System.DateTime(2018, 8, 28, 0, 0, 0, 0);
            // 
            // lblPlannedOn
            // 
            this.lblPlannedOn.AutoSize = true;
            this.lblPlannedOn.ExcludeFromUniqueId = false;
            this.lblPlannedOn.Location = new System.Drawing.Point(3, 169);
            this.lblPlannedOn.Name = "lblPlannedOn";
            this.lblPlannedOn.NextFocusId = ((long)(0));
            this.lblPlannedOn.PerformLayoutEnabled = true;
            this.lblPlannedOn.PreviousFocusId = ((long)(0));
            this.lblPlannedOn.Size = new System.Drawing.Size(35, 13);
            this.lblPlannedOn.TabIndex = 15;
            this.lblPlannedOn.Text = "Planned on";
            // 
            // txtComments
            // 
            this.txtComments.ExcludeFromUniqueId = false;
            this.txtComments.Location = new System.Drawing.Point(169, 217);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.NextFocusId = ((long)(0));
            this.txtComments.PerformLayoutEnabled = true;
            this.txtComments.PreviousFocusId = ((long)(0));
            this.txtComments.Size = new System.Drawing.Size(368, 59);
            this.txtComments.TabIndex = 16;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.ExcludeFromUniqueId = false;
            this.lblComments.Location = new System.Drawing.Point(3, 220);
            this.lblComments.Name = "lblComments";
            this.lblComments.NextFocusId = ((long)(0));
            this.lblComments.PerformLayoutEnabled = true;
            this.lblComments.PreviousFocusId = ((long)(0));
            this.lblComments.Size = new System.Drawing.Size(35, 13);
            this.lblComments.TabIndex = 17;
            this.lblComments.Text = "Comments";
            // 
            // txtPlanningMadeBy
            // 
            this.txtPlanningMadeBy.ExcludeFromUniqueId = false;
            this.txtPlanningMadeBy.Location = new System.Drawing.Point(3, 400);
            this.txtPlanningMadeBy.Name = "txtPlanningMadeBy";
            this.txtPlanningMadeBy.NextFocusId = ((long)(0));
            this.txtPlanningMadeBy.PerformLayoutEnabled = true;
            this.txtPlanningMadeBy.PreviousFocusId = ((long)(0));
            this.txtPlanningMadeBy.Size = new System.Drawing.Size(561, 22);
            this.txtPlanningMadeBy.TabIndex = 18;
            this.txtPlanningMadeBy.Text = "Planning made by";
            this.txtPlanningMadeBy.Visible = false;
            // 
            // txtPlanningModifiedBy
            // 
            this.txtPlanningModifiedBy.ExcludeFromUniqueId = false;
            this.txtPlanningModifiedBy.Location = new System.Drawing.Point(3, 413);
            this.txtPlanningModifiedBy.Name = "txtPlanningModifiedBy";
            this.txtPlanningModifiedBy.NextFocusId = ((long)(0));
            this.txtPlanningModifiedBy.PerformLayoutEnabled = true;
            this.txtPlanningModifiedBy.PreviousFocusId = ((long)(0));
            this.txtPlanningModifiedBy.Size = new System.Drawing.Size(561, 22);
            this.txtPlanningModifiedBy.TabIndex = 18;
            this.txtPlanningModifiedBy.Text = "Planning modified by";
            this.txtPlanningModifiedBy.Visible = false;
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.ExcludeFromUniqueId = false;
            this.lblAttachment.Location = new System.Drawing.Point(3, 284);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.NextFocusId = ((long)(0));
            this.lblAttachment.PerformLayoutEnabled = true;
            this.lblAttachment.PreviousFocusId = ((long)(0));
            this.lblAttachment.Size = new System.Drawing.Size(35, 13);
            this.lblAttachment.TabIndex = 20;
            this.lblAttachment.Text = "Attachment";
            // 
            // txtAttachmentName
            // 
            this.txtAttachmentName.AutoSize = true;
            this.txtAttachmentName.ExcludeFromUniqueId = false;
            this.txtAttachmentName.LinkColor = System.Drawing.Color.Blue;
            this.txtAttachmentName.Location = new System.Drawing.Point(201, 284);
            this.txtAttachmentName.Name = "txtAttachmentName";
            this.txtAttachmentName.NextFocusId = ((long)(0));
            this.txtAttachmentName.PerformLayoutEnabled = true;
            this.txtAttachmentName.PreviousFocusId = ((long)(0));
            this.txtAttachmentName.Size = new System.Drawing.Size(53, 13);
            this.txtAttachmentName.TabIndex = 21;
            this.txtAttachmentName.TabStop = true;
            this.txtAttachmentName.Text = "(no attachment)";
            this.txtAttachmentName.LinkClicked += new Gizmox.WebGUI.Forms.LinkLabelLinkClickedEventHandler(this.txtAttachmentName_LinkClicked);
            // 
            // btnUploadAttachment
            // 
            this.btnUploadAttachment.BackgroundImage = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnUploadAttachment.BackgroundImage"));
            this.btnUploadAttachment.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Zoom;
            this.btnUploadAttachment.ExcludeFromUniqueId = false;
            this.btnUploadAttachment.Location = new System.Drawing.Point(169, 279);
            this.btnUploadAttachment.Name = "btnUploadAttachment";
            this.btnUploadAttachment.NextFocusId = ((long)(0));
            this.btnUploadAttachment.PerformLayoutEnabled = true;
            this.btnUploadAttachment.PreviousFocusId = ((long)(0));
            this.btnUploadAttachment.Size = new System.Drawing.Size(32, 23);
            this.btnUploadAttachment.TabIndex = 22;
            this.btnUploadAttachment.Click += new System.EventHandler(this.btnUploadAttachment_Click);
            // 
            // ofdAttachment
            // 
            this.ofdAttachment.Theme = "";
            this.ofdAttachment.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdAttachment_FileOk);
            // 
            // txtHour
            // 
            this.txtHour.CustomStyle = "Masked";
            this.txtHour.ExcludeFromUniqueId = false;
            this.txtHour.Location = new System.Drawing.Point(369, 165);
            this.txtHour.Mask = "00:00";
            this.txtHour.Name = "txtHour";
            this.txtHour.NextFocusId = ((long)(0));
            this.txtHour.PerformLayoutEnabled = true;
            this.txtHour.PreviousFocusId = ((long)(0));
            this.txtHour.PromptChar = '0';
            this.txtHour.Size = new System.Drawing.Size(51, 20);
            this.txtHour.TabIndex = 23;
            this.txtHour.Text = "00:00";
            this.txtHour.TextMaskFormat = Gizmox.WebGUI.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // lblSupplierReference
            // 
            this.lblSupplierReference.AutoSize = true;
            this.lblSupplierReference.ExcludeFromUniqueId = false;
            this.lblSupplierReference.Location = new System.Drawing.Point(282, 116);
            this.lblSupplierReference.Name = "lblSupplierReference";
            this.lblSupplierReference.NextFocusId = ((long)(0));
            this.lblSupplierReference.PerformLayoutEnabled = true;
            this.lblSupplierReference.PreviousFocusId = ((long)(0));
            this.lblSupplierReference.Size = new System.Drawing.Size(35, 13);
            this.lblSupplierReference.TabIndex = 24;
            this.lblSupplierReference.Text = "Supplier reference";
            // 
            // txtSupplierReference
            // 
            this.txtSupplierReference.ExcludeFromUniqueId = false;
            this.txtSupplierReference.Location = new System.Drawing.Point(396, 113);
            this.txtSupplierReference.Name = "txtSupplierReference";
            this.txtSupplierReference.NextFocusId = ((long)(0));
            this.txtSupplierReference.PerformLayoutEnabled = true;
            this.txtSupplierReference.PreviousFocusId = ((long)(0));
            this.txtSupplierReference.Size = new System.Drawing.Size(141, 20);
            this.txtSupplierReference.TabIndex = 25;
            // 
            // txtTrackTraceLink
            // 
            this.txtTrackTraceLink.ExcludeFromUniqueId = false;
            this.txtTrackTraceLink.Location = new System.Drawing.Point(169, 305);
            this.txtTrackTraceLink.Name = "txtTrackTraceLink";
            this.txtTrackTraceLink.NextFocusId = ((long)(0));
            this.txtTrackTraceLink.PerformLayoutEnabled = true;
            this.txtTrackTraceLink.PreviousFocusId = ((long)(0));
            this.txtTrackTraceLink.Size = new System.Drawing.Size(333, 20);
            this.txtTrackTraceLink.TabIndex = 26;
            // 
            // lblTrackTraceLink
            // 
            this.lblTrackTraceLink.AutoSize = true;
            this.lblTrackTraceLink.ExcludeFromUniqueId = false;
            this.lblTrackTraceLink.Location = new System.Drawing.Point(3, 308);
            this.lblTrackTraceLink.Name = "lblTrackTraceLink";
            this.lblTrackTraceLink.NextFocusId = ((long)(0));
            this.lblTrackTraceLink.PerformLayoutEnabled = true;
            this.lblTrackTraceLink.PreviousFocusId = ((long)(0));
            this.lblTrackTraceLink.Size = new System.Drawing.Size(35, 13);
            this.lblTrackTraceLink.TabIndex = 27;
            this.lblTrackTraceLink.Text = "Track && Trace link";
            // 
            // btnOpenTTLink
            // 
            this.btnOpenTTLink.BackgroundImage = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnOpenTTLink.BackgroundImage"));
            this.btnOpenTTLink.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Zoom;
            this.btnOpenTTLink.ExcludeFromUniqueId = false;
            this.btnOpenTTLink.Location = new System.Drawing.Point(505, 303);
            this.btnOpenTTLink.Name = "btnOpenTTLink";
            this.btnOpenTTLink.NextFocusId = ((long)(0));
            this.btnOpenTTLink.PerformLayoutEnabled = true;
            this.btnOpenTTLink.PreviousFocusId = ((long)(0));
            this.btnOpenTTLink.Size = new System.Drawing.Size(32, 22);
            this.btnOpenTTLink.TabIndex = 28;
            this.btnOpenTTLink.Click += new System.EventHandler(this.btnOpenTTLink_Click);
            // 
            // chbNoAppointment
            // 
            this.chbNoAppointment.AutoSize = true;
            this.chbNoAppointment.ExcludeFromUniqueId = false;
            this.chbNoAppointment.Location = new System.Drawing.Point(169, 189);
            this.chbNoAppointment.Name = "chbNoAppointment";
            this.chbNoAppointment.NextFocusId = ((long)(0));
            this.chbNoAppointment.PerformLayoutEnabled = true;
            this.chbNoAppointment.PreviousFocusId = ((long)(0));
            this.chbNoAppointment.Size = new System.Drawing.Size(102, 17);
            this.chbNoAppointment.TabIndex = 29;
            this.chbNoAppointment.Text = "No appointment";
            this.chbNoAppointment.CheckedChanged += new System.EventHandler(this.chbNoAppointment_CheckedChanged);
            // 
            // chbConfirmed
            // 
            this.chbConfirmed.AutoSize = true;
            this.chbConfirmed.ExcludeFromUniqueId = false;
            this.chbConfirmed.Location = new System.Drawing.Point(325, 189);
            this.chbConfirmed.Name = "chbConfirmed";
            this.chbConfirmed.NextFocusId = ((long)(0));
            this.chbConfirmed.PerformLayoutEnabled = true;
            this.chbConfirmed.PreviousFocusId = ((long)(0));
            this.chbConfirmed.Size = new System.Drawing.Size(140, 17);
            this.chbConfirmed.TabIndex = 30;
            this.chbConfirmed.Text = "Delivery date confirmed";
            // 
            // gbxContainerInfo
            // 
            this.gbxContainerInfo.Controls.Add(this.chbPeopleConfirmed);
            this.gbxContainerInfo.Controls.Add(this.chbNeedPeople);
            this.gbxContainerInfo.Controls.Add(this.chbContainerInfo);
            this.gbxContainerInfo.Controls.Add(this.lblDeliveryMethod);
            this.gbxContainerInfo.Controls.Add(this.cmbDeliveryMethod);
            this.gbxContainerInfo.Controls.Add(this.lblDeliveryPort);
            this.gbxContainerInfo.Controls.Add(this.dtpDeliveryAtPort);
            this.gbxContainerInfo.Controls.Add(this.lblContainerNumber);
            this.gbxContainerInfo.Controls.Add(this.txtContainerNumber);
            this.gbxContainerInfo.ExcludeFromUniqueId = false;
            this.gbxContainerInfo.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbxContainerInfo.Location = new System.Drawing.Point(572, 7);
            this.gbxContainerInfo.Name = "gbxContainerInfo";
            this.gbxContainerInfo.NextFocusId = ((long)(0));
            this.gbxContainerInfo.PerformLayoutEnabled = true;
            this.gbxContainerInfo.PreviousFocusId = ((long)(0));
            this.gbxContainerInfo.Size = new System.Drawing.Size(337, 160);
            this.gbxContainerInfo.TabIndex = 31;
            this.gbxContainerInfo.TabStop = false;
            this.gbxContainerInfo.Text = "Container info";
            // 
            // txtContainerNumber
            // 
            this.txtContainerNumber.ExcludeFromUniqueId = false;
            this.txtContainerNumber.Location = new System.Drawing.Point(126, 20);
            this.txtContainerNumber.Name = "txtContainerNumber";
            this.txtContainerNumber.NextFocusId = ((long)(0));
            this.txtContainerNumber.PerformLayoutEnabled = true;
            this.txtContainerNumber.PreviousFocusId = ((long)(0));
            this.txtContainerNumber.Size = new System.Drawing.Size(205, 20);
            this.txtContainerNumber.TabIndex = 0;
            // 
            // lblContainerNumber
            // 
            this.lblContainerNumber.AutoSize = true;
            this.lblContainerNumber.ExcludeFromUniqueId = false;
            this.lblContainerNumber.Location = new System.Drawing.Point(3, 23);
            this.lblContainerNumber.Name = "lblContainerNumber";
            this.lblContainerNumber.NextFocusId = ((long)(0));
            this.lblContainerNumber.PerformLayoutEnabled = true;
            this.lblContainerNumber.PreviousFocusId = ((long)(0));
            this.lblContainerNumber.Size = new System.Drawing.Size(35, 13);
            this.lblContainerNumber.TabIndex = 1;
            this.lblContainerNumber.Text = "Container number";
            // 
            // dtpDeliveryAtPort
            // 
            this.dtpDeliveryAtPort.CustomFormat = "";
            this.dtpDeliveryAtPort.ExcludeFromUniqueId = false;
            this.dtpDeliveryAtPort.IsEmpty = false;
            this.dtpDeliveryAtPort.IsEmptyAllowed = false;
            this.dtpDeliveryAtPort.Location = new System.Drawing.Point(126, 46);
            this.dtpDeliveryAtPort.Name = "dtpDeliveryAtPort";
            this.dtpDeliveryAtPort.NextFocusId = ((long)(0));
            this.dtpDeliveryAtPort.PerformLayoutEnabled = true;
            this.dtpDeliveryAtPort.PreviousFocusId = ((long)(0));
            this.dtpDeliveryAtPort.Size = new System.Drawing.Size(205, 21);
            this.dtpDeliveryAtPort.TabIndex = 2;
            this.dtpDeliveryAtPort.Value = new System.DateTime(2018, 9, 11, 0, 0, 0, 0);
            // 
            // lblDeliveryPort
            // 
            this.lblDeliveryPort.AutoSize = true;
            this.lblDeliveryPort.ExcludeFromUniqueId = false;
            this.lblDeliveryPort.Location = new System.Drawing.Point(3, 49);
            this.lblDeliveryPort.Name = "lblDeliveryPort";
            this.lblDeliveryPort.NextFocusId = ((long)(0));
            this.lblDeliveryPort.PerformLayoutEnabled = true;
            this.lblDeliveryPort.PreviousFocusId = ((long)(0));
            this.lblDeliveryPort.Size = new System.Drawing.Size(35, 13);
            this.lblDeliveryPort.TabIndex = 3;
            this.lblDeliveryPort.Text = "Delivery at port";
            // 
            // cmbDeliveryMethod
            // 
            this.cmbDeliveryMethod.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeliveryMethod.ExcludeFromUniqueId = false;
            this.cmbDeliveryMethod.FormattingEnabled = true;
            this.cmbDeliveryMethod.Location = new System.Drawing.Point(126, 73);
            this.cmbDeliveryMethod.Name = "cmbDeliveryMethod";
            this.cmbDeliveryMethod.NextFocusId = ((long)(0));
            this.cmbDeliveryMethod.PerformLayoutEnabled = true;
            this.cmbDeliveryMethod.PreviousFocusId = ((long)(0));
            this.cmbDeliveryMethod.Size = new System.Drawing.Size(205, 21);
            this.cmbDeliveryMethod.TabIndex = 4;
            // 
            // lblDeliveryMethod
            // 
            this.lblDeliveryMethod.AutoSize = true;
            this.lblDeliveryMethod.ExcludeFromUniqueId = false;
            this.lblDeliveryMethod.Location = new System.Drawing.Point(3, 76);
            this.lblDeliveryMethod.Name = "lblDeliveryMethod";
            this.lblDeliveryMethod.NextFocusId = ((long)(0));
            this.lblDeliveryMethod.PerformLayoutEnabled = true;
            this.lblDeliveryMethod.PreviousFocusId = ((long)(0));
            this.lblDeliveryMethod.Size = new System.Drawing.Size(35, 13);
            this.lblDeliveryMethod.TabIndex = 5;
            this.lblDeliveryMethod.Text = "Delivery method";
            // 
            // chbContainerInfo
            // 
            this.chbContainerInfo.AutoSize = true;
            this.chbContainerInfo.ExcludeFromUniqueId = false;
            this.chbContainerInfo.Location = new System.Drawing.Point(6, 109);
            this.chbContainerInfo.Name = "chbContainerInfo";
            this.chbContainerInfo.NextFocusId = ((long)(0));
            this.chbContainerInfo.PerformLayoutEnabled = true;
            this.chbContainerInfo.PreviousFocusId = ((long)(0));
            this.chbContainerInfo.Size = new System.Drawing.Size(150, 17);
            this.chbContainerInfo.TabIndex = 6;
            this.chbContainerInfo.Text = "All container info received";
            // 
            // chbNeedPeople
            // 
            this.chbNeedPeople.AutoSize = true;
            this.chbNeedPeople.ExcludeFromUniqueId = false;
            this.chbNeedPeople.Location = new System.Drawing.Point(6, 131);
            this.chbNeedPeople.Name = "chbNeedPeople";
            this.chbNeedPeople.NextFocusId = ((long)(0));
            this.chbNeedPeople.PerformLayoutEnabled = true;
            this.chbNeedPeople.PreviousFocusId = ((long)(0));
            this.chbNeedPeople.Size = new System.Drawing.Size(152, 17);
            this.chbNeedPeople.TabIndex = 6;
            this.chbNeedPeople.Text = "Need people for unloading";
            // 
            // chbPeopleConfirmed
            // 
            this.chbPeopleConfirmed.AutoSize = true;
            this.chbPeopleConfirmed.ExcludeFromUniqueId = false;
            this.chbPeopleConfirmed.Location = new System.Drawing.Point(179, 131);
            this.chbPeopleConfirmed.Name = "chbPeopleConfirmed";
            this.chbPeopleConfirmed.NextFocusId = ((long)(0));
            this.chbPeopleConfirmed.PerformLayoutEnabled = true;
            this.chbPeopleConfirmed.PreviousFocusId = ((long)(0));
            this.chbPeopleConfirmed.Size = new System.Drawing.Size(120, 17);
            this.chbPeopleConfirmed.TabIndex = 6;
            this.chbPeopleConfirmed.Text = "Presence confirmed";
            // 
            // chbReceived
            // 
            this.chbReceived.AutoSize = true;
            this.chbReceived.ExcludeFromUniqueId = false;
            this.chbReceived.Location = new System.Drawing.Point(169, 330);
            this.chbReceived.Name = "chbReceived";
            this.chbReceived.NextFocusId = ((long)(0));
            this.chbReceived.PerformLayoutEnabled = true;
            this.chbReceived.PreviousFocusId = ((long)(0));
            this.chbReceived.Size = new System.Drawing.Size(71, 17);
            this.chbReceived.TabIndex = 32;
            this.chbReceived.Text = "Delivered";
            // 
            // btnSave
            // 
            this.btnSave.ExcludeFromUniqueId = false;
            this.btnSave.Location = new System.Drawing.Point(165, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.NextFocusId = ((long)(0));
            this.btnSave.PerformLayoutEnabled = true;
            this.btnSave.PreviousFocusId = ((long)(0));
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddPlanningRow
            // 
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chbReceived);
            this.Controls.Add(this.gbxContainerInfo);
            this.Controls.Add(this.chbConfirmed);
            this.Controls.Add(this.chbNoAppointment);
            this.Controls.Add(this.btnOpenTTLink);
            this.Controls.Add(this.lblTrackTraceLink);
            this.Controls.Add(this.txtTrackTraceLink);
            this.Controls.Add(this.txtSupplierReference);
            this.Controls.Add(this.lblSupplierReference);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.btnUploadAttachment);
            this.Controls.Add(this.txtAttachmentName);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.txtPlanningModifiedBy);
            this.Controls.Add(this.txtPlanningMadeBy);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblPlannedOn);
            this.Controls.Add(this.dtpPlannedOn);
            this.Controls.Add(this.lblRayon);
            this.Controls.Add(this.txtRayon);
            this.Controls.Add(this.lblDock);
            this.Controls.Add(this.txtDock);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblTransporter);
            this.Controls.Add(this.cmbTransporter);
            this.Size = new System.Drawing.Size(925, 476);
            this.Text = "AddPlanningRow";
            this.Load += new System.EventHandler(this.AddPlanningRow_Load);
            this.gbxContainerInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private ComboBox cmbTransporter;
        private Label lblTransporter;
        private ComboBox cmbSupplier;
        private Label lblSupplier;
        private TextBox txtOrderNumber;
        private Label lblOrderNumber;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private TextBox txtDock;
        private Label lblDock;
        private TextBox txtRayon;
        private Label lblRayon;
        private DateTimePicker dtpPlannedOn;
        private Label lblPlannedOn;
        private TextBox txtComments;
        private Label lblComments;
        private Label txtPlanningMadeBy;
        private Label txtPlanningModifiedBy;
        private Label lblAttachment;
        private LinkLabel txtAttachmentName;
        private Button btnUploadAttachment;
        private OpenFileDialog ofdAttachment;
        private MaskedTextBox txtHour;
        private Label lblSupplierReference;
        private TextBox txtSupplierReference;
        private TextBox txtTrackTraceLink;
        private Label lblTrackTraceLink;
        private Button btnOpenTTLink;
        private CheckBox chbNoAppointment;
        private CheckBox chbConfirmed;
        private GroupBox gbxContainerInfo;
        private Label lblContainerNumber;
        private TextBox txtContainerNumber;
        private Label lblDeliveryPort;
        private DateTimePicker dtpDeliveryAtPort;
        private Label lblDeliveryMethod;
        private ComboBox cmbDeliveryMethod;
        private CheckBox chbPeopleConfirmed;
        private CheckBox chbNeedPeople;
        private CheckBox chbContainerInfo;
        private CheckBox chbReceived;
        private Button btnSave;
    }
}