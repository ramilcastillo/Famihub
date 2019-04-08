using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.ExpenseNotes
{
    partial class WorkflowCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Visual WebGui UserControl Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new Gizmox.WebGUI.Forms.Button();
            this.cmbUser = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblUser = new Gizmox.WebGUI.Forms.Label();
            this.txtDescription = new Gizmox.WebGUI.Forms.TextBox();
            this.lblDescription = new Gizmox.WebGUI.Forms.Label();
            this.btnDelete = new Gizmox.WebGUI.Forms.Button();
            this.lbxApprovers = new Gizmox.WebGUI.Forms.ListBox();
            this.lblApprovers = new Gizmox.WebGUI.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.ExcludeFromUniqueId = false;
            this.btnAdd.Location = new System.Drawing.Point(498, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NextFocusId = ((long)(0));
            this.btnAdd.PerformLayoutEnabled = true;
            this.btnAdd.PreviousFocusId = ((long)(0));
            this.btnAdd.Size = new System.Drawing.Size(231, 26);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add approver to workflow";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.ExcludeFromUniqueId = false;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(498, 44);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.NextFocusId = ((long)(0));
            this.cmbUser.PerformLayoutEnabled = true;
            this.cmbUser.PreviousFocusId = ((long)(0));
            this.cmbUser.Size = new System.Drawing.Size(231, 21);
            this.cmbUser.Sorted = true;
            this.cmbUser.TabIndex = 8;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ExcludeFromUniqueId = false;
            this.lblUser.Location = new System.Drawing.Point(427, 44);
            this.lblUser.Name = "lblUser";
            this.lblUser.NextFocusId = ((long)(0));
            this.lblUser.PerformLayoutEnabled = true;
            this.lblUser.PreviousFocusId = ((long)(0));
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User";
            // 
            // txtDescription
            // 
            this.txtDescription.ExcludeFromUniqueId = false;
            this.txtDescription.Location = new System.Drawing.Point(116, 8);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextFocusId = ((long)(0));
            this.txtDescription.PerformLayoutEnabled = true;
            this.txtDescription.PreviousFocusId = ((long)(0));
            this.txtDescription.Size = new System.Drawing.Size(613, 25);
            this.txtDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ExcludeFromUniqueId = false;
            this.lblDescription.Location = new System.Drawing.Point(7, 11);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.NextFocusId = ((long)(0));
            this.lblDescription.PerformLayoutEnabled = true;
            this.lblDescription.PreviousFocusId = ((long)(0));
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnDelete.ExcludeFromUniqueId = false;
            this.btnDelete.Location = new System.Drawing.Point(116, 564);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NextFocusId = ((long)(0));
            this.btnDelete.PerformLayoutEnabled = true;
            this.btnDelete.PreviousFocusId = ((long)(0));
            this.btnDelete.Size = new System.Drawing.Size(289, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete approver from workflow";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbxApprovers
            // 
            this.lbxApprovers.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.lbxApprovers.ExcludeFromUniqueId = false;
            this.lbxApprovers.Location = new System.Drawing.Point(116, 44);
            this.lbxApprovers.Name = "lbxApprovers";
            this.lbxApprovers.NextFocusId = ((long)(0));
            this.lbxApprovers.PerformLayoutEnabled = true;
            this.lbxApprovers.PreviousFocusId = ((long)(0));
            this.lbxApprovers.Size = new System.Drawing.Size(289, 511);
            this.lbxApprovers.TabIndex = 2;
            // 
            // lblApprovers
            // 
            this.lblApprovers.AutoSize = true;
            this.lblApprovers.ExcludeFromUniqueId = false;
            this.lblApprovers.Location = new System.Drawing.Point(7, 42);
            this.lblApprovers.Name = "lblApprovers";
            this.lblApprovers.NextFocusId = ((long)(0));
            this.lblApprovers.PerformLayoutEnabled = true;
            this.lblApprovers.PreviousFocusId = ((long)(0));
            this.lblApprovers.Size = new System.Drawing.Size(76, 17);
            this.lblApprovers.TabIndex = 5;
            this.lblApprovers.Text = "Approvers";
            // 
            // WorkflowCreateForm
            // 
            this.Controls.Add(this.lblApprovers);
            this.Controls.Add(this.lbxApprovers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.btnAdd);
            this.Size = new System.Drawing.Size(836, 606);
            this.Text = "ApprovalWorkflowDetail";
            this.Load += new System.EventHandler(this.ApprovalWorkflowDetail_Load);
            this.ResumeLayout(false);

        }


        #endregion
        private Button btnAdd;
        private ComboBox cmbUser;
        private Label lblUser;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnDelete;
        private ListBox lbxApprovers;
        private Label lblApprovers;
    }
}