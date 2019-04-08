namespace FamiHub.Core
{
    public static class Actions
    {
        public static bool SaveBtn()
        {
            return Common.Session.MainForm.btnSave.Enabled;
        }
        public static void SaveBtn(bool enabled)
        {
            if (Common.Session.MainForm != null)
            {
                BusinessLayer.General.Logging.Log("Setting button 'enabled' property for MainForm button 'Save' to " + enabled.ToString(), BusinessLayer.General.Logging.LogLevel.Debug);
                Common.Session.MainForm.btnSave.Enabled = enabled;
            }
        }
        public static bool CancelBtn()
        {
            return Common.Session.MainForm.btnCancel.Enabled;
        }
        public static void CancelBtn(bool enabled)
        {
            if (Common.Session.MainForm != null)
            {
                BusinessLayer.General.Logging.Log("Setting button 'enabled' property for MainForm button 'Cancel' to " + enabled.ToString(), BusinessLayer.General.Logging.LogLevel.Debug);
                Common.Session.MainForm.btnCancel.Enabled = enabled;
            }
        }
        public static bool NewBtn()
        {
            return Common.Session.MainForm.btnAdd.Enabled;
        }
        public static void NewBtn(bool enabled)
        {
            if (Common.Session.MainForm != null)
            {
                BusinessLayer.General.Logging.Log("Setting button 'enabled' property for MainForm button 'Add' to " + enabled.ToString(), BusinessLayer.General.Logging.LogLevel.Debug);
                Common.Session.MainForm.btnAdd.Enabled = enabled;
            }
        }
        public static bool DeleteBtn()
        {
            return Common.Session.MainForm.btnDelete.Enabled;
        }
        public static void DeleteBtn(bool enabled)
        {
            if (Common.Session.MainForm != null)
            {
                BusinessLayer.General.Logging.Log("Setting button 'enabled' property for MainForm button 'Delete' to " + enabled.ToString(), BusinessLayer.General.Logging.LogLevel.Debug);
                Common.Session.MainForm.btnDelete.Enabled = enabled;
            }
        }
        public static void AllBtn(bool enabled)
        {
            if (Common.Session.MainForm != null)
            {
                SaveBtn(enabled);
                CancelBtn(enabled);
                NewBtn(enabled);
                DeleteBtn(enabled);
            }
        }
    }
}