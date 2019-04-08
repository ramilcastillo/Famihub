#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

#endregion

namespace FamiHub.Core
{
    public partial class FHFormDialog : Form
    {
        public FHFormDialog()
        {
            InitializeComponent();
        }

        private void FHFormDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Common.Session.MainForm._activeDialog = null;
        }
    }
}