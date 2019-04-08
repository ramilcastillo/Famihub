using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.Core
{
    partial class Logon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logon));
            this.pnlForm = new Gizmox.WebGUI.Forms.Panel();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.btnLogin = new Gizmox.WebGUI.Forms.Button();
            this.lblPassword = new Gizmox.WebGUI.Forms.Label();
            this.txtPassword = new Gizmox.WebGUI.Forms.TextBox();
            this.txtUsername = new Gizmox.WebGUI.Forms.TextBox();
            this.lblUsername = new Gizmox.WebGUI.Forms.Label();
            this.lblWelcome = new Gizmox.WebGUI.Forms.Label();
            this.pnlLogo = new Gizmox.WebGUI.Forms.Panel();
            this.ntrVersion = new Gizmox.WebGUI.Forms.Label();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.pnlForm.BackColor = System.Drawing.SystemColors.Control;
            this.pnlForm.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))));
            this.pnlForm.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.pnlForm.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(2);
            this.pnlForm.Controls.Add(this.ntrVersion);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Controls.Add(this.btnLogin);
            this.pnlForm.Controls.Add(this.lblPassword);
            this.pnlForm.Controls.Add(this.txtPassword);
            this.pnlForm.Controls.Add(this.txtUsername);
            this.pnlForm.Controls.Add(this.lblUsername);
            this.pnlForm.Controls.Add(this.lblWelcome);
            this.pnlForm.Controls.Add(this.pnlLogo);
            this.pnlForm.ExcludeFromUniqueId = false;
            this.pnlForm.Location = new System.Drawing.Point(9, 9);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.NextFocusId = ((long)(0));
            this.pnlForm.PerformLayoutEnabled = true;
            this.pnlForm.PreviousFocusId = ((long)(0));
            this.pnlForm.Size = new System.Drawing.Size(401, 349);
            this.pnlForm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ExcludeFromUniqueId = false;
            this.label1.Location = new System.Drawing.Point(1, 329);
            this.label1.Name = "label1";
            this.label1.NextFocusId = ((long)(0));
            this.label1.PerformLayoutEnabled = true;
            this.label1.PreviousFocusId = ((long)(0));
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "© Famiflora SA";
            // 
            // btnLogin
            // 
            this.btnLogin.ExcludeFromUniqueId = false;
            this.btnLogin.Location = new System.Drawing.Point(20, 281);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NextFocusId = ((long)(0));
            this.btnLogin.PerformLayoutEnabled = true;
            this.btnLogin.PreviousFocusId = ((long)(0));
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ExcludeFromUniqueId = false;
            this.lblPassword.Location = new System.Drawing.Point(17, 230);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.NextFocusId = ((long)(0));
            this.lblPassword.PerformLayoutEnabled = true;
            this.lblPassword.PreviousFocusId = ((long)(0));
            this.lblPassword.Size = new System.Drawing.Size(35, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.ExcludeFromUniqueId = false;
            this.txtPassword.Location = new System.Drawing.Point(20, 246);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NextFocusId = ((long)(0));
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PerformLayoutEnabled = true;
            this.txtPassword.PreviousFocusId = ((long)(0));
            this.txtPassword.Size = new System.Drawing.Size(358, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.ExcludeFromUniqueId = false;
            this.txtUsername.Location = new System.Drawing.Point(20, 196);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.NextFocusId = ((long)(0));
            this.txtUsername.PerformLayoutEnabled = true;
            this.txtUsername.PreviousFocusId = ((long)(0));
            this.txtUsername.Size = new System.Drawing.Size(358, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ExcludeFromUniqueId = false;
            this.lblUsername.Location = new System.Drawing.Point(17, 180);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.NextFocusId = ((long)(0));
            this.lblUsername.PerformLayoutEnabled = true;
            this.lblUsername.PreviousFocusId = ((long)(0));
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblWelcome
            // 
            this.lblWelcome.ExcludeFromUniqueId = false;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(0, 112);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.NextFocusId = ((long)(0));
            this.lblWelcome.PerformLayoutEnabled = true;
            this.lblWelcome.PreviousFocusId = ((long)(0));
            this.lblWelcome.Size = new System.Drawing.Size(400, 51);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "FamiHub Portal\r\nWelcome!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("pnlLogo.BackgroundImage"));
            this.pnlLogo.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Center;
            this.pnlLogo.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlLogo.ExcludeFromUniqueId = false;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.NextFocusId = ((long)(0));
            this.pnlLogo.PerformLayoutEnabled = true;
            this.pnlLogo.PreviousFocusId = ((long)(0));
            this.pnlLogo.Size = new System.Drawing.Size(399, 112);
            this.pnlLogo.TabIndex = 0;
            // 
            // ntrVersion
            // 
            this.ntrVersion.ExcludeFromUniqueId = false;
            this.ntrVersion.Location = new System.Drawing.Point(206, 329);
            this.ntrVersion.Name = "ntrVersion";
            this.ntrVersion.NextFocusId = ((long)(0));
            this.ntrVersion.PerformLayoutEnabled = true;
            this.ntrVersion.PreviousFocusId = ((long)(0));
            this.ntrVersion.Size = new System.Drawing.Size(187, 18);
            this.ntrVersion.TabIndex = 6;
            this.ntrVersion.Text = "Version x.x.xxxxx.xx";
            this.ntrVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Logon
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.None;
            this.Controls.Add(this.pnlForm);
            this.Size = new System.Drawing.Size(419, 367);
            this.Text = "FamiHub Portal";
            this.pnlForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Panel pnlForm;
        private Panel pnlLogo;
        private Label lblWelcome;
        private TextBox txtUsername;
        private Label lblUsername;
        private Button btnLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label label1;
        private Label ntrVersion;
    }
}