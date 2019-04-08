using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.FHCore
{
    partial class UserGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserGroupForm));
            this.btnDown = new Gizmox.WebGUI.Forms.Button();
            this.btnUp = new Gizmox.WebGUI.Forms.Button();
            this.btnAdd = new Gizmox.WebGUI.Forms.Button();
            this.menu = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblMenu = new Gizmox.WebGUI.Forms.Label();
            this.txtDescription = new Gizmox.WebGUI.Forms.TextBox();
            this.lblDescription = new Gizmox.WebGUI.Forms.Label();
            this.btnNewGroup = new Gizmox.WebGUI.Forms.Button();
            this.btnDelete = new Gizmox.WebGUI.Forms.Button();
            this.menus = new Gizmox.WebGUI.Forms.ListBox();
            this.lblUsergroup = new Gizmox.WebGUI.Forms.Label();
            this.group = new Gizmox.WebGUI.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnDown.ExcludeFromUniqueId = false;
            this.btnDown.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDown.Image"));
            this.btnDown.Location = new System.Drawing.Point(303, 502);
            this.btnDown.Name = "btnDown";
            this.btnDown.NextFocusId = ((long)(0));
            this.btnDown.PerformLayoutEnabled = true;
            this.btnDown.PreviousFocusId = ((long)(0));
            this.btnDown.Size = new System.Drawing.Size(55, 55);
            this.btnDown.TabIndex = 10;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnUp.ExcludeFromUniqueId = false;
            this.btnUp.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnUp.Image"));
            this.btnUp.Location = new System.Drawing.Point(303, 446);
            this.btnUp.Name = "btnUp";
            this.btnUp.NextFocusId = ((long)(0));
            this.btnUp.PerformLayoutEnabled = true;
            this.btnUp.PreviousFocusId = ((long)(0));
            this.btnUp.Size = new System.Drawing.Size(55, 55);
            this.btnUp.TabIndex = 10;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ExcludeFromUniqueId = false;
            this.btnAdd.Location = new System.Drawing.Point(394, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NextFocusId = ((long)(0));
            this.btnAdd.PerformLayoutEnabled = true;
            this.btnAdd.PreviousFocusId = ((long)(0));
            this.btnAdd.Size = new System.Drawing.Size(231, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add menu";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menu
            // 
            this.menu.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.menu.ExcludeFromUniqueId = false;
            this.menu.FormattingEnabled = true;
            this.menu.Location = new System.Drawing.Point(394, 95);
            this.menu.Name = "menu";
            this.menu.NextFocusId = ((long)(0));
            this.menu.PerformLayoutEnabled = true;
            this.menu.PreviousFocusId = ((long)(0));
            this.menu.Size = new System.Drawing.Size(231, 21);
            this.menu.Sorted = true;
            this.menu.TabIndex = 8;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.ExcludeFromUniqueId = false;
            this.lblMenu.Location = new System.Drawing.Point(318, 98);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.NextFocusId = ((long)(0));
            this.lblMenu.PerformLayoutEnabled = true;
            this.lblMenu.PreviousFocusId = ((long)(0));
            this.lblMenu.Size = new System.Drawing.Size(35, 13);
            this.lblMenu.TabIndex = 7;
            this.lblMenu.Text = "Menu";
            // 
            // txtDescription
            // 
            this.txtDescription.ExcludeFromUniqueId = false;
            this.txtDescription.Location = new System.Drawing.Point(394, 13);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextFocusId = ((long)(0));
            this.txtDescription.PerformLayoutEnabled = true;
            this.txtDescription.PreviousFocusId = ((long)(0));
            this.txtDescription.Size = new System.Drawing.Size(231, 20);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Visible = false;
            this.txtDescription.KeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ExcludeFromUniqueId = false;
            this.lblDescription.Location = new System.Drawing.Point(318, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.NextFocusId = ((long)(0));
            this.lblDescription.PerformLayoutEnabled = true;
            this.lblDescription.PreviousFocusId = ((long)(0));
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            this.lblDescription.Visible = false;
            // 
            // btnNewGroup
            // 
            this.btnNewGroup.ExcludeFromUniqueId = false;
            this.btnNewGroup.Location = new System.Drawing.Point(321, 11);
            this.btnNewGroup.Name = "btnNewGroup";
            this.btnNewGroup.NextFocusId = ((long)(0));
            this.btnNewGroup.PerformLayoutEnabled = true;
            this.btnNewGroup.PreviousFocusId = ((long)(0));
            this.btnNewGroup.Size = new System.Drawing.Size(212, 23);
            this.btnNewGroup.TabIndex = 4;
            this.btnNewGroup.Text = "New usergroup";
            this.btnNewGroup.Click += new System.EventHandler(this.btnNewGroup_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnDelete.ExcludeFromUniqueId = false;
            this.btnDelete.Location = new System.Drawing.Point(10, 566);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NextFocusId = ((long)(0));
            this.btnDelete.PerformLayoutEnabled = true;
            this.btnDelete.PreviousFocusId = ((long)(0));
            this.btnDelete.Size = new System.Drawing.Size(289, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete menu";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menus
            // 
            this.menus.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.menus.ExcludeFromUniqueId = false;
            this.menus.Location = new System.Drawing.Point(10, 46);
            this.menus.Name = "menus";
            this.menus.NextFocusId = ((long)(0));
            this.menus.PerformLayoutEnabled = true;
            this.menus.PreviousFocusId = ((long)(0));
            this.menus.Size = new System.Drawing.Size(289, 511);
            this.menus.TabIndex = 2;
            // 
            // lblUsergroup
            // 
            this.lblUsergroup.AutoSize = true;
            this.lblUsergroup.ExcludeFromUniqueId = false;
            this.lblUsergroup.Location = new System.Drawing.Point(7, 16);
            this.lblUsergroup.Name = "lblUsergroup";
            this.lblUsergroup.NextFocusId = ((long)(0));
            this.lblUsergroup.PerformLayoutEnabled = true;
            this.lblUsergroup.PreviousFocusId = ((long)(0));
            this.lblUsergroup.Size = new System.Drawing.Size(35, 13);
            this.lblUsergroup.TabIndex = 1;
            this.lblUsergroup.Text = "User group";
            // 
            // group
            // 
            this.group.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.group.ExcludeFromUniqueId = false;
            this.group.FormattingEnabled = true;
            this.group.Location = new System.Drawing.Point(71, 13);
            this.group.Name = "group";
            this.group.NextFocusId = ((long)(0));
            this.group.PerformLayoutEnabled = true;
            this.group.PreviousFocusId = ((long)(0));
            this.group.Size = new System.Drawing.Size(228, 21);
            this.group.Sorted = true;
            this.group.TabIndex = 0;
            this.group.SelectedIndexChanged += new System.EventHandler(this.group_SelectedIndexChanged);
            // 
            // UserGroupForm
            // 
            this.Controls.Add(this.group);
            this.Controls.Add(this.lblUsergroup);
            this.Controls.Add(this.menus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnNewGroup);
            this.Size = new System.Drawing.Size(836, 606);
            this.Text = "UserGroup";
            this.Load += new System.EventHandler(this.UserGroupForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDown;
        private Button btnUp;
        private Button btnAdd;
        private ComboBox menu;
        private Label lblMenu;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnNewGroup;
        private Button btnDelete;
        private ListBox menus;
        private Label lblUsergroup;
        private ComboBox group;


    }
}