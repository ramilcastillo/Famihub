#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

#endregion

namespace FamiHub.UI.ExpenseNotes
{
    public partial class WorkflowCreateForm : FHFormTab
    {
        public WorkflowCreateForm()
        {
            InitializeComponent();
            GetUsers();
        }

        private void ApprovalWorkflowDetail_Load(object sender, EventArgs e)
        {

        }
        public override void ButtonState()
        {
            Core.Actions.SaveBtn(true);
        }

        public override void Save()
        {
            var approverType = new Models.Core.ApproverType {
                Description = txtDescription.Text
            };
            FamiHub.Crud.Add(approverType);
            IList<Models.Core.ApproverType> lstApproverType = FamiHub.Crud.GetAll<Models.Core.ApproverType>();
            var approverTypeId = lstApproverType.OrderByDescending(s => s.Id).Select(s=>s.Id).First();
            var approverTypeParam = FamiHub.Crud.GetById<Models.Core.ApproverType,int>(approverTypeId);
            Models.Core.Approver approver;
            for (int i = 0; i < lbxApprovers.Items.Count; i++)
            {
                var description = lbxApprovers.Items[i].ToString();
                approver = new Models.Core.Approver {
                    ApproverName = description.Replace("Approver " + (i + 1) + " - ", ""),
                    Level = i + 1,
                    ApproverType = approverTypeParam
                };
                FamiHub.Crud.Put(approver);
            }
            MessageBox.Show("Successfully Saved Workflow!");
        }

        public void GetUsers()
        {
            IList<Models.Core.User> lstUsers = Crud.GetAll<Models.Core.User>();
            var lstUserDetails = new List<UserDetails>();
            foreach (var user in lstUsers)
            {
                lstUserDetails.Add(new UserDetails {
                    Id =  user.Id,
                    FullName = user.FirstName+" "+user.LastName
                });
            }                         
            cmbUser.DataSource = null;
            cmbUser.DataSource = lstUserDetails;
            cmbUser.DisplayMember = "FullName";
            cmbUser.ValueMember = "FullName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var user = (UserDetails)cmbUser.SelectedItem;
            bool isNew = true;
            for(int i = 0; i<lbxApprovers.Items.Count;i++)
            {
                if (lbxApprovers.Items[i].ToString().Contains(user.FullName))
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
                    lbxApprovers.Items.Add("Approver " + (lbxApprovers.Items.Count + 1).ToString() + " - " + user.FullName);
                    lbxApprovers.DisplayMember = "FullName";
                }
            }
            else
            {              
                MessageBox.Show("User is already assigned as approver!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxApprovers.Items.Count > 0)
            {
                lbxApprovers.Items.RemoveAt(lbxApprovers.Items.Count - 1);
            }
        }
    }
    public class UserDetails
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }
    public class UserDescription
    {
        public string Description { get; set; }
    }
}