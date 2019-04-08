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

#endregion

namespace FamiHub.Core
{
    public partial class MainForm : Form
    {
        private FHFormTab _activeTab { get { return (FHFormTab)workspace.SelectedTab?.Tag; } }
        internal FHFormDialog _activeDialog { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblLoggedInAs.Text = "Logged in as " + Common.Session.CurrentUser?.FirstName + " " + Common.Session.CurrentUser?.LastName + " (" + Common.Session.CurrentUser?.UserName + ")";
            lnkLogout.Location = new Point(lblLoggedInAs.Location.X + lblLoggedInAs.Width, lnkLogout.Location.Y);
            Actions.AllBtn(false);
            tmrKeepAlive.Start();
        }

        internal void OpenTabPage(FHFormTab form)
        {
            if (workspace.TabPages.Count > 9)
            {
                Common.Interaction.ThrowMessage(this, "Maximum 10 tabpages per session!");
                form.Dispose();
            }
            else
            {
                WorkspaceTab tp = new WorkspaceTab();
                tp.BackColor = Color.White;
                tp.Text = form.Text;
                form.Dock = DockStyle.Fill;
                tp.Controls.Add(form);
                tp.Tag = form;

                workspace.Controls.Add(tp);
                workspace.SelectedItem = tp;
                form.Focus();
                tp.Text = form.Text;
            }
        }

        public void menuTree_MouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null && e.Button == MouseButtons.Left)
            {
                Common.FormHandling.OpenForm(e.Node.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_activeTab != null) _activeTab.Add();
        }

        private void workspace_CloseClick(object sender, EventArgs e)
        {
            if (_activeTab != null) _activeTab.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_activeTab != null) _activeTab.Cancel();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_activeTab != null) _activeTab.Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_activeTab != null) _activeTab.Delete();
        }

        private void workspace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_activeTab != null)
            {
                _activeTab.OnActivateTab();
            }
            else
            {
                Actions.AllBtn(false);
            }
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Common.Session.CurrentSession.SessionEnd = DateTime.Now;
            Crud.Put(Common.Session.CurrentSession);

            Common.Session.CurrentSession = null;
            Common.Session.CurrentUser = null;
            Common.Session.MainForm = null;

            GC.Collect();

            Context.Transfer(new Logon());
            tmrKeepAlive.Stop();

            Dispose();
        }

        private void tmrKeepAlive_Tick(object sender, EventArgs e)
        {
            Common.Session.CurrentSession.SessionEnd = DateTime.Now.AddHours(1);
            Crud.Put(Common.Session.CurrentSession);
        }

        private void lblLoggedInAs_TextChanged(object sender, EventArgs e)
        {
            lnkLogout.Location = new Point(lblLoggedInAs.Location.X + lblLoggedInAs.Width, lnkLogout.Location.Y);
        }
    }
}