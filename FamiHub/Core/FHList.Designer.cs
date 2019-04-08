using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub
{
    partial class FHList<DataType, DetailFormType> : FHFormTab where DetailFormType : FHFormTab
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
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.btnSearch = new Gizmox.WebGUI.Forms.Button();
            this.lblSearchValue = new Gizmox.WebGUI.Forms.Label();
            this.txtSearchValue = new Gizmox.WebGUI.Forms.TextBox();
            this.lblField = new Gizmox.WebGUI.Forms.Label();
            this.cmbField = new Gizmox.WebGUI.Forms.ComboBox();
            this.dgvList = new Gizmox.WebGUI.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.lblSearchValue);
            this.pnlTop.Controls.Add(this.txtSearchValue);
            this.pnlTop.Controls.Add(this.lblField);
            this.pnlTop.Controls.Add(this.cmbField);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.ExcludeFromUniqueId = false;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.NextFocusId = ((long)(0));
            this.pnlTop.PerformLayoutEnabled = true;
            this.pnlTop.PreviousFocusId = ((long)(0));
            this.pnlTop.Size = new System.Drawing.Size(553, 69);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.ExcludeFromUniqueId = false;
            this.btnSearch.Location = new System.Drawing.Point(327, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NextFocusId = ((long)(0));
            this.btnSearch.PerformLayoutEnabled = true;
            this.btnSearch.PreviousFocusId = ((long)(0));
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchValue
            // 
            this.lblSearchValue.AutoSize = true;
            this.lblSearchValue.ExcludeFromUniqueId = false;
            this.lblSearchValue.Location = new System.Drawing.Point(12, 42);
            this.lblSearchValue.Name = "lblSearchValue";
            this.lblSearchValue.NextFocusId = ((long)(0));
            this.lblSearchValue.PerformLayoutEnabled = true;
            this.lblSearchValue.PreviousFocusId = ((long)(0));
            this.lblSearchValue.Size = new System.Drawing.Size(70, 13);
            this.lblSearchValue.TabIndex = 3;
            this.lblSearchValue.Text = "Search value";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.ExcludeFromUniqueId = false;
            this.txtSearchValue.Location = new System.Drawing.Point(115, 39);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.NextFocusId = ((long)(0));
            this.txtSearchValue.PerformLayoutEnabled = true;
            this.txtSearchValue.PreviousFocusId = ((long)(0));
            this.txtSearchValue.Size = new System.Drawing.Size(182, 20);
            this.txtSearchValue.TabIndex = 2;
            this.txtSearchValue.KeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtSearchValue_KeyDown);
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.ExcludeFromUniqueId = false;
            this.lblField.Location = new System.Drawing.Point(12, 15);
            this.lblField.Name = "lblField";
            this.lblField.NextFocusId = ((long)(0));
            this.lblField.PerformLayoutEnabled = true;
            this.lblField.PreviousFocusId = ((long)(0));
            this.lblField.Size = new System.Drawing.Size(63, 13);
            this.lblField.TabIndex = 1;
            this.lblField.Text = "Search field";
            // 
            // cmbField
            // 
            this.cmbField.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbField.ExcludeFromUniqueId = false;
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Location = new System.Drawing.Point(115, 12);
            this.cmbField.Name = "cmbField";
            this.cmbField.NextFocusId = ((long)(0));
            this.cmbField.PerformLayoutEnabled = true;
            this.cmbField.PreviousFocusId = ((long)(0));
            this.cmbField.Size = new System.Drawing.Size(182, 21);
            this.cmbField.TabIndex = 0;
            this.cmbField.TabStop = false;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = Gizmox.WebGUI.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgvList.ExcludeFromUniqueId = false;
            this.dgvList.Location = new System.Drawing.Point(0, 69);
            this.dgvList.Name = "dgvList";
            this.dgvList.NextFocusId = ((long)(0));
            this.dgvList.PerformLayoutEnabled = true;
            this.dgvList.PreviousFocusId = ((long)(0));
            this.dgvList.RenderCellPanelsAsText = false;
            this.dgvList.RowTemplate.Enabled = true;
            this.dgvList.Size = new System.Drawing.Size(553, 291);
            this.dgvList.TabIndex = 1;
            this.dgvList.TabStop = false;
            this.dgvList.CellDoubleClick += new Gizmox.WebGUI.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // FHList
            // 
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlTop);
            this.Size = new System.Drawing.Size(553, 360);
            this.Text = "FHList";
            this.Load += new System.EventHandler(this.ListWindow_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Gizmox.WebGUI.Forms.ComboBox cmbField;
        private Gizmox.WebGUI.Forms.Label lblField;
        private Gizmox.WebGUI.Forms.Label lblSearchValue;
        private Gizmox.WebGUI.Forms.TextBox txtSearchValue;
        private Gizmox.WebGUI.Forms.Button btnSearch;
        protected Gizmox.WebGUI.Forms.DataGridView dgvList;
        internal Panel pnlTop;
    }
}