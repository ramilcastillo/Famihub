#region License
// *******************************************************
// Copyright (c) 2018 Famiflora SA
// 
// This file is part of FamiHub.
// FamiHub can not be copied and/or distributed without the express
// permission of Famiflora SA.
// *******************************************************
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gizmox.WebGUI.Forms;

namespace FamiHub.UI.FHCore
{
    public partial class MessageTranslations : FHFormTab
    {
        private IList<BusinessLayer.General.Localization.TranslationWrapper> mGridDataSource
            = new List<BusinessLayer.General.Localization.TranslationWrapper>();
        private BindingSource mBindingSource = new BindingSource();

        public MessageTranslations()
        {
            InitializeComponent();
        }

        private void MessageTranslations_Load(object sender, EventArgs e)
        {
            dgvTranslations.AllowUserToAddRows = false;
            dgvTranslations.AllowUserToDeleteRows = false;
            dgvTranslations.AutoGenerateColumns = false;
            mBindingSource.DataSource = mGridDataSource;
            dgvTranslations.DataSource = mBindingSource;
            mBindingSource.CurrentItemChanged += MBindingSource_CurrentItemChanged;
        }

        private void MBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            BindingSource sndr = (BindingSource)sender;
            BusinessLayer.General.Localization.TranslationWrapper wrap = (BusinessLayer.General.Localization.TranslationWrapper)sndr.Current;
            if (wrap != null)
                Common.Localization.SetMessageTranslation(wrap);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtLanguage.Text != "")
            {
                mGridDataSource = Common.Localization.GetMessageTranslationsByForm
                                        (txtMessageGroup.Text, txtLanguage.Text, chbOnlyNotTranslated.Checked);

                mBindingSource.DataSource = mGridDataSource;
                dgvTranslations.Focus();
            }
        }
    }
}
