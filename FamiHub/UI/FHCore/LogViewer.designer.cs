using Gizmox.WebGUI.Forms;

namespace FamiHub.UI.FHCore
{
    partial class LogViewer
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
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.splitContainer = new Gizmox.WebGUI.Forms.SplitContainer();
            this.dgvLog = new Gizmox.WebGUI.Forms.DataGridView();
            this.timeStamp = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.userName = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.hostName = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.level = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.logText = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new Gizmox.WebGUI.Forms.Button();
            this.txtLogInfo = new Gizmox.WebGUI.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
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
            this.splitContainer.Panel1.Controls.Add(this.dgvLog);
            this.splitContainer.Panel1.ExcludeFromUniqueId = false;
            this.splitContainer.Panel1.NextFocusId = ((long)(0));
            this.splitContainer.Panel1.PerformLayoutEnabled = true;
            this.splitContainer.Panel1.PreviousFocusId = ((long)(0));
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnClear);
            this.splitContainer.Panel2.Controls.Add(this.txtLogInfo);
            this.splitContainer.Panel2.ExcludeFromUniqueId = false;
            this.splitContainer.Panel2.NextFocusId = ((long)(0));
            this.splitContainer.Panel2.PerformLayoutEnabled = true;
            this.splitContainer.Panel2.PreviousFocusId = ((long)(0));
            this.splitContainer.PerformLayoutEnabled = true;
            this.splitContainer.PreviousFocusId = ((long)(0));
            this.splitContainer.Size = new System.Drawing.Size(907, 485);
            this.splitContainer.SplitterDistance = 302;
            this.splitContainer.TabIndex = 0;
            // 
            // dgvLog
            // 
            this.dgvLog.ColumnHeadersHeight = 24;
            this.dgvLog.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.timeStamp,
            this.userName,
            this.hostName,
            this.level,
            this.logText});
            this.dgvLog.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgvLog.ExcludeFromUniqueId = false;
            this.dgvLog.Location = new System.Drawing.Point(0, 0);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.NextFocusId = ((long)(0));
            this.dgvLog.PerformLayoutEnabled = true;
            this.dgvLog.PreviousFocusId = ((long)(0));
            this.dgvLog.RenderCellPanelsAsText = false;
            this.dgvLog.RowTemplate.Enabled = true;
            this.dgvLog.Size = new System.Drawing.Size(907, 302);
            this.dgvLog.TabIndex = 1;
            this.dgvLog.SelectionChanged += new System.EventHandler(this.dgvLog_SelectionChanged);
            // 
            // timeStamp
            // 
            this.timeStamp.DataPropertyName = "Timestamp";
            this.timeStamp.DefaultCellStyle = dataGridViewCellStyle1;
            this.timeStamp.FillWeight = 150F;
            this.timeStamp.HeaderText = "Date";
            this.timeStamp.MinimumWidth = 22;
            this.timeStamp.Name = "timeStamp";
            this.timeStamp.SortMode = Gizmox.WebGUI.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "UserName";
            this.userName.DefaultCellStyle = dataGridViewCellStyle2;
            this.userName.FillWeight = 150F;
            this.userName.HeaderText = "User";
            this.userName.MinimumWidth = 22;
            this.userName.Name = "userName";
            this.userName.SortMode = Gizmox.WebGUI.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // hostName
            // 
            this.hostName.DataPropertyName = "HostName";
            this.hostName.DefaultCellStyle = dataGridViewCellStyle3;
            this.hostName.HeaderText = "Hostname";
            this.hostName.MinimumWidth = 22;
            this.hostName.Name = "hostName";
            this.hostName.SortMode = Gizmox.WebGUI.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // level
            // 
            this.level.DataPropertyName = "Level";
            this.level.DefaultCellStyle = dataGridViewCellStyle4;
            this.level.HeaderText = "Level";
            this.level.MinimumWidth = 22;
            this.level.Name = "level";
            this.level.SortMode = Gizmox.WebGUI.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // logText
            // 
            this.logText.DataPropertyName = "Text";
            this.logText.DefaultCellStyle = dataGridViewCellStyle5;
            this.logText.FillWeight = 300F;
            this.logText.HeaderText = "Log";
            this.logText.MinimumWidth = 22;
            this.logText.Name = "logText";
            this.logText.SortMode = Gizmox.WebGUI.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnClear.ExcludeFromUniqueId = false;
            this.btnClear.Location = new System.Drawing.Point(791, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.NextFocusId = ((long)(0));
            this.btnClear.PerformLayoutEnabled = true;
            this.btnClear.PreviousFocusId = ((long)(0));
            this.btnClear.Size = new System.Drawing.Size(104, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear log";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtLogInfo
            // 
            this.txtLogInfo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.txtLogInfo.ExcludeFromUniqueId = false;
            this.txtLogInfo.Location = new System.Drawing.Point(0, 0);
            this.txtLogInfo.Multiline = true;
            this.txtLogInfo.Name = "txtLogInfo";
            this.txtLogInfo.NextFocusId = ((long)(0));
            this.txtLogInfo.PerformLayoutEnabled = true;
            this.txtLogInfo.PreviousFocusId = ((long)(0));
            this.txtLogInfo.ReadOnly = true;
            this.txtLogInfo.ScrollBars = Gizmox.WebGUI.Forms.ScrollBars.Vertical;
            this.txtLogInfo.Size = new System.Drawing.Size(907, 141);
            this.txtLogInfo.TabIndex = 0;
            // 
            // LogViewer
            // 
            this.Controls.Add(this.splitContainer);
            this.Size = new System.Drawing.Size(907, 485);
            this.Text = "LogViewer";
            this.Load += new System.EventHandler(this.LogViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer;
        private DataGridView dgvLog;
        private DataGridViewTextBoxColumn timeStamp;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn hostName;
        private DataGridViewTextBoxColumn level;
        private DataGridViewTextBoxColumn logText;
        private TextBox txtLogInfo;
        private Button btnClear;
    }
}