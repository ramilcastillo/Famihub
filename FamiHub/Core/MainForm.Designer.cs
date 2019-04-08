using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.Core
{
    partial class MainForm
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

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.lnkLogout = new Gizmox.WebGUI.Forms.LinkLabel();
            this.menuBar = new Gizmox.WebGUI.Forms.ToolStrip();
            this.btnSave = new Gizmox.WebGUI.Forms.ToolStripButton();
            this.btnCancel = new Gizmox.WebGUI.Forms.ToolStripButton();
            this.toolStripSeparator1 = new Gizmox.WebGUI.Forms.ToolStripSeparator();
            this.btnAdd = new Gizmox.WebGUI.Forms.ToolStripButton();
            this.btnDelete = new Gizmox.WebGUI.Forms.ToolStripButton();
            this.lblLoggedInAs = new Gizmox.WebGUI.Forms.Label();
            this.pnlLeft = new Gizmox.WebGUI.Forms.Panel();
            this.navigationMenu = new Gizmox.WebGUI.Forms.NavigationTabs();
            this.pnlLeftTop = new Gizmox.WebGUI.Forms.Panel();
            this.pnlLogo = new Gizmox.WebGUI.Forms.Panel();
            this.workspace = new Gizmox.WebGUI.Forms.WorkspaceTabs();
            this.tmrKeepAlive = new Gizmox.WebGUI.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationMenu)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workspace)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTop.Controls.Add(this.lnkLogout);
            this.pnlTop.Controls.Add(this.menuBar);
            this.pnlTop.Controls.Add(this.lblLoggedInAs);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.ExcludeFromUniqueId = false;
            this.pnlTop.Location = new System.Drawing.Point(226, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.NextFocusId = ((long)(0));
            this.pnlTop.PerformLayoutEnabled = true;
            this.pnlTop.PreviousFocusId = ((long)(0));
            this.pnlTop.Size = new System.Drawing.Size(800, 76);
            this.pnlTop.TabIndex = 0;
            // 
            // lnkLogout
            // 
            this.lnkLogout.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.ExcludeFromUniqueId = false;
            this.lnkLogout.LinkColor = System.Drawing.Color.Blue;
            this.lnkLogout.Location = new System.Drawing.Point(72, 6);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.NextFocusId = ((long)(0));
            this.lnkLogout.PerformLayoutEnabled = true;
            this.lnkLogout.PreviousFocusId = ((long)(0));
            this.lnkLogout.Size = new System.Drawing.Size(53, 13);
            this.lnkLogout.TabIndex = 3;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkLogout.LinkClicked += new Gizmox.WebGUI.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // menuBar
            // 
            this.menuBar.AutoSize = false;
            this.menuBar.BackColor = System.Drawing.SystemColors.Control;
            this.menuBar.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.menuBar.ExcludeFromUniqueId = false;
            this.menuBar.GripStyle = Gizmox.WebGUI.Forms.ToolStripGripStyle.Hidden;
            this.menuBar.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnCancel,
            this.toolStripSeparator1,
            this.btnAdd,
            this.btnDelete});
            this.menuBar.Location = new System.Drawing.Point(0, 42);
            this.menuBar.Margin = new Gizmox.WebGUI.Forms.Padding(4, 0, 0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.NextFocusId = ((long)(0));
            this.menuBar.PerformLayoutEnabled = true;
            this.menuBar.PreviousFocusId = ((long)(0));
            this.menuBar.Size = new System.Drawing.Size(800, 46);
            this.menuBar.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ExcludeFromUniqueId = false;
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.ImageScaling = Gizmox.WebGUI.Forms.ToolStripItemImageScaling.None;
            this.btnSave.Margin = new Gizmox.WebGUI.Forms.Padding(3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 39);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ExcludeFromUniqueId = false;
            this.btnCancel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnCancel.Image"));
            this.btnCancel.ImageScaling = Gizmox.WebGUI.Forms.ToolStripItemImageScaling.None;
            this.btnCancel.Margin = new Gizmox.WebGUI.Forms.Padding(3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(39, 39);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ExcludeFromUniqueId = false;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.ExcludeFromUniqueId = false;
            this.btnAdd.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnAdd.Image"));
            this.btnAdd.ImageScaling = Gizmox.WebGUI.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.Margin = new Gizmox.WebGUI.Forms.Padding(3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 39);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ExcludeFromUniqueId = false;
            this.btnDelete.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDelete.Image"));
            this.btnDelete.ImageScaling = Gizmox.WebGUI.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.Margin = new Gizmox.WebGUI.Forms.Padding(3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(39, 39);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.ExcludeFromUniqueId = false;
            this.lblLoggedInAs.Location = new System.Drawing.Point(5, 6);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.NextFocusId = ((long)(0));
            this.lblLoggedInAs.PerformLayoutEnabled = true;
            this.lblLoggedInAs.PreviousFocusId = ((long)(0));
            this.lblLoggedInAs.Size = new System.Drawing.Size(67, 13);
            this.lblLoggedInAs.TabIndex = 2;
            this.lblLoggedInAs.Text = "Logged in as";
            this.lblLoggedInAs.TextChanged += new System.EventHandler(this.lblLoggedInAs_TextChanged);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.navigationMenu);
            this.pnlLeft.Controls.Add(this.pnlLeftTop);
            this.pnlLeft.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.pnlLeft.ExcludeFromUniqueId = false;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.NextFocusId = ((long)(0));
            this.pnlLeft.PerformLayoutEnabled = true;
            this.pnlLeft.PreviousFocusId = ((long)(0));
            this.pnlLeft.Size = new System.Drawing.Size(226, 656);
            this.pnlLeft.TabIndex = 1;
            // 
            // navigationMenu
            // 
            this.navigationMenu.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.navigationMenu.ExcludeFromUniqueId = false;
            this.navigationMenu.Location = new System.Drawing.Point(0, 76);
            this.navigationMenu.Name = "navigationMenu";
            this.navigationMenu.NextFocusId = ((long)(0));
            this.navigationMenu.PerformLayoutEnabled = true;
            this.navigationMenu.PreviousFocusId = ((long)(0));
            this.navigationMenu.Size = new System.Drawing.Size(226, 580);
            this.navigationMenu.TabIndex = 1;
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLeftTop.Controls.Add(this.pnlLogo);
            this.pnlLeftTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlLeftTop.ExcludeFromUniqueId = false;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.NextFocusId = ((long)(0));
            this.pnlLeftTop.PerformLayoutEnabled = true;
            this.pnlLeftTop.PreviousFocusId = ((long)(0));
            this.pnlLeftTop.Size = new System.Drawing.Size(226, 76);
            this.pnlLeftTop.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLogo.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("pnlLogo.BackgroundImage"));
            this.pnlLogo.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Zoom;
            this.pnlLogo.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlLogo.ExcludeFromUniqueId = false;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.NextFocusId = ((long)(0));
            this.pnlLogo.PerformLayoutEnabled = true;
            this.pnlLogo.PreviousFocusId = ((long)(0));
            this.pnlLogo.Size = new System.Drawing.Size(226, 76);
            this.pnlLogo.TabIndex = 0;
            // 
            // workspace
            // 
            this.workspace.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.workspace.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.SystemColors.AppWorkspace);
            this.workspace.ExcludeFromUniqueId = false;
            this.workspace.Location = new System.Drawing.Point(230, 80);
            this.workspace.Margin = new Gizmox.WebGUI.Forms.Padding(4, 0, 0, 0);
            this.workspace.Name = "workspace";
            this.workspace.NextFocusId = ((long)(0));
            this.workspace.PerformLayoutEnabled = true;
            this.workspace.PreviousFocusId = ((long)(0));
            this.workspace.Size = new System.Drawing.Size(790, 570);
            this.workspace.TabIndex = 2;
            this.workspace.CloseClick += new System.EventHandler(this.workspace_CloseClick);
            this.workspace.SelectedIndexChanged += new System.EventHandler(this.workspace_SelectedIndexChanged);
            // 
            // tmrKeepAlive
            // 
            this.tmrKeepAlive.Enabled = true;
            this.tmrKeepAlive.Interval = 10000;
            this.tmrKeepAlive.Tick += new System.EventHandler(this.tmrKeepAlive_Tick);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.None;
            this.Controls.Add(this.workspace);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Size = new System.Drawing.Size(1026, 656);
            this.Text = "FamiHub Portal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.RegisteredTimers = new Gizmox.WebGUI.Forms.Timer[] {
        this.tmrKeepAlive};
            this.pnlTop.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationMenu)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workspace)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Panel pnlTop;
        private Panel pnlLeft;
        private Panel pnlLeftTop;
        private Panel pnlLogo;
        private Label lblLoggedInAs;
        private ToolStrip menuBar;
        private ToolStripSeparator toolStripSeparator1;
        internal WorkspaceTabs workspace;
        internal ToolStripButton btnAdd;
        internal ToolStripButton btnSave;
        internal ToolStripButton btnCancel;
        internal ToolStripButton btnDelete;
        internal NavigationTabs navigationMenu;
        private LinkLabel lnkLogout;
        private Timer tmrKeepAlive;
    }
}