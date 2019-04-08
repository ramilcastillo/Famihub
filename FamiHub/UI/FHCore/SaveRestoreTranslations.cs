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
using System.IO;
using System.IO.Compression;
using Gizmox.WebGUI.Forms;

namespace FamiHub.UI.FHCore
{
    public partial class SaveRestoreTranslations : FHFormTab
    {
        public SaveRestoreTranslations()
        {
            InitializeComponent();
        }

        private void SaveRestoreTranslations_Load(object sender, EventArgs e)
        {
            cmbLanguage.DataSource = Common.Localization.GetLanguages();
            cmbLanguage.DisplayMember = "Item2";
            cmbLanguage.ValueMember = "Item1";
        }

        private void Export()
        {
            if (!string.IsNullOrEmpty(cmbLanguage.ValueMember.ToString()))
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = Common.Session.TemporaryPath;

                    IList<BusinessLayer.General.Localization.TranslationWrapper> mt = Common.Localization.GetMessageTranslationsByForm(
                        "", cmbLanguage.SelectedValue.ToString(), false);
                    List<BusinessLayer.General.Localization.TranslationWrapper> mtl = new List<BusinessLayer.General.Localization.TranslationWrapper>(mt);
                    Common.Xml.objectToXml(mtl, savePath + "\\mtl.xml");

                    IList<BusinessLayer.General.Localization.TranslationWrapper> ft = Common.Localization.GetFormTranslationsByForm(
                        "", cmbLanguage.SelectedValue.ToString(), false);
                    List<BusinessLayer.General.Localization.TranslationWrapper> ftl = new List<BusinessLayer.General.Localization.TranslationWrapper>(ft);
                    Common.Xml.objectToXml(ftl, savePath + "\\ftl.xml");

                    if (File.Exists(saveFileDialog.FileName))
                        File.Delete(saveFileDialog.FileName);
                    ZipFile.CreateFromDirectory(savePath, saveFileDialog.FileName);
                    Directory.Delete(savePath, true);
                    Common.Interaction.ThrowMessage(this, "Export completed.");
                }
            }
            else
            {
                Common.Interaction.ThrowMessage(this, "Please select a language.");
            }
        }

        private void Restore(string filename)
        {
            string savePath = Common.Session.TemporaryPath;
            string importFile = filename;
            ZipFile.ExtractToDirectory(importFile, savePath);

            List<BusinessLayer.General.Localization.TranslationWrapper> mt = new List<BusinessLayer.General.Localization.TranslationWrapper>();
            mt = (List<BusinessLayer.General.Localization.TranslationWrapper>)Common.Xml.xmlToObject<List<BusinessLayer.General.Localization.TranslationWrapper>>(savePath + "\\mtl.xml");
            foreach (BusinessLayer.General.Localization.TranslationWrapper m in mt)
            {
                Common.Localization.SetMessageTranslation(m);
            }

            List<BusinessLayer.General.Localization.TranslationWrapper> ft = new List<BusinessLayer.General.Localization.TranslationWrapper>();
            ft = (List<BusinessLayer.General.Localization.TranslationWrapper>)Common.Xml.xmlToObject<List<BusinessLayer.General.Localization.TranslationWrapper>>(savePath + "\\ftl.xml");
            foreach (BusinessLayer.General.Localization.TranslationWrapper f in ft)
            {
                Common.Localization.SetFormTranslation(f);
            }
            Directory.Delete(savePath, true);
            Common.Interaction.ThrowMessage(this, "Import completed.");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Restore(openFileDialog.FileName);
            }
            else
            {
                Common.Interaction.ThrowMessage(this, "Please select a file.");
            }
        }
    }
}
