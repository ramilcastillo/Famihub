using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.Customers
{
    partial class AddLoyaltyTransaction
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
            this.cmbDestination = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblDestination = new Gizmox.WebGUI.Forms.Label();
            this.txtPoints = new Gizmox.WebGUI.Forms.TextBox();
            this.lblPoints = new Gizmox.WebGUI.Forms.Label();
            this.lblComments = new Gizmox.WebGUI.Forms.Label();
            this.txtComments = new Gizmox.WebGUI.Forms.TextBox();
            this.btnAdd = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDestination
            // 
            this.cmbDestination.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestination.ExcludeFromUniqueId = false;
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(118, 3);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.NextFocusId = ((long)(0));
            this.cmbDestination.PerformLayoutEnabled = true;
            this.cmbDestination.PreviousFocusId = ((long)(0));
            this.cmbDestination.Size = new System.Drawing.Size(419, 21);
            this.cmbDestination.TabIndex = 0;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.ExcludeFromUniqueId = false;
            this.lblDestination.Location = new System.Drawing.Point(4, 6);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.NextFocusId = ((long)(0));
            this.lblDestination.PerformLayoutEnabled = true;
            this.lblDestination.PreviousFocusId = ((long)(0));
            this.lblDestination.Size = new System.Drawing.Size(35, 13);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Destination";
            // 
            // txtPoints
            // 
            this.txtPoints.ExcludeFromUniqueId = false;
            this.txtPoints.Location = new System.Drawing.Point(118, 30);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.NextFocusId = ((long)(0));
            this.txtPoints.PerformLayoutEnabled = true;
            this.txtPoints.PreviousFocusId = ((long)(0));
            this.txtPoints.Size = new System.Drawing.Size(121, 20);
            this.txtPoints.TabIndex = 0;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.ExcludeFromUniqueId = false;
            this.lblPoints.Location = new System.Drawing.Point(4, 33);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.NextFocusId = ((long)(0));
            this.lblPoints.PerformLayoutEnabled = true;
            this.lblPoints.PreviousFocusId = ((long)(0));
            this.lblPoints.Size = new System.Drawing.Size(35, 13);
            this.lblPoints.TabIndex = 3;
            this.lblPoints.Text = "Points";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.ExcludeFromUniqueId = false;
            this.lblComments.Location = new System.Drawing.Point(4, 59);
            this.lblComments.Name = "lblComments";
            this.lblComments.NextFocusId = ((long)(0));
            this.lblComments.PerformLayoutEnabled = true;
            this.lblComments.PreviousFocusId = ((long)(0));
            this.lblComments.Size = new System.Drawing.Size(35, 13);
            this.lblComments.TabIndex = 3;
            this.lblComments.Text = "Comments";
            // 
            // txtComments
            // 
            this.txtComments.ExcludeFromUniqueId = false;
            this.txtComments.Location = new System.Drawing.Point(118, 56);
            this.txtComments.Name = "txtComments";
            this.txtComments.NextFocusId = ((long)(0));
            this.txtComments.PerformLayoutEnabled = true;
            this.txtComments.PreviousFocusId = ((long)(0));
            this.txtComments.Size = new System.Drawing.Size(419, 20);
            this.txtComments.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.ExcludeFromUniqueId = false;
            this.btnAdd.Location = new System.Drawing.Point(118, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NextFocusId = ((long)(0));
            this.btnAdd.PerformLayoutEnabled = true;
            this.btnAdd.PreviousFocusId = ((long)(0));
            this.btnAdd.Size = new System.Drawing.Size(121, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add transaction";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddLoyaltyTransaction
            // 
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.cmbDestination);
            this.Size = new System.Drawing.Size(558, 128);
            this.Text = "AddLoyaltyTransaction";
            this.ResumeLayout(false);

        }


        #endregion

        private ComboBox cmbDestination;
        private Label lblDestination;
        private TextBox txtPoints;
        private Label lblPoints;
        private Label lblComments;
        private TextBox txtComments;
        private Button btnAdd;
    }
}