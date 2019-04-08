using Gizmox.WebGUI.Forms;

namespace FamiHub.Common
{
    internal static class ComboBoxFiller
    {
        public static void CountryComboBox(ComboBox comboBox)
        {

            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            comboBox.DataSource = Crud.GetAll<Models.Core.Country>();

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public static void SalutationComboBox(ComboBox comboBox)
        {

            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Id";
            comboBox.DataSource = Crud.GetAll<Models.Core.Salutation>();

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}