using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.FHCore
{
    partial class IconSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconSelector));
            this.iconList = new Gizmox.WebGUI.Forms.ListView();
            this.toolStrip1 = new Gizmox.WebGUI.Forms.ToolStrip();
            this.btnView = new Gizmox.WebGUI.Forms.ToolStripButton();
            this.txtSearch = new Gizmox.WebGUI.Forms.ToolStripTextBox();
            this.SuspendLayout();
            // 
            // iconList
            // 
            this.iconList.DataMember = null;
            this.iconList.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.iconList.Location = new System.Drawing.Point(0, 25);
            this.iconList.Name = "iconList";
            this.iconList.Size = new System.Drawing.Size(555, 296);
            this.iconList.TabIndex = 0;
            this.iconList.View = Gizmox.WebGUI.Forms.View.SmallIcon;
            this.iconList.DoubleClick += new System.EventHandler(this.iconList_DoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.btnView,
            this.txtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(555, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnView
            // 
            this.btnView.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnView.Image"));
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(23, 20);
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = true;
            this.txtSearch.MaxLength = 0;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 21);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // IconSelector
            // 
            this.Controls.Add(this.iconList);
            this.Controls.Add(this.toolStrip1);
            this.Size = new System.Drawing.Size(555, 321);
            this.Text = "IconSelector";
            this.Load += new System.EventHandler(this.IconSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView iconList;
        private ToolStrip toolStrip1;
        private ToolStripButton btnView;
        private ToolStripTextBox txtSearch;
    }
}