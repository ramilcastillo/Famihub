using Gizmox.WebGUI.Forms;

namespace FamiHub.UI.FHCore
{
    partial class Errors
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new Gizmox.WebGUI.Forms.SplitContainer();
            this.dgvErrors = new Gizmox.WebGUI.Forms.DataGridView();
            this.errorTime = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.userName = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.className = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.errorDescription = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.txtErrorInfo = new Gizmox.WebGUI.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.splitContainer.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.splitContainer.ExcludeFromUniqueId = false;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.NextFocusId = ((long)(0));
            this.splitContainer.Orientation = Gizmox.WebGUI.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvErrors);
            this.splitContainer.Panel1.ExcludeFromUniqueId = false;
            this.splitContainer.Panel1.NextFocusId = ((long)(0));
            this.splitContainer.Panel1.PerformLayoutEnabled = true;
            this.splitContainer.Panel1.PreviousFocusId = ((long)(0));
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.txtErrorInfo);
            this.splitContainer.Panel2.ExcludeFromUniqueId = false;
            this.splitContainer.Panel2.NextFocusId = ((long)(0));
            this.splitContainer.Panel2.PerformLayoutEnabled = true;
            this.splitContainer.Panel2.PreviousFocusId = ((long)(0));
            this.splitContainer.PerformLayoutEnabled = true;
            this.splitContainer.PreviousFocusId = ((long)(0));
            this.splitContainer.Size = new System.Drawing.Size(664, 435);
            this.splitContainer.SplitterDistance = 267;
            this.splitContainer.TabIndex = 0;
            // 
            // dgvErrors
            // 
            this.dgvErrors.ColumnHeadersHeightSizeMode = Gizmox.WebGUI.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrors.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.errorTime,
            this.userName,
            this.className,
            this.errorDescription});
            this.dgvErrors.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgvErrors.ExcludeFromUniqueId = false;
            this.dgvErrors.Location = new System.Drawing.Point(0, 0);
            this.dgvErrors.Name = "dgvErrors";
            this.dgvErrors.NextFocusId = ((long)(0));
            this.dgvErrors.PerformLayoutEnabled = true;
            this.dgvErrors.PreviousFocusId = ((long)(0));
            this.dgvErrors.RenderCellPanelsAsText = false;
            this.dgvErrors.RowTemplate.Enabled = true;
            this.dgvErrors.Size = new System.Drawing.Size(664, 267);
            this.dgvErrors.TabIndex = 1;
            this.dgvErrors.SelectionChanged += new System.EventHandler(this.dgvErrors_SelectionChanged);
            // 
            // errorTime
            // 
            this.errorTime.DataPropertyName = "Time";
            this.errorTime.FillWeight = 150F;
            this.errorTime.HeaderText = "Time";
            this.errorTime.Name = "errorTime";
            // 
            // userName
            // 
            this.userName.DataPropertyName = "User";
            this.userName.HeaderText = "User";
            this.userName.Name = "userName";
            // 
            // className
            // 
            this.className.DataPropertyName = "ClassName";
            this.className.FillWeight = 150F;
            this.className.HeaderText = "Class";
            this.className.Name = "className";
            // 
            // errorDescription
            // 
            this.errorDescription.DataPropertyName = "ErrorDescription";
            this.errorDescription.FillWeight = 300F;
            this.errorDescription.HeaderText = "Error";
            this.errorDescription.Name = "errorDescription";
            // 
            // txtErrorInfo
            // 
            this.txtErrorInfo.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtErrorInfo.ExcludeFromUniqueId = false;
            this.txtErrorInfo.Location = new System.Drawing.Point(0, 0);
            this.txtErrorInfo.Multiline = true;
            this.txtErrorInfo.Name = "txtErrorInfo";
            this.txtErrorInfo.NextFocusId = ((long)(0));
            this.txtErrorInfo.PerformLayoutEnabled = true;
            this.txtErrorInfo.PreviousFocusId = ((long)(0));
            this.txtErrorInfo.ReadOnly = true;
            this.txtErrorInfo.ScrollBars = Gizmox.WebGUI.Forms.ScrollBars.Vertical;
            this.txtErrorInfo.Size = new System.Drawing.Size(664, 164);
            this.txtErrorInfo.TabIndex = 0;
            this.txtErrorInfo.TabStop = false;
            // 
            // Errors
            // 
            this.Controls.Add(this.splitContainer);
            this.Size = new System.Drawing.Size(664, 435);
            this.Text = "Errors";
            this.Load += new System.EventHandler(this.Errors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer;
        private DataGridView dgvErrors;
        private TextBox txtErrorInfo;
        private DataGridViewTextBoxColumn errorTime;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn className;
        private DataGridViewTextBoxColumn errorDescription;
    }
}