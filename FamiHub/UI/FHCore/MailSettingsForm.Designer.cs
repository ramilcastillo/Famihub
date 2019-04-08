using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.FHCore
{
    partial class MailSettingsForm
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
            this.lblHost = new Gizmox.WebGUI.Forms.Label();
            this.lblPort = new Gizmox.WebGUI.Forms.Label();
            this.lblDefaultAddress = new Gizmox.WebGUI.Forms.Label();
            this.lblPassword = new Gizmox.WebGUI.Forms.Label();
            this.txtUsername = new Gizmox.WebGUI.Forms.TextBox();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.txtPassword = new Gizmox.WebGUI.Forms.TextBox();
            this.lblUsername = new Gizmox.WebGUI.Forms.Label();
            this.txtDefaultAddress = new Gizmox.WebGUI.Forms.TextBox();
            this.txtPort = new Gizmox.WebGUI.Forms.TextBox();
            this.txtHost = new Gizmox.WebGUI.Forms.TextBox();
            this.gbxSmtpSettings = new Gizmox.WebGUI.Forms.GroupBox();
            this.txtUsername.SuspendLayout();
            this.gbxSmtpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.ExcludeFromUniqueId = false;
            this.lblHost.Location = new System.Drawing.Point(5, 26);
            this.lblHost.Name = "lblHost";
            this.lblHost.NextFocusId = ((long)(0));
            this.lblHost.PerformLayoutEnabled = true;
            this.lblHost.PreviousFocusId = ((long)(0));
            this.lblHost.Size = new System.Drawing.Size(41, 17);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.ExcludeFromUniqueId = false;
            this.lblPort.Location = new System.Drawing.Point(5, 52);
            this.lblPort.Name = "lblPort";
            this.lblPort.NextFocusId = ((long)(0));
            this.lblPort.PerformLayoutEnabled = true;
            this.lblPort.PreviousFocusId = ((long)(0));
            this.lblPort.Size = new System.Drawing.Size(39, 17);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Port:";
            // 
            // lblDefaultAddress
            // 
            this.lblDefaultAddress.AutoSize = true;
            this.lblDefaultAddress.ExcludeFromUniqueId = false;
            this.lblDefaultAddress.Location = new System.Drawing.Point(5, 76);
            this.lblDefaultAddress.Name = "lblDefaultAddress";
            this.lblDefaultAddress.NextFocusId = ((long)(0));
            this.lblDefaultAddress.PerformLayoutEnabled = true;
            this.lblDefaultAddress.PreviousFocusId = ((long)(0));
            this.lblDefaultAddress.Size = new System.Drawing.Size(144, 17);
            this.lblDefaultAddress.TabIndex = 0;
            this.lblDefaultAddress.Text = "Default From Address:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ExcludeFromUniqueId = false;
            this.lblPassword.Location = new System.Drawing.Point(5, 128);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.NextFocusId = ((long)(0));
            this.lblPassword.PerformLayoutEnabled = true;
            this.lblPassword.PreviousFocusId = ((long)(0));
            this.lblPassword.Size = new System.Drawing.Size(71, 17);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Controls.Add(this.label5);
            this.txtUsername.ExcludeFromUniqueId = false;
            this.txtUsername.Location = new System.Drawing.Point(165, 99);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.NextFocusId = ((long)(0));
            this.txtUsername.PerformLayoutEnabled = true;
            this.txtUsername.PreviousFocusId = ((long)(0));
            this.txtUsername.Size = new System.Drawing.Size(114, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ExcludeFromUniqueId = false;
            this.label5.Location = new System.Drawing.Point(32, 130);
            this.label5.Name = "label4";
            this.label5.NextFocusId = ((long)(0));
            this.label5.PerformLayoutEnabled = true;
            this.label5.PreviousFocusId = ((long)(0));
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.ExcludeFromUniqueId = false;
            this.txtPassword.Location = new System.Drawing.Point(165, 125);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NextFocusId = ((long)(0));
            this.txtPassword.PerformLayoutEnabled = true;
            this.txtPassword.PreviousFocusId = ((long)(0));
            this.txtPassword.Size = new System.Drawing.Size(114, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ExcludeFromUniqueId = false;
            this.lblUsername.Location = new System.Drawing.Point(5, 102);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.NextFocusId = ((long)(0));
            this.lblUsername.PerformLayoutEnabled = true;
            this.lblUsername.PreviousFocusId = ((long)(0));
            this.lblUsername.Size = new System.Drawing.Size(74, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // txtDefaultAddress
            // 
            this.txtDefaultAddress.ExcludeFromUniqueId = false;
            this.txtDefaultAddress.Location = new System.Drawing.Point(165, 73);
            this.txtDefaultAddress.Name = "txtDefaultAddress";
            this.txtDefaultAddress.NextFocusId = ((long)(0));
            this.txtDefaultAddress.PerformLayoutEnabled = true;
            this.txtDefaultAddress.PreviousFocusId = ((long)(0));
            this.txtDefaultAddress.Size = new System.Drawing.Size(114, 20);
            this.txtDefaultAddress.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.ExcludeFromUniqueId = false;
            this.txtPort.Location = new System.Drawing.Point(165, 49);
            this.txtPort.Name = "txtPort";
            this.txtPort.NextFocusId = ((long)(0));
            this.txtPort.PerformLayoutEnabled = true;
            this.txtPort.PreviousFocusId = ((long)(0));
            this.txtPort.Size = new System.Drawing.Size(114, 20);
            this.txtPort.TabIndex = 1;
            // 
            // txtHost
            // 
            this.txtHost.ExcludeFromUniqueId = false;
            this.txtHost.Location = new System.Drawing.Point(165, 23);
            this.txtHost.Name = "txtHost";
            this.txtHost.NextFocusId = ((long)(0));
            this.txtHost.PerformLayoutEnabled = true;
            this.txtHost.PreviousFocusId = ((long)(0));
            this.txtHost.Size = new System.Drawing.Size(114, 20);
            this.txtHost.TabIndex = 0;
            // 
            // gbxSmtpSettings
            // 
            this.gbxSmtpSettings.Controls.Add(this.txtHost);
            this.gbxSmtpSettings.Controls.Add(this.lblPassword);
            this.gbxSmtpSettings.Controls.Add(this.txtPort);
            this.gbxSmtpSettings.Controls.Add(this.txtUsername);
            this.gbxSmtpSettings.Controls.Add(this.lblHost);
            this.gbxSmtpSettings.Controls.Add(this.txtDefaultAddress);
            this.gbxSmtpSettings.Controls.Add(this.txtPassword);
            this.gbxSmtpSettings.Controls.Add(this.lblDefaultAddress);
            this.gbxSmtpSettings.Controls.Add(this.lblPort);
            this.gbxSmtpSettings.Controls.Add(this.lblUsername);
            this.gbxSmtpSettings.ExcludeFromUniqueId = false;
            this.gbxSmtpSettings.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbxSmtpSettings.Location = new System.Drawing.Point(4, 6);
            this.gbxSmtpSettings.Name = "gbxSmtpSettings";
            this.gbxSmtpSettings.NextFocusId = ((long)(0));
            this.gbxSmtpSettings.PerformLayoutEnabled = true;
            this.gbxSmtpSettings.PreviousFocusId = ((long)(0));
            this.gbxSmtpSettings.Size = new System.Drawing.Size(309, 163);
            this.gbxSmtpSettings.TabIndex = 2;
            this.gbxSmtpSettings.TabStop = false;
            this.gbxSmtpSettings.Text = "SMTP Details";
            // 
            // MailSettingsForm
            // 
            this.Controls.Add(this.gbxSmtpSettings);
            this.Size = new System.Drawing.Size(679, 473);
            this.Text = "MailSettingsForm";
            this.Load += new System.EventHandler(this.MailSettingsForm_Load);
            this.txtUsername.ResumeLayout(false);
            this.gbxSmtpSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Label lblHost;
        private Label lblPort;
        private Label lblDefaultAddress;
        private TextBox txtPort;
        private TextBox txtHost;
        private TextBox txtDefaultAddress;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label label5;
        private TextBox txtPassword;
        private Label lblUsername;
        private GroupBox gbxSmtpSettings;
    }
}