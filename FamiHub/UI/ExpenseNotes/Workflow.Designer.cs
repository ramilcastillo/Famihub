using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.ExpenseNotes
{
    partial class Workflow
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

        #region Visual WebGui UserControl Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FHList
            // 
            this.Size = new System.Drawing.Size(401, 350);
            this.Text = "FHList";
            this.Load += new System.EventHandler(this.FHList_Load);
            this.ResumeLayout(false);

        }


        #endregion
    }
}