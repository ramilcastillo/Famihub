#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using FamiHub.Common.Mail.Resource;
using FamiHub.Models.Core;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using NHibernate.Criterion;

#endregion

namespace FamiHub.UI.FHCore
{
    public partial class MailSettingsForm : FHFormTab
    {
        public MailSettingsForm()
        {
            InitializeComponent();
        }

        public override void ButtonState()
        {
            Core.Actions.SaveBtn(true);
        }

        private void MailSettingsForm_Load(object sender, EventArgs e)
        {
            var setting = GetCurrentSetting();
            txtDefaultAddress.Text = setting.DefaultFromAddress;
            txtHost.Text = setting.Host;
            txtPassword.Text = setting.Password;
            txtPort.Text = setting.Port.ToString();
            txtUsername.Text = setting.Username;
        }

        public SMTPSettings GetCurrentSetting()
        {
            var session = Common.Session.DatabaseConnection;
            var mailSettings = new SMTPSettings();

            mailSettings.DefaultFromAddress = FamiHub.Crud.GetById<Models.Core.Property, string>("MailSetting_DefaultFromAddress") == null? string.Empty: FamiHub.Crud.GetById<Models.Core.Property, string>("MailSetting_DefaultFromAddress").Value;
            mailSettings.Host = FamiHub.Crud.GetById<Models.Core.Property, string>("MailSetting_Host") == null?string.Empty: FamiHub.Crud.GetById<Models.Core.Property, string>("MailSetting_Host").Value;
            mailSettings.Port = FamiHub.Crud.GetById<Models.Core.Property, string>("MailSetting_Port") == null? 0 : int.Parse(FamiHub.Crud.GetById<Models.Core.Property, string>("MailSetting_Port").Value);
            mailSettings.Username = FamiHub.Crud.GetById<Models.Core.Property, string>("MailSetting_Username") == null? string.Empty: FamiHub.Crud.GetById<Models.Core.Property, string>("MailSetting_Username").Value;
            mailSettings.Password = FamiHub.Crud.GetById<Models.Core.Property, string>("MailSetting_Password")==null ? string.Empty: FamiHub.Crud.GetById<Models.Core.Property, string>("MailSetting_Password").Value;

            session.Close();

            return mailSettings;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        public override void Save()
        {
            try
            { 
                var defaultAddress = new Models.Core.Property()
                {
                    Key = "MailSetting_DefaultFromAddress",
                    Value = txtDefaultAddress.Text
                };
                FamiHub.Crud.Put(defaultAddress);
                var host = new Models.Core.Property()
                {
                    Key = "MailSetting_Host",
                    Value = txtHost.Text
                };
                FamiHub.Crud.Put(host);
                var port = new Models.Core.Property()
                {
                    Key = "MailSetting_Port",
                    Value = txtPort.Text
                };
                FamiHub.Crud.Put(port);
                var username = new Models.Core.Property()
                {
                    Key = "MailSetting_Username",
                    Value = txtUsername.Text
                };
                FamiHub.Crud.Put(username);
                var password = new Models.Core.Property()
                {
                    Key = "MailSetting_Password",
                    Value = txtPassword.Text
                };
                FamiHub.Crud.Put(password);
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
            MessageBox.Show("Successfully Saved!");
        }
    }
}