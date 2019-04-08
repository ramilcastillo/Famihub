#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using NHibernate.Criterion;

#endregion

namespace FamiHub.Core
{
    public partial class Logon : Form
    {
        public Logon()
        {
            InitializeComponent();
            ntrVersion.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Proceed();
        }

        private void GoToApplication(Models.Core.User user)
        {
            Common.Session.CurrentUser = user;
            BusinessLayer.General.Logging.Log("Password correct", BusinessLayer.General.Logging.LogLevel.Info);

            BusinessLayer.General.Logging.Log("Creating session for user", BusinessLayer.General.Logging.LogLevel.Debug);
            Models.Core.Session sess = new Models.Core.Session();
            sess.HostName = Environment.MachineName;
            sess.User = user;
            sess.SessionStart = DateTime.Now;
            sess.SessionEnd = DateTime.Now.AddHours(1);
            Crud.Add(sess);
            Common.Session.CurrentSession = sess;

            BusinessLayer.General.Logging.Log("Creating MainForm object", BusinessLayer.General.Logging.LogLevel.Debug);
            MainForm mainForm = new MainForm();
            Common.Session.MainForm = mainForm;
            Common.MenuBuilder.Build();
            Context.Transfer(mainForm);

            BusinessLayer.General.Logging.Log("MainForm loaded", BusinessLayer.General.Logging.LogLevel.Debug);
            BusinessLayer.General.Logging.Log("Login form closed", BusinessLayer.General.Logging.LogLevel.Debug);

            Dispose();
        }

        private void Proceed()
        {
            try
            {
                BusinessLayer.General.Logging.Log("Loading user data for user " + txtUsername.Text, BusinessLayer.General.Logging.LogLevel.Debug);
                var session = Common.Session.DatabaseConnection;
                Models.Core.User user = session.CreateCriteria(typeof(Models.Core.User))
                                .Add(Expression.Eq("UserName", txtUsername.Text.ToLower()))
                                .Add(Expression.Eq("Active", true))
                                .UniqueResult<Models.Core.User>();

                BusinessLayer.General.Logging.Log("User trying to login: " + txtUsername.Text, BusinessLayer.General.Logging.LogLevel.Info);

                if (user?.BecosoftUser ?? false)
                {
                    if (BusinessLayer.General.Security.BecosoftUser(user, txtPassword.Text))
                    {
                        GoToApplication(user);
                    }
                }
                if (user?.Password == Common.Encryption.Encrypt.EncryptText(txtPassword.Text))
                {
                    GoToApplication(user);
                }
                else
                {
                    BusinessLayer.General.Logging.Log("Password incorrect for user " + txtUsername.Text, BusinessLayer.General.Logging.LogLevel.Warning);
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    txtUsername.Focus();
                    Common.Interaction.ThrowMessage(this, "Password incorrect");
                }
            }
            catch (Exception ex)
            {
                Common.ExceptionHandling.HandleException(ex);
            }
        }

        private void txtPassword_KeyDown(object objSender, KeyEventArgs objArgs)
        {
            if (objArgs.KeyCode == Keys.Enter)
            {
                Proceed();
            }
        }
    }
}