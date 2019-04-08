#region License
// *******************************************************
// Copyright (c) 2018 Famiflora SA
// 
// This file is part of FamiHub.
// FamiHub can not be copied and/or distributed without the express
// permission of Famiflora SA.
// *******************************************************
#endregion
using Gizmox.WebGUI.Forms;
using System;

namespace FamiHub.Common
{
    internal static class Interaction
    {
        public static void ThrowMessage(object caller, string message, params string[] var)
        {
            string callerName = "";
            if (caller != null)
            {
                callerName = caller.GetType().Name;
            }
            ThrowMessage(callerName, message, var);
        }
        public static void ThrowMessage(string group, string message, params string[] var)
        {
            message = Localization.Translate(message, group);
            string msg = message;
            if (var != null)
                msg = String.Format(message, var);
            MessageBox.Show(msg);
            BusinessLayer.General.Logging.Log("Message: " + msg, BusinessLayer.General.Logging.LogLevel.Debug);
        }
        public static void DownloadFromStream(ContainerControl caller, byte[] fileAsByteArray, string fileName)
        {
            System.IO.MemoryStream memStream = new System.IO.MemoryStream();
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binForm = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            memStream.Write(fileAsByteArray, 0, fileAsByteArray.Length);
            Gizmox.WebGUI.Common.Gateways.DownloadGateway myDownload = new Gizmox.WebGUI.Common.Gateways.DownloadGateway(memStream, fileName);
            myDownload.StartDownload(caller);
        }
    }
}
