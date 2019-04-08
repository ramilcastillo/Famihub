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

namespace FamiHub.UI.Customers
{
    public partial class LoyaltyInvoicesList : FHList<Models.Customers.LoyaltyInvoice, LoyaltyInvoicesList>
    {
        public LoyaltyInvoicesList()
        {
            InitializeComponent();
        }
    }
}