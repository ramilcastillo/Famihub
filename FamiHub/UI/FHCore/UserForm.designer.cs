using Gizmox.WebGUI.Forms;

namespace FamiHub.UI.FHCore
{
    partial class UserForm
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
            this.txtUsername = new Gizmox.WebGUI.Forms.TextBox();
            this.lblUsername = new Gizmox.WebGUI.Forms.Label();
            this.lblPassword = new Gizmox.WebGUI.Forms.Label();
            this.txtPassword = new Gizmox.WebGUI.Forms.TextBox();
            this.cmbLanguage = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblLanguage = new Gizmox.WebGUI.Forms.Label();
            this.cmbUsergroup = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblUsergroup = new Gizmox.WebGUI.Forms.Label();
            this.tabControl = new Gizmox.WebGUI.Forms.WorkspaceTabs();
            this.tabPageGeneral = new Gizmox.WebGUI.Forms.WorkspaceTab();
            this.txtMailAddress = new Gizmox.WebGUI.Forms.TextBox();
            this.lblMailAddress = new Gizmox.WebGUI.Forms.Label();
            this.lblLastname = new Gizmox.WebGUI.Forms.Label();
            this.txtLastname = new Gizmox.WebGUI.Forms.TextBox();
            this.lblFirstname = new Gizmox.WebGUI.Forms.Label();
            this.txtFirstname = new Gizmox.WebGUI.Forms.TextBox();
            this.tabPageRights = new Gizmox.WebGUI.Forms.WorkspaceTab();
            this.chbApiAccess = new Gizmox.WebGUI.Forms.CheckBox();
            this.lblApiAccess = new Gizmox.WebGUI.Forms.Label();
            this.tabPageExpenseNotesApproval = new Gizmox.WebGUI.Forms.WorkspaceTab();
            this.chbBecosoft = new Gizmox.WebGUI.Forms.CheckBox();
            this.comboBox1 = new Gizmox.WebGUI.Forms.ComboBox();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.cmbExpenseNotesApprovalFlow = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbExpenseNotesApproval = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblExpenseNotesApprovalFlow = new Gizmox.WebGUI.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageRights.SuspendLayout();
            this.tabPageExpenseNotesApproval.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.ExcludeFromUniqueId = false;
            this.txtUsername.Location = new System.Drawing.Point(99, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.NextFocusId = ((long)(0));
            this.txtUsername.PerformLayoutEnabled = true;
            this.txtUsername.PreviousFocusId = ((long)(0));
            this.txtUsername.Size = new System.Drawing.Size(224, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ExcludeFromUniqueId = false;
            this.lblUsername.Location = new System.Drawing.Point(12, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.NextFocusId = ((long)(0));
            this.lblUsername.PerformLayoutEnabled = true;
            this.lblUsername.PreviousFocusId = ((long)(0));
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ExcludeFromUniqueId = false;
            this.lblPassword.Location = new System.Drawing.Point(12, 41);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.NextFocusId = ((long)(0));
            this.lblPassword.PerformLayoutEnabled = true;
            this.lblPassword.PreviousFocusId = ((long)(0));
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.ExcludeFromUniqueId = false;
            this.txtPassword.Location = new System.Drawing.Point(99, 38);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NextFocusId = ((long)(0));
            this.txtPassword.PerformLayoutEnabled = true;
            this.txtPassword.PreviousFocusId = ((long)(0));
            this.txtPassword.Size = new System.Drawing.Size(224, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.ExcludeFromUniqueId = false;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(99, 64);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.NextFocusId = ((long)(0));
            this.cmbLanguage.PerformLayoutEnabled = true;
            this.cmbLanguage.PreviousFocusId = ((long)(0));
            this.cmbLanguage.Size = new System.Drawing.Size(224, 21);
            this.cmbLanguage.TabIndex = 4;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.ExcludeFromUniqueId = false;
            this.lblLanguage.Location = new System.Drawing.Point(12, 67);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.NextFocusId = ((long)(0));
            this.lblLanguage.PerformLayoutEnabled = true;
            this.lblLanguage.PreviousFocusId = ((long)(0));
            this.lblLanguage.Size = new System.Drawing.Size(55, 13);
            this.lblLanguage.TabIndex = 5;
            this.lblLanguage.Text = "Language";
            // 
            // cmbUsergroup
            // 
            this.cmbUsergroup.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsergroup.ExcludeFromUniqueId = false;
            this.cmbUsergroup.FormattingEnabled = true;
            this.cmbUsergroup.Location = new System.Drawing.Point(99, 91);
            this.cmbUsergroup.Name = "cmbUsergroup";
            this.cmbUsergroup.NextFocusId = ((long)(0));
            this.cmbUsergroup.PerformLayoutEnabled = true;
            this.cmbUsergroup.PreviousFocusId = ((long)(0));
            this.cmbUsergroup.Size = new System.Drawing.Size(224, 21);
            this.cmbUsergroup.TabIndex = 6;
            // 
            // lblUsergroup
            // 
            this.lblUsergroup.AutoSize = true;
            this.lblUsergroup.ExcludeFromUniqueId = false;
            this.lblUsergroup.Location = new System.Drawing.Point(12, 94);
            this.lblUsergroup.Name = "lblUsergroup";
            this.lblUsergroup.NextFocusId = ((long)(0));
            this.lblUsergroup.PerformLayoutEnabled = true;
            this.lblUsergroup.PreviousFocusId = ((long)(0));
            this.lblUsergroup.Size = new System.Drawing.Size(56, 13);
            this.lblUsergroup.TabIndex = 7;
            this.lblUsergroup.Text = "Usergroup";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Controls.Add(this.tabPageRights);
            this.tabControl.Controls.Add(this.tabPageExpenseNotesApproval);
            this.tabControl.ExcludeFromUniqueId = false;
            this.tabControl.Location = new System.Drawing.Point(15, 118);
            this.tabControl.Name = "tabControl";
            this.tabControl.NextFocusId = ((long)(0));
            this.tabControl.PerformLayoutEnabled = true;
            this.tabControl.PreviousFocusId = ((long)(0));
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(545, 187);
            this.tabControl.TabIndex = 8;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.txtMailAddress);
            this.tabPageGeneral.Controls.Add(this.lblMailAddress);
            this.tabPageGeneral.Controls.Add(this.lblLastname);
            this.tabPageGeneral.Controls.Add(this.txtLastname);
            this.tabPageGeneral.Controls.Add(this.lblFirstname);
            this.tabPageGeneral.Controls.Add(this.txtFirstname);
            this.tabPageGeneral.CustomStyle = "Workspace";
            this.tabPageGeneral.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPageGeneral.DockPadding.All = 3;
            this.tabPageGeneral.ExcludeFromUniqueId = false;
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.NextFocusId = ((long)(0));
            this.tabPageGeneral.Padding = new Gizmox.WebGUI.Forms.Padding(3);
            this.tabPageGeneral.PerformLayoutEnabled = true;
            this.tabPageGeneral.PreviousFocusId = ((long)(0));
            this.tabPageGeneral.Size = new System.Drawing.Size(537, 157);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            // 
            // txtMailAddress
            // 
            this.txtMailAddress.ExcludeFromUniqueId = false;
            this.txtMailAddress.Location = new System.Drawing.Point(80, 58);
            this.txtMailAddress.Name = "txtMailAddress";
            this.txtMailAddress.NextFocusId = ((long)(0));
            this.txtMailAddress.PerformLayoutEnabled = true;
            this.txtMailAddress.PreviousFocusId = ((long)(0));
            this.txtMailAddress.Size = new System.Drawing.Size(224, 20);
            this.txtMailAddress.TabIndex = 2;
            // 
            // lblMailAddress
            // 
            this.lblMailAddress.AutoSize = true;
            this.lblMailAddress.ExcludeFromUniqueId = false;
            this.lblMailAddress.Location = new System.Drawing.Point(9, 61);
            this.lblMailAddress.Name = "lblMailAddress";
            this.lblMailAddress.NextFocusId = ((long)(0));
            this.lblMailAddress.PerformLayoutEnabled = true;
            this.lblMailAddress.PreviousFocusId = ((long)(0));
            this.lblMailAddress.Size = new System.Drawing.Size(56, 13);
            this.lblMailAddress.TabIndex = 3;
            this.lblMailAddress.Text = "Mail address";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.ExcludeFromUniqueId = false;
            this.lblLastname.Location = new System.Drawing.Point(6, 35);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.NextFocusId = ((long)(0));
            this.lblLastname.PerformLayoutEnabled = true;
            this.lblLastname.PreviousFocusId = ((long)(0));
            this.lblLastname.Size = new System.Drawing.Size(56, 13);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "Last name";
            // 
            // txtLastname
            // 
            this.txtLastname.ExcludeFromUniqueId = false;
            this.txtLastname.Location = new System.Drawing.Point(80, 32);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.NextFocusId = ((long)(0));
            this.txtLastname.PerformLayoutEnabled = true;
            this.txtLastname.PreviousFocusId = ((long)(0));
            this.txtLastname.Size = new System.Drawing.Size(224, 20);
            this.txtLastname.TabIndex = 2;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.ExcludeFromUniqueId = false;
            this.lblFirstname.Location = new System.Drawing.Point(6, 9);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.NextFocusId = ((long)(0));
            this.lblFirstname.PerformLayoutEnabled = true;
            this.lblFirstname.PreviousFocusId = ((long)(0));
            this.lblFirstname.Size = new System.Drawing.Size(55, 13);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "First name";
            // 
            // txtFirstname
            // 
            this.txtFirstname.ExcludeFromUniqueId = false;
            this.txtFirstname.Location = new System.Drawing.Point(80, 6);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.NextFocusId = ((long)(0));
            this.txtFirstname.PerformLayoutEnabled = true;
            this.txtFirstname.PreviousFocusId = ((long)(0));
            this.txtFirstname.Size = new System.Drawing.Size(224, 20);
            this.txtFirstname.TabIndex = 0;
            // 
            // tabPageRights
            // 
            this.tabPageRights.Controls.Add(this.chbApiAccess);
            this.tabPageRights.Controls.Add(this.lblApiAccess);
            this.tabPageRights.CustomStyle = "Workspace";
            this.tabPageRights.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPageRights.ExcludeFromUniqueId = false;
            this.tabPageRights.Location = new System.Drawing.Point(0, 0);
            this.tabPageRights.Name = "tabPageRights";
            this.tabPageRights.NextFocusId = ((long)(0));
            this.tabPageRights.PerformLayoutEnabled = true;
            this.tabPageRights.PreviousFocusId = ((long)(0));
            this.tabPageRights.Size = new System.Drawing.Size(537, 157);
            this.tabPageRights.TabIndex = 1;
            this.tabPageRights.Text = "Rights";
            // 
            // chbApiAccess
            // 
            this.chbApiAccess.AutoSize = true;
            this.chbApiAccess.ExcludeFromUniqueId = false;
            this.chbApiAccess.Location = new System.Drawing.Point(80, 4);
            this.chbApiAccess.Name = "chbApiAccess";
            this.chbApiAccess.NextFocusId = ((long)(0));
            this.chbApiAccess.PerformLayoutEnabled = true;
            this.chbApiAccess.PreviousFocusId = ((long)(0));
            this.chbApiAccess.Size = new System.Drawing.Size(15, 14);
            this.chbApiAccess.TabIndex = 1;
            // 
            // lblApiAccess
            // 
            this.lblApiAccess.AutoSize = true;
            this.lblApiAccess.ExcludeFromUniqueId = false;
            this.lblApiAccess.Location = new System.Drawing.Point(6, 9);
            this.lblApiAccess.Name = "lblApiAccess";
            this.lblApiAccess.NextFocusId = ((long)(0));
            this.lblApiAccess.PerformLayoutEnabled = true;
            this.lblApiAccess.PreviousFocusId = ((long)(0));
            this.lblApiAccess.Size = new System.Drawing.Size(35, 13);
            this.lblApiAccess.TabIndex = 0;
            this.lblApiAccess.Text = "API Access";
            // 
            // tabPageExpenseNotesApproval
            // 
            this.tabPageExpenseNotesApproval.Controls.Add(this.lblExpenseNotesApprovalFlow);
            this.tabPageExpenseNotesApproval.Controls.Add(this.cmbExpenseNotesApproval);
            this.tabPageExpenseNotesApproval.CustomStyle = "Workspace";
            this.tabPageExpenseNotesApproval.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPageExpenseNotesApproval.ExcludeFromUniqueId = false;
            this.tabPageExpenseNotesApproval.Location = new System.Drawing.Point(0, 0);
            this.tabPageExpenseNotesApproval.Name = "tabPageExpenseNotesApproval";
            this.tabPageExpenseNotesApproval.NextFocusId = ((long)(0));
            this.tabPageExpenseNotesApproval.PerformLayoutEnabled = true;
            this.tabPageExpenseNotesApproval.PreviousFocusId = ((long)(0));
            this.tabPageExpenseNotesApproval.Size = new System.Drawing.Size(537, 157);
            this.tabPageExpenseNotesApproval.TabIndex = 2;
            this.tabPageExpenseNotesApproval.Text = "Expense Notes";
            // 
            // chbBecosoft
            // 
            this.chbBecosoft.AutoSize = true;
            this.chbBecosoft.ExcludeFromUniqueId = false;
            this.chbBecosoft.Location = new System.Drawing.Point(373, 14);
            this.chbBecosoft.Name = "chbBecosoft";
            this.chbBecosoft.NextFocusId = ((long)(0));
            this.chbBecosoft.PerformLayoutEnabled = true;
            this.chbBecosoft.PreviousFocusId = ((long)(0));
            this.chbBecosoft.Size = new System.Drawing.Size(104, 17);
            this.chbBecosoft.TabIndex = 9;
            this.chbBecosoft.Text = "Is Becosoft user";
            this.chbBecosoft.CheckedChanged += new System.EventHandler(this.chbBecosoft_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.ExcludeFromUniqueId = false;
            this.comboBox1.Location = new System.Drawing.Point(74, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.NextFocusId = ((long)(0));
            this.comboBox1.PerformLayoutEnabled = true;
            this.comboBox1.PreviousFocusId = ((long)(0));
            this.comboBox1.Size = new System.Drawing.Size(176, 25);
            // 
            // label1
            // 
            this.label1.ExcludeFromUniqueId = false;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.NextFocusId = ((long)(0));
            this.label1.PerformLayoutEnabled = true;
            this.label1.PreviousFocusId = ((long)(0));
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // cmbExpenseNotesApprovalFlow
            // 
            this.cmbExpenseNotesApprovalFlow.ExcludeFromUniqueId = false;
            this.cmbExpenseNotesApprovalFlow.FormattingEnabled = true;
            this.cmbExpenseNotesApprovalFlow.Location = new System.Drawing.Point(1, 1);
            this.cmbExpenseNotesApprovalFlow.Name = "cmbExpenseNotesApprovalFlow";
            this.cmbExpenseNotesApprovalFlow.NextFocusId = ((long)(0));
            this.cmbExpenseNotesApprovalFlow.PerformLayoutEnabled = true;
            this.cmbExpenseNotesApprovalFlow.PreviousFocusId = ((long)(0));
            this.cmbExpenseNotesApprovalFlow.Size = new System.Drawing.Size(121, 25);
            this.cmbExpenseNotesApprovalFlow.TabIndex = 0;
            // 
            // cmbExpenseNotesApproval
            // 
            this.cmbExpenseNotesApproval.ExcludeFromUniqueId = false;
            this.cmbExpenseNotesApproval.FormattingEnabled = true;
            this.cmbExpenseNotesApproval.Location = new System.Drawing.Point(197, 6);
            this.cmbExpenseNotesApproval.Name = "cmbExpenseNotesApproval";
            this.cmbExpenseNotesApproval.NextFocusId = ((long)(0));
            this.cmbExpenseNotesApproval.PerformLayoutEnabled = true;
            this.cmbExpenseNotesApproval.PreviousFocusId = ((long)(0));
            this.cmbExpenseNotesApproval.Size = new System.Drawing.Size(159, 25);
            this.cmbExpenseNotesApproval.TabIndex = 0;
            // 
            // lblExpenseNotesApprovalFlow
            // 
            this.lblExpenseNotesApprovalFlow.AutoSize = true;
            this.lblExpenseNotesApprovalFlow.ExcludeFromUniqueId = false;
            this.lblExpenseNotesApprovalFlow.Location = new System.Drawing.Point(7, 10);
            this.lblExpenseNotesApprovalFlow.Name = "lblExpenseNotesApprovalFlow";
            this.lblExpenseNotesApprovalFlow.NextFocusId = ((long)(0));
            this.lblExpenseNotesApprovalFlow.PerformLayoutEnabled = true;
            this.lblExpenseNotesApprovalFlow.PreviousFocusId = ((long)(0));
            this.lblExpenseNotesApprovalFlow.Size = new System.Drawing.Size(42, 17);
            this.lblExpenseNotesApprovalFlow.TabIndex = 1;
            this.lblExpenseNotesApprovalFlow.Text = "Expense notes approval flow:";
            // 
            // UserForm
            // 
            this.Controls.Add(this.chbBecosoft);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblUsergroup);
            this.Controls.Add(this.cmbUsergroup);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Size = new System.Drawing.Size(572, 317);
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageRights.ResumeLayout(false);
            this.tabPageExpenseNotesApproval.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private ComboBox cmbLanguage;
        private Label lblLanguage;
        private ComboBox cmbUsergroup;
        private Label lblUsergroup;
        private WorkspaceTabs tabControl;
        private WorkspaceTab tabPageGeneral;
        private Label lblFirstname;
        private TextBox txtFirstname;
        private Label lblLastname;
        private TextBox txtLastname;
        private TextBox txtMailAddress;
        private Label lblMailAddress;
        private WorkspaceTab tabPageRights;
        private CheckBox chbApiAccess;
        private Label lblApiAccess;
        private CheckBox chbBecosoft;
        private WorkspaceTab tabPageExpenseNotesApproval;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox cmbExpenseNotesApprovalFlow;
        private Label lblExpenseNotesApprovalFlow;
        private ComboBox cmbExpenseNotesApproval;
    }
}