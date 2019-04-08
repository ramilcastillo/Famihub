using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.Customers
{
    partial class GeneratePhysicalCardsFile
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
            this.nudQuantity = new Gizmox.WebGUI.Forms.NumericUpDown();
            this.lblQuantity = new Gizmox.WebGUI.Forms.Label();
            this.lblWarning = new Gizmox.WebGUI.Forms.Label();
            this.btnCreate = new Gizmox.WebGUI.Forms.Button();
            this.ntrLastCardCreated = new Gizmox.WebGUI.Forms.Label();
            this.bgwCreateCards = new System.ComponentModel.BackgroundWorker();
            this.pgbProcess = new Gizmox.WebGUI.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // nudQuantity
            // 
            this.nudQuantity.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.nudQuantity.CurrentValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.ExcludeFromUniqueId = false;
            this.nudQuantity.Location = new System.Drawing.Point(125, 11);
            this.nudQuantity.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.NextFocusId = ((long)(0));
            this.nudQuantity.PerformLayoutEnabled = true;
            this.nudQuantity.PreviousFocusId = ((long)(0));
            this.nudQuantity.Size = new System.Drawing.Size(120, 21);
            this.nudQuantity.TabIndex = 0;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ExcludeFromUniqueId = false;
            this.lblQuantity.Location = new System.Drawing.Point(4, 13);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.NextFocusId = ((long)(0));
            this.lblQuantity.PerformLayoutEnabled = true;
            this.lblQuantity.PreviousFocusId = ((long)(0));
            this.lblQuantity.Size = new System.Drawing.Size(35, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "# of cards to create";
            // 
            // lblWarning
            // 
            this.lblWarning.ExcludeFromUniqueId = false;
            this.lblWarning.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(4, 40);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.NextFocusId = ((long)(0));
            this.lblWarning.PerformLayoutEnabled = true;
            this.lblWarning.PreviousFocusId = ((long)(0));
            this.lblWarning.Size = new System.Drawing.Size(374, 31);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Text = "WARNING: a customer for each card will be created in Becosoft!";
            // 
            // btnCreate
            // 
            this.btnCreate.ExcludeFromUniqueId = false;
            this.btnCreate.Location = new System.Drawing.Point(125, 71);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.NextFocusId = ((long)(0));
            this.btnCreate.PerformLayoutEnabled = true;
            this.btnCreate.PreviousFocusId = ((long)(0));
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // ntrLastCardCreated
            // 
            this.ntrLastCardCreated.AutoSize = true;
            this.ntrLastCardCreated.ExcludeFromUniqueId = false;
            this.ntrLastCardCreated.Location = new System.Drawing.Point(210, 103);
            this.ntrLastCardCreated.Name = "ntrLastCardCreated";
            this.ntrLastCardCreated.NextFocusId = ((long)(0));
            this.ntrLastCardCreated.PerformLayoutEnabled = true;
            this.ntrLastCardCreated.PreviousFocusId = ((long)(0));
            this.ntrLastCardCreated.Size = new System.Drawing.Size(35, 13);
            this.ntrLastCardCreated.TabIndex = 4;
            this.ntrLastCardCreated.Text = "00000000000000000";
            // 
            // bgwCreateCards
            // 
            this.bgwCreateCards.WorkerReportsProgress = true;
            this.bgwCreateCards.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCreateCards_DoWork);
            this.bgwCreateCards.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwCreateCards_ProgressChanged);
            this.bgwCreateCards.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCreateCards_RunWorkerCompleted);
            // 
            // pgbProcess
            // 
            this.pgbProcess.ExcludeFromUniqueId = false;
            this.pgbProcess.Location = new System.Drawing.Point(213, 71);
            this.pgbProcess.Name = "pgbProcess";
            this.pgbProcess.NextFocusId = ((long)(0));
            this.pgbProcess.PerformLayoutEnabled = true;
            this.pgbProcess.PreviousFocusId = ((long)(0));
            this.pgbProcess.Size = new System.Drawing.Size(165, 23);
            this.pgbProcess.TabIndex = 5;
            // 
            // GeneratePhysicalCardsFile
            // 
            this.Controls.Add(this.pgbProcess);
            this.Controls.Add(this.ntrLastCardCreated);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Size = new System.Drawing.Size(391, 306);
            this.Text = "GeneratePhysicalCardsFile";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private NumericUpDown nudQuantity;
        private Label lblQuantity;
        private Label lblWarning;
        private Button btnCreate;
        private Label ntrLastCardCreated;
        private System.ComponentModel.BackgroundWorker bgwCreateCards;
        private ProgressBar pgbProcess;
    }
}