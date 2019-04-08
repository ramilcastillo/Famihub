using Gizmox.WebGUI.Forms;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;

namespace FamiHub.Common
{
    internal static class MenuBuilder
    {
        public static void Build()
        {
            try
            {
                var session = Session.DatabaseConnection;
                List<string> Permissionlist = new List<string>();
                Models.Core.User user = Session.CurrentUser;
                
                string nodename = null;
                Session.MainForm.navigationMenu.Controls.Clear();
                System.Drawing.Font nodeFont = new System.Drawing.Font("Tahoma", 10);
                System.Drawing.Font topNodeFont = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
                ImageList tabImages = new ImageList();
                Session.MainForm.navigationMenu.ImageList = tabImages;
                int imageIdx = 0;

                if (user.UserGroup != null)
                {
                    IList<Models.Core.UserGroupMenu> userGroupMenus = session.CreateCriteria(typeof(Models.Core.UserGroupMenu))
                                                                    .Add(Expression.Eq("UserGroup", user.UserGroup))
                                                                    .AddOrder(Order.Asc("Sequence"))
                                                                    .List<Models.Core.UserGroupMenu>();

                    foreach (Models.Core.UserGroupMenu ugmMenu in userGroupMenus)
                    {
                        TreeView menuTree = new TreeView();
                        menuTree.SelectedNode = null;
                        menuTree.SelectOnRightClick = true;
                        menuTree.Nodes.Clear();

                        Models.Core.Menu menu = ugmMenu.Menu;

                        IList<Models.Core.MenuItem> menuPrograms = session.CreateCriteria(typeof(Models.Core.MenuItem))
                                                                    .Add(Expression.Eq("Menu", menu))
                                                                    .AddOrder(Order.Asc("Sequence"))
                                                                    .List<Models.Core.MenuItem>();

                        foreach (Models.Core.MenuItem menuProgram in menuPrograms)
                        {
                            Models.Core.Program program = menuProgram.Program;
                            nodename = Localization.TranslateCpt(program.Form, "_form", Session.CurrentUser.Language ?? "en", program.Description);
                            menuTree.Nodes.Add(program.Code, nodename).NodeFont = nodeFont;
                            Permissionlist.Add(program.Code.ToLower());
                        }

                        NavigationTab objTabControls = new NavigationTab(menu.Description);
                        menuTree.Dock = DockStyle.Fill;
                        menuTree.ShowLines = false;
                        menuTree.NodeMouseClick += Session.MainForm.menuTree_MouseClick;
                        objTabControls.Controls.Add(menuTree);
                        if (!string.IsNullOrEmpty(menu.Icon))
                        {
                            tabImages.Images.Add(new Gizmox.WebGUI.Common.Resources.IconResourceHandle(menu.Icon));
                            objTabControls.ImageIndex = imageIdx;
                            imageIdx++;
                        }
                        Session.MainForm.navigationMenu.Controls.Add(objTabControls);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.HandleException(ex);
            }
        }
    }
}