using Gizmox.WebGUI.Forms;
using NHibernate;
using System;
using System.Collections.Generic;
using System.IO;

namespace FamiHub.Common
{
    internal static class Session
    {
        public static object GetProperty(string key)
        {
            try
            {
                return VWGContext.Current.Session[key];
            }
            catch
            {
                return null;
            }
        }
        public static void SetProperty(string key, object value)
        {
            VWGContext.Current.Session[key] = value;
        }
        public static string Host
        {
            get
            {
                return VWGContext.Current.HttpContext.Request.Url.Host;
            }
        }
        public static ISession DatabaseConnection
        {
            get
            {
                    return OpenSession();
            }
        }
        public static Models.Core.User CurrentUser
        {
            get
            {
                return (Models.Core.User)GetProperty("LoggedInUser");
            }
            set
            {
                SetProperty("LoggedInUser", value);
            }
        }
        public static Models.Core.Session CurrentSession
        {
            get
            {
                return (Models.Core.Session)GetProperty("Session");
            }
            set
            {
                SetProperty("Session", value);
            }
        }
        public static Core.MainForm MainForm
        {
            get
            {
                return (Core.MainForm)GetProperty("MainForm");
            }
            set
            {
                SetProperty("MainForm", value);
            }
        }
        public static string TemporaryPath
        {
            get
            {
                string baseDir = Properties.Settings.Default.TempFileDirectory;
                string dir = baseDir + "\\" + Common.Session.Host + "-" + CurrentSession.Id + "\\";

                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                dir = dir + Guid.NewGuid().ToString() + "\\";

                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                return dir;
            }
        }
        public static ISession OpenSession()
        {
            return DataConnector.NHibernateConnector.OpenSession();
        }
        public static void UpdateDatabaseSchema()
        {
            DataConnector.NHibernateConnector.UpdateDbSchema();
        }
    }
}