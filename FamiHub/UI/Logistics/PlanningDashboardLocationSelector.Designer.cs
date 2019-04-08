using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.Logistics
{
    partial class PlanningDashboardLocationSelector
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
            this.cmbLocation = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblLocation = new Gizmox.WebGUI.Forms.Label();
            this.btnOk = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbLocation
            // 
            this.cmbLocation.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.ExcludeFromUniqueId = false;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(87, 32);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.NextFocusId = ((long)(0));
            this.cmbLocation.PerformLayoutEnabled = true;
            this.cmbLocation.PreviousFocusId = ((long)(0));
            this.cmbLocation.Size = new System.Drawing.Size(203, 21);
            this.cmbLocation.TabIndex = 0;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.ExcludeFromUniqueId = false;
            this.lblLocation.Location = new System.Drawing.Point(3, 35);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.NextFocusId = ((long)(0));
            this.lblLocation.PerformLayoutEnabled = true;
            this.lblLocation.PreviousFocusId = ((long)(0));
            this.lblLocation.Size = new System.Drawing.Size(35, 13);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // btnOk
            // 
            this.btnOk.ExcludeFromUniqueId = false;
            this.btnOk.Location = new System.Drawing.Point(215, 67);
            this.btnOk.Name = "btnOk";
            this.btnOk.NextFocusId = ((long)(0));
            this.btnOk.PerformLayoutEnabled = true;
            this.btnOk.PreviousFocusId = ((long)(0));
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // PlanningDashboardLocationSelector
            // 
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.cmbLocation);
            this.Size = new System.Drawing.Size(305, 112);
            this.Text = "PlanningDashboardLocationSelector";
            this.ResumeLayout(false);

        }


        #endregion

        private ComboBox cmbLocation;
        private Label lblLocation;
        private Button btnOk;
    }
}