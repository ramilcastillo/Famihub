#region Using

using System;
using System.Collections.Generic;
using Gizmox.WebGUI.Forms;
using NHibernate.Criterion;
using FamiHub.Common.Extensions;

#endregion

namespace FamiHub.UI.FHCore
{
    public partial class MenuForm : FHFormTab
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void RefreshAll()
        {
            RefreshMenus();
            RefreshPackages();
            RefreshPrograms((Models.Core.Module)cmbModule.SelectedItem);
        }

        private void btnNewMenu_Click(object sender, EventArgs e)
        {
            lblDescription.Visible = true;
            txtDescription.Visible = true;
            btnNewMenu.Visible = false;
            txtDescription.Focus();
        }

        private IList<Models.Core.Menu> menus;
        private void RefreshMenus()
        {
            menus = Crud.GetAll<Models.Core.Menu>();
            menu.DataSource = null;
            menu.DataSource = menus;
            menu.DisplayMember = "Description";
            menu.ValueMember = "Id";
        }
         
        private IList<Models.Core.Program> installedPrograms;
        private void RefreshPrograms(Models.Core.Module package = null)
        {
            var session = Common.Session.DatabaseConnection;
            installedPrograms = session.CreateCriteria(typeof(Models.Core.Program))
                                    .Add(Expression.Eq("Type", "F"))
                                    .Add(Expression.Eq("Package", package))
                                    .List<Models.Core.Program>();

            program.DataSource = null;
            program.DataSource = installedPrograms;
            program.DisplayMember = "Description";
            program.ValueMember = "Form";
            session.Close();
        }

        private void RefreshPackages()
        {
            IList<Models.Core.Module> packages = Crud.GetAll<Models.Core.Module>();
            cmbModule.DataSource = null;
            cmbModule.DataSource = packages;
            cmbModule.DisplayMember = "Description";
            cmbModule.ValueMember = "Package";
        }

        public override void BeforeClose()
        {
            Common.MenuBuilder.Build();
        }

        private void RefreshMenuPrograms()
        {
            if (selectedMenu != null)
            {
                var session = Common.Session.DatabaseConnection;
                IList<Models.Core.MenuItem> menuPrograms = session.CreateCriteria(typeof(Models.Core.MenuItem))
                                                                    .Add(Expression.Eq("Menu", menu.SelectedItem))
                                                                    .AddOrder(Order.Asc("Sequence"))
                                                                    .List<Models.Core.MenuItem>();
                session.Close();

                programs.Items.Clear();
                foreach (Models.Core.MenuItem mpgms in menuPrograms)
                {
                    programs.Items.Add(mpgms.Program);
                }
                programs.DisplayMember = "Description";
            }
        }

        private Models.Core.Menu selectedMenu = null;

        private void MenuDesigner_Load(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void program_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMenu = (Models.Core.Menu)menu.SelectedItem;
        }

        public override void ButtonState()
        {
            Core.Actions.SaveBtn(true);
            Core.Actions.DeleteBtn(true);
            Core.Actions.CancelBtn(true);
        }

        public override void Save()
        {
            selectedMenu.Icon = iconName;
            Crud.Put(selectedMenu);
            IList<Models.Core.MenuItem> mpgms = Crud.GetList<Models.Core.MenuItem, Models.Core.Menu>("Menu", selectedMenu);
            foreach (Models.Core.MenuItem mpgm in mpgms)
                Crud.Delete(mpgm);
            int seq = 0;
            foreach (Models.Core.Program pgm in programs.Items)
            {
                Models.Core.MenuItem mpgm = new Models.Core.MenuItem();
                mpgm.Sequence = seq++;
                mpgm.Menu = selectedMenu;
                mpgm.Program = pgm;
                Crud.Put(mpgm);
            }
            RefreshAll();
            Common.Interaction.ThrowMessage(this, "Menu saved succesfully.");
        }

        public override void Delete()
        {
            IList<Models.Core.MenuItem> mpgms = Crud.GetList<Models.Core.MenuItem, Models.Core.Menu>("menu", selectedMenu);
            foreach (Models.Core.MenuItem mpgm in mpgms)
                Crud.Delete(mpgm);
            Crud.Delete(selectedMenu);
            RefreshAll();
        }

        public override void Cancel()
        {
            string selectedMenuCode = menu.SelectedValue.ToString();
            RefreshAll();
            menu.SelectedValue = selectedMenuCode;
        }

        private void txtDescription_KeyDown(object objSender, KeyEventArgs objArgs)
        {
            if (objArgs.KeyCode == Keys.Enter)
            {
                txtDescription.Visible = false;
                lblDescription.Visible = false;
                btnNewMenu.Visible = true;
                Models.Core.Menu menu = new Models.Core.Menu();
                menu.Description = txtDescription.Text;
                Crud.Put(menu);
                txtDescription.Text = "";
                RefreshMenus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            programs.Items.Add((Models.Core.Program)program.SelectedItem);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (programs.SelectedItems.Count > 0)
            {
                programs.Items.RemoveAt(programs.SelectedIndex);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (programs.SelectedItems.Count > 0)
            {
                programs.MoveItem(1);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (programs.SelectedItems.Count > 0)
            {
                programs.MoveItem(-1);
            }
        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMenu = (Models.Core.Menu)menu.SelectedItem;
            iconName = null;
            btnIcon.BackgroundImage = null;
            if (selectedMenu != null)
                iconName = selectedMenu.Icon;
            if (!string.IsNullOrEmpty(iconName))
                btnIcon.BackgroundImage = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(iconName);
            RefreshMenuPrograms();
        }

        private string iconName = null;
        private void btnIcon_Click(object sender, EventArgs e)
        {
            IconSelector icn = new IconSelector();
            icn.ShowDialog();
            string fn = icn.selectedIcon;
            if (!string.IsNullOrEmpty(fn))
            {
                btnIcon.BackgroundImage = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(fn);
                iconName = fn;
            }
            else
            {
                btnIcon.BackgroundImage = null;
                iconName = null;
            }
        }

        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPrograms((Models.Core.Module)cmbModule.SelectedItem);
        }
    }
}