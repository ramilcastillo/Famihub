#region Using

using System;
using System.Collections.Generic;
using Gizmox.WebGUI.Forms;
using NHibernate.Criterion;
using FamiHub.Common.Extensions;

#endregion

namespace FamiHub.UI.FHCore
{
    public partial class UserGroupForm : FHFormTab
    {
        public UserGroupForm()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            menus.Items.Add((Models.Core.Menu)menu.SelectedItem);
        }

        public override void BeforeClose()
        {
            Common.MenuBuilder.Build();
        }

        private void UserGroupForm_Load(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void RefreshAll()
        {
            RefreshUserGroups();
            RefreshMenus();
        }

        private IList<Models.Core.Menu> menuList;
        private void RefreshMenus()
        {
            menuList = Crud.GetAll<Models.Core.Menu>();
            menu.DataSource = null;
            menu.DataSource = menuList;
            menu.DisplayMember = "Description";
            menu.ValueMember = "Id";
        }

        private IList<Models.Core.UserGroup> userGroupList;
        private void RefreshUserGroups()
        {
            userGroupList = Crud.GetAll<Models.Core.UserGroup>();
            group.DataSource = null;
            group.DataSource = userGroupList;
            group.DisplayMember = "Name";
            group.ValueMember = "Id";
        }

        private void RefreshUserGroupMenus()
        {
            if (selectedUserGroup != null)
            {
                var session = Common.Session.DatabaseConnection;
                IList<Models.Core.UserGroupMenu> userGroupMenus = session.CreateCriteria(typeof(Models.Core.UserGroupMenu))
                                                                    .Add(Expression.Eq("UserGroup", selectedUserGroup))
                                                                    .AddOrder(Order.Asc("Sequence"))
                                                                    .List<Models.Core.UserGroupMenu>();
                session.Close();

                menus.Items.Clear();
                foreach (Models.Core.UserGroupMenu mpgms in userGroupMenus)
                {
                    menus.Items.Add(mpgms.Menu);
                }
                menus.DisplayMember = "Description";
            }
        }

        private Models.Core.UserGroup selectedUserGroup;
        private void group_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUserGroup = (Models.Core.UserGroup)group.SelectedItem;
            RefreshUserGroupMenus();
        }

        private void btnNewGroup_Click(object sender, EventArgs e)
        {
            lblDescription.Visible = true;
            txtDescription.Visible = true;
            btnNewGroup.Visible = false;
            txtDescription.Focus();
        }

        private void txtDescription_KeyDown(object objSender, KeyEventArgs objArgs)
        {
            if (objArgs.KeyCode == Keys.Enter)
            {
                lblDescription.Visible = false;
                txtDescription.Visible = false;
                btnNewGroup.Visible = true;
                Models.Core.UserGroup ugrp = new Models.Core.UserGroup();
                ugrp.Name = txtDescription.Text;
                Crud.Put(ugrp);
                txtDescription.Text = "";
                RefreshUserGroups();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (menus.SelectedItems.Count > 0)
            {
                menus.Items.RemoveAt(menus.SelectedIndex);
            }
        }

        public override void ButtonState()
        {
            Core.Actions.SaveBtn(true);
            Core.Actions.DeleteBtn(true);
            Core.Actions.CancelBtn(true);
        }

        public override void Save()
        {
            Crud.Put(selectedUserGroup);
            IList<Models.Core.UserGroupMenu> mugms = Crud.GetList<Models.Core.UserGroupMenu, Models.Core.UserGroup>("UserGroup", selectedUserGroup);
            foreach (Models.Core.UserGroupMenu mugm in mugms) Crud.Delete(mugm);

            int seq = 0;
            foreach (Models.Core.Menu men in menus.Items)
            {
                Models.Core.UserGroupMenu mugm = new Models.Core.UserGroupMenu();
                mugm.Sequence = seq++;
                mugm.UserGroup = selectedUserGroup;
                mugm.Menu = men;
                Crud.Put(mugm);
            }
            RefreshAll();
            Common.Interaction.ThrowMessage(this, "Usergroup saved succesfully.");
        }

        public override void Delete()
        {
            IList<Models.Core.UserGroupMenu> mugms = Crud.GetList<Models.Core.UserGroupMenu, Models.Core.UserGroup>("UserGroup", selectedUserGroup);
            foreach (Models.Core.UserGroupMenu mugm in mugms)
                Crud.Delete(mugm);
            Crud.Delete(selectedUserGroup);
            RefreshAll();
        }

        public override void Cancel()
        {
            string selectedUserGroupCode = group.SelectedValue.ToString();
            RefreshAll();
            group.SelectedValue = selectedUserGroupCode;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (menus.SelectedItems.Count > 0)
            {
                menus.MoveItem(1);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (menus.SelectedItems.Count > 0)
            {
                menus.MoveItem(-1);
            }
        }
    }
}