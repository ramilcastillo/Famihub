using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FamiHub.BusinessLayer.Employees
{
    public static class GpsConnector
    {
        private static string currentSessionId = null;
        private static DateTime currentSessionExpires = new DateTime(1970, 1, 1, 0, 0, 0);
        private static void Login()
        {
            if (currentSessionId == null || currentSessionExpires <= DateTime.Now)
            {
                var client = new WebClient { Headers = { [HttpRequestHeader.ContentType] = "application/json", ["GPS-Application"] = "GPS-Service" } };
                var username = "";
                var password = "";
                
                string json = string.Format("{\"LoginID\":\"{0}\",\"Password\":\"{1}\"}", username, password);
                string result = client.UploadString($"http://172.16.8.20/GPS-Services/api/login", json);
                dynamic objResult = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                string sessionId = objResult.sessionID;
            }
            else
            {

            }
        }
    }
}
