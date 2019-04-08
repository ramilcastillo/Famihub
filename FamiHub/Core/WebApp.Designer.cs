namespace FamiHub
{
    partial class WebApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebApp));
            this.pnlLoader = new Gizmox.WebGUI.Forms.Panel();
            this.lblPleaseWait = new Gizmox.WebGUI.Forms.Label();
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.tmrLoad = new Gizmox.WebGUI.Forms.Timer(this.components);
            this.pnlLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoader
            // 
            this.pnlLoader.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.pnlLoader.Controls.Add(this.lblPleaseWait);
            this.pnlLoader.Controls.Add(this.pnlTop);
            this.pnlLoader.ExcludeFromUniqueId = false;
            this.pnlLoader.Location = new System.Drawing.Point(9, 9);
            this.pnlLoader.Name = "pnlLoader";
            this.pnlLoader.NextFocusId = ((long)(0));
            this.pnlLoader.PerformLayoutEnabled = true;
            this.pnlLoader.PreviousFocusId = ((long)(0));
            this.pnlLoader.Size = new System.Drawing.Size(550, 445);
            this.pnlLoader.TabIndex = 0;
            // 
            // lblPleaseWait
            // 
            this.lblPleaseWait.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.lblPleaseWait.ExcludeFromUniqueId = false;
            this.lblPleaseWait.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseWait.Location = new System.Drawing.Point(0, 333);
            this.lblPleaseWait.Name = "lblPleaseWait";
            this.lblPleaseWait.NextFocusId = ((long)(0));
            this.lblPleaseWait.PerformLayoutEnabled = true;
            this.lblPleaseWait.PreviousFocusId = ((long)(0));
            this.lblPleaseWait.Size = new System.Drawing.Size(550, 112);
            this.lblPleaseWait.TabIndex = 1;
            this.lblPleaseWait.Text = "Please wait...";
            this.lblPleaseWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("pnlTop.BackgroundImage"));
            this.pnlTop.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Zoom;
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.ExcludeFromUniqueId = false;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.NextFocusId = ((long)(0));
            this.pnlTop.PerformLayoutEnabled = true;
            this.pnlTop.PreviousFocusId = ((long)(0));
            this.pnlTop.Size = new System.Drawing.Size(550, 333);
            this.pnlTop.TabIndex = 0;
            // 
            // tmrLoad
            // 
            this.tmrLoad.Enabled = true;
            this.tmrLoad.Interval = 500;
            this.tmrLoad.Tick += new System.EventHandler(this.tmrLoad_Tick);
            // 
            // WebApp
            // 
            this.Controls.Add(this.pnlLoader);
            this.Name = "Loader";
            this.Size = new System.Drawing.Size(568, 463);
            this.Text = "FamiHub Portal";
            this.Load += new System.EventHandler(this.WebApp_Load);
            this.RegisteredTimers = new Gizmox.WebGUI.Forms.Timer[] {
        this.tmrLoad};
            this.pnlLoader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Panel pnlLoader;
        private Gizmox.WebGUI.Forms.Label lblPleaseWait;
        private Gizmox.WebGUI.Forms.Panel pnlTop;
        private Gizmox.WebGUI.Forms.Timer tmrLoad;
    }
}