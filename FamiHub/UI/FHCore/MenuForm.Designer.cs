using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.FHCore
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.menu = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblMenu = new Gizmox.WebGUI.Forms.Label();
            this.programs = new Gizmox.WebGUI.Forms.ListBox();
            this.btnDelete = new Gizmox.WebGUI.Forms.Button();
            this.btnNewMenu = new Gizmox.WebGUI.Forms.Button();
            this.lblDescription = new Gizmox.WebGUI.Forms.Label();
            this.txtDescription = new Gizmox.WebGUI.Forms.TextBox();
            this.lblProgram = new Gizmox.WebGUI.Forms.Label();
            this.program = new Gizmox.WebGUI.Forms.ComboBox();
            this.btnAdd = new Gizmox.WebGUI.Forms.Button();
            this.btnUp = new Gizmox.WebGUI.Forms.Button();
            this.btnDown = new Gizmox.WebGUI.Forms.Button();
            this.lblIcon = new Gizmox.WebGUI.Forms.Label();
            this.btnIcon = new Gizmox.WebGUI.Forms.Button();
            this.cmbModule = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblModule = new Gizmox.WebGUI.Forms.Label();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.menu.ExcludeFromUniqueId = false;
            this.menu.FormattingEnabled = true;
            this.menu.Location = new System.Drawing.Point(73, 13);
            this.menu.Name = "menu";
            this.menu.NextFocusId = ((long)(0));
            this.menu.PerformLayoutEnabled = true;
            this.menu.PreviousFocusId = ((long)(0));
            this.menu.Size = new System.Drawing.Size(228, 21);
            this.menu.Sorted = true;
            this.menu.TabIndex = 0;
            this.menu.SelectedIndexChanged += new System.EventHandler(this.menu_SelectedIndexChanged);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.ExcludeFromUniqueId = false;
            this.lblMenu.Location = new System.Drawing.Point(9, 16);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.NextFocusId = ((long)(0));
            this.lblMenu.PerformLayoutEnabled = true;
            this.lblMenu.PreviousFocusId = ((long)(0));
            this.lblMenu.Size = new System.Drawing.Size(35, 13);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // programs
            // 
            this.programs.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.programs.ExcludeFromUniqueId = false;
            this.programs.Location = new System.Drawing.Point(12, 46);
            this.programs.Name = "programs";
            this.programs.NextFocusId = ((long)(0));
            this.programs.PerformLayoutEnabled = true;
            this.programs.PreviousFocusId = ((long)(0));
            this.programs.Size = new System.Drawing.Size(289, 511);
            this.programs.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnDelete.ExcludeFromUniqueId = false;
            this.btnDelete.Location = new System.Drawing.Point(12, 566);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NextFocusId = ((long)(0));
            this.btnDelete.PerformLayoutEnabled = true;
            this.btnDelete.PreviousFocusId = ((long)(0));
            this.btnDelete.Size = new System.Drawing.Size(289, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete program from menu";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNewMenu
            // 
            this.btnNewMenu.ExcludeFromUniqueId = false;
            this.btnNewMenu.Location = new System.Drawing.Point(323, 11);
            this.btnNewMenu.Name = "btnNewMenu";
            this.btnNewMenu.NextFocusId = ((long)(0));
            this.btnNewMenu.PerformLayoutEnabled = true;
            this.btnNewMenu.PreviousFocusId = ((long)(0));
            this.btnNewMenu.Size = new System.Drawing.Size(212, 23);
            this.btnNewMenu.TabIndex = 4;
            this.btnNewMenu.Text = "New menu";
            this.btnNewMenu.Click += new System.EventHandler(this.btnNewMenu_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ExcludeFromUniqueId = false;
            this.lblDescription.Location = new System.Drawing.Point(320, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.NextFocusId = ((long)(0));
            this.lblDescription.PerformLayoutEnabled = true;
            this.lblDescription.PreviousFocusId = ((long)(0));
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            this.lblDescription.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.ExcludeFromUniqueId = false;
            this.txtDescription.Location = new System.Drawing.Point(396, 13);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextFocusId = ((long)(0));
            this.txtDescription.PerformLayoutEnabled = true;
            this.txtDescription.PreviousFocusId = ((long)(0));
            this.txtDescription.Size = new System.Drawing.Size(231, 20);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Visible = false;
            this.txtDescription.KeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.ExcludeFromUniqueId = false;
            this.lblProgram.Location = new System.Drawing.Point(320, 130);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.NextFocusId = ((long)(0));
            this.lblProgram.PerformLayoutEnabled = true;
            this.lblProgram.PreviousFocusId = ((long)(0));
            this.lblProgram.Size = new System.Drawing.Size(35, 13);
            this.lblProgram.TabIndex = 7;
            this.lblProgram.Text = "Program";
            // 
            // program
            // 
            this.program.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.program.ExcludeFromUniqueId = false;
            this.program.FormattingEnabled = true;
            this.program.Location = new System.Drawing.Point(396, 127);
            this.program.Name = "program";
            this.program.NextFocusId = ((long)(0));
            this.program.PerformLayoutEnabled = true;
            this.program.PreviousFocusId = ((long)(0));
            this.program.Size = new System.Drawing.Size(231, 21);
            this.program.Sorted = true;
            this.program.TabIndex = 8;
            this.program.SelectedIndexChanged += new System.EventHandler(this.program_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.ExcludeFromUniqueId = false;
            this.btnAdd.Location = new System.Drawing.Point(396, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NextFocusId = ((long)(0));
            this.btnAdd.PerformLayoutEnabled = true;
            this.btnAdd.PreviousFocusId = ((long)(0));
            this.btnAdd.Size = new System.Drawing.Size(231, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add to menu";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnUp.ExcludeFromUniqueId = false;
            this.btnUp.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnUp.Image"));
            this.btnUp.Location = new System.Drawing.Point(305, 447);
            this.btnUp.Name = "btnUp";
            this.btnUp.NextFocusId = ((long)(0));
            this.btnUp.PerformLayoutEnabled = true;
            this.btnUp.PreviousFocusId = ((long)(0));
            this.btnUp.Size = new System.Drawing.Size(55, 55);
            this.btnUp.TabIndex = 10;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnDown.ExcludeFromUniqueId = false;
            this.btnDown.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDown.Image"));
            this.btnDown.Location = new System.Drawing.Point(305, 502);
            this.btnDown.Name = "btnDown";
            this.btnDown.NextFocusId = ((long)(0));
            this.btnDown.PerformLayoutEnabled = true;
            this.btnDown.PreviousFocusId = ((long)(0));
            this.btnDown.Size = new System.Drawing.Size(55, 55);
            this.btnDown.TabIndex = 10;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.ExcludeFromUniqueId = false;
            this.lblIcon.Location = new System.Drawing.Point(320, 46);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.NextFocusId = ((long)(0));
            this.lblIcon.PerformLayoutEnabled = true;
            this.lblIcon.PreviousFocusId = ((long)(0));
            this.lblIcon.Size = new System.Drawing.Size(35, 13);
            this.lblIcon.TabIndex = 11;
            this.lblIcon.Text = "Icon";
            // 
            // btnIcon
            // 
            this.btnIcon.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Zoom;
            this.btnIcon.ExcludeFromUniqueId = false;
            this.btnIcon.Location = new System.Drawing.Point(382, 41);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.NextFocusId = ((long)(0));
            this.btnIcon.PerformLayoutEnabled = true;
            this.btnIcon.PreviousFocusId = ((long)(0));
            this.btnIcon.Size = new System.Drawing.Size(36, 23);
            this.btnIcon.TabIndex = 12;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // cmbModule
            // 
            this.cmbModule.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbModule.ExcludeFromUniqueId = false;
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Location = new System.Drawing.Point(396, 102);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.NextFocusId = ((long)(0));
            this.cmbModule.PerformLayoutEnabled = true;
            this.cmbModule.PreviousFocusId = ((long)(0));
            this.cmbModule.Size = new System.Drawing.Size(231, 21);
            this.cmbModule.Sorted = true;
            this.cmbModule.TabIndex = 8;
            this.cmbModule.SelectedIndexChanged += new System.EventHandler(this.cmbModule_SelectedIndexChanged);
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.ExcludeFromUniqueId = false;
            this.lblModule.Location = new System.Drawing.Point(320, 105);
            this.lblModule.Name = "lblModule";
            this.lblModule.NextFocusId = ((long)(0));
            this.lblModule.PerformLayoutEnabled = true;
            this.lblModule.PreviousFocusId = ((long)(0));
            this.lblModule.Size = new System.Drawing.Size(35, 13);
            this.lblModule.TabIndex = 7;
            this.lblModule.Text = "Module";
            // 
            // MenuForm
            // 
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.cmbModule);
            this.Controls.Add(this.btnIcon);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.program);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnNewMenu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.programs);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.menu);
            this.Size = new System.Drawing.Size(836, 606);
            this.Text = "MenuDesigner";
            this.Load += new System.EventHandler(this.MenuDesigner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox menu;
        private Label lblMenu;
        private ListBox programs;
        private Button btnDelete;
        private Button btnNewMenu;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblProgram;
        private ComboBox program;
        private Button btnAdd;
        private Button btnUp;
        private Button btnDown;
        private Label lblIcon;
        private Button btnIcon;
        private ComboBox cmbModule;
        private Label lblModule;
    }
}