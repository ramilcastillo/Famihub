#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

#endregion

namespace FamiHub.UI.FHCore
{
    public partial class IconSelector : FHFormTab
    {
        public IconSelector()
        {
            InitializeComponent();
        }

        private ImageList imgList = new ImageList();
        public string selectedIcon = null;

        private void getResources(string filter)
        {
            string dir = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile.ToString()) + "\\Resources\\Icons\\";
            string[] icons = System.IO.Directory.GetFiles(dir, "*.png");
            int imgIndex = 0;
            imgList.Images.Clear();
            iconList.Items.Clear();

            iconList.LargeImageList = imgList;
            iconList.SmallImageList = imgList;

            foreach (string icon in icons)
            {
                string fn = System.IO.Path.GetFileName(icon);
                if (fn.Contains(filter))
                {
                    imgList.Images.Add(new Gizmox.WebGUI.Common.Resources.IconResourceHandle(fn));
                    ListViewItem itm = new ListViewItem(fn, imgIndex);
                    iconList.Items.Add(itm);
                    imgIndex++;
                }
            }
        }

        private void IconSelector_Load(object sender, EventArgs e)
        {
            getResources(txtSearch.Text);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (iconList.View == View.SmallIcon)
            {
                iconList.View = View.LargeIcon;
            }
            else
            {
                iconList.View = View.SmallIcon;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getResources(txtSearch.Text);
        }

        private void iconList_DoubleClick(object sender, EventArgs e)
        {
            if (iconList.SelectedItems.Count == 1)
            {
                ListViewItem item = iconList.SelectedItem;
                selectedIcon = item.Text;
                this.Close();
            }
        }
    }
}