using Gizmox.WebGUI.Forms;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace FamiHub.Common
{
    internal static class FormHandling
    {
        public static void OpenForm(string code)
        {
            try
            {
                var session = Session.DatabaseConnection;
                Models.Core.Program pgm = session.CreateCriteria(typeof(Models.Core.Program))
                                                .Add(Expression.Eq("Code", code))
                                                .UniqueResult<Models.Core.Program>();
                
                if (pgm != null)
                {
                    string form = pgm.Form;
                    string prefix = "FamiHub.UI.";
                    if (pgm.Form.StartsWith("*."))
                    {
                        prefix = "FamiHub.Core.";
                        form = pgm.Form.Replace("*.", "");
                    }
                    dynamic ProjAndForm = prefix + form + ",FamiHub";
                    Type objType = Type.GetType(ProjAndForm);
                    Control objForm = (Control)Activator.CreateInstance(objType);
                    ((FHFormTab)objForm).Show();
                }
                else
                {
                    if (!string.IsNullOrEmpty(code))
                    {
                        Interaction.ThrowMessage(Session.MainForm, "Input invalid");
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.HandleException(ex);
            }
        }
        public static void Translate(this Control parent, string formName = null, IList<Models.Core.FormTranslation> trls = null)
        {
            try
            {
                string sessionLanguage = Session.CurrentUser?.Language ?? "en";

                if (formName == null)
                {
                    formName = GetProgramType((FHFormTab)parent);
                    if (parent is FHFormTab)
                    {
                        Models.Core.Program pgm = GetProgram((FHFormTab)parent);
                        parent.Text = pgm?.Description;
                        parent.Text = Localization.TranslateCpt(formName, "_form", sessionLanguage, parent.Text);
                        if (!string.IsNullOrEmpty(pgm?.Code))
                        {
                            parent.Text = parent.Text;
                        }

                        BusinessLayer.General.Logging.Log("Form title set to '" + parent.Text + "' for form " + formName, BusinessLayer.General.Logging.LogLevel.Debug);
                    }
                }

                if (trls == null)
                {
                    trls = Localization.GetFormTranslationsByForm(formName, sessionLanguage);
                }

                Models.Core.FormTranslation trl;
                foreach (Control c in parent.Controls)
                {
                    if (HasProperty(c, "Text") && ToTranslate(c))
                    {
                        if (c.Text != "" && c.Text != c.Name.ToString() && c.Text != "..." && c.Name.ToString().Substring(0, 3) != "ntr" && c.Name.ToString().Substring(0, 3) != "txt")
                        {
                            trl = trls.Cast<Models.Core.FormTranslation>().FirstOrDefault(i => i.Component == c.Name);
                            if (!string.IsNullOrEmpty(trl?.Translation))
                                c.Text = trl.Translation;
                            else
                                c.Text = Localization.TranslateCpt(formName, c.Name, sessionLanguage, c.Text);
                        }
                    }
                    if (c is DataGridView)
                    {
                        BusinessLayer.General.Logging.Log("Component '" + c.Name + "' is DataGridView, using other translation method", BusinessLayer.General.Logging.LogLevel.Debug);
                        DataGridView dgv = (DataGridView)c;
                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            trl = trls.Cast<Models.Core.FormTranslation>().FirstOrDefault(i => i.Component == column.Name);
                            if (!string.IsNullOrEmpty(trl?.Translation))
                                column.HeaderText = trl.Translation;
                            else
                                column.HeaderText = Localization.TranslateCpt(formName, column.Name, sessionLanguage, column.HeaderText);
                        }
                    }
                    Translate(c, formName, trls);
                }
            }
            catch (Exception ex)
            {
                Common.ExceptionHandling.HandleException(ex);
            }
        }
        private static bool ToTranslate(Control control)
        {
            bool result = true;
            if (control is TextBox || control is ComboBox || control is DataGridView ||
                control is DateTimePicker || control is NumericUpDown || control is ListBox ||
                control is ListView)
            {
                result = false;
            }
            BusinessLayer.General.Logging.Log("Control " + control.Name + " needs to be translated: " + result.ToString(), BusinessLayer.General.Logging.LogLevel.Debug);
            return result;
        }
        public static bool HasProperty(object control, string propertyName)
        {
            BusinessLayer.General.Logging.Log("Control " + control.GetType().ToString() + " has property '" + propertyName + "': " +
                (control.GetType().GetProperty(propertyName) != null), BusinessLayer.General.Logging.LogLevel.Debug);
            return control.GetType().GetProperty(propertyName) != null;
        }
        private static string GetProgramType(FHFormTab form)
        {
            string typ = form.GetType().ToString().Replace("FamiHub.UI.", "");
            if (typ.StartsWith("FamiHub.Core."))
            {
                typ = form.GetType().ToString().Replace("FamiHub.Core.", "*.");
            }
            BusinessLayer.General.Logging.Log("Got program type '" + typ + "'", BusinessLayer.General.Logging.LogLevel.Debug);
            return typ;
        }
        public static Models.Core.Program GetProgram(FHFormTab form)
        {
            Models.Core.Program pgm = null;
            string typ = GetProgramType(form);
            BusinessLayer.General.Logging.Log("Loading program info for '" + typ + "' from database", BusinessLayer.General.Logging.LogLevel.Debug);
            var session = Session.OpenSession();
            pgm = session.CreateCriteria(typeof(Models.Core.Program))
                .Add(Expression.Eq("Form", typ))
                .UniqueResult<Models.Core.Program>();
            BusinessLayer.General.Logging.Log("Got program info for '" + typ + "'", BusinessLayer.General.Logging.LogLevel.Debug);
            return pgm;
        }
        public static Models.Core.Program GetProgramByCode(string programCode)
        {
            BusinessLayer.General.Logging.Log("Loading program info for code '" + programCode + "' from database", BusinessLayer.General.Logging.LogLevel.Debug);
            var session = Session.OpenSession();
            Models.Core.Program pgm = session.CreateCriteria(typeof(Models.Core.Program))
                                        .Add(Expression.Eq("Code", programCode))
                                        .UniqueResult<Models.Core.Program>();
            BusinessLayer.General.Logging.Log("Got program info for code '" + programCode + "'", BusinessLayer.General.Logging.LogLevel.Debug);
            return pgm;
        }
        public static void InitForm(Control parent)
        {
            try
            {
                foreach (Control c in parent.Controls)
                {
                    // Set DataGridView properties
                    if (c is DataGridView)
                    {
                        DataGridView((DataGridView)c);
                    }

                    // Set workspacetabs control properties
                    if (c is WorkspaceTabs)
                    {
                        ((WorkspaceTabs)c).ShowCloseButton = false;
                    }
                    
                    // Set DateTimePicker control properties
                    if (c is DateTimePicker)
                    {
                        var dtp = (DateTimePicker)c;
                        dtp.CalendarFirstDayOfWeek = Day.Monday;
                        dtp.Format = DateTimePickerFormat.Custom;
                        dtp.CustomFormat = "dd/MM/yyyy";
                    }

                    // If checkbox, move up 4 points
                    if (c is CheckBox)
                    {
                        var chb = (CheckBox)c;
                        chb.Location = new Point(chb.Location.X, chb.Location.Y - 4);
                    }

                    InitForm(c);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.HandleException(ex);
            }
        }
        public static void DataGridView(DataGridView ctl)
        {
            ctl.RowHeadersVisible = false;
            ctl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ctl.MultiSelect = false;
            ctl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ctl.ScrollBars = ScrollBars.Vertical;
            ctl.ColumnHeadersDefaultCellStyle.Font = new Font(ctl.ColumnHeadersDefaultCellStyle.Font.FontFamily, ctl.ColumnHeadersDefaultCellStyle.Font.SizeInPoints, FontStyle.Bold);
            ctl.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            ctl.RowTemplate.Height = 16;
            ctl.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            ctl.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            ctl.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ctl.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            ctl.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            ctl.AllowUserToOrderColumns = false;
            ctl.AllowUserToResizeRows = false;
            ctl.BorderStyle = BorderStyle.None;
            ctl.BackgroundColor = Color.Gainsboro;
            ctl.AutoGenerateColumns = false;
            ctl.EnableHeadersVisualStyles = false;
            ctl.ItemsPerPage = 50;
        }
        public static void SetGridEdit(DataGridView Grid, bool Editable = true)
        {
            DataGridView(Grid);
            Grid.AllowUserToAddRows = Editable;
            Grid.AllowUserToDeleteRows = Editable;
            Grid.ReadOnly = !(Editable);
            if (Editable)
            {
                Grid.Rows.Clear();
            }
        }
    }
}