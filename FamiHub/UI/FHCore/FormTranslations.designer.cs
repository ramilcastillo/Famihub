using Gizmox.WebGUI.Forms;

namespace FamiHub.UI.FHCore
{
    partial class FormTranslations
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
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.btnLoad = new Gizmox.WebGUI.Forms.Button();
            this.lblOnlyNotTranslated = new Gizmox.WebGUI.Forms.Label();
            this.chbOnlyNotTranslated = new Gizmox.WebGUI.Forms.CheckBox();
            this.lblForm = new Gizmox.WebGUI.Forms.Label();
            this.txtForm = new Gizmox.WebGUI.Forms.TextBox();
            this.lblLanguage = new Gizmox.WebGUI.Forms.Label();
            this.txtLanguage = new Gizmox.WebGUI.Forms.TextBox();
            this.dgvTranslations = new Gizmox.WebGUI.Forms.DataGridView();
            this.form = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.component = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.englishText = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.translation = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranslations)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnLoad);
            this.pnlTop.Controls.Add(this.lblOnlyNotTranslated);
            this.pnlTop.Controls.Add(this.chbOnlyNotTranslated);
            this.pnlTop.Controls.Add(this.lblForm);
            this.pnlTop.Controls.Add(this.txtForm);
            this.pnlTop.Controls.Add(this.lblLanguage);
            this.pnlTop.Controls.Add(this.txtLanguage);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.ExcludeFromUniqueId = false;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.NextFocusId = ((long)(0));
            this.pnlTop.PerformLayoutEnabled = true;
            this.pnlTop.PreviousFocusId = ((long)(0));
            this.pnlTop.Size = new System.Drawing.Size(709, 90);
            this.pnlTop.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.ExcludeFromUniqueId = false;
            this.btnLoad.Location = new System.Drawing.Point(369, 59);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.NextFocusId = ((long)(0));
            this.btnLoad.PerformLayoutEnabled = true;
            this.btnLoad.PreviousFocusId = ((long)(0));
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblOnlyNotTranslated
            // 
            this.lblOnlyNotTranslated.AutoSize = true;
            this.lblOnlyNotTranslated.ExcludeFromUniqueId = false;
            this.lblOnlyNotTranslated.Location = new System.Drawing.Point(12, 64);
            this.lblOnlyNotTranslated.Name = "lblOnlyNotTranslated";
            this.lblOnlyNotTranslated.NextFocusId = ((long)(0));
            this.lblOnlyNotTranslated.PerformLayoutEnabled = true;
            this.lblOnlyNotTranslated.PreviousFocusId = ((long)(0));
            this.lblOnlyNotTranslated.Size = new System.Drawing.Size(95, 13);
            this.lblOnlyNotTranslated.TabIndex = 6;
            this.lblOnlyNotTranslated.Text = "Only not translated";
            // 
            // chbOnlyNotTranslated
            // 
            this.chbOnlyNotTranslated.AutoSize = true;
            this.chbOnlyNotTranslated.ExcludeFromUniqueId = false;
            this.chbOnlyNotTranslated.Location = new System.Drawing.Point(125, 61);
            this.chbOnlyNotTranslated.Name = "chbOnlyNotTranslated";
            this.chbOnlyNotTranslated.NextFocusId = ((long)(0));
            this.chbOnlyNotTranslated.PerformLayoutEnabled = true;
            this.chbOnlyNotTranslated.PreviousFocusId = ((long)(0));
            this.chbOnlyNotTranslated.Size = new System.Drawing.Size(15, 14);
            this.chbOnlyNotTranslated.TabIndex = 5;
            this.chbOnlyNotTranslated.UseVisualStyleBackColor = true;
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.ExcludeFromUniqueId = false;
            this.lblForm.Location = new System.Drawing.Point(12, 41);
            this.lblForm.Name = "lblForm";
            this.lblForm.NextFocusId = ((long)(0));
            this.lblForm.PerformLayoutEnabled = true;
            this.lblForm.PreviousFocusId = ((long)(0));
            this.lblForm.Size = new System.Drawing.Size(30, 13);
            this.lblForm.TabIndex = 4;
            this.lblForm.Text = "Form";
            // 
            // txtForm
            // 
            this.txtForm.ExcludeFromUniqueId = false;
            this.txtForm.Location = new System.Drawing.Point(125, 38);
            this.txtForm.Name = "txtForm";
            this.txtForm.NextFocusId = ((long)(0));
            this.txtForm.PerformLayoutEnabled = true;
            this.txtForm.PreviousFocusId = ((long)(0));
            this.txtForm.Size = new System.Drawing.Size(220, 20);
            this.txtForm.TabIndex = 3;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.ExcludeFromUniqueId = false;
            this.lblLanguage.Location = new System.Drawing.Point(12, 15);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.NextFocusId = ((long)(0));
            this.lblLanguage.PerformLayoutEnabled = true;
            this.lblLanguage.PreviousFocusId = ((long)(0));
            this.lblLanguage.Size = new System.Drawing.Size(55, 13);
            this.lblLanguage.TabIndex = 2;
            this.lblLanguage.Text = "Language";
            // 
            // txtLanguage
            // 
            this.txtLanguage.CharacterCasing = Gizmox.WebGUI.Forms.CharacterCasing.Lower;
            this.txtLanguage.ExcludeFromUniqueId = false;
            this.txtLanguage.Location = new System.Drawing.Point(125, 12);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.NextFocusId = ((long)(0));
            this.txtLanguage.PerformLayoutEnabled = true;
            this.txtLanguage.PreviousFocusId = ((long)(0));
            this.txtLanguage.Size = new System.Drawing.Size(46, 20);
            this.txtLanguage.TabIndex = 1;
            // 
            // dgvTranslations
            // 
            this.dgvTranslations.ColumnHeadersHeightSizeMode = Gizmox.WebGUI.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranslations.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.form,
            this.component,
            this.englishText,
            this.translation});
            this.dgvTranslations.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgvTranslations.ExcludeFromUniqueId = false;
            this.dgvTranslations.Location = new System.Drawing.Point(0, 90);
            this.dgvTranslations.Name = "dgvTranslations";
            this.dgvTranslations.NextFocusId = ((long)(0));
            this.dgvTranslations.PerformLayoutEnabled = true;
            this.dgvTranslations.PreviousFocusId = ((long)(0));
            this.dgvTranslations.RenderCellPanelsAsText = false;
            this.dgvTranslations.RowTemplate.Enabled = true;
            this.dgvTranslations.Size = new System.Drawing.Size(709, 352);
            this.dgvTranslations.TabIndex = 1;
            // 
            // form
            // 
            this.form.DataPropertyName = "Form";
            this.form.DefaultCellStyle = dataGridViewCellStyle1;
            this.form.FillWeight = 250F;
            this.form.HeaderText = "Form";
            this.form.Name = "form";
            this.form.ReadOnly = true;
            // 
            // component
            // 
            this.component.DataPropertyName = "Component";
            this.component.DefaultCellStyle = dataGridViewCellStyle2;
            this.component.FillWeight = 250F;
            this.component.HeaderText = "Component";
            this.component.Name = "component";
            this.component.ReadOnly = true;
            // 
            // englishText
            // 
            this.englishText.DataPropertyName = "English";
            this.englishText.DefaultCellStyle = dataGridViewCellStyle3;
            this.englishText.FillWeight = 250F;
            this.englishText.HeaderText = "Text";
            this.englishText.Name = "englishText";
            this.englishText.ReadOnly = true;
            // 
            // translation
            // 
            this.translation.DataPropertyName = "Translation";
            this.translation.DefaultCellStyle = dataGridViewCellStyle4;
            this.translation.FillWeight = 250F;
            this.translation.HeaderText = "Translation";
            this.translation.Name = "translation";
            // 
            // FormTranslations
            // 
            this.Controls.Add(this.dgvTranslations);
            this.Controls.Add(this.pnlTop);
            this.Size = new System.Drawing.Size(709, 442);
            this.Text = "FormTranslations";
            this.Load += new System.EventHandler(this.FormTranslations_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranslations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlTop;
        private Label lblLanguage;
        private TextBox txtLanguage;
        private Label lblOnlyNotTranslated;
        private CheckBox chbOnlyNotTranslated;
        private Label lblForm;
        private TextBox txtForm;
        private Button btnLoad;
        private DataGridView dgvTranslations;
        private DataGridViewTextBoxColumn form;
        private DataGridViewTextBoxColumn component;
        private DataGridViewTextBoxColumn englishText;
        private DataGridViewTextBoxColumn translation;
    }
}