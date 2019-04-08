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

namespace FamiHub.UI.FHCore
{
    public partial class Configuration : FHFormTab
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            cmbLogLevel.DataSource = Enum.GetValues(typeof(BusinessLayer.General.Logging.LogLevel));
        }

        public override void ButtonState()
        {
            Core.Actions.SaveBtn(true);
        }

        private void LoadData()
        {
            cmbLogLevel.SelectedValue = Convert.ToInt16(GetProperty("DebugLevel") ?? "0");
            chbBecosoft.Checked = GetProperty("Becosoft:CustomerLinkActive") == "1";
            chbTranslationsApi.Checked = (Crud.GetById<Models.Core.Property, string>("Translation:WebApi")?.Value ?? "0") == "1";
            txtTranslationsApiHost.Text = GetProperty("Translation:ApiHost");
            txtTranslationsApiUser.Text = GetProperty("Translation:ApiUser");
            txtTranslationsApiPassword.Text = GetProperty("Translation:ApiPassword");
        }

        public override void Save()
        {
            SetProperty("DebugLevel", ((int)cmbLogLevel.SelectedValue).ToString());
            if (chbBecosoft.Checked) { SetProperty("Becosoft:CustomerLinkActive", "1"); } else { SetProperty("Becosoft:CustomerLinkActive", "0"); }
            if (chbTranslationsApi.Checked) { SetProperty("Translation:WebApi", "1"); } else { SetProperty("Translation:WebApi", "0"); }
            SetProperty("Translation:ApiHost", txtTranslationsApiHost.Text);
            SetProperty("Translation:ApiUser", txtTranslationsApiUser.Text);
            SetProperty("Translation:ApiPassword", txtTranslationsApiPassword.Text);

            Close();
        }

        private string GetProperty(string key)
        {
            return Crud.GetById<Models.Core.Property, string>(key)?.Value;
        }
        private void SetProperty(string key, string value)
        {
            Models.Core.Property property = new Models.Core.Property();
            property.Key = key;
            property.Value = value;
            Crud.Put(property);
        }

        private void chbTranslationsApi_CheckedChanged(object sender, EventArgs e)
        {
            txtTranslationsApiHost.Enabled = chbTranslationsApi.Checked;
            txtTranslationsApiUser.Enabled = chbTranslationsApi.Checked;
            txtTranslationsApiPassword.Enabled = chbTranslationsApi.Checked;
        }
    }
}