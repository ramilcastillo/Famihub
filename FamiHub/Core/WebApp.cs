#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using NHibernate.Criterion;

#endregion

namespace FamiHub
{
    public partial class WebApp : Form
    {
        public WebApp()
        {
            InitializeComponent();
            tmrLoad.Start();
        }

        void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Common.ExceptionHandling.HandleException(e.Exception);
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            tmrLoad.Stop();
        }

        private void CleanUpSessions()
        {
            string baseDir = Properties.Settings.Default.TempFileDirectory;
            BusinessLayer.General.Logging.Log("Cleaning up temporary directory: " + baseDir, BusinessLayer.General.Logging.LogLevel.Debug);

            var session = Common.Session.DatabaseConnection;
            IList<Models.Core.Session> sessions = session.CreateCriteria(typeof(Models.Core.Session))
                                                    .Add(Expression.Lt("SessionEnd", DateTime.Now.AddMinutes(-30)))
                                                    .List<Models.Core.Session>();

            foreach (var userSession in sessions)
            {
                string dir = baseDir + "\\" + Common.Session.Host + "-" + userSession.Id + "\\";
                if (Directory.Exists(dir))
                {
                    Directory.Delete(dir, true);

                    BusinessLayer.General.Logging.Log(".. Deleting folder for session: " + userSession.Id, BusinessLayer.General.Logging.LogLevel.Debug);
                }
            }

            BusinessLayer.General.Logging.Log("Cleaning up temporary directory finished.", BusinessLayer.General.Logging.LogLevel.Debug);
        }

        private void WebApp_Load(object sender, EventArgs e)
        {
            try
            {
                Application.ThreadException += Application_ThreadException;
                Models.Core.Property databaseVersion = null;

                Common.Session.OpenSession();

                try
                {
                    databaseVersion = (Models.Core.Property)Common.Session.DatabaseConnection.Get(typeof(Models.Core.Property), "dbVersion");
                }
                catch { }
                
                if (databaseVersion == null)
                {
                    lblPleaseWait.Text = "Installing database scheme...";
                    Common.Session.UpdateDatabaseSchema();
                    databaseVersion = new Models.Core.Property();
                    databaseVersion.Key = "dbVersion";
                    databaseVersion.Value = typeof(Models.Core.Property).Assembly.GetName().Version.ToString();
                    Crud.Put(databaseVersion);
                }
                else if (databaseVersion.Value != typeof(Models.Core.Property).Assembly.GetName().Version.ToString() || System.Diagnostics.Debugger.IsAttached)
                {
                    lblPleaseWait.Text = "Updating database scheme...";
                    Common.Session.UpdateDatabaseSchema();
                    databaseVersion.Value = typeof(Models.Core.Property).Assembly.GetName().Version.ToString();
                    Crud.Put(databaseVersion);
                }

                lblPleaseWait.Text = "Installing new base data...";
                Common.Install.UpdateDb();

                CleanUpSessions();

                Core.Logon logon = new Core.Logon();
                Context.Transfer(logon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}