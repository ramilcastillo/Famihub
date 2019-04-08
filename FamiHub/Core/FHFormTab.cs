#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

#endregion

namespace FamiHub
{
    [ToolboxItem(false)]
    public partial class FHFormTab : UserControl
    {
        Core.FHFormDialog _dialog;
        Core.FHFormDialog _previousDialog;
        bool _dialogLoaded = false;
        public FHFormTab()
        {
            InitializeComponent();
        }

        public void OnActivateTab()
        {
            Core.Actions.AllBtn(false);
            ButtonState();
        }

        public override void Show()
        {
            BackColor = SystemColors.Control;
            Common.Session.MainForm.OpenTabPage(this);
            Common.FormHandling.Translate(this);
            Core.Actions.AllBtn(false);
            ButtonState();
        }

        public void ShowDialog()
        {
            BackColor = SystemColors.Control;
            if (Common.Session.MainForm._activeDialog != null)
            {
                _previousDialog = Common.Session.MainForm._activeDialog;
            }
            _dialog = new Core.FHFormDialog();
            Common.Session.MainForm._activeDialog = _dialog;
            _dialogLoaded = true;
            Dock = DockStyle.Fill;
            _dialog.Size = Size;
            _dialog.Controls.Add(this);
            _dialog.MinimizeBox = false;
            _dialog.MaximizeBox = false;
            Common.FormHandling.Translate(this);
            _dialog.ShowDialog();
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                bool done = false;
                base.Text = value;
                if (!this.DesignMode)
                {
                    if (Common.Session.MainForm != null)
                    {
                        foreach (TabPage tp in Common.Session.MainForm.workspace.TabPages)
                        {
                            if (tp.Tag == this)
                            {
                                tp.Text = value;
                                done = true;
                            }
                        }
                        if (!done && Common.Session.MainForm._activeDialog != null && _dialogLoaded)
                        {
                            Common.Session.MainForm._activeDialog.Text = value;
                        }
                    }
                }
            }
        }

        public virtual void ButtonState() { }
        public virtual void Save() { }
        public virtual void Cancel() { }
        public virtual void Add() { }
        public virtual void Delete() { }
        public virtual void BeforeClose() { }
        public virtual void RefreshData() { }
        public void Close()
        {
            Core.MainForm mainForm = Common.Session.MainForm;

            BeforeClose();
            if (Common.Session.MainForm._activeDialog != null)
            {
                Common.Session.MainForm._activeDialog.Close();
                if (_previousDialog != null)
                    Common.Session.MainForm._activeDialog = _previousDialog;
            }
            else
            {
                foreach (TabPage tab in mainForm.workspace.TabPages)
                {
                    if (tab.Tag == this)
                    {
                        int newTab = mainForm.workspace.TabPages.IndexOf(tab) - 1;
                        mainForm.workspace.TabPages.Remove(tab);
                        if (newTab > 0) mainForm.workspace.SelectedIndex = newTab;
                    }
                }
            }

            BusinessLayer.General.Logging.Log("User closed form " + Common.FormHandling.GetProgram(this).Code + ".", BusinessLayer.General.Logging.LogLevel.Debug);

            Dispose();
        }

        private void FHFormTab_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            if (!DesignMode)
            {
                Common.FormHandling.InitForm(this);
            }
        }
    }
}