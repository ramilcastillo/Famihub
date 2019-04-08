#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Gizmox.WebGUI.Forms;

#endregion

namespace FamiHub
{
    public partial class FHList<DataType, DetailFormType> : FHFormTab where DetailFormType : FHFormTab
    {
        public FHList()
        {
            InitializeComponent();
        }

        IList<SearchColumn> scs = new List<SearchColumn>();
        private class SearchColumn
        {
            public string ColumnName { get; set; }
            public string ColumnHeader { get; set; }
        }

        private Dictionary<string, string> _columns = new Dictionary<string, string>();
        public void AddCheckBoxColumn(string dataPropertyName, string columnHeader, int fillWeight = 100, bool searchable = false, bool visible = true)
        {
            BusinessLayer.General.Logging.Log("Adding column to FHList form '" + Name + "': " + columnHeader, BusinessLayer.General.Logging.LogLevel.Debug);
            DataGridViewCheckBoxColumn dgvCol = new DataGridViewCheckBoxColumn();
            dgvCol.Name = "COL" + dataPropertyName;
            dgvCol.DataPropertyName = dataPropertyName;
            dgvCol.FillWeight = fillWeight;
            dgvCol.HeaderText = columnHeader;
            dgvCol.Visible = visible;
            dgvCol.ReadOnly = false;
           
            dgvList.Columns.Add(dgvCol);
            _columns.Add(dataPropertyName, dgvCol.Name);

            BusinessLayer.General.Logging.Log(". Columnname: " + dgvCol.Name + ", Data property name: " + dgvCol.DataPropertyName + ", "
                + "Fill weight: " + dgvCol.FillWeight + ", Header text: " + dgvCol.HeaderText, BusinessLayer.General.Logging.LogLevel.Debug);
             
            Common.FormHandling.SetGridEdit(dgvList, true);
            BusinessLayer.General.Logging.Log("Column added to FHList '" + Name + "': " + columnHeader, BusinessLayer.General.Logging.LogLevel.Debug);
        }
        public void AddColumn(string dataPropertyName, string columnHeader, int fillWeight = 100, bool searchable = false, bool visible = true)
        {
            BusinessLayer.General.Logging.Log("Adding column to FHList form '" + Name + "': " + columnHeader, BusinessLayer.General.Logging.LogLevel.Debug);

            DataGridViewColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.Name = "COL" + dataPropertyName;
            dgvCol.DataPropertyName = dataPropertyName;
            dgvCol.FillWeight = fillWeight;
            dgvCol.HeaderText = columnHeader;
            dgvCol.Visible = visible;
            dgvList.Columns.Add(dgvCol);

            _columns.Add(dataPropertyName, dgvCol.Name);

            BusinessLayer.General.Logging.Log(". Columnname: " + dgvCol.Name + ", Data property name: " + dgvCol.DataPropertyName + ", "
                + "Fill weight: " + dgvCol.FillWeight + ", Header text: " + dgvCol.HeaderText, BusinessLayer.General.Logging.LogLevel.Debug);

            if (searchable)
            {
                BusinessLayer.General.Logging.Log(".. Column is searchable, adding column to search field combobox", BusinessLayer.General.Logging.LogLevel.Debug);
                pnlTop.Visible = true;
                SearchColumn sc = new SearchColumn();
                sc.ColumnHeader = dgvCol.HeaderText;
                sc.ColumnName = dgvCol.Name;
                scs.Add(sc);

                Tuple<string, string> searchField = new Tuple<string, string>(dgvCol.Name,
                    Common.Localization.Translate(dgvCol.HeaderText, Common.FormHandling.GetProgram(this).Code));
                cmbField.Items.Add(searchField);

                cmbField.DisplayMember = "Item2";
                cmbField.SelectedIndex = 0;
            }
            Common.FormHandling.SetGridEdit(dgvList, false);
            BusinessLayer.General.Logging.Log("Column added to FHList '" + Name + "': " + columnHeader, BusinessLayer.General.Logging.LogLevel.Debug);
        }

        public new virtual void RefreshData()
        {
            BusinessLayer.General.Logging.Log("Data refresh for form '" + Name + "'", BusinessLayer.General.Logging.LogLevel.Debug);
            IList<DataType> items = Crud.GetAll<DataType>();
            dgvList.DataSource = items;
            if (pnlTop.Visible) Search();
        }

        public override void ButtonState()
        {
            Core.Actions.NewBtn(true);
            Core.Actions.DeleteBtn(true);
        }

        public override void Add()
        {
            BusinessLayer.General.Logging.Log("Opening detail form for FHList form '" + Name + "', new object", BusinessLayer.General.Logging.LogLevel.Debug);
            DetailFormType detail = (DetailFormType)Activator.CreateInstance(typeof(DetailFormType), new object[] { this, null });
            detail.Show();
        }

        public override void Delete()
        {
            if (dgvList.SelectedRows.Count == 1)
            {
                BusinessLayer.General.Logging.Log("Record deleted in database via FHList form '" + Name + "'", BusinessLayer.General.Logging.LogLevel.Debug);
                Crud.Delete(dgvList.SelectedRows[0].DataBoundItem);
                RefreshData();
            }
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.SelectedRows.Count == 1)
            {
                BusinessLayer.General.Logging.Log("Opening detail form for FHList form '" + Name + "', existing record", BusinessLayer.General.Logging.LogLevel.Debug);
                DataType dataObject = (DataType)dgvList.SelectedRows[0].DataBoundItem;
                DetailFormType detail = (DetailFormType)Activator.CreateInstance(typeof(DetailFormType), new object[] { this, dataObject });
                detail.Show();
            }
        }

        private void ListWindow_Load(object sender, EventArgs e)
        {
            Common.FormHandling.SetGridEdit(dgvList, false);
            if (!DesignMode) RefreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        protected void Search()
        {
            BusinessLayer.General.Logging.Log("Data search in FHList form '" + Name + "', field: " + cmbField.SelectedItem + ", value: " +
                txtSearchValue.Text, BusinessLayer.General.Logging.LogLevel.Debug);
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvList.DataSource];
            currencyManager1.SuspendBinding();
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                var cellValue = row.Cells[((Tuple<string, string>)cmbField.SelectedItem).Item1].Value;
                if (cellValue != null && cellValue.ToString().ToUpper().Contains(txtSearchValue.Text.ToUpper()))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Selected = false;
                    row.Visible = false;
                }
            }
            currencyManager1.ResumeBinding();
            txtSearchValue.Focus();
        }

        private void txtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

    }
}