using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.Customers
{
    partial class UseLoyaltyPoints
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
            this.btnUse = new Gizmox.WebGUI.Forms.Button();
            this.txtComments = new Gizmox.WebGUI.Forms.TextBox();
            this.lblComments = new Gizmox.WebGUI.Forms.Label();
            this.lblPoints = new Gizmox.WebGUI.Forms.Label();
            this.txtPoints = new Gizmox.WebGUI.Forms.TextBox();
            this.lblPartner = new Gizmox.WebGUI.Forms.Label();
            this.cmbPartner = new Gizmox.WebGUI.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUse
            // 
            this.btnUse.ExcludeFromUniqueId = false;
            this.btnUse.Location = new System.Drawing.Point(118, 93);
            this.btnUse.Name = "btnUse";
            this.btnUse.NextFocusId = ((long)(0));
            this.btnUse.PerformLayoutEnabled = true;
            this.btnUse.PreviousFocusId = ((long)(0));
            this.btnUse.Size = new System.Drawing.Size(121, 23);
            this.btnUse.TabIndex = 0;
            this.btnUse.Text = "Use points";
            this.btnUse.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.TextAboveImage;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // txtComments
            // 
            this.txtComments.ExcludeFromUniqueId = false;
            this.txtComments.Location = new System.Drawing.Point(118, 58);
            this.txtComments.Name = "txtComments";
            this.txtComments.NextFocusId = ((long)(0));
            this.txtComments.PerformLayoutEnabled = true;
            this.txtComments.PreviousFocusId = ((long)(0));
            this.txtComments.Size = new System.Drawing.Size(419, 20);
            this.txtComments.TabIndex = 0;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.ExcludeFromUniqueId = false;
            this.lblComments.Location = new System.Drawing.Point(4, 61);
            this.lblComments.Name = "lblComments";
            this.lblComments.NextFocusId = ((long)(0));
            this.lblComments.PerformLayoutEnabled = true;
            this.lblComments.PreviousFocusId = ((long)(0));
            this.lblComments.Size = new System.Drawing.Size(35, 13);
            this.lblComments.TabIndex = 3;
            this.lblComments.Text = "Comments";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.ExcludeFromUniqueId = false;
            this.lblPoints.Location = new System.Drawing.Point(4, 35);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.NextFocusId = ((long)(0));
            this.lblPoints.PerformLayoutEnabled = true;
            this.lblPoints.PreviousFocusId = ((long)(0));
            this.lblPoints.Size = new System.Drawing.Size(35, 13);
            this.lblPoints.TabIndex = 3;
            this.lblPoints.Text = "Points";
            // 
            // txtPoints
            // 
            this.txtPoints.ExcludeFromUniqueId = false;
            this.txtPoints.Location = new System.Drawing.Point(118, 32);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.NextFocusId = ((long)(0));
            this.txtPoints.PerformLayoutEnabled = true;
            this.txtPoints.PreviousFocusId = ((long)(0));
            this.txtPoints.Size = new System.Drawing.Size(121, 20);
            this.txtPoints.TabIndex = 0;
            // 
            // lblPartner
            // 
            this.lblPartner.AutoSize = true;
            this.lblPartner.ExcludeFromUniqueId = false;
            this.lblPartner.Location = new System.Drawing.Point(4, 8);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.NextFocusId = ((long)(0));
            this.lblPartner.PerformLayoutEnabled = true;
            this.lblPartner.PreviousFocusId = ((long)(0));
            this.lblPartner.Size = new System.Drawing.Size(35, 13);
            this.lblPartner.TabIndex = 1;
            this.lblPartner.Text = "Destination";
            // 
            // cmbPartner
            // 
            this.cmbPartner.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartner.ExcludeFromUniqueId = false;
            this.cmbPartner.FormattingEnabled = true;
            this.cmbPartner.Location = new System.Drawing.Point(118, 5);
            this.cmbPartner.Name = "cmbPartner";
            this.cmbPartner.NextFocusId = ((long)(0));
            this.cmbPartner.PerformLayoutEnabled = true;
            this.cmbPartner.PreviousFocusId = ((long)(0));
            this.cmbPartner.Size = new System.Drawing.Size(419, 21);
            this.cmbPartner.TabIndex = 0;
            // 
            // UseLoyaltyPoints
            // 
            this.Controls.Add(this.cmbPartner);
            this.Controls.Add(this.lblPartner);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.btnUse);
            this.Size = new System.Drawing.Size(556, 131);
            this.Text = "UseLoyaltyPoints";
            this.ResumeLayout(false);

        }


        #endregion

        private Button btnUse;
        private TextBox txtComments;
        private Label lblComments;
        private Label lblPoints;
        private TextBox txtPoints;
        private Label lblPartner;
        private ComboBox cmbPartner;
    }
}