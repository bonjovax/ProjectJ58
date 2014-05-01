﻿namespace nPOSProj
{
    partial class mdiUserAcc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiUserAcc));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkSystemAccess = new System.Windows.Forms.CheckBox();
            this.chkUserAccounts = new System.Windows.Forms.CheckBox();
            this.chkConfiguration = new System.Windows.Forms.CheckBox();
            this.chkGiftCards = new System.Windows.Forms.CheckBox();
            this.chkInventory = new System.Windows.Forms.CheckBox();
            this.chkReports = new System.Windows.Forms.CheckBox();
            this.chkCustomers = new System.Windows.Forms.CheckBox();
            this.chkSales = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxULastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxUMiddleName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxUFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxUUserName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxUUserID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column4,
            this.Column7});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(1, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 198);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "User ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "User Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "First Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Middle Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Last Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Last Login";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date and Time Created";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 300;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 207);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 174);
            this.tabControl1.TabIndex = 59;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtBoxLastName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtBoxMiddleName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtBoxFirstName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtBoxPassword);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtBoxUserName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtBoxUserID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(506, 148);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Account";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.Location = new System.Drawing.Point(408, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(47, 71);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(455, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 71);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(320, 54);
            this.txtBoxLastName.MaxLength = 50;
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(182, 21);
            this.txtBoxLastName.TabIndex = 4;
            this.txtBoxLastName.TextChanged += new System.EventHandler(this.txtBoxLastName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name";
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Location = new System.Drawing.Point(320, 32);
            this.txtBoxMiddleName.MaxLength = 50;
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(182, 21);
            this.txtBoxMiddleName.TabIndex = 3;
            this.txtBoxMiddleName.TextChanged += new System.EventHandler(this.txtBoxMiddleName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Middle Name";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(320, 10);
            this.txtBoxFirstName.MaxLength = 50;
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(182, 21);
            this.txtBoxFirstName.TabIndex = 2;
            this.txtBoxFirstName.TextChanged += new System.EventHandler(this.txtBoxFirstName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "First Name";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(71, 54);
            this.txtBoxPassword.MaxLength = 20;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(162, 21);
            this.txtBoxPassword.TabIndex = 1;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(71, 32);
            this.txtBoxUserName.MaxLength = 20;
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(162, 21);
            this.txtBoxUserName.TabIndex = 0;
            this.txtBoxUserName.TextChanged += new System.EventHandler(this.txtBoxUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // txtBoxUserID
            // 
            this.txtBoxUserID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserID.Location = new System.Drawing.Point(71, 10);
            this.txtBoxUserID.Name = "txtBoxUserID";
            this.txtBoxUserID.ReadOnly = true;
            this.txtBoxUserID.Size = new System.Drawing.Size(52, 21);
            this.txtBoxUserID.TabIndex = 56;
            this.txtBoxUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxUserID.TextChanged += new System.EventHandler(this.txtBoxUserID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.chkSystemAccess);
            this.tabPage2.Controls.Add(this.chkUserAccounts);
            this.tabPage2.Controls.Add(this.chkConfiguration);
            this.tabPage2.Controls.Add(this.chkGiftCards);
            this.tabPage2.Controls.Add(this.chkInventory);
            this.tabPage2.Controls.Add(this.chkReports);
            this.tabPage2.Controls.Add(this.chkCustomers);
            this.tabPage2.Controls.Add(this.chkSales);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(506, 148);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restrictions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(455, 76);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 71);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkSystemAccess
            // 
            this.chkSystemAccess.AutoSize = true;
            this.chkSystemAccess.Enabled = false;
            this.chkSystemAccess.Location = new System.Drawing.Point(19, 18);
            this.chkSystemAccess.Name = "chkSystemAccess";
            this.chkSystemAccess.Size = new System.Drawing.Size(127, 17);
            this.chkSystemAccess.TabIndex = 7;
            this.chkSystemAccess.Text = "** System Access **";
            this.chkSystemAccess.UseVisualStyleBackColor = true;
            this.chkSystemAccess.CheckedChanged += new System.EventHandler(this.chkSystemAccess_CheckedChanged);
            // 
            // chkUserAccounts
            // 
            this.chkUserAccounts.AutoSize = true;
            this.chkUserAccounts.Enabled = false;
            this.chkUserAccounts.Location = new System.Drawing.Point(152, 50);
            this.chkUserAccounts.Name = "chkUserAccounts";
            this.chkUserAccounts.Size = new System.Drawing.Size(95, 17);
            this.chkUserAccounts.TabIndex = 13;
            this.chkUserAccounts.Text = "User Accounts";
            this.chkUserAccounts.UseVisualStyleBackColor = true;
            this.chkUserAccounts.CheckedChanged += new System.EventHandler(this.chkUserAccounts_CheckedChanged);
            // 
            // chkConfiguration
            // 
            this.chkConfiguration.AutoSize = true;
            this.chkConfiguration.Enabled = false;
            this.chkConfiguration.Location = new System.Drawing.Point(152, 66);
            this.chkConfiguration.Name = "chkConfiguration";
            this.chkConfiguration.Size = new System.Drawing.Size(91, 17);
            this.chkConfiguration.TabIndex = 14;
            this.chkConfiguration.Text = "Configuration";
            this.chkConfiguration.UseVisualStyleBackColor = true;
            this.chkConfiguration.CheckedChanged += new System.EventHandler(this.chkConfiguration_CheckedChanged);
            // 
            // chkGiftCards
            // 
            this.chkGiftCards.AutoSize = true;
            this.chkGiftCards.Enabled = false;
            this.chkGiftCards.Location = new System.Drawing.Point(152, 34);
            this.chkGiftCards.Name = "chkGiftCards";
            this.chkGiftCards.Size = new System.Drawing.Size(74, 17);
            this.chkGiftCards.TabIndex = 12;
            this.chkGiftCards.Text = "Gift Cards";
            this.chkGiftCards.UseVisualStyleBackColor = true;
            this.chkGiftCards.CheckedChanged += new System.EventHandler(this.chkGiftCards_CheckedChanged);
            // 
            // chkInventory
            // 
            this.chkInventory.AutoSize = true;
            this.chkInventory.Enabled = false;
            this.chkInventory.Location = new System.Drawing.Point(19, 66);
            this.chkInventory.Name = "chkInventory";
            this.chkInventory.Size = new System.Drawing.Size(74, 17);
            this.chkInventory.TabIndex = 10;
            this.chkInventory.Text = "Inventory";
            this.chkInventory.UseVisualStyleBackColor = true;
            this.chkInventory.CheckedChanged += new System.EventHandler(this.chkInventory_CheckedChanged);
            // 
            // chkReports
            // 
            this.chkReports.AutoSize = true;
            this.chkReports.Enabled = false;
            this.chkReports.Location = new System.Drawing.Point(152, 18);
            this.chkReports.Name = "chkReports";
            this.chkReports.Size = new System.Drawing.Size(64, 17);
            this.chkReports.TabIndex = 11;
            this.chkReports.Text = "Reports";
            this.chkReports.UseVisualStyleBackColor = true;
            this.chkReports.CheckedChanged += new System.EventHandler(this.chkReports_CheckedChanged);
            // 
            // chkCustomers
            // 
            this.chkCustomers.AutoSize = true;
            this.chkCustomers.Enabled = false;
            this.chkCustomers.Location = new System.Drawing.Point(19, 50);
            this.chkCustomers.Name = "chkCustomers";
            this.chkCustomers.Size = new System.Drawing.Size(77, 17);
            this.chkCustomers.TabIndex = 9;
            this.chkCustomers.Text = "Customers";
            this.chkCustomers.UseVisualStyleBackColor = true;
            this.chkCustomers.CheckedChanged += new System.EventHandler(this.chkCustomers_CheckedChanged);
            // 
            // chkSales
            // 
            this.chkSales.AutoSize = true;
            this.chkSales.Enabled = false;
            this.chkSales.Location = new System.Drawing.Point(19, 34);
            this.chkSales.Name = "chkSales";
            this.chkSales.Size = new System.Drawing.Size(51, 17);
            this.chkSales.TabIndex = 8;
            this.chkSales.Text = "Sales";
            this.chkSales.UseVisualStyleBackColor = true;
            this.chkSales.CheckedChanged += new System.EventHandler(this.chkSales_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnUClear);
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.txtBoxULastName);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtBoxUMiddleName);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtBoxUFirstName);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtBoxUUserName);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtBoxUUserID);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(506, 148);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update & Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(356, 76);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 71);
            this.btnDelete.TabIndex = 61;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUClear
            // 
            this.btnUClear.Image = ((System.Drawing.Image)(resources.GetObject("btnUClear.Image")));
            this.btnUClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUClear.Location = new System.Drawing.Point(406, 76);
            this.btnUClear.Name = "btnUClear";
            this.btnUClear.Size = new System.Drawing.Size(47, 71);
            this.btnUClear.TabIndex = 20;
            this.btnUClear.Text = "Clear";
            this.btnUClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUClear.UseVisualStyleBackColor = true;
            this.btnUClear.Click += new System.EventHandler(this.btnUClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(453, 76);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 71);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBoxULastName
            // 
            this.txtBoxULastName.Location = new System.Drawing.Point(320, 54);
            this.txtBoxULastName.MaxLength = 50;
            this.txtBoxULastName.Name = "txtBoxULastName";
            this.txtBoxULastName.Size = new System.Drawing.Size(182, 21);
            this.txtBoxULastName.TabIndex = 19;
            this.txtBoxULastName.TextChanged += new System.EventHandler(this.txtBoxULastName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Last Name";
            // 
            // txtBoxUMiddleName
            // 
            this.txtBoxUMiddleName.Location = new System.Drawing.Point(320, 32);
            this.txtBoxUMiddleName.MaxLength = 50;
            this.txtBoxUMiddleName.Name = "txtBoxUMiddleName";
            this.txtBoxUMiddleName.Size = new System.Drawing.Size(182, 21);
            this.txtBoxUMiddleName.TabIndex = 18;
            this.txtBoxUMiddleName.TextChanged += new System.EventHandler(this.txtBoxUMiddleName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Middle Name";
            // 
            // txtBoxUFirstName
            // 
            this.txtBoxUFirstName.Location = new System.Drawing.Point(320, 10);
            this.txtBoxUFirstName.MaxLength = 50;
            this.txtBoxUFirstName.Name = "txtBoxUFirstName";
            this.txtBoxUFirstName.Size = new System.Drawing.Size(182, 21);
            this.txtBoxUFirstName.TabIndex = 17;
            this.txtBoxUFirstName.TextChanged += new System.EventHandler(this.txtBoxUFirstName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "First Name";
            // 
            // txtBoxUUserName
            // 
            this.txtBoxUUserName.Location = new System.Drawing.Point(71, 32);
            this.txtBoxUUserName.MaxLength = 20;
            this.txtBoxUUserName.Name = "txtBoxUUserName";
            this.txtBoxUUserName.Size = new System.Drawing.Size(162, 21);
            this.txtBoxUUserName.TabIndex = 16;
            this.txtBoxUUserName.TextChanged += new System.EventHandler(this.txtBoxUUserName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "User Name";
            // 
            // txtBoxUUserID
            // 
            this.txtBoxUUserID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUUserID.Location = new System.Drawing.Point(71, 10);
            this.txtBoxUUserID.Name = "txtBoxUUserID";
            this.txtBoxUUserID.ReadOnly = true;
            this.txtBoxUUserID.Size = new System.Drawing.Size(52, 21);
            this.txtBoxUUserID.TabIndex = 60;
            this.txtBoxUUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxUUserID.TextChanged += new System.EventHandler(this.txtBoxUUserID_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "User ID";
            // 
            // mdiUserAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 393);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mdiUserAcc";
            this.Text = "User Accounts";
            this.Load += new System.EventHandler(this.mdiUserAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMiddleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chkSales;
        private System.Windows.Forms.CheckBox chkInventory;
        private System.Windows.Forms.CheckBox chkReports;
        private System.Windows.Forms.CheckBox chkCustomers;
        private System.Windows.Forms.CheckBox chkUserAccounts;
        private System.Windows.Forms.CheckBox chkConfiguration;
        private System.Windows.Forms.CheckBox chkGiftCards;
        private System.Windows.Forms.CheckBox chkSystemAccess;
        private System.Windows.Forms.Button btnUClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxULastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxUMiddleName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxUFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxUUserName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxUUserID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnDelete;

    }
}