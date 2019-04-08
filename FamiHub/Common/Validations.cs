using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gizmox.WebGUI.Forms;

namespace FamiHub.Common
{
    internal static class Validations
    {
        public static void ValidateDouble(TextBox textbox)
        {
            double value;
            while (!double.TryParse(textbox.Text, out value))
            {
                Interaction.ThrowMessage(textbox.Parent, "This is not a valid input!");
                textbox.Text = "0";
            }
        }
        public static void ValidateLong(TextBox textbox)
        {
            long value;
            while (!long.TryParse(textbox.Text, out value))
            {
                Interaction.ThrowMessage(textbox.Parent, "This is not a valid input!");
                textbox.Text = "0";
            }
        }
    }
}