namespace FamiHub.UI.FHCore
{
    public partial class CountryForm : FHFormTab
    {
        FHFormTab _caller;
        internal Models.Core.Country dataObject;
        public CountryForm(FHFormTab caller, Models.Core.Country country)
        {
            InitializeComponent();

            _caller = caller;
            dataObject = country;

            if (dataObject == null)
                dataObject = new Models.Core.Country();

            LoadData();
        }

        public void LoadData()
        {
            txtName.Text = dataObject.Name;
            txtCode.Text = dataObject.IsoCode;
        }

        public override void ButtonState()
        {
            Core.Actions.SaveBtn(true);
        }

        public override void Save()
        {
            dataObject.IsoCode = txtCode.Text;
            dataObject.Name = txtName.Text;
            Crud.Put(dataObject);

            _caller.RefreshData();
            Close();
        }
    }
}
