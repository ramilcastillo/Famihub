using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace FamiHub.UI.Customers
{
    partial class CustomerForm
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
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.lblName = new Gizmox.WebGUI.Forms.Label();
            this.txtName = new Gizmox.WebGUI.Forms.TextBox();
            this.txtFirstName = new Gizmox.WebGUI.Forms.TextBox();
            this.lblFirstName = new Gizmox.WebGUI.Forms.Label();
            this.cmbSalutation = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblSalutation = new Gizmox.WebGUI.Forms.Label();
            this.wstCustomer = new Gizmox.WebGUI.Forms.WorkspaceTabs();
            this.tabContactInfo = new Gizmox.WebGUI.Forms.WorkspaceTab();
            this.txtStreet = new Gizmox.WebGUI.Forms.TextBox();
            this.lblStreet = new Gizmox.WebGUI.Forms.Label();
            this.lblNumber = new Gizmox.WebGUI.Forms.Label();
            this.txtNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.lblBox = new Gizmox.WebGUI.Forms.Label();
            this.txtBox = new Gizmox.WebGUI.Forms.TextBox();
            this.txtZip = new Gizmox.WebGUI.Forms.TextBox();
            this.lblZipCity = new Gizmox.WebGUI.Forms.Label();
            this.txtCity = new Gizmox.WebGUI.Forms.TextBox();
            this.cmbCountry = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblCountry = new Gizmox.WebGUI.Forms.Label();
            this.txtMobilePhone = new Gizmox.WebGUI.Forms.TextBox();
            this.lblMobilePhone = new Gizmox.WebGUI.Forms.Label();
            this.txtPhone = new Gizmox.WebGUI.Forms.TextBox();
            this.lblPhone = new Gizmox.WebGUI.Forms.Label();
            this.txtMailAddress = new Gizmox.WebGUI.Forms.TextBox();
            this.lblMailAddress = new Gizmox.WebGUI.Forms.Label();
            this.tabLoyaltyProgramInfo = new Gizmox.WebGUI.Forms.WorkspaceTab();
            this.btnUsePoints = new Gizmox.WebGUI.Forms.Button();
            this.btnAddLoyaltyTransaction = new Gizmox.WebGUI.Forms.Button();
            this.wstLoyalty = new Gizmox.WebGUI.Forms.WorkspaceTabs();
            this.tabBalance = new Gizmox.WebGUI.Forms.WorkspaceTab();
            this.dgvLoyaltyBalances = new Gizmox.WebGUI.Forms.DataGridView();
            this.clmBalanceOverviewPartner = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.clmBalanceOverviewPoints = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.pnlTopBalanceOverview = new Gizmox.WebGUI.Forms.Panel();
            this.txtTotalBalance = new Gizmox.WebGUI.Forms.TextBox();
            this.lblTotalBalance = new Gizmox.WebGUI.Forms.Label();
            this.tabTransactions = new Gizmox.WebGUI.Forms.WorkspaceTab();
            this.dgvLoyaltyTransactions = new Gizmox.WebGUI.Forms.DataGridView();
            this.clmTransactionDate = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.clmPointsOrigin = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.clmDestination = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.clmTransactionPoints = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.clmTransactionInfoText = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.txtLoyaltyCardNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.lblLoyaltyCardNumber = new Gizmox.WebGUI.Forms.Label();
            this.dtpBirthDate = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.lblBirthDate = new Gizmox.WebGUI.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wstCustomer)).BeginInit();
            this.wstCustomer.SuspendLayout();
            this.tabContactInfo.SuspendLayout();
            this.tabLoyaltyProgramInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wstLoyalty)).BeginInit();
            this.wstLoyalty.SuspendLayout();
            this.tabBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoyaltyBalances)).BeginInit();
            this.pnlTopBalanceOverview.SuspendLayout();
            this.tabTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoyaltyTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ExcludeFromUniqueId = false;
            this.lblName.Location = new System.Drawing.Point(4, 6);
            this.lblName.Name = "lblName";
            this.lblName.NextFocusId = ((long)(0));
            this.lblName.PerformLayoutEnabled = true;
            this.lblName.PreviousFocusId = ((long)(0));
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.ExcludeFromUniqueId = false;
            this.txtName.Location = new System.Drawing.Point(138, 3);
            this.txtName.Name = "txtName";
            this.txtName.NextFocusId = ((long)(0));
            this.txtName.PerformLayoutEnabled = true;
            this.txtName.PreviousFocusId = ((long)(0));
            this.txtName.Size = new System.Drawing.Size(347, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.ExcludeFromUniqueId = false;
            this.txtFirstName.Location = new System.Drawing.Point(138, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.NextFocusId = ((long)(0));
            this.txtFirstName.PerformLayoutEnabled = true;
            this.txtFirstName.PreviousFocusId = ((long)(0));
            this.txtFirstName.Size = new System.Drawing.Size(347, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ExcludeFromUniqueId = false;
            this.lblFirstName.Location = new System.Drawing.Point(4, 32);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.NextFocusId = ((long)(0));
            this.lblFirstName.PerformLayoutEnabled = true;
            this.lblFirstName.PreviousFocusId = ((long)(0));
            this.lblFirstName.Size = new System.Drawing.Size(35, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First name";
            // 
            // cmbSalutation
            // 
            this.cmbSalutation.ExcludeFromUniqueId = false;
            this.cmbSalutation.FormattingEnabled = true;
            this.cmbSalutation.Location = new System.Drawing.Point(138, 54);
            this.cmbSalutation.Name = "cmbSalutation";
            this.cmbSalutation.NextFocusId = ((long)(0));
            this.cmbSalutation.PerformLayoutEnabled = true;
            this.cmbSalutation.PreviousFocusId = ((long)(0));
            this.cmbSalutation.Size = new System.Drawing.Size(121, 21);
            this.cmbSalutation.TabIndex = 2;
            // 
            // lblSalutation
            // 
            this.lblSalutation.AutoSize = true;
            this.lblSalutation.ExcludeFromUniqueId = false;
            this.lblSalutation.Location = new System.Drawing.Point(4, 58);
            this.lblSalutation.Name = "lblSalutation";
            this.lblSalutation.NextFocusId = ((long)(0));
            this.lblSalutation.PerformLayoutEnabled = true;
            this.lblSalutation.PreviousFocusId = ((long)(0));
            this.lblSalutation.Size = new System.Drawing.Size(35, 13);
            this.lblSalutation.TabIndex = 3;
            this.lblSalutation.Text = "Salutation";
            // 
            // wstCustomer
            // 
            this.wstCustomer.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.wstCustomer.Controls.Add(this.tabContactInfo);
            this.wstCustomer.Controls.Add(this.tabLoyaltyProgramInfo);
            this.wstCustomer.ExcludeFromUniqueId = false;
            this.wstCustomer.Location = new System.Drawing.Point(7, 112);
            this.wstCustomer.Name = "wstCustomer";
            this.wstCustomer.NextFocusId = ((long)(0));
            this.wstCustomer.PerformLayoutEnabled = true;
            this.wstCustomer.PreviousFocusId = ((long)(0));
            this.wstCustomer.SelectedIndex = 0;
            this.wstCustomer.Size = new System.Drawing.Size(840, 469);
            this.wstCustomer.TabIndex = 11;
            // 
            // tabContactInfo
            // 
            this.tabContactInfo.Controls.Add(this.txtStreet);
            this.tabContactInfo.Controls.Add(this.lblStreet);
            this.tabContactInfo.Controls.Add(this.lblNumber);
            this.tabContactInfo.Controls.Add(this.txtNumber);
            this.tabContactInfo.Controls.Add(this.lblBox);
            this.tabContactInfo.Controls.Add(this.txtBox);
            this.tabContactInfo.Controls.Add(this.txtZip);
            this.tabContactInfo.Controls.Add(this.lblZipCity);
            this.tabContactInfo.Controls.Add(this.txtCity);
            this.tabContactInfo.Controls.Add(this.cmbCountry);
            this.tabContactInfo.Controls.Add(this.lblCountry);
            this.tabContactInfo.Controls.Add(this.txtMobilePhone);
            this.tabContactInfo.Controls.Add(this.lblMobilePhone);
            this.tabContactInfo.Controls.Add(this.txtPhone);
            this.tabContactInfo.Controls.Add(this.lblPhone);
            this.tabContactInfo.Controls.Add(this.txtMailAddress);
            this.tabContactInfo.Controls.Add(this.lblMailAddress);
            this.tabContactInfo.CustomStyle = "Workspace";
            this.tabContactInfo.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabContactInfo.ExcludeFromUniqueId = false;
            this.tabContactInfo.Location = new System.Drawing.Point(0, 0);
            this.tabContactInfo.Name = "tabContactInfo";
            this.tabContactInfo.NextFocusId = ((long)(0));
            this.tabContactInfo.PerformLayoutEnabled = true;
            this.tabContactInfo.PreviousFocusId = ((long)(0));
            this.tabContactInfo.Size = new System.Drawing.Size(832, 439);
            this.tabContactInfo.TabIndex = 0;
            this.tabContactInfo.Text = "Contact details";
            // 
            // txtStreet
            // 
            this.txtStreet.ExcludeFromUniqueId = false;
            this.txtStreet.Location = new System.Drawing.Point(127, 7);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.NextFocusId = ((long)(0));
            this.txtStreet.PerformLayoutEnabled = true;
            this.txtStreet.PreviousFocusId = ((long)(0));
            this.txtStreet.Size = new System.Drawing.Size(347, 20);
            this.txtStreet.TabIndex = 4;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.ExcludeFromUniqueId = false;
            this.lblStreet.Location = new System.Drawing.Point(5, 10);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.NextFocusId = ((long)(0));
            this.lblStreet.PerformLayoutEnabled = true;
            this.lblStreet.PreviousFocusId = ((long)(0));
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 1;
            this.lblStreet.Text = "Street";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.ExcludeFromUniqueId = false;
            this.lblNumber.Location = new System.Drawing.Point(490, 10);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.NextFocusId = ((long)(0));
            this.lblNumber.PerformLayoutEnabled = true;
            this.lblNumber.PreviousFocusId = ((long)(0));
            this.lblNumber.Size = new System.Drawing.Size(35, 13);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Number";
            // 
            // txtNumber
            // 
            this.txtNumber.ExcludeFromUniqueId = false;
            this.txtNumber.Location = new System.Drawing.Point(552, 7);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.NextFocusId = ((long)(0));
            this.txtNumber.PerformLayoutEnabled = true;
            this.txtNumber.PreviousFocusId = ((long)(0));
            this.txtNumber.Size = new System.Drawing.Size(73, 20);
            this.txtNumber.TabIndex = 5;
            // 
            // lblBox
            // 
            this.lblBox.AutoSize = true;
            this.lblBox.ExcludeFromUniqueId = false;
            this.lblBox.Location = new System.Drawing.Point(645, 10);
            this.lblBox.Name = "lblBox";
            this.lblBox.NextFocusId = ((long)(0));
            this.lblBox.PerformLayoutEnabled = true;
            this.lblBox.PreviousFocusId = ((long)(0));
            this.lblBox.Size = new System.Drawing.Size(35, 13);
            this.lblBox.TabIndex = 6;
            this.lblBox.Text = "Box";
            // 
            // txtBox
            // 
            this.txtBox.ExcludeFromUniqueId = false;
            this.txtBox.Location = new System.Drawing.Point(686, 7);
            this.txtBox.Name = "txtBox";
            this.txtBox.NextFocusId = ((long)(0));
            this.txtBox.PerformLayoutEnabled = true;
            this.txtBox.PreviousFocusId = ((long)(0));
            this.txtBox.Size = new System.Drawing.Size(62, 20);
            this.txtBox.TabIndex = 7;
            // 
            // txtZip
            // 
            this.txtZip.ExcludeFromUniqueId = false;
            this.txtZip.Location = new System.Drawing.Point(127, 33);
            this.txtZip.Name = "txtZip";
            this.txtZip.NextFocusId = ((long)(0));
            this.txtZip.PerformLayoutEnabled = true;
            this.txtZip.PreviousFocusId = ((long)(0));
            this.txtZip.Size = new System.Drawing.Size(121, 20);
            this.txtZip.TabIndex = 8;
            // 
            // lblZipCity
            // 
            this.lblZipCity.AutoSize = true;
            this.lblZipCity.ExcludeFromUniqueId = false;
            this.lblZipCity.Location = new System.Drawing.Point(5, 36);
            this.lblZipCity.Name = "lblZipCity";
            this.lblZipCity.NextFocusId = ((long)(0));
            this.lblZipCity.PerformLayoutEnabled = true;
            this.lblZipCity.PreviousFocusId = ((long)(0));
            this.lblZipCity.Size = new System.Drawing.Size(35, 13);
            this.lblZipCity.TabIndex = 1;
            this.lblZipCity.Text = "Zip/City";
            // 
            // txtCity
            // 
            this.txtCity.ExcludeFromUniqueId = false;
            this.txtCity.Location = new System.Drawing.Point(254, 33);
            this.txtCity.Name = "txtCity";
            this.txtCity.NextFocusId = ((long)(0));
            this.txtCity.PerformLayoutEnabled = true;
            this.txtCity.PreviousFocusId = ((long)(0));
            this.txtCity.Size = new System.Drawing.Size(220, 20);
            this.txtCity.TabIndex = 9;
            // 
            // cmbCountry
            // 
            this.cmbCountry.ExcludeFromUniqueId = false;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(127, 59);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.NextFocusId = ((long)(0));
            this.cmbCountry.PerformLayoutEnabled = true;
            this.cmbCountry.PreviousFocusId = ((long)(0));
            this.cmbCountry.Size = new System.Drawing.Size(347, 21);
            this.cmbCountry.TabIndex = 10;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.ExcludeFromUniqueId = false;
            this.lblCountry.Location = new System.Drawing.Point(5, 62);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.NextFocusId = ((long)(0));
            this.lblCountry.PerformLayoutEnabled = true;
            this.lblCountry.PreviousFocusId = ((long)(0));
            this.lblCountry.Size = new System.Drawing.Size(35, 13);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "Country";
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.ExcludeFromUniqueId = false;
            this.txtMobilePhone.Location = new System.Drawing.Point(127, 138);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.NextFocusId = ((long)(0));
            this.txtMobilePhone.PerformLayoutEnabled = true;
            this.txtMobilePhone.PreviousFocusId = ((long)(0));
            this.txtMobilePhone.Size = new System.Drawing.Size(347, 20);
            this.txtMobilePhone.TabIndex = 13;
            // 
            // lblMobilePhone
            // 
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.ExcludeFromUniqueId = false;
            this.lblMobilePhone.Location = new System.Drawing.Point(5, 141);
            this.lblMobilePhone.Name = "lblMobilePhone";
            this.lblMobilePhone.NextFocusId = ((long)(0));
            this.lblMobilePhone.PerformLayoutEnabled = true;
            this.lblMobilePhone.PreviousFocusId = ((long)(0));
            this.lblMobilePhone.Size = new System.Drawing.Size(35, 13);
            this.lblMobilePhone.TabIndex = 1;
            this.lblMobilePhone.Text = "Mobile phone";
            // 
            // txtPhone
            // 
            this.txtPhone.ExcludeFromUniqueId = false;
            this.txtPhone.Location = new System.Drawing.Point(127, 112);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.NextFocusId = ((long)(0));
            this.txtPhone.PerformLayoutEnabled = true;
            this.txtPhone.PreviousFocusId = ((long)(0));
            this.txtPhone.Size = new System.Drawing.Size(347, 20);
            this.txtPhone.TabIndex = 12;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ExcludeFromUniqueId = false;
            this.lblPhone.Location = new System.Drawing.Point(5, 115);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.NextFocusId = ((long)(0));
            this.lblPhone.PerformLayoutEnabled = true;
            this.lblPhone.PreviousFocusId = ((long)(0));
            this.lblPhone.Size = new System.Drawing.Size(35, 13);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone";
            // 
            // txtMailAddress
            // 
            this.txtMailAddress.ExcludeFromUniqueId = false;
            this.txtMailAddress.Location = new System.Drawing.Point(127, 86);
            this.txtMailAddress.Name = "txtMailAddress";
            this.txtMailAddress.NextFocusId = ((long)(0));
            this.txtMailAddress.PerformLayoutEnabled = true;
            this.txtMailAddress.PreviousFocusId = ((long)(0));
            this.txtMailAddress.Size = new System.Drawing.Size(347, 20);
            this.txtMailAddress.TabIndex = 11;
            // 
            // lblMailAddress
            // 
            this.lblMailAddress.AutoSize = true;
            this.lblMailAddress.ExcludeFromUniqueId = false;
            this.lblMailAddress.Location = new System.Drawing.Point(5, 89);
            this.lblMailAddress.Name = "lblMailAddress";
            this.lblMailAddress.NextFocusId = ((long)(0));
            this.lblMailAddress.PerformLayoutEnabled = true;
            this.lblMailAddress.PreviousFocusId = ((long)(0));
            this.lblMailAddress.Size = new System.Drawing.Size(35, 13);
            this.lblMailAddress.TabIndex = 1;
            this.lblMailAddress.Text = "Mail address";
            // 
            // tabLoyaltyProgramInfo
            // 
            this.tabLoyaltyProgramInfo.Controls.Add(this.btnUsePoints);
            this.tabLoyaltyProgramInfo.Controls.Add(this.btnAddLoyaltyTransaction);
            this.tabLoyaltyProgramInfo.Controls.Add(this.wstLoyalty);
            this.tabLoyaltyProgramInfo.Controls.Add(this.txtLoyaltyCardNumber);
            this.tabLoyaltyProgramInfo.Controls.Add(this.lblLoyaltyCardNumber);
            this.tabLoyaltyProgramInfo.CustomStyle = "Workspace";
            this.tabLoyaltyProgramInfo.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabLoyaltyProgramInfo.ExcludeFromUniqueId = false;
            this.tabLoyaltyProgramInfo.Location = new System.Drawing.Point(0, 0);
            this.tabLoyaltyProgramInfo.Name = "tabLoyaltyProgramInfo";
            this.tabLoyaltyProgramInfo.NextFocusId = ((long)(0));
            this.tabLoyaltyProgramInfo.PerformLayoutEnabled = true;
            this.tabLoyaltyProgramInfo.PreviousFocusId = ((long)(0));
            this.tabLoyaltyProgramInfo.Size = new System.Drawing.Size(832, 439);
            this.tabLoyaltyProgramInfo.TabIndex = 1;
            this.tabLoyaltyProgramInfo.Text = "Loyalty program info";
            // 
            // btnUsePoints
            // 
            this.btnUsePoints.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnUsePoints.ExcludeFromUniqueId = false;
            this.btnUsePoints.Location = new System.Drawing.Point(648, 10);
            this.btnUsePoints.Name = "btnUsePoints";
            this.btnUsePoints.NextFocusId = ((long)(0));
            this.btnUsePoints.PerformLayoutEnabled = true;
            this.btnUsePoints.PreviousFocusId = ((long)(0));
            this.btnUsePoints.Size = new System.Drawing.Size(169, 23);
            this.btnUsePoints.TabIndex = 7;
            this.btnUsePoints.TabStop = false;
            this.btnUsePoints.Text = "Use points";
            this.btnUsePoints.Click += new System.EventHandler(this.btnUsePoints_Click);
            // 
            // btnAddLoyaltyTransaction
            // 
            this.btnAddLoyaltyTransaction.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnAddLoyaltyTransaction.ExcludeFromUniqueId = false;
            this.btnAddLoyaltyTransaction.Location = new System.Drawing.Point(648, 36);
            this.btnAddLoyaltyTransaction.Name = "btnAddLoyaltyTransaction";
            this.btnAddLoyaltyTransaction.NextFocusId = ((long)(0));
            this.btnAddLoyaltyTransaction.PerformLayoutEnabled = true;
            this.btnAddLoyaltyTransaction.PreviousFocusId = ((long)(0));
            this.btnAddLoyaltyTransaction.Size = new System.Drawing.Size(169, 23);
            this.btnAddLoyaltyTransaction.TabIndex = 7;
            this.btnAddLoyaltyTransaction.TabStop = false;
            this.btnAddLoyaltyTransaction.Text = "Add loyalty transaction";
            this.btnAddLoyaltyTransaction.Click += new System.EventHandler(this.btnAddLoyaltyTransaction_Click);
            // 
            // wstLoyalty
            // 
            this.wstLoyalty.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.wstLoyalty.Controls.Add(this.tabBalance);
            this.wstLoyalty.Controls.Add(this.tabTransactions);
            this.wstLoyalty.ExcludeFromUniqueId = false;
            this.wstLoyalty.Location = new System.Drawing.Point(7, 59);
            this.wstLoyalty.Name = "wstLoyalty";
            this.wstLoyalty.NextFocusId = ((long)(0));
            this.wstLoyalty.PerformLayoutEnabled = true;
            this.wstLoyalty.PreviousFocusId = ((long)(0));
            this.wstLoyalty.SelectedIndex = 0;
            this.wstLoyalty.Size = new System.Drawing.Size(814, 373);
            this.wstLoyalty.TabIndex = 6;
            // 
            // tabBalance
            // 
            this.tabBalance.Controls.Add(this.dgvLoyaltyBalances);
            this.tabBalance.Controls.Add(this.pnlTopBalanceOverview);
            this.tabBalance.CustomStyle = "Workspace";
            this.tabBalance.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabBalance.ExcludeFromUniqueId = false;
            this.tabBalance.Location = new System.Drawing.Point(0, 0);
            this.tabBalance.Name = "tabBalance";
            this.tabBalance.NextFocusId = ((long)(0));
            this.tabBalance.PerformLayoutEnabled = true;
            this.tabBalance.PreviousFocusId = ((long)(0));
            this.tabBalance.Size = new System.Drawing.Size(806, 342);
            this.tabBalance.TabIndex = 0;
            this.tabBalance.Text = "Balance overview";
            // 
            // dgvLoyaltyBalances
            // 
            this.dgvLoyaltyBalances.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.clmBalanceOverviewPartner,
            this.clmBalanceOverviewPoints});
            this.dgvLoyaltyBalances.DisableNavigation = true;
            this.dgvLoyaltyBalances.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgvLoyaltyBalances.ExcludeFromUniqueId = false;
            this.dgvLoyaltyBalances.Location = new System.Drawing.Point(0, 34);
            this.dgvLoyaltyBalances.Name = "dgvLoyaltyBalances";
            this.dgvLoyaltyBalances.NextFocusId = ((long)(0));
            this.dgvLoyaltyBalances.PerformLayoutEnabled = true;
            this.dgvLoyaltyBalances.PreviousFocusId = ((long)(0));
            this.dgvLoyaltyBalances.RenderCellPanelsAsText = false;
            this.dgvLoyaltyBalances.RowTemplate.Enabled = true;
            this.dgvLoyaltyBalances.Size = new System.Drawing.Size(806, 313);
            this.dgvLoyaltyBalances.TabIndex = 0;
            // 
            // clmBalanceOverviewPartner
            // 
            this.clmBalanceOverviewPartner.DataPropertyName = "PartnerName";
            this.clmBalanceOverviewPartner.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmBalanceOverviewPartner.HeaderText = "Partner";
            this.clmBalanceOverviewPartner.Name = "clmBalanceOverviewPartner";
            // 
            // clmBalanceOverviewPoints
            // 
            this.clmBalanceOverviewPoints.DataPropertyName = "PointsText";
            this.clmBalanceOverviewPoints.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmBalanceOverviewPoints.FillWeight = 20F;
            this.clmBalanceOverviewPoints.HeaderText = "Points";
            this.clmBalanceOverviewPoints.Name = "clmBalanceOverviewPoints";
            // 
            // pnlTopBalanceOverview
            // 
            this.pnlTopBalanceOverview.Controls.Add(this.txtTotalBalance);
            this.pnlTopBalanceOverview.Controls.Add(this.lblTotalBalance);
            this.pnlTopBalanceOverview.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTopBalanceOverview.ExcludeFromUniqueId = false;
            this.pnlTopBalanceOverview.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBalanceOverview.Name = "pnlTopBalanceOverview";
            this.pnlTopBalanceOverview.NextFocusId = ((long)(0));
            this.pnlTopBalanceOverview.PerformLayoutEnabled = true;
            this.pnlTopBalanceOverview.PreviousFocusId = ((long)(0));
            this.pnlTopBalanceOverview.Size = new System.Drawing.Size(806, 34);
            this.pnlTopBalanceOverview.TabIndex = 0;
            // 
            // txtTotalBalance
            // 
            this.txtTotalBalance.ExcludeFromUniqueId = false;
            this.txtTotalBalance.Location = new System.Drawing.Point(116, 7);
            this.txtTotalBalance.Name = "txtTotalBalance";
            this.txtTotalBalance.NextFocusId = ((long)(0));
            this.txtTotalBalance.PerformLayoutEnabled = true;
            this.txtTotalBalance.PreviousFocusId = ((long)(0));
            this.txtTotalBalance.ReadOnly = true;
            this.txtTotalBalance.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBalance.TabIndex = 1;
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.ExcludeFromUniqueId = false;
            this.lblTotalBalance.Location = new System.Drawing.Point(5, 10);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.NextFocusId = ((long)(0));
            this.lblTotalBalance.PerformLayoutEnabled = true;
            this.lblTotalBalance.PreviousFocusId = ((long)(0));
            this.lblTotalBalance.Size = new System.Drawing.Size(35, 13);
            this.lblTotalBalance.TabIndex = 0;
            this.lblTotalBalance.Text = "Total balance:";
            // 
            // tabTransactions
            // 
            this.tabTransactions.Controls.Add(this.dgvLoyaltyTransactions);
            this.tabTransactions.CustomStyle = "Workspace";
            this.tabTransactions.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabTransactions.ExcludeFromUniqueId = false;
            this.tabTransactions.Location = new System.Drawing.Point(0, 0);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.NextFocusId = ((long)(0));
            this.tabTransactions.PerformLayoutEnabled = true;
            this.tabTransactions.PreviousFocusId = ((long)(0));
            this.tabTransactions.Size = new System.Drawing.Size(806, 343);
            this.tabTransactions.TabIndex = 1;
            this.tabTransactions.Text = "Transactions";
            // 
            // dgvLoyaltyTransactions
            // 
            this.dgvLoyaltyTransactions.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.clmTransactionDate,
            this.clmPointsOrigin,
            this.clmDestination,
            this.clmTransactionPoints,
            this.clmTransactionInfoText});
            this.dgvLoyaltyTransactions.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgvLoyaltyTransactions.ExcludeFromUniqueId = false;
            this.dgvLoyaltyTransactions.Location = new System.Drawing.Point(0, 0);
            this.dgvLoyaltyTransactions.Name = "dgvLoyaltyTransactions";
            this.dgvLoyaltyTransactions.NextFocusId = ((long)(0));
            this.dgvLoyaltyTransactions.PerformLayoutEnabled = true;
            this.dgvLoyaltyTransactions.PreviousFocusId = ((long)(0));
            this.dgvLoyaltyTransactions.RenderCellPanelsAsText = false;
            this.dgvLoyaltyTransactions.RowTemplate.Enabled = true;
            this.dgvLoyaltyTransactions.Size = new System.Drawing.Size(806, 310);
            this.dgvLoyaltyTransactions.TabIndex = 0;
            // 
            // clmTransactionDate
            // 
            this.clmTransactionDate.DataPropertyName = "TransactionDate";
            this.clmTransactionDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmTransactionDate.HeaderText = "Transaction date";
            this.clmTransactionDate.Name = "clmTransactionDate";
            // 
            // clmPointsOrigin
            // 
            this.clmPointsOrigin.DataPropertyName = "Origin";
            this.clmPointsOrigin.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmPointsOrigin.FillWeight = 200F;
            this.clmPointsOrigin.HeaderText = "Origin";
            this.clmPointsOrigin.Name = "clmPointsOrigin";
            // 
            // clmDestination
            // 
            this.clmDestination.DataPropertyName = "Destination";
            this.clmDestination.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmDestination.FillWeight = 200F;
            this.clmDestination.HeaderText = "Destination";
            this.clmDestination.Name = "clmDestination";
            // 
            // clmTransactionPoints
            // 
            this.clmTransactionPoints.DataPropertyName = "Points";
            this.clmTransactionPoints.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmTransactionPoints.HeaderText = "Points";
            this.clmTransactionPoints.Name = "clmTransactionPoints";
            // 
            // clmTransactionInfoText
            // 
            this.clmTransactionInfoText.DataPropertyName = "Info";
            this.clmTransactionInfoText.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmTransactionInfoText.FillWeight = 300F;
            this.clmTransactionInfoText.HeaderText = "Remarks";
            this.clmTransactionInfoText.Name = "clmTransactionInfoText";
            // 
            // txtLoyaltyCardNumber
            // 
            this.txtLoyaltyCardNumber.ExcludeFromUniqueId = false;
            this.txtLoyaltyCardNumber.Location = new System.Drawing.Point(127, 7);
            this.txtLoyaltyCardNumber.Name = "txtLoyaltyCardNumber";
            this.txtLoyaltyCardNumber.NextFocusId = ((long)(0));
            this.txtLoyaltyCardNumber.PerformLayoutEnabled = true;
            this.txtLoyaltyCardNumber.PreviousFocusId = ((long)(0));
            this.txtLoyaltyCardNumber.Size = new System.Drawing.Size(183, 20);
            this.txtLoyaltyCardNumber.TabIndex = 4;
            // 
            // lblLoyaltyCardNumber
            // 
            this.lblLoyaltyCardNumber.AutoSize = true;
            this.lblLoyaltyCardNumber.ExcludeFromUniqueId = false;
            this.lblLoyaltyCardNumber.Location = new System.Drawing.Point(5, 10);
            this.lblLoyaltyCardNumber.Name = "lblLoyaltyCardNumber";
            this.lblLoyaltyCardNumber.NextFocusId = ((long)(0));
            this.lblLoyaltyCardNumber.PerformLayoutEnabled = true;
            this.lblLoyaltyCardNumber.PreviousFocusId = ((long)(0));
            this.lblLoyaltyCardNumber.Size = new System.Drawing.Size(35, 13);
            this.lblLoyaltyCardNumber.TabIndex = 1;
            this.lblLoyaltyCardNumber.Text = "Loyalty cardnumber";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "";
            this.dtpBirthDate.ExcludeFromUniqueId = false;
            this.dtpBirthDate.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.IsEmpty = false;
            this.dtpBirthDate.IsEmptyAllowed = false;
            this.dtpBirthDate.Location = new System.Drawing.Point(138, 81);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.NextFocusId = ((long)(0));
            this.dtpBirthDate.PerformLayoutEnabled = true;
            this.dtpBirthDate.PreviousFocusId = ((long)(0));
            this.dtpBirthDate.Size = new System.Drawing.Size(121, 21);
            this.dtpBirthDate.TabIndex = 3;
            this.dtpBirthDate.Value = new System.DateTime(2018, 6, 19, 0, 0, 0, 0);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.ExcludeFromUniqueId = false;
            this.lblBirthDate.Location = new System.Drawing.Point(4, 84);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.NextFocusId = ((long)(0));
            this.lblBirthDate.PerformLayoutEnabled = true;
            this.lblBirthDate.PreviousFocusId = ((long)(0));
            this.lblBirthDate.Size = new System.Drawing.Size(35, 13);
            this.lblBirthDate.TabIndex = 12;
            this.lblBirthDate.Text = "Birthdate";
            // 
            // CustomerForm
            // 
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.wstCustomer);
            this.Controls.Add(this.lblSalutation);
            this.Controls.Add(this.cmbSalutation);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Size = new System.Drawing.Size(856, 584);
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.wstCustomer)).EndInit();
            this.wstCustomer.ResumeLayout(false);
            this.tabContactInfo.ResumeLayout(false);
            this.tabLoyaltyProgramInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wstLoyalty)).EndInit();
            this.wstLoyalty.ResumeLayout(false);
            this.tabBalance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoyaltyBalances)).EndInit();
            this.pnlTopBalanceOverview.ResumeLayout(false);
            this.tabTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoyaltyTransactions)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Label lblName;
        private TextBox txtName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private ComboBox cmbSalutation;
        private Label lblSalutation;
        private WorkspaceTabs wstCustomer;
        private WorkspaceTab tabContactInfo;
        private TextBox txtMobilePhone;
        private Label lblMobilePhone;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtMailAddress;
        private Label lblMailAddress;
        private TextBox txtStreet;
        private Label lblStreet;
        private Label lblNumber;
        private TextBox txtNumber;
        private Label lblBox;
        private TextBox txtBox;
        private TextBox txtZip;
        private Label lblZipCity;
        private TextBox txtCity;
        private ComboBox cmbCountry;
        private Label lblCountry;
        private DateTimePicker dtpBirthDate;
        private Label lblBirthDate;
        private WorkspaceTab tabLoyaltyProgramInfo;
        private TextBox txtLoyaltyCardNumber;
        private Label lblLoyaltyCardNumber;
        private WorkspaceTabs wstLoyalty;
        private WorkspaceTab tabBalance;
        private DataGridView dgvLoyaltyBalances;
        private Panel pnlTopBalanceOverview;
        private Label lblTotalBalance;
        private TextBox txtTotalBalance;
        private DataGridViewTextBoxColumn clmBalanceOverviewPartner;
        private DataGridViewTextBoxColumn clmBalanceOverviewPoints;
        private WorkspaceTab tabTransactions;
        private DataGridView dgvLoyaltyTransactions;
        private DataGridViewTextBoxColumn clmTransactionDate;
        private DataGridViewTextBoxColumn clmPointsOrigin;
        private DataGridViewTextBoxColumn clmDestination;
        private DataGridViewTextBoxColumn clmTransactionPoints;
        private Button btnAddLoyaltyTransaction;
        private Button btnUsePoints;
        private DataGridViewTextBoxColumn clmTransactionInfoText;
    }
}