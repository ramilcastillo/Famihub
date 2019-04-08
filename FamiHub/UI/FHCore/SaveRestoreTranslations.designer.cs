using Gizmox.WebGUI.Forms;

namespace FamiHub.UI.FHCore
{
    partial class SaveRestoreTranslations
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbExport = new GroupBox();
            this.lblLanguage = new Label();
            this.cmbLanguage = new ComboBox();
            this.saveFileDialog = new SaveFileDialog();
            this.btnExport = new Button();
            this.gbImport = new GroupBox();
            this.btnImport = new Button();
            this.openFileDialog = new OpenFileDialog();
            this.gbExport.SuspendLayout();
            this.gbImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbExport
            // 
            this.gbExport.Controls.Add(this.btnExport);
            this.gbExport.Controls.Add(this.lblLanguage);
            this.gbExport.Controls.Add(this.cmbLanguage);
            this.gbExport.Location = new System.Drawing.Point(12, 12);
            this.gbExport.Name = "gbExport";
            this.gbExport.Size = new System.Drawing.Size(289, 78);
            this.gbExport.TabIndex = 0;
            this.gbExport.TabStop = false;
            this.gbExport.Text = "Export translations";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(6, 22);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(55, 13);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "Language";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(97, 19);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(186, 21);
            this.cmbLanguage.TabIndex = 0;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Translation file|*.trl";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(97, 46);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // gbImport
            // 
            this.gbImport.Controls.Add(this.btnImport);
            this.gbImport.Location = new System.Drawing.Point(12, 96);
            this.gbImport.Name = "gbImport";
            this.gbImport.Size = new System.Drawing.Size(289, 74);
            this.gbImport.TabIndex = 1;
            this.gbImport.TabStop = false;
            this.gbImport.Text = "Import translations";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(97, 31);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Translations file|*.trl";
            // 
            // SaveRestoreTranslations
            // 
            this.ClientSize = new System.Drawing.Size(313, 182);
            this.Controls.Add(this.gbImport);
            this.Controls.Add(this.gbExport);
            this.Name = "SaveRestoreTranslations";
            this.Text = "SaveRestoreTranslations";
            this.Load += new System.EventHandler(this.SaveRestoreTranslations_Load);
            this.gbExport.ResumeLayout(false);
            this.gbExport.PerformLayout();
            this.gbImport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbExport;
        private Label lblLanguage;
        private ComboBox cmbLanguage;
        private Button btnExport;
        private SaveFileDialog saveFileDialog;
        private GroupBox gbImport;
        private Button btnImport;
        private OpenFileDialog openFileDialog;
    }
}