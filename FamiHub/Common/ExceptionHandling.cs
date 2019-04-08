#region License
// *******************************************************
// Copyright (c) 2018 Famiflora SA
// 
// This file is part of FamiHub.
// FamiHub can not be copied and/or distributed without the express
// permission of Famiflora SA.
// *******************************************************
#endregion
using FamiHub.Models.Core;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Gizmox.WebGUI.Forms;

namespace FamiHub.Common
{
    internal class ExceptionHandling
    {
        private static void ThrowException(Assembly asm, Exception ex)
        {
            string msg = null;
            string errornr = Guid.NewGuid().ToString();
            StackTrace st = new StackTrace(ex, true);
            MethodBase method = st.GetFrame(0).GetMethod();
            string customMessage = ex.Message;
            msg = string.Empty;
            while (!(ex == null))
            {
                msg += "" + "\r\n";
                msg += ex.ToString() + "\r\n";
                ex = ex.InnerException;
            }
            string classn = method.ReflectedType.Name;
            string box = null;
            box = string.Empty;
            box += "Assembly: " + "\t" + Path.GetFileName(asm.Location) + "\r\n";
            box += "Directory: " + "\t" + "\t" + Environment.CurrentDirectory.ToString() + "\r\n";
            box += "Version: " + "\t" + "\t" + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\r\n";
            box += "Time: " + "\t" + "\t" + DateTime.Now + "\r\n";
            box += "Method: " + "\t" + "\t" + method.Name + "\r\n";
            box += "Class: " + "\t" + "\t" + classn + "\r\n";
            box += "Line: " + "\t" + "\t" + st.GetFrame(0).GetFileLineNumber().ToString() + "\t" + "Column: " + "\t" + st.GetFrame(0).GetFileColumnNumber().ToString() + "\r\n";
            box += "Error: " + "\t" + "\t" + customMessage + "\r\n" + "\r\n" + "Show detailed error information?";
            BusinessLayer.General.Logging.Log("Error: " + customMessage, BusinessLayer.General.Logging.LogLevel.Error);
            try
            {
                Error errordb = new Error();
                string os = Environment.OSVersion.ToString();
                if (Environment.Is64BitOperatingSystem == true)
                {
                    os += " (x64)";
                }
                User username = null;
                User userWs = Session.CurrentSession.User;
                if (userWs != null) username = userWs;
                errordb.ClassName = classn;
                errordb.ErrorDescription = customMessage;
                errordb.Host = Environment.MachineName.ToString();
                errordb.LongError = msg;
                errordb.Method = method.Name;
                errordb.OS = os;
                errordb.Place = st.GetFrame(0).GetFileLineNumber().ToString() + " : " + st.GetFrame(0).GetFileColumnNumber().ToString();
                errordb.StackInfo = st.ToString();
                errordb.User = username;
                errordb.Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                errordb.ErrorTime = DateTime.Now;
                Crud.Add(errordb);
            }
            catch (Exception errdb)
            {
                ThrowException(asm, errdb);
            }
            DialogResult ch = MessageBox.Show(box, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (ch == DialogResult.Yes)
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK);
            }
        }
        public static void HandleException(System.Exception ex)
        {
            ThrowException(Assembly.GetCallingAssembly(), ex);
        }
    }
}
