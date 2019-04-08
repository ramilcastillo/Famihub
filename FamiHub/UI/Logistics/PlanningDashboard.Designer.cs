using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.Logistics
{
    partial class PlanningDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanningDashboard));
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.txtLocation = new Gizmox.WebGUI.Forms.Label();
            this.txtDate = new Gizmox.WebGUI.Forms.Label();
            this.pnlTopRight = new Gizmox.WebGUI.Forms.Panel();
            this.btnPlusDay = new Gizmox.WebGUI.Forms.Button();
            this.pnlTopLeft = new Gizmox.WebGUI.Forms.Panel();
            this.btnMinDay = new Gizmox.WebGUI.Forms.Button();
            this.tmrRefresh = new Gizmox.WebGUI.Forms.Timer(this.components);
            this.dgvPlanning = new Gizmox.WebGUI.Forms.DataGridView();
            this.clmTransporter = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.clmSupplier = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.clmOrderNumber = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.clmDock = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.clmRayon = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.clmComments = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new Gizmox.WebGUI.Forms.Panel();
            this.txtSelectedPlanningInfo = new Gizmox.WebGUI.Forms.TextBox();
            this.pnlBottomRight = new Gizmox.WebGUI.Forms.Panel();
            this.btnAttachment = new Gizmox.WebGUI.Forms.Button();
            this.btnTrackTrace = new Gizmox.WebGUI.Forms.Button();
            this.btnReceived = new Gizmox.WebGUI.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlTopRight.SuspendLayout();
            this.pnlTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanning)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlBottomRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Snow;
            this.pnlTop.Controls.Add(this.txtLocation);
            this.pnlTop.Controls.Add(this.txtDate);
            this.pnlTop.Controls.Add(this.pnlTopRight);
            this.pnlTop.Controls.Add(this.pnlTopLeft);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.ExcludeFromUniqueId = false;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.NextFocusId = ((long)(0));
            this.pnlTop.PerformLayoutEnabled = true;
            this.pnlTop.PreviousFocusId = ((long)(0));
            this.pnlTop.Size = new System.Drawing.Size(842, 73);
            this.pnlTop.TabIndex = 0;
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.txtLocation.ExcludeFromUniqueId = false;
            this.txtLocation.Location = new System.Drawing.Point(446, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.NextFocusId = ((long)(0));
            this.txtLocation.PerformLayoutEnabled = true;
            this.txtLocation.PreviousFocusId = ((long)(0));
            this.txtLocation.Size = new System.Drawing.Size(296, 16);
            this.txtLocation.TabIndex = 2;
            this.txtLocation.Text = "Location";
            this.txtLocation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDate
            // 
            this.txtDate.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtDate.ExcludeFromUniqueId = false;
            this.txtDate.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(100, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.NextFocusId = ((long)(0));
            this.txtDate.PerformLayoutEnabled = true;
            this.txtDate.PreviousFocusId = ((long)(0));
            this.txtDate.Size = new System.Drawing.Size(642, 73);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "00/00/0000";
            this.txtDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.BackColor = System.Drawing.Color.Snow;
            this.pnlTopRight.Controls.Add(this.btnPlusDay);
            this.pnlTopRight.Dock = Gizmox.WebGUI.Forms.DockStyle.Right;
            this.pnlTopRight.ExcludeFromUniqueId = false;
            this.pnlTopRight.Location = new System.Drawing.Point(742, 0);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.NextFocusId = ((long)(0));
            this.pnlTopRight.PerformLayoutEnabled = true;
            this.pnlTopRight.PreviousFocusId = ((long)(0));
            this.pnlTopRight.Size = new System.Drawing.Size(100, 73);
            this.pnlTopRight.TabIndex = 0;
            // 
            // btnPlusDay
            // 
            this.btnPlusDay.BackgroundImage = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnPlusDay.BackgroundImage"));
            this.btnPlusDay.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Zoom;
            this.btnPlusDay.ExcludeFromUniqueId = false;
            this.btnPlusDay.Location = new System.Drawing.Point(12, 10);
            this.btnPlusDay.Name = "btnPlusDay";
            this.btnPlusDay.NextFocusId = ((long)(0));
            this.btnPlusDay.PerformLayoutEnabled = true;
            this.btnPlusDay.PreviousFocusId = ((long)(0));
            this.btnPlusDay.Size = new System.Drawing.Size(75, 52);
            this.btnPlusDay.TabIndex = 0;
            this.btnPlusDay.TabStop = false;
            this.btnPlusDay.Click += new System.EventHandler(this.btnPlusDay_Click);
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.BackColor = System.Drawing.Color.Snow;
            this.pnlTopLeft.Controls.Add(this.btnMinDay);
            this.pnlTopLeft.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.pnlTopLeft.ExcludeFromUniqueId = false;
            this.pnlTopLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.NextFocusId = ((long)(0));
            this.pnlTopLeft.PerformLayoutEnabled = true;
            this.pnlTopLeft.PreviousFocusId = ((long)(0));
            this.pnlTopLeft.Size = new System.Drawing.Size(100, 73);
            this.pnlTopLeft.TabIndex = 0;
            // 
            // btnMinDay
            // 
            this.btnMinDay.BackgroundImage = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnMinDay.BackgroundImage"));
            this.btnMinDay.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Zoom;
            this.btnMinDay.ExcludeFromUniqueId = false;
            this.btnMinDay.Location = new System.Drawing.Point(13, 10);
            this.btnMinDay.Name = "btnMinDay";
            this.btnMinDay.NextFocusId = ((long)(0));
            this.btnMinDay.PerformLayoutEnabled = true;
            this.btnMinDay.PreviousFocusId = ((long)(0));
            this.btnMinDay.Size = new System.Drawing.Size(75, 52);
            this.btnMinDay.TabIndex = 0;
            this.btnMinDay.TabStop = false;
            this.btnMinDay.Click += new System.EventHandler(this.btnMinDay_Click);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 60000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // dgvPlanning
            // 
            this.dgvPlanning.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.clmTransporter,
            this.clmSupplier,
            this.clmOrderNumber,
            this.clmQuantity,
            this.clmDock,
            this.clmRayon,
            this.clmComments});
            this.dgvPlanning.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgvPlanning.ExcludeFromUniqueId = false;
            this.dgvPlanning.Location = new System.Drawing.Point(0, 73);
            this.dgvPlanning.Name = "dgvPlanning";
            this.dgvPlanning.NextFocusId = ((long)(0));
            this.dgvPlanning.PerformLayoutEnabled = true;
            this.dgvPlanning.PreviousFocusId = ((long)(0));
            this.dgvPlanning.RenderCellPanelsAsText = false;
            this.dgvPlanning.RowTemplate.Enabled = true;
            this.dgvPlanning.Size = new System.Drawing.Size(842, 309);
            this.dgvPlanning.TabIndex = 1;
            this.dgvPlanning.SelectionChanged += new System.EventHandler(this.dgvPlanning_SelectionChanged);
            // 
            // clmTransporter
            // 
            this.clmTransporter.DataPropertyName = "Transporter";
            this.clmTransporter.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmTransporter.FillWeight = 50F;
            this.clmTransporter.HeaderText = "Transporter";
            this.clmTransporter.Name = "clmTransporter";
            // 
            // clmSupplier
            // 
            this.clmSupplier.DataPropertyName = "Supplier";
            this.clmSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmSupplier.FillWeight = 50F;
            this.clmSupplier.HeaderText = "Supplier";
            this.clmSupplier.Name = "clmSupplier";
            // 
            // clmOrderNumber
            // 
            this.clmOrderNumber.DataPropertyName = "OrderNumber";
            this.clmOrderNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmOrderNumber.FillWeight = 20F;
            this.clmOrderNumber.HeaderText = "Ordernumber";
            this.clmOrderNumber.Name = "clmOrderNumber";
            // 
            // clmQuantity
            // 
            this.clmQuantity.DataPropertyName = "Quantity";
            this.clmQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmQuantity.FillWeight = 20F;
            this.clmQuantity.HeaderText = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            // 
            // clmDock
            // 
            this.clmDock.DataPropertyName = "Dock";
            this.clmDock.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmDock.FillWeight = 10F;
            this.clmDock.HeaderText = "Dock";
            this.clmDock.Name = "clmDock";
            // 
            // clmRayon
            // 
            this.clmRayon.DataPropertyName = "Rayon";
            this.clmRayon.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmRayon.FillWeight = 50F;
            this.clmRayon.HeaderText = "Rayon";
            this.clmRayon.Name = "clmRayon";
            // 
            // clmComments
            // 
            this.clmComments.DataPropertyName = "Comments";
            this.clmComments.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmComments.HeaderText = "Comments";
            this.clmComments.Name = "clmComments";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.txtSelectedPlanningInfo);
            this.pnlBottom.Controls.Add(this.pnlBottomRight);
            this.pnlBottom.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.pnlBottom.ExcludeFromUniqueId = false;
            this.pnlBottom.Location = new System.Drawing.Point(0, 382);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.NextFocusId = ((long)(0));
            this.pnlBottom.PerformLayoutEnabled = true;
            this.pnlBottom.PreviousFocusId = ((long)(0));
            this.pnlBottom.Size = new System.Drawing.Size(842, 187);
            this.pnlBottom.TabIndex = 2;
            // 
            // txtSelectedPlanningInfo
            // 
            this.txtSelectedPlanningInfo.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtSelectedPlanningInfo.ExcludeFromUniqueId = false;
            this.txtSelectedPlanningInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedPlanningInfo.Location = new System.Drawing.Point(0, 0);
            this.txtSelectedPlanningInfo.Multiline = true;
            this.txtSelectedPlanningInfo.Name = "txtSelectedPlanningInfo";
            this.txtSelectedPlanningInfo.NextFocusId = ((long)(0));
            this.txtSelectedPlanningInfo.PerformLayoutEnabled = true;
            this.txtSelectedPlanningInfo.PreviousFocusId = ((long)(0));
            this.txtSelectedPlanningInfo.ReadOnly = true;
            this.txtSelectedPlanningInfo.ScrollBars = Gizmox.WebGUI.Forms.ScrollBars.Vertical;
            this.txtSelectedPlanningInfo.Size = new System.Drawing.Size(742, 187);
            this.txtSelectedPlanningInfo.TabIndex = 0;
            // 
            // pnlBottomRight
            // 
            this.pnlBottomRight.Controls.Add(this.btnReceived);
            this.pnlBottomRight.Controls.Add(this.btnTrackTrace);
            this.pnlBottomRight.Controls.Add(this.btnAttachment);
            this.pnlBottomRight.Dock = Gizmox.WebGUI.Forms.DockStyle.Right;
            this.pnlBottomRight.ExcludeFromUniqueId = false;
            this.pnlBottomRight.Location = new System.Drawing.Point(742, 0);
            this.pnlBottomRight.Name = "pnlBottomRight";
            this.pnlBottomRight.NextFocusId = ((long)(0));
            this.pnlBottomRight.PerformLayoutEnabled = true;
            this.pnlBottomRight.PreviousFocusId = ((long)(0));
            this.pnlBottomRight.Size = new System.Drawing.Size(100, 187);
            this.pnlBottomRight.TabIndex = 1;
            // 
            // btnAttachment
            // 
            this.btnAttachment.ExcludeFromUniqueId = false;
            this.btnAttachment.Location = new System.Drawing.Point(12, 11);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.NextFocusId = ((long)(0));
            this.btnAttachment.PerformLayoutEnabled = true;
            this.btnAttachment.PreviousFocusId = ((long)(0));
            this.btnAttachment.Size = new System.Drawing.Size(75, 41);
            this.btnAttachment.TabIndex = 0;
            this.btnAttachment.Text = "Open attachment";
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // btnTrackTrace
            // 
            this.btnTrackTrace.ExcludeFromUniqueId = false;
            this.btnTrackTrace.Location = new System.Drawing.Point(13, 67);
            this.btnTrackTrace.Name = "btnTrackTrace";
            this.btnTrackTrace.NextFocusId = ((long)(0));
            this.btnTrackTrace.PerformLayoutEnabled = true;
            this.btnTrackTrace.PreviousFocusId = ((long)(0));
            this.btnTrackTrace.Size = new System.Drawing.Size(75, 41);
            this.btnTrackTrace.TabIndex = 0;
            this.btnTrackTrace.Text = "Open track && trace";
            this.btnTrackTrace.Click += new System.EventHandler(this.btnTrackTrace_Click);
            // 
            // btnReceived
            // 
            this.btnReceived.ExcludeFromUniqueId = false;
            this.btnReceived.Location = new System.Drawing.Point(13, 122);
            this.btnReceived.Name = "btnReceived";
            this.btnReceived.NextFocusId = ((long)(0));
            this.btnReceived.PerformLayoutEnabled = true;
            this.btnReceived.PreviousFocusId = ((long)(0));
            this.btnReceived.Size = new System.Drawing.Size(75, 41);
            this.btnReceived.TabIndex = 0;
            this.btnReceived.Text = "Delivery processed";
            this.btnReceived.Click += new System.EventHandler(this.btnReceived_Click);
            // 
            // PlanningDashboard
            // 
            this.Controls.Add(this.dgvPlanning);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Size = new System.Drawing.Size(842, 569);
            this.Text = "PlanningDashboard";
            this.RegisteredTimers = new Gizmox.WebGUI.Forms.Timer[] {
        this.tmrRefresh};
            this.pnlTop.ResumeLayout(false);
            this.pnlTopRight.ResumeLayout(false);
            this.pnlTopLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanning)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottomRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Panel pnlTop;
        private Label txtDate;
        private Panel pnlTopRight;
        private Button btnPlusDay;
        private Panel pnlTopLeft;
        private Button btnMinDay;
        private DataGridView dgvPlanning;
        private DataGridViewTextBoxColumn clmTransporter;
        private DataGridViewTextBoxColumn clmSupplier;
        private DataGridViewTextBoxColumn clmOrderNumber;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmDock;
        private DataGridViewTextBoxColumn clmRayon;
        private DataGridViewTextBoxColumn clmComments;
        internal Timer tmrRefresh;
        internal Label txtLocation;
        private Panel pnlBottom;
        private TextBox txtSelectedPlanningInfo;
        private Panel pnlBottomRight;
        private Button btnAttachment;
        private Button btnTrackTrace;
        private Button btnReceived;
    }
}