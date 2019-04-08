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
    public partial class ExpenseNotesDetailForm : FHFormTab
    {
        internal Models.Core.ExpenseNotes dataObject;
        FHFormTab _expensenotes;
        public ExpenseNotesDetailForm(FHFormTab expensenotes, Models.Core.ExpenseNotes expenseNotesModel)
        {
            InitializeComponent();
            this._expensenotes = expensenotes;
            this.dataObject = expenseNotesModel;

            if (this.dataObject == null)
                this.dataObject = new Models.Core.ExpenseNotes();
        }
    }
}