using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamiHub.UI.FHCore
{
    public partial class CountryList : FHList<Models.Core.Country, CountryForm>
    {
        public CountryList()
        {
            InitializeComponent();

            AddColumn("IsoCode", "ISO code", 25, true);
            AddColumn("Name", "Name", 100, true);
        }
    }
}
