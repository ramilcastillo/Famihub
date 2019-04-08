using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiHub.BusinessLayer.General
{
    public static class Logging
    {
        public static void Log(string text, LogLevel level, Models.Core.User user = null)
        {
            int logLevel = Convert.ToInt16(Crud.GetById<Models.Core.Property, string>("DebugLevel")?.Value ?? "0");
            if ((int)level >= logLevel)
            {
                Models.Core.Logging log = new Models.Core.Logging();
                log.Text = text;
                log.Timestamp = DateTime.Now;
                log.User = user;
                log.Hostname = Environment.MachineName;
                log.Level = (int)level;
                Crud.Add(log);
                Debug.WriteLine("(" + log.Timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff") + ") " +
                    level.ToString().ToUpper() + ": " + text);
            }
        }
        public enum LogLevel
        {
            Debug = 0,
            Info = 1,
            Warning = 2,
            Error = 3
        }
    }
}
