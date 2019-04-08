using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.Logistics
{
    partial class PlanningLocations
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
            this.lbxLocations = new Gizmox.WebGUI.Forms.ListBox();
            this.btnDelete = new Gizmox.WebGUI.Forms.Button();
            this.txtLocation = new Gizmox.WebGUI.Forms.TextBox();
            this.lblLocation = new Gizmox.WebGUI.Forms.Label();
            this.btnAdd = new Gizmox.WebGUI.Forms.Button();
            this.lblContainerLocation = new Gizmox.WebGUI.Forms.Label();
            this.chbContainers = new Gizmox.WebGUI.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbxLocations
            // 
            this.lbxLocations.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.lbxLocations.ExcludeFromUniqueId = false;
            this.lbxLocations.Location = new System.Drawing.Point(12, 11);
            this.lbxLocations.Name = "lbxLocations";
            this.lbxLocations.NextFocusId = ((long)(0));
            this.lbxLocations.PerformLayoutEnabled = true;
            this.lbxLocations.PreviousFocusId = ((long)(0));
            this.lbxLocations.Size = new System.Drawing.Size(201, 394);
            this.lbxLocations.TabIndex = 0;
            this.lbxLocations.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnDelete.ExcludeFromUniqueId = false;
            this.btnDelete.Location = new System.Drawing.Point(12, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NextFocusId = ((long)(0));
            this.btnDelete.PerformLayoutEnabled = true;
            this.btnDelete.PreviousFocusId = ((long)(0));
            this.btnDelete.Size = new System.Drawing.Size(201, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete selected location";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.ExcludeFromUniqueId = false;
            this.txtLocation.Location = new System.Drawing.Point(309, 68);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.NextFocusId = ((long)(0));
            this.txtLocation.PerformLayoutEnabled = true;
            this.txtLocation.PreviousFocusId = ((long)(0));
            this.txtLocation.Size = new System.Drawing.Size(168, 20);
            this.txtLocation.TabIndex = 3;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.ExcludeFromUniqueId = false;
            this.lblLocation.Location = new System.Drawing.Point(225, 71);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.NextFocusId = ((long)(0));
            this.lblLocation.PerformLayoutEnabled = true;
            this.lblLocation.PreviousFocusId = ((long)(0));
            this.lblLocation.Size = new System.Drawing.Size(35, 13);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location name";
            // 
            // btnAdd
            // 
            this.btnAdd.ExcludeFromUniqueId = false;
            this.btnAdd.Location = new System.Drawing.Point(228, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NextFocusId = ((long)(0));
            this.btnAdd.PerformLayoutEnabled = true;
            this.btnAdd.PreviousFocusId = ((long)(0));
            this.btnAdd.Size = new System.Drawing.Size(249, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add location";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblContainerLocation
            // 
            this.lblContainerLocation.AutoSize = true;
            this.lblContainerLocation.ExcludeFromUniqueId = false;
            this.lblContainerLocation.Location = new System.Drawing.Point(225, 97);
            this.lblContainerLocation.Name = "lblContainerLocation";
            this.lblContainerLocation.NextFocusId = ((long)(0));
            this.lblContainerLocation.PerformLayoutEnabled = true;
            this.lblContainerLocation.PreviousFocusId = ((long)(0));
            this.lblContainerLocation.Size = new System.Drawing.Size(35, 13);
            this.lblContainerLocation.TabIndex = 6;
            this.lblContainerLocation.Text = "Containers";
            // 
            // chbContainers
            // 
            this.chbContainers.AutoSize = true;
            this.chbContainers.ExcludeFromUniqueId = false;
            this.chbContainers.Location = new System.Drawing.Point(309, 96);
            this.chbContainers.Name = "chbContainers";
            this.chbContainers.NextFocusId = ((long)(0));
            this.chbContainers.PerformLayoutEnabled = true;
            this.chbContainers.PreviousFocusId = ((long)(0));
            this.chbContainers.Size = new System.Drawing.Size(15, 14);
            this.chbContainers.TabIndex = 7;
            // 
            // PlanningLocations
            // 
            this.Controls.Add(this.chbContainers);
            this.Controls.Add(this.lblContainerLocation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbxLocations);
            this.Size = new System.Drawing.Size(479, 442);
            this.Text = "PlanningLocations";
            this.Load += new System.EventHandler(this.PlanningLocations_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private ListBox lbxLocations;
        private Button btnDelete;
        private TextBox txtLocation;
        private Label lblLocation;
        private Button btnAdd;
        private Label lblContainerLocation;
        private CheckBox chbContainers;
    }
}