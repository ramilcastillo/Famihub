using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.ExpenseNotes
{
    partial class ExpenseNotesForm
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
            this.textBox2 = new Gizmox.WebGUI.Forms.TextBox();
            this.textBox1 = new Gizmox.WebGUI.Forms.TextBox();
            this.dateTimePicker1 = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.txtHost = new Gizmox.WebGUI.Forms.TextBox();
            this.maskedTextBox1 = new Gizmox.WebGUI.Forms.MaskedTextBox();
            this.gbxExpenseNotes = new Gizmox.WebGUI.Forms.GroupBox();
            this.lblBankAccount = new Gizmox.WebGUI.Forms.Label();
            this.txtComments = new Gizmox.WebGUI.Forms.TextBox();
            this.groupBox1 = new Gizmox.WebGUI.Forms.GroupBox();
            this.lblDate = new Gizmox.WebGUI.Forms.Label();
            this.txtBankAccount = new Gizmox.WebGUI.Forms.TextBox();
            this.txtAmount = new Gizmox.WebGUI.Forms.MaskedTextBox();
            this.lblComments = new Gizmox.WebGUI.Forms.Label();
            this.lblDepartment = new Gizmox.WebGUI.Forms.Label();
            this.dtpDate = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.txtDepartment = new Gizmox.WebGUI.Forms.TextBox();
            this.lblAmount = new Gizmox.WebGUI.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.ExcludeFromUniqueId = false;
            this.textBox2.Location = new System.Drawing.Point(111, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.NextFocusId = ((long)(0));
            this.textBox2.PerformLayoutEnabled = true;
            this.textBox2.PreviousFocusId = ((long)(0));
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.ExcludeFromUniqueId = false;
            this.textBox1.Location = new System.Drawing.Point(111, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.NextFocusId = ((long)(0));
            this.textBox1.PerformLayoutEnabled = true;
            this.textBox1.PreviousFocusId = ((long)(0));
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.ExcludeFromUniqueId = false;
            this.dateTimePicker1.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.IsEmpty = false;
            this.dateTimePicker1.IsEmptyAllowed = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.NextFocusId = ((long)(0));
            this.dateTimePicker1.PerformLayoutEnabled = true;
            this.dateTimePicker1.PreviousFocusId = ((long)(0));
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 24);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2018, 9, 18, 0, 0, 0, 0);
            // 
            // txtHost
            // 
            this.txtHost.ExcludeFromUniqueId = false;
            this.txtHost.Location = new System.Drawing.Point(111, 8);
            this.txtHost.Name = "txtHost";
            this.txtHost.NextFocusId = ((long)(0));
            this.txtHost.PerformLayoutEnabled = true;
            this.txtHost.PreviousFocusId = ((long)(0));
            this.txtHost.Size = new System.Drawing.Size(167, 20);
            this.txtHost.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.CustomStyle = "Masked";
            this.maskedTextBox1.ExcludeFromUniqueId = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(111, 95);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.NextFocusId = ((long)(0));
            this.maskedTextBox1.PerformLayoutEnabled = true;
            this.maskedTextBox1.PreviousFocusId = ((long)(0));
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // gbxExpenseNotes
            // 
            this.gbxExpenseNotes.ExcludeFromUniqueId = false;
            this.gbxExpenseNotes.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbxExpenseNotes.ForeColor = System.Drawing.Color.Black;
            this.gbxExpenseNotes.Location = new System.Drawing.Point(338, 8);
            this.gbxExpenseNotes.Name = "gbxExpenseNotes";
            this.gbxExpenseNotes.NextFocusId = ((long)(0));
            this.gbxExpenseNotes.PerformLayoutEnabled = true;
            this.gbxExpenseNotes.PreviousFocusId = ((long)(0));
            this.gbxExpenseNotes.Size = new System.Drawing.Size(325, 197);
            this.gbxExpenseNotes.TabIndex = 3;
            this.gbxExpenseNotes.TabStop = false;
            this.gbxExpenseNotes.Text = "Submit expense note";
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.ExcludeFromUniqueId = false;
            this.lblBankAccount.Location = new System.Drawing.Point(8, 26);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.NextFocusId = ((long)(0));
            this.lblBankAccount.PerformLayoutEnabled = true;
            this.lblBankAccount.PreviousFocusId = ((long)(0));
            this.lblBankAccount.Size = new System.Drawing.Size(92, 17);
            this.lblBankAccount.TabIndex = 0;
            this.lblBankAccount.Text = "Bank account";
            // 
            // txtComments
            // 
            this.txtComments.ExcludeFromUniqueId = false;
            this.txtComments.Location = new System.Drawing.Point(109, 143);
            this.txtComments.Name = "txtComments";
            this.txtComments.NextFocusId = ((long)(0));
            this.txtComments.PerformLayoutEnabled = true;
            this.txtComments.PreviousFocusId = ((long)(0));
            this.txtComments.Size = new System.Drawing.Size(167, 20);
            this.txtComments.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBankAccount);
            this.groupBox1.Controls.Add(this.txtComments);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.txtDepartment);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.txtBankAccount);
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.lblComments);
            this.groupBox1.ExcludeFromUniqueId = false;
            this.groupBox1.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.NextFocusId = ((long)(0));
            this.groupBox1.PerformLayoutEnabled = true;
            this.groupBox1.PreviousFocusId = ((long)(0));
            this.groupBox1.Size = new System.Drawing.Size(296, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Submit expense note";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ExcludeFromUniqueId = false;
            this.lblDate.Location = new System.Drawing.Point(8, 58);
            this.lblDate.Name = "lblDate";
            this.lblDate.NextFocusId = ((long)(0));
            this.lblDate.PerformLayoutEnabled = true;
            this.lblDate.PreviousFocusId = ((long)(0));
            this.lblDate.Size = new System.Drawing.Size(37, 17);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // txtBankAccount
            // 
            this.txtBankAccount.ExcludeFromUniqueId = false;
            this.txtBankAccount.Location = new System.Drawing.Point(109, 26);
            this.txtBankAccount.Name = "txtBankAccount";
            this.txtBankAccount.NextFocusId = ((long)(0));
            this.txtBankAccount.PerformLayoutEnabled = true;
            this.txtBankAccount.PreviousFocusId = ((long)(0));
            this.txtBankAccount.Size = new System.Drawing.Size(167, 20);
            this.txtBankAccount.TabIndex = 0;
            this.txtBankAccount.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            // 
            // txtAmount
            // 
            this.txtAmount.CustomStyle = "Masked";
            this.txtAmount.ExcludeFromUniqueId = false;
            this.txtAmount.Location = new System.Drawing.Point(109, 113);
            this.txtAmount.Mask = "00000000.00";
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.NextFocusId = ((long)(0));
            this.txtAmount.PerformLayoutEnabled = true;
            this.txtAmount.PreviousFocusId = ((long)(0));
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.ExcludeFromUniqueId = false;
            this.lblComments.Location = new System.Drawing.Point(8, 146);
            this.lblComments.Name = "lblComments";
            this.lblComments.NextFocusId = ((long)(0));
            this.lblComments.PerformLayoutEnabled = true;
            this.lblComments.PreviousFocusId = ((long)(0));
            this.lblComments.Size = new System.Drawing.Size(75, 17);
            this.lblComments.TabIndex = 0;
            this.lblComments.Text = "Comments";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.ExcludeFromUniqueId = false;
            this.lblDepartment.Location = new System.Drawing.Point(8, 86);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.NextFocusId = ((long)(0));
            this.lblDepartment.PerformLayoutEnabled = true;
            this.lblDepartment.PreviousFocusId = ((long)(0));
            this.lblDepartment.Size = new System.Drawing.Size(82, 17);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.ExcludeFromUniqueId = false;
            this.dtpDate.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Short;
            this.dtpDate.IsEmpty = false;
            this.dtpDate.IsEmptyAllowed = false;
            this.dtpDate.Location = new System.Drawing.Point(109, 52);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.NextFocusId = ((long)(0));
            this.dtpDate.PerformLayoutEnabled = true;
            this.dtpDate.PreviousFocusId = ((long)(0));
            this.dtpDate.Size = new System.Drawing.Size(120, 24);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = new System.DateTime(2018, 9, 18, 0, 0, 0, 0);
            // 
            // txtDepartment
            // 
            this.txtDepartment.ExcludeFromUniqueId = false;
            this.txtDepartment.Location = new System.Drawing.Point(109, 83);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.NextFocusId = ((long)(0));
            this.txtDepartment.PerformLayoutEnabled = true;
            this.txtDepartment.PreviousFocusId = ((long)(0));
            this.txtDepartment.Size = new System.Drawing.Size(167, 20);
            this.txtDepartment.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.ExcludeFromUniqueId = false;
            this.lblAmount.Location = new System.Drawing.Point(8, 116);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.NextFocusId = ((long)(0));
            this.lblAmount.PerformLayoutEnabled = true;
            this.lblAmount.PreviousFocusId = ((long)(0));
            this.lblAmount.Size = new System.Drawing.Size(57, 17);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // ExpenseNotesForm
            // 
            this.Controls.Add(this.groupBox1);
            this.Size = new System.Drawing.Size(678, 349);
            this.Text = " ";
            this.Load += new System.EventHandler(this.ExpenseNotesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtHost;
        private MaskedTextBox maskedTextBox1;
        private GroupBox gbxExpenseNotes;
        private Label lblBankAccount;
        private TextBox txtComments;
        private GroupBox groupBox1;
        private Label lblAmount;
        private TextBox txtDepartment;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private TextBox txtBankAccount;
        private Label lblDepartment;
        private MaskedTextBox txtAmount;
        private Label lblComments;
    }
}