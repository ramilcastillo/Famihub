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
    public partial class LoyaltyPartnerList : FHList<Models.Customers.LoyaltyPartner, LoyaltyPartnerForm>
    {
        public LoyaltyPartnerList()
        {
            InitializeComponent();

            AddColumn("Name", "Name", 100, true);
            AddColumn("Zip", "Zip", 25, true);
            AddColumn("City", "City", 50, true);
        }
    }
}