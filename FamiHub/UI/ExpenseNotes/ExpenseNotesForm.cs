#region Using

using System;
using Gizmox.WebGUI.Forms;
using FamiHub.Models.Core;
#endregion

namespace FamiHub.UI.ExpenseNotes
{
    public partial class ExpenseNotesForm : FHFormTab
    {
        public ExpenseNotesForm()
        {
            InitializeComponent();
        }

        private void ExpenseNotesForm_Load(object sender, EventArgs e)
        {

        }
        public override void ButtonState()
        {
            Core.Actions.SaveBtn(true);
        }
        public override void Save()
        {
            try
            {
                if (!Validate())
                    return;

                var expenseNotes = new Models.Core.ExpenseNotes()
                {
                    Id = Guid.NewGuid(),
                    Amount = double.Parse(txtAmount.Text),
                    Comments = txtComments.Text,
                    Date = dtpDate.Value,
                    Department = txtDepartment.Text,
                    BankAccount = txtBankAccount.Text,
                    ApprovalState = Models.Enum.ApprovalStates.ToBeApproved,
                    RequestedOn = DateTime.Now,
                    Requestedby = Common.Session.CurrentUser,
                    ApprovalBy = null,
                    ApprovalOn = null
                };

                FamiHub.Crud.Add(expenseNotes);
                MessageBox.Show("Record successfully saved!");

            }
            catch (Exception x)
            {

                throw new Exception(x.Message);
            }
        }

        public bool Validate()
        {
            if (txtBankAccount.Text == string.Empty)
            {
                MessageBox.Show("Fill out Bank account field");
                return false;
            }
            if (txtDepartment.Text == string.Empty)
            {
                MessageBox.Show("Fill out Department field");
                return false;
            }
            if (txtAmount.Text == "        .")
            {
                MessageBox.Show("Fill out Amount field");
                return false;
            }
            if (txtComments.Text == string.Empty)
            {
                MessageBox.Show("Fill out Comments field");
                return false;
            }
            return true;
        }
    }
}