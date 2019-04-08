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
    public partial class LoyaltyRewardsList : FHList<Models.Customers.LoyaltyRewards, LoyaltyRewardsForm>
    {
        public LoyaltyRewardsList()
        {
            InitializeComponent();

            AddColumn("DescriptionDutch", "Dutch Description", 100, true);
            AddColumn("Points", "Points", 20, true);
            AddColumn("ValidFrom", "Valid From", 20, false);
            AddColumn("ValidTo", "Valid Till", 20, false);
        }
    }
}