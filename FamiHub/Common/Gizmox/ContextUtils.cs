using System;
using System.Collections.Generic;
using System.Web;
using System.IO;

using Gizmox.WebGUI.Forms;

namespace Gizmox.WebGUI.Common.Gateways
{
    public class ContextUtils
    {
        public static string GetPhysicalWebPath(Control myForm)
        {
            return myForm.Context.Server.MapPath(myForm.Context.HttpContext.Request.ApplicationPath);
        }

        public static string GetPhysicalPath(Control myForm, string myFolder, string myFilename)
        {
            //Returns Physical Directory of File on Server
            return Path.Combine(Path.Combine(GetPhysicalWebPath(myForm), myFolder), myFilename);
        }

        public static string GetPhysicalPath(Control myForm, string myFolder, string myFilename, string myCustomRootPath)
        {
            //Returns Physical Directory of File on Server

            string myRootPath = null;
            string myPath = null;

            if (myCustomRootPath == null)
            {
                //Use Server's Entire Physical Path
                myRootPath = GetPhysicalWebPath(myForm);
                //Build Path
                myPath = Path.Combine(Path.Combine(myRootPath, myFolder), myFilename);
            }
            else
            {
                //Custom Root Path - Attempt to read from web.config (ie, required for CrystalTech medium trust)
                //Build Path using Server.MapPath()
                myPath = myForm.Context.Server.MapPath(Path.Combine(Path.Combine(myCustomRootPath, myFolder), myFilename));
            }

            return myPath;
        }

    }
}
