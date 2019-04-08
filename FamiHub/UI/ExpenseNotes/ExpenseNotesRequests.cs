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

namespace FamiHub.UI.ExpenseNotes
{
    public partial class ExpenseNotesRequests : FHList<Models.Core.ExpenseNotes, ExpenseNotesDetailForm>
    {
        public ExpenseNotesRequests()
        {
            InitializeComponent();
            AddColumn("RequestedOn", "Requested on", 100, true);
            AddColumn("Date", "Date", 100, true);
            AddColumn("Department", "Department", 100, true);
            AddColumn("Amount", "Amount", 100, true);
            AddColumn("Comments", "Comments", 100, true);
            AddColumn("ApprovalState", "Approval state", 100, false);
        }
        public override void RefreshData()
        {
            BusinessLayer.General.Logging.Log("Loading Workflow", BusinessLayer.General.Logging.LogLevel.Debug);
            IList<Models.Core.ExpenseNotes> items = Common.Session.DatabaseConnection
                                                .CreateCriteria(typeof(Models.Core.ExpenseNotes))
                                                .List<Models.Core.ExpenseNotes>();
            dgvList.DataSource = items;
            Search();
        }
    }
}