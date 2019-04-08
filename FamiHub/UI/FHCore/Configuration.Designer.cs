using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.FHCore
{
    partial class Configuration
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
            this.wstConfiguration = new Gizmox.WebGUI.Forms.WorkspaceTabs();
            this.tabGeneral = new Gizmox.WebGUI.Forms.WorkspaceTab();
            this.cmbLogLevel = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblLogLevel = new Gizmox.WebGUI.Forms.Label();
            this.lblBecosoft = new Gizmox.WebGUI.Forms.Label();
            this.chbBecosoft = new Gizmox.WebGUI.Forms.CheckBox();
            this.lblTranslationsApi = new Gizmox.WebGUI.Forms.Label();
            this.txtTranslationsApiHost = new Gizmox.WebGUI.Forms.TextBox();
            this.chbTranslationsApi = new Gizmox.WebGUI.Forms.CheckBox();
            this.lblTranslationsApiHost = new Gizmox.WebGUI.Forms.Label();
            this.txtTranslationsApiUser = new Gizmox.WebGUI.Forms.TextBox();
            this.lblTranslationsApiUser = new Gizmox.WebGUI.Forms.Label();
            this.txtTranslationsApiPassword = new Gizmox.WebGUI.Forms.TextBox();
            this.lblTranslationsApiPassword = new Gizmox.WebGUI.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wstConfiguration)).BeginInit();
            this.wstConfiguration.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // wstConfiguration
            // 
            this.wstConfiguration.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.wstConfiguration.Controls.Add(this.tabGeneral);
            this.wstConfiguration.ExcludeFromUniqueId = false;
            this.wstConfiguration.Location = new System.Drawing.Point(5, 10);
            this.wstConfiguration.Name = "wstConfiguration";
            this.wstConfiguration.NextFocusId = ((long)(0));
            this.wstConfiguration.PerformLayoutEnabled = true;
            this.wstConfiguration.PreviousFocusId = ((long)(0));
            this.wstConfiguration.SelectedIndex = 0;
            this.wstConfiguration.Size = new System.Drawing.Size(723, 519);
            this.wstConfiguration.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.lblTranslationsApiPassword);
            this.tabGeneral.Controls.Add(this.txtTranslationsApiPassword);
            this.tabGeneral.Controls.Add(this.lblTranslationsApiUser);
            this.tabGeneral.Controls.Add(this.txtTranslationsApiUser);
            this.tabGeneral.Controls.Add(this.lblTranslationsApiHost);
            this.tabGeneral.Controls.Add(this.chbTranslationsApi);
            this.tabGeneral.Controls.Add(this.txtTranslationsApiHost);
            this.tabGeneral.Controls.Add(this.lblTranslationsApi);
            this.tabGeneral.Controls.Add(this.chbBecosoft);
            this.tabGeneral.Controls.Add(this.lblBecosoft);
            this.tabGeneral.Controls.Add(this.lblLogLevel);
            this.tabGeneral.Controls.Add(this.cmbLogLevel);
            this.tabGeneral.CustomStyle = "Workspace";
            this.tabGeneral.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabGeneral.ExcludeFromUniqueId = false;
            this.tabGeneral.Location = new System.Drawing.Point(0, 0);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.NextFocusId = ((long)(0));
            this.tabGeneral.PerformLayoutEnabled = true;
            this.tabGeneral.PreviousFocusId = ((long)(0));
            this.tabGeneral.Size = new System.Drawing.Size(715, 493);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            // 
            // cmbLogLevel
            // 
            this.cmbLogLevel.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogLevel.ExcludeFromUniqueId = false;
            this.cmbLogLevel.FormattingEnabled = true;
            this.cmbLogLevel.Location = new System.Drawing.Point(145, 7);
            this.cmbLogLevel.Name = "cmbLogLevel";
            this.cmbLogLevel.NextFocusId = ((long)(0));
            this.cmbLogLevel.PerformLayoutEnabled = true;
            this.cmbLogLevel.PreviousFocusId = ((long)(0));
            this.cmbLogLevel.Size = new System.Drawing.Size(121, 21);
            this.cmbLogLevel.TabIndex = 0;
            // 
            // lblLogLevel
            // 
            this.lblLogLevel.AutoSize = true;
            this.lblLogLevel.ExcludeFromUniqueId = false;
            this.lblLogLevel.Location = new System.Drawing.Point(5, 10);
            this.lblLogLevel.Name = "lblLogLevel";
            this.lblLogLevel.NextFocusId = ((long)(0));
            this.lblLogLevel.PerformLayoutEnabled = true;
            this.lblLogLevel.PreviousFocusId = ((long)(0));
            this.lblLogLevel.Size = new System.Drawing.Size(35, 13);
            this.lblLogLevel.TabIndex = 1;
            this.lblLogLevel.Text = "Log level";
            // 
            // lblBecosoft
            // 
            this.lblBecosoft.AutoSize = true;
            this.lblBecosoft.ExcludeFromUniqueId = false;
            this.lblBecosoft.Location = new System.Drawing.Point(5, 37);
            this.lblBecosoft.Name = "lblBecosoft";
            this.lblBecosoft.NextFocusId = ((long)(0));
            this.lblBecosoft.PerformLayoutEnabled = true;
            this.lblBecosoft.PreviousFocusId = ((long)(0));
            this.lblBecosoft.Size = new System.Drawing.Size(35, 13);
            this.lblBecosoft.TabIndex = 3;
            this.lblBecosoft.Text = "Activate Becosoft link";
            // 
            // chbBecosoft
            // 
            this.chbBecosoft.AutoSize = true;
            this.chbBecosoft.ExcludeFromUniqueId = false;
            this.chbBecosoft.Location = new System.Drawing.Point(145, 36);
            this.chbBecosoft.Name = "chbBecosoft";
            this.chbBecosoft.NextFocusId = ((long)(0));
            this.chbBecosoft.PerformLayoutEnabled = true;
            this.chbBecosoft.PreviousFocusId = ((long)(0));
            this.chbBecosoft.Size = new System.Drawing.Size(15, 14);
            this.chbBecosoft.TabIndex = 5;
            // 
            // lblTranslationsApi
            // 
            this.lblTranslationsApi.AutoSize = true;
            this.lblTranslationsApi.ExcludeFromUniqueId = false;
            this.lblTranslationsApi.Location = new System.Drawing.Point(5, 63);
            this.lblTranslationsApi.Name = "lblTranslationsApi";
            this.lblTranslationsApi.NextFocusId = ((long)(0));
            this.lblTranslationsApi.PerformLayoutEnabled = true;
            this.lblTranslationsApi.PreviousFocusId = ((long)(0));
            this.lblTranslationsApi.Size = new System.Drawing.Size(35, 13);
            this.lblTranslationsApi.TabIndex = 6;
            this.lblTranslationsApi.Text = "Translations via API";
            // 
            // txtTranslationsApiHost
            // 
            this.txtTranslationsApiHost.ExcludeFromUniqueId = false;
            this.txtTranslationsApiHost.Location = new System.Drawing.Point(145, 86);
            this.txtTranslationsApiHost.Name = "txtTranslationsApiHost";
            this.txtTranslationsApiHost.NextFocusId = ((long)(0));
            this.txtTranslationsApiHost.PerformLayoutEnabled = true;
            this.txtTranslationsApiHost.PreviousFocusId = ((long)(0));
            this.txtTranslationsApiHost.Size = new System.Drawing.Size(336, 20);
            this.txtTranslationsApiHost.TabIndex = 4;
            // 
            // chbTranslationsApi
            // 
            this.chbTranslationsApi.AutoSize = true;
            this.chbTranslationsApi.ExcludeFromUniqueId = false;
            this.chbTranslationsApi.Location = new System.Drawing.Point(145, 62);
            this.chbTranslationsApi.Name = "chbTranslationsApi";
            this.chbTranslationsApi.NextFocusId = ((long)(0));
            this.chbTranslationsApi.PerformLayoutEnabled = true;
            this.chbTranslationsApi.PreviousFocusId = ((long)(0));
            this.chbTranslationsApi.Size = new System.Drawing.Size(15, 14);
            this.chbTranslationsApi.TabIndex = 7;
            this.chbTranslationsApi.CheckedChanged += new System.EventHandler(this.chbTranslationsApi_CheckedChanged);
            // 
            // lblTranslationsApiHost
            // 
            this.lblTranslationsApiHost.AutoSize = true;
            this.lblTranslationsApiHost.ExcludeFromUniqueId = false;
            this.lblTranslationsApiHost.Location = new System.Drawing.Point(5, 89);
            this.lblTranslationsApiHost.Name = "lblTranslationsApiHost";
            this.lblTranslationsApiHost.NextFocusId = ((long)(0));
            this.lblTranslationsApiHost.PerformLayoutEnabled = true;
            this.lblTranslationsApiHost.PreviousFocusId = ((long)(0));
            this.lblTranslationsApiHost.Size = new System.Drawing.Size(35, 13);
            this.lblTranslationsApiHost.TabIndex = 8;
            this.lblTranslationsApiHost.Text = "Translations API host";
            // 
            // txtTranslationsApiUser
            // 
            this.txtTranslationsApiUser.ExcludeFromUniqueId = false;
            this.txtTranslationsApiUser.Location = new System.Drawing.Point(145, 112);
            this.txtTranslationsApiUser.Name = "txtTranslationsApiUser";
            this.txtTranslationsApiUser.NextFocusId = ((long)(0));
            this.txtTranslationsApiUser.PerformLayoutEnabled = true;
            this.txtTranslationsApiUser.PreviousFocusId = ((long)(0));
            this.txtTranslationsApiUser.Size = new System.Drawing.Size(170, 20);
            this.txtTranslationsApiUser.TabIndex = 9;
            // 
            // lblTranslationsApiUser
            // 
            this.lblTranslationsApiUser.AutoSize = true;
            this.lblTranslationsApiUser.ExcludeFromUniqueId = false;
            this.lblTranslationsApiUser.Location = new System.Drawing.Point(5, 115);
            this.lblTranslationsApiUser.Name = "lblTranslationsApiUser";
            this.lblTranslationsApiUser.NextFocusId = ((long)(0));
            this.lblTranslationsApiUser.PerformLayoutEnabled = true;
            this.lblTranslationsApiUser.PreviousFocusId = ((long)(0));
            this.lblTranslationsApiUser.Size = new System.Drawing.Size(35, 13);
            this.lblTranslationsApiUser.TabIndex = 10;
            this.lblTranslationsApiUser.Text = "Translations API username";
            // 
            // txtTranslationsApiPassword
            // 
            this.txtTranslationsApiPassword.ExcludeFromUniqueId = false;
            this.txtTranslationsApiPassword.Location = new System.Drawing.Point(145, 138);
            this.txtTranslationsApiPassword.Name = "txtTranslationsApiPassword";
            this.txtTranslationsApiPassword.NextFocusId = ((long)(0));
            this.txtTranslationsApiPassword.PerformLayoutEnabled = true;
            this.txtTranslationsApiPassword.PreviousFocusId = ((long)(0));
            this.txtTranslationsApiPassword.Size = new System.Drawing.Size(170, 20);
            this.txtTranslationsApiPassword.TabIndex = 11;
            this.txtTranslationsApiPassword.UseSystemPasswordChar = true;
            // 
            // lblTranslationsApiPassword
            // 
            this.lblTranslationsApiPassword.AutoSize = true;
            this.lblTranslationsApiPassword.ExcludeFromUniqueId = false;
            this.lblTranslationsApiPassword.Location = new System.Drawing.Point(5, 141);
            this.lblTranslationsApiPassword.Name = "lblTranslationsApiPassword";
            this.lblTranslationsApiPassword.NextFocusId = ((long)(0));
            this.lblTranslationsApiPassword.PerformLayoutEnabled = true;
            this.lblTranslationsApiPassword.PreviousFocusId = ((long)(0));
            this.lblTranslationsApiPassword.Size = new System.Drawing.Size(35, 13);
            this.lblTranslationsApiPassword.TabIndex = 12;
            this.lblTranslationsApiPassword.Text = "Translations API password";
            // 
            // Configuration
            // 
            this.Controls.Add(this.wstConfiguration);
            this.Size = new System.Drawing.Size(741, 542);
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wstConfiguration)).EndInit();
            this.wstConfiguration.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private WorkspaceTabs wstConfiguration;
        private WorkspaceTab tabGeneral;
        private Label lblLogLevel;
        private ComboBox cmbLogLevel;
        private Label lblTranslationsApiHost;
        private CheckBox chbTranslationsApi;
        private TextBox txtTranslationsApiHost;
        private Label lblTranslationsApi;
        private CheckBox chbBecosoft;
        private Label lblBecosoft;
        private Label lblTranslationsApiPassword;
        private TextBox txtTranslationsApiPassword;
        private Label lblTranslationsApiUser;
        private TextBox txtTranslationsApiUser;
    }
}