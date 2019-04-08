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
    public partial class UserList : FHList<Models.Core.User, UserForm>
    {
        public UserList()
        {
            InitializeComponent();

            AddColumn("UserName", "Username", 100, true);
            AddColumn("LastName", "Last name", 100, true);
            AddColumn("FirstName", "First name", 100, true);
        }

        public override void Delete()
        {
            if (dgvList.SelectedRows.Count == 1)
            {
                Models.Core.User usr = (Models.Core.User)dgvList.SelectedRows[0].DataBoundItem;
                usr.Active = false;
                BusinessLayer.General.Logging.Log("User '" + usr.UserName + "' set to inactive", BusinessLayer.General.Logging.LogLevel.Debug);
                Crud.Put(usr);
                RefreshData();
            }
        }

        public override void RefreshData()
        {
            BusinessLayer.General.Logging.Log("Loading active users", BusinessLayer.General.Logging.LogLevel.Debug);
            IList<Models.Core.User> items = Common.Session.DatabaseConnection
                                                .CreateCriteria(typeof(Models.Core.User))
                                                .Add(Expression.Eq("Active", true))
                                                .List<Models.Core.User>();
            dgvList.DataSource = items;
            Search();
        }
    }
}
