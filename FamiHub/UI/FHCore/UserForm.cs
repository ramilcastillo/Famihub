#region License
// *******************************************************
// Copyright (c) 2018 Famiflora SA
// 
// This file is part of FamiHub.
// FamiHub can not be copied and/or distributed without the express
// permission of Famiflora SA.
// *******************************************************
#endregion
using NHibernate.Criterion;
using System.Collections.Generic;

namespace FamiHub.UI.FHCore
{
    public partial class UserForm : FHFormTab
    {
        internal Models.Core.User dataObject;
        FHFormTab caller;
        public UserForm(FHFormTab caller, Models.Core.User user)
        {
            InitializeComponent();

            this.caller = caller;
            this.dataObject = user;

            LoadLanguages();
            LoadUserGroups();

            if (this.dataObject == null)
                this.dataObject = new Models.Core.User();
            else
                LoadData();
            LoadWorkflow();
        }
        private void LoadWorkflow()
        {
            IList<Models.Core.ApproverType> lstApproverType = FamiHub.Crud.GetAll<Models.Core.ApproverType>();
            cmbExpenseNotesApproval.DataSource = lstApproverType;
            cmbExpenseNotesApproval.DisplayMember = "Description";
            
        }
        private void LoadLanguages()
        {
            BusinessLayer.General.Logging.Log("Loading languages", BusinessLayer.General.Logging.LogLevel.Debug);
            cmbLanguage.DataSource = Common.Localization.GetLanguages();
            cmbLanguage.DisplayMember = "Item2";
            cmbLanguage.ValueMember = "Item1";
        }

        private void LoadUserGroups()
        {
            BusinessLayer.General.Logging.Log("Loading user groups", BusinessLayer.General.Logging.LogLevel.Debug);
            cmbUsergroup.DataSource = Crud.GetAll<Models.Core.UserGroup>();
            cmbUsergroup.DisplayMember = "Name";
            cmbUsergroup.ValueMember = "Id";
        }

        private void LoadData()
        {
            txtUsername.Text = dataObject.UserName;
            if (!string.IsNullOrEmpty(txtUsername.Text)) txtUsername.Enabled = false;
            if (!string.IsNullOrEmpty(dataObject.Password)) txtPassword.Text = Common.Encryption.Encrypt.DecryptText(dataObject.Password);
            cmbLanguage.SelectedValue = dataObject.Language;
            cmbUsergroup.SelectedValue = dataObject.UserGroup.Id;
            txtFirstname.Text = dataObject.FirstName;
            txtLastname.Text = dataObject.LastName;
            txtMailAddress.Text = dataObject.MailAddress;
            chbApiAccess.Checked = dataObject.ApiUser;
            chbBecosoft.Checked = dataObject.BecosoftUser;
        }

        public override void ButtonState()
        {
            Core.Actions.SaveBtn(true);
        }

        public override void Save()
        {
            BusinessLayer.General.Logging.Log("Saving user data to database, user: " + txtUsername.Text, BusinessLayer.General.Logging.LogLevel.Debug);
            dataObject.UserName = txtUsername.Text.ToLower();
            dataObject.Password = Common.Encryption.Encrypt.EncryptText(txtPassword.Text);
            dataObject.Language = cmbLanguage.SelectedValue.ToString();
            dataObject.UserGroup = (Models.Core.UserGroup)cmbUsergroup.SelectedItem;
            dataObject.FirstName = txtFirstname.Text;
            dataObject.LastName = txtLastname.Text;
            dataObject.MailAddress = txtMailAddress.Text;
            dataObject.Active = true;
            dataObject.ApiUser = chbApiAccess.Checked;
            dataObject.BecosoftUser = chbBecosoft.Checked;

            if ((dataObject.Id == 0 && !ExistingUser(txtUsername.Text)) || dataObject.Id > 0)
            {
                Crud.Put(dataObject);
                caller.RefreshData();
                Close();
            }
            else
            {
                Common.Interaction.ThrowMessage(this, "Username '{0}' already exists", txtUsername.Text);
            }
        }

        private bool ExistingUser(string userName)
        {
            var session = Common.Session.DatabaseConnection;
            Models.Core.User user = session.CreateCriteria(typeof(Models.Core.User))
                            .Add(Expression.Eq("UserName", userName))
                            .Add(Expression.Eq("Active", true))
                            .UniqueResult<Models.Core.User>();

            if (user != null)
                return true;
            else
                return false;
        }

        private void chbBecosoft_CheckedChanged(object sender, System.EventArgs e)
        {
            txtPassword.Enabled = !chbBecosoft.Checked;
            txtFirstname.Enabled = !chbBecosoft.Checked;
            txtLastname.Enabled = !chbBecosoft.Checked;
            txtPassword.Enabled = !chbBecosoft.Checked;
        }
    }
}
