#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FamiHub.Models.Core;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using NHibernate.Criterion;

#endregion

namespace FamiHub.UI.ExpenseNotes
{
    public partial class WorkflowForm : FHFormTab
    {
        internal Models.Core.ApproverType dataObject;
        FHFormTab _workflow;
        public WorkflowForm(FHFormTab workflow, Models.Core.ApproverType approvertype)
        {
            InitializeComponent();
            this._workflow = workflow;
            this.dataObject = approvertype;
            LoadData();
            GetUsers();
            if (this.dataObject == null)
                this.dataObject = new Models.Core.ApproverType();
        }
        public void GetUsers()
        {
            IList<Models.Core.User> lstUsers = Crud.GetAll<Models.Core.User>();
            var lstUserDetails = new List<UserDetails>();
            foreach (var user in lstUsers)
            {
                lstUserDetails.Add(new UserDetails
                {
                    Id = user.Id,
                    FullName = user.FirstName + " " + user.LastName
                });
            }
            cmbUser.DataSource = null;
            cmbUser.DataSource = lstUserDetails;
            cmbUser.DisplayMember = "FullName";
            cmbUser.ValueMember = "FullName";
        }

        private void LoadData()
        {
            txtDescription.Text = dataObject.Description;
            var session = Common.Session.DatabaseConnection;        
            var approver = session.CreateCriteria(typeof(Models.Core.Approver))
                         .Add(Expression.Eq("ApproverType",dataObject))
                        .List<Models.Core.Approver>();
            var lstApprovers = new ApproverObject();
            foreach (var i in approver)
            {
                lstApprovers = new ApproverObject {
                    Description = "Approver "+i.Level+" - "+i.ApproverName
                };
                lbxApprovers.Items.Add(lstApprovers);
                lbxApprovers.DisplayMember = "Description";
            }          
        }

        private void WorkflowForm_Load(object sender, EventArgs e)
        {

        }

        public override void ButtonState()
        {
            Core.Actions.SaveBtn(true);
        }

        public override void Save()
        {
            var session = Common.Session.DatabaseConnection;
            var approvers = session.CreateCriteria(typeof(Models.Core.Approver))
                         .Add(Expression.Eq("ApproverType", dataObject))
                        .List<Models.Core.Approver>();
            foreach (var approverItem in approvers)
            {
                FamiHub.Crud.Delete<Models.Core.Approver>(approverItem);
            }

            Models.Core.Approver approver;
            for (int i = 0; i < lbxApprovers.Items.Count; i++)
            {
                var description = lbxApprovers.Items[i].ToString();
                approver = new Models.Core.Approver
                {
                    ApproverName = description.Replace("Approver " + (i + 1) + " - ", ""),
                    Level = i + 1,
                    ApproverType = dataObject
                };
                FamiHub.Crud.Put(approver);
            }
            MessageBox.Show("Successfully Saved Workflow!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxApprovers.Items.Count > 0)
            {
                lbxApprovers.Items.RemoveAt(lbxApprovers.Items.Count - 1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var user = (UserDetails)cmbUser.SelectedItem;
            bool isNew = true;
            for (int i = 0; i < lbxApprovers.Items.Count; i++)
            {
                var name = (lbxApprovers.Items[i]).ToString();
                if (name.Contains(user.FullName))
                {
                    isNew = false;
                }
            }
            if (isNew)
            {
                if (lbxApprovers.Items.Count == 3)
                {
                    MessageBox.Show("Maximum of 3 approvers!");
                }
                else
                {
                    var item = new ApproverObject {
                        Description = "Approver " + (lbxApprovers.Items.Count + 1).ToString() + " - " + user.FullName
                    };
                    lbxApprovers.Items.Add(item.Description);
                    lbxApprovers.DisplayMember = "Description";
                }
            }
            else
            {
                MessageBox.Show("User is already assigned as approver!");
            }
        }
    }
    public class ApproverObject
    {
        public string Description { get; set; }
    }
}