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
    public partial class CustomerList : FHList<Models.Customers.Customer, CustomerForm>
    {
        public CustomerList()
        {
            InitializeComponent();

            AddColumn("LastName", "Name", 100, true);
            AddColumn("FirstName", "First name", 100, true);
            AddColumn("LoyaltyCardNumber", "Loyalty card", 20, true);
            AddColumn("MailAddress", "Mail address", 50, true);
        }
    }
}