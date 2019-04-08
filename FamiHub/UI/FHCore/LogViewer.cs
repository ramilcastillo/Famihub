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
using System.Linq;
using Gizmox.WebGUI.Forms;

namespace FamiHub.UI.FHCore
{
    public partial class LogViewer : FHFormTab
    {
        IList<LogWrapper> dataList = new List<LogWrapper>();
        public LogViewer()
        {
            InitializeComponent();
            Common.FormHandling.SetGridEdit(dgvLog, false);
        }

        public void LoadData()
        {
            if (dataList.Count > 0)
                dataList.Clear();

            var res = Crud.GetAll<Models.Core.Logging>();
            IEnumerable<Models.Core.Logging> sortedEnum = res.OrderBy(f => f.Timestamp);
            IList<Models.Core.Logging> sortedList = sortedEnum.ToList();

            foreach (var loggingItem in sortedList)
            {
                LogWrapper log = new LogWrapper();
                log.Logging = loggingItem;

                dataList.Add(log);
            }
            dgvLog.DataSource = null;
            dgvLog.DataSource = dataList;
        }

        private class LogWrapper
        {
            private Models.Core.Logging _logging;
            public virtual Models.Core.Logging Logging
            {
                set
                {
                    _logging = value;
                }
                get
                {
                    return _logging;
                }
            }
            public virtual long Id
            {
                get
                {
                    return _logging.Id;
                }
            }
            public virtual DateTime Timestamp
            {
                get
                {
                    return _logging.Timestamp;
                }
            }
            public virtual Models.Core.User User
            {
                get
                {
                    return _logging.User;
                }
            }
            public virtual string UserName
            {
                get
                {
                    if (_logging.User != null)
                    {
                        return _logging.User.UserName + " (" + _logging.User.FirstName + " " + _logging.User.LastName + ")";
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            public virtual string Hostname
            {
                get
                {
                    return _logging.Hostname;
                }
            }
            public virtual string Text
            {
                get
                {
                    return _logging.Text;
                }
            }
            public virtual string Level
            {
                get
                {
                    BusinessLayer.General.Logging.LogLevel level = (BusinessLayer.General.Logging.LogLevel)_logging.Level;
                    return level.ToString();
                }
            }
        }

        private void LogViewer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvLog_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLog.SelectedRows.Count > 0)
            {
                var logItem = (LogWrapper)dgvLog.SelectedRows[0].DataBoundItem;
                string info;

                info = "Level: " + logItem.Level + "\r\n";
                info = info + "Date: " + logItem.Timestamp.ToString() + "\r\n";
                info = info + "User: " + logItem.UserName + "\r\n";
                info = info + "Hostname: " + logItem.Hostname + "\r\n";
                info = info + "\r\n" + logItem.Text;

                txtLogInfo.Text = info;
            }
            else
            {
                txtLogInfo.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow logItem in dgvLog.Rows)
            {
                LogWrapper log = (LogWrapper)logItem.DataBoundItem;
                Crud.Delete(log.Logging);
            }

            LoadData();
        }
    }
}
