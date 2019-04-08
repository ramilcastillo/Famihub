#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using FamiHub.Models.Core;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using NHibernate.Criterion;

#endregion

namespace FamiHub.UI.ExpenseNotes
{
    public partial class Workflow : FHList<ApproverType, WorkflowForm>
    {
        public Workflow()
        {
            InitializeComponent();

            AddColumn("Description", "Workflow", 100, true);
        }

        private void FHList_Load(object sender, EventArgs e)
        {
        }

        private void lvWorkflow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        public override void RefreshData()
        {
            BusinessLayer.General.Logging.Log("Loading Workflow", BusinessLayer.General.Logging.LogLevel.Debug);
            IList<ApproverType> items = Common.Session.DatabaseConnection
                                                .CreateCriteria(typeof(ApproverType))
                                                .List<ApproverType>();
            dgvList.DataSource = items;
            Search();
        }
    }
}