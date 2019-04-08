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
using System.Windows.Forms;

namespace FamiHub.UI.FHCore
{
    public partial class Errors : FHFormTab
    {
        public Errors()
        {
            InitializeComponent();
        }

        public override void ButtonState()
        {
            Core.Actions.DeleteBtn(true);
        }

        public override void Delete()
        {
            if (dgvErrors.SelectedRows.Count == 1)
            {
                ErrorWrapper ew = (ErrorWrapper)dgvErrors.SelectedRows[0].DataBoundItem;
                Crud.Delete(ew.Error);
                RefreshData();
            }
        }

        private void dgvErrors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvErrors.SelectedRows.Count == 1)
            {
                ErrorWrapper ew = (ErrorWrapper)dgvErrors.SelectedRows[0].DataBoundItem;
                string error = ew.Error.ErrorDescription + "\r\n" + "\r\n";
                error = error + "User: " + ew.Error.User.UserName + " (" + ew.Error.User.FirstName + " " + ew.Error.User.LastName + ")" + "\r\n";
                error = error + "Host: " + ew.Error.Host + "\r\n";
                error = error + "OS: " + ew.Error.OS + "\r\n";
                error = error + "Version: " + ew.Error.Version + "\r\n";
                error = error + "Time: " + ew.Error.ErrorTime + "\r\n";
                error = error + "Class: " + ew.Error.ClassName + "\r\n";
                error = error + "Method: " + ew.Error.Method + "\r\n";
                error = error + "Place: " + ew.Error.Place;
                error = error + "\r\n" + "\r\n";
                error = error + "---------------------------ERROR---------------------------" + "\r\n";
                error = error + ew.Error.LongError + "\r\n";
                error = error + "\r\n" + "\r\n";
                error = error + "------------------------STACK TRACE------------------------" + "\r\n";
                error = error + ew.Error.StackInfo;

                txtErrorInfo.Text = error;
            }
            else
            {
                txtErrorInfo.Text = "";
            }
        }

        private void Errors_Load(object sender, EventArgs e)
        {
            Common.FormHandling.SetGridEdit(dgvErrors, false);
            RefreshData();
        }

        public override void RefreshData()
        {
            IList<Models.Core.Error> mErrors = Crud.GetAll<Models.Core.Error>();
            IList<ErrorWrapper> errors = new List<ErrorWrapper>();
            foreach (Models.Core.Error error in mErrors)
            {
                ErrorWrapper err = new ErrorWrapper();
                err.Error = error;
                errors.Add(err);
            }
            dgvErrors.DataSource = errors;
        }

        private class ErrorWrapper
        {
            public Models.Core.Error Error { get; set; }
            public string User
            {
                get
                {
                    if (Error.User != null)
                    {
                        return Error.User.UserName;
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            public string ErrorDescription { get { return Error.ErrorDescription; } }
            public int Id { get { return Error.Id; } }
            public DateTime Time { get { return Error.ErrorTime; } }
            public string ClassName { get { return Error.ClassName; } }
        }
    }
}
