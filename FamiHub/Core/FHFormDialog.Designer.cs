using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.Core
{
    partial class FHFormDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FHFormDialog
            // 
            this.Size = new System.Drawing.Size(359, 146);
            this.Text = "FHFormDialog";
            this.FormClosed += new Gizmox.WebGUI.Forms.Form.FormClosedEventHandler(this.FHFormDialog_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion


    }
}