﻿namespace nPOSProj
{
    partial class mPOrder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mPOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.rdPOno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSupplierCode = new System.Windows.Forms.TextBox();
            this.txtBoxSupplierName = new System.Windows.Forms.TextBox();
            this.lAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxRemarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdOrderedBy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBoxWarehouse = new System.Windows.Forms.ComboBox();
            this.cBoxCourier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rdTotal = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxUOM = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxQty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxParticulars = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxStockCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.dgQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npos_dbDataSet = new nPOSProj.npos_dbDataSet();
            this.inventorywarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventory_warehouseTableAdapter = new nPOSProj.npos_dbDataSetTableAdapters.inventory_warehouseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorywarehouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "P.O No.:";
            // 
            // rdPOno
            // 
            this.rdPOno.BackColor = System.Drawing.Color.Khaki;
            this.rdPOno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPOno.Location = new System.Drawing.Point(70, 6);
            this.rdPOno.MaxLength = 10;
            this.rdPOno.Name = "rdPOno";
            this.rdPOno.ReadOnly = true;
            this.rdPOno.Size = new System.Drawing.Size(86, 23);
            this.rdPOno.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier";
            // 
            // txtBoxSupplierCode
            // 
            this.txtBoxSupplierCode.Location = new System.Drawing.Point(70, 37);
            this.txtBoxSupplierCode.MaxLength = 9;
            this.txtBoxSupplierCode.Name = "txtBoxSupplierCode";
            this.txtBoxSupplierCode.Size = new System.Drawing.Size(100, 23);
            this.txtBoxSupplierCode.TabIndex = 0;
            this.txtBoxSupplierCode.TextChanged += new System.EventHandler(this.txtBoxSupplierCode_TextChanged);
            this.txtBoxSupplierCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxSupplierCode_KeyDown);
            // 
            // txtBoxSupplierName
            // 
            this.txtBoxSupplierName.Location = new System.Drawing.Point(174, 37);
            this.txtBoxSupplierName.MaxLength = 100;
            this.txtBoxSupplierName.Name = "txtBoxSupplierName";
            this.txtBoxSupplierName.Size = new System.Drawing.Size(278, 23);
            this.txtBoxSupplierName.TabIndex = 1;
            this.txtBoxSupplierName.TextChanged += new System.EventHandler(this.txtBoxSupplierName_TextChanged);
            this.txtBoxSupplierName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxSupplierName_KeyDown);
            // 
            // lAddress
            // 
            this.lAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddress.Location = new System.Drawing.Point(70, 63);
            this.lAddress.Name = "lAddress";
            this.lAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lAddress.Size = new System.Drawing.Size(546, 23);
            this.lAddress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // dt
            // 
            this.dt.CustomFormat = "";
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt.Location = new System.Drawing.Point(70, 90);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(100, 23);
            this.dt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Remarks:";
            // 
            // txtBoxRemarks
            // 
            this.txtBoxRemarks.Location = new System.Drawing.Point(11, 146);
            this.txtBoxRemarks.Multiline = true;
            this.txtBoxRemarks.Name = "txtBoxRemarks";
            this.txtBoxRemarks.ReadOnly = true;
            this.txtBoxRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxRemarks.Size = new System.Drawing.Size(337, 64);
            this.txtBoxRemarks.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ordered by:";
            // 
            // rdOrderedBy
            // 
            this.rdOrderedBy.BackColor = System.Drawing.Color.Black;
            this.rdOrderedBy.ForeColor = System.Drawing.Color.White;
            this.rdOrderedBy.Location = new System.Drawing.Point(483, 90);
            this.rdOrderedBy.MaxLength = 20;
            this.rdOrderedBy.Name = "rdOrderedBy";
            this.rdOrderedBy.ReadOnly = true;
            this.rdOrderedBy.Size = new System.Drawing.Size(133, 23);
            this.rdOrderedBy.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Warehouse:";
            // 
            // cBoxWarehouse
            // 
            this.cBoxWarehouse.DataSource = this.inventorywarehouseBindingSource;
            this.cBoxWarehouse.DisplayMember = "warehouse_name";
            this.cBoxWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWarehouse.Enabled = false;
            this.cBoxWarehouse.FormattingEnabled = true;
            this.cBoxWarehouse.Location = new System.Drawing.Point(483, 115);
            this.cBoxWarehouse.Name = "cBoxWarehouse";
            this.cBoxWarehouse.Size = new System.Drawing.Size(133, 24);
            this.cBoxWarehouse.TabIndex = 5;
            this.cBoxWarehouse.SelectedIndexChanged += new System.EventHandler(this.cBoxWarehouse_SelectedIndexChanged);
            // 
            // cBoxCourier
            // 
            this.cBoxCourier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCourier.Enabled = false;
            this.cBoxCourier.FormattingEnabled = true;
            this.cBoxCourier.Items.AddRange(new object[] {
            "LBC",
            "JRS Express",
            "2GO",
            "Lite Ferries",
            "DHL",
            "FedEx",
            "Mersk",
            "FJP Shipping",
            "Oceanjet",
            "Cokaliong Shipping Lines",
            "Trans-Asia Shipping Lines",
            "Philippine Span Asia Carrier Corp"});
            this.cBoxCourier.Location = new System.Drawing.Point(483, 141);
            this.cBoxCourier.Name = "cBoxCourier";
            this.cBoxCourier.Size = new System.Drawing.Size(133, 24);
            this.cBoxCourier.TabIndex = 6;
            this.cBoxCourier.SelectedIndexChanged += new System.EventHandler(this.cBoxCourier_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Courier:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgQTY,
            this.stock_code,
            this.Unit,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 295);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(634, 215);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOk.Location = new System.Drawing.Point(524, 169);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(38, 48);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "&OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(562, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 48);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.rdTotal);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtBoxUnitPrice);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtBoxUOM);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtBoxQty);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtBoxParticulars);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBoxStockCode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 73);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Controller";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(550, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(30, 32);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(550, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 32);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rdTotal
            // 
            this.rdTotal.BackColor = System.Drawing.Color.Black;
            this.rdTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTotal.ForeColor = System.Drawing.Color.Lime;
            this.rdTotal.Location = new System.Drawing.Point(442, 16);
            this.rdTotal.Name = "rdTotal";
            this.rdTotal.ReadOnly = true;
            this.rdTotal.Size = new System.Drawing.Size(99, 23);
            this.rdTotal.TabIndex = 16;
            this.rdTotal.Text = "0.00";
            this.rdTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(579, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(27, 32);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtBoxUnitPrice
            // 
            this.txtBoxUnitPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUnitPrice.Location = new System.Drawing.Point(341, 16);
            this.txtBoxUnitPrice.Name = "txtBoxUnitPrice";
            this.txtBoxUnitPrice.ReadOnly = true;
            this.txtBoxUnitPrice.Size = new System.Drawing.Size(99, 23);
            this.txtBoxUnitPrice.TabIndex = 14;
            this.txtBoxUnitPrice.Text = "0.00";
            this.txtBoxUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxUnitPrice.TextChanged += new System.EventHandler(this.txtBoxUnitPrice_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(276, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Unit Price";
            // 
            // txtBoxUOM
            // 
            this.txtBoxUOM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUOM.Location = new System.Drawing.Point(387, 44);
            this.txtBoxUOM.Name = "txtBoxUOM";
            this.txtBoxUOM.ReadOnly = true;
            this.txtBoxUOM.Size = new System.Drawing.Size(155, 23);
            this.txtBoxUOM.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(352, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "UOM";
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQty.Location = new System.Drawing.Point(232, 16);
            this.txtBoxQty.MaxLength = 8;
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.ReadOnly = true;
            this.txtBoxQty.Size = new System.Drawing.Size(43, 23);
            this.txtBoxQty.TabIndex = 11;
            this.txtBoxQty.Text = "0";
            this.txtBoxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxQty.TextChanged += new System.EventHandler(this.txtBoxQty_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(203, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Qty";
            // 
            // txtBoxParticulars
            // 
            this.txtBoxParticulars.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxParticulars.Location = new System.Drawing.Point(84, 44);
            this.txtBoxParticulars.Name = "txtBoxParticulars";
            this.txtBoxParticulars.ReadOnly = true;
            this.txtBoxParticulars.Size = new System.Drawing.Size(263, 23);
            this.txtBoxParticulars.TabIndex = 13;
            this.txtBoxParticulars.TextChanged += new System.EventHandler(this.txtBoxParticulars_TextChanged);
            this.txtBoxParticulars.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxParticulars_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Particulars";
            // 
            // txtBoxStockCode
            // 
            this.txtBoxStockCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStockCode.Location = new System.Drawing.Point(84, 16);
            this.txtBoxStockCode.Name = "txtBoxStockCode";
            this.txtBoxStockCode.ReadOnly = true;
            this.txtBoxStockCode.Size = new System.Drawing.Size(117, 23);
            this.txtBoxStockCode.TabIndex = 10;
            this.txtBoxStockCode.TextChanged += new System.EventHandler(this.txtBoxStockCode_TextChanged);
            this.txtBoxStockCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxStockCode_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Stock Code";
            // 
            // btnProceed
            // 
            this.btnProceed.Enabled = false;
            this.btnProceed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.Location = new System.Drawing.Point(456, 37);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.Text = "&Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // dgQTY
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgQTY.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgQTY.HeaderText = "Qty";
            this.dgQTY.Name = "dgQTY";
            this.dgQTY.ReadOnly = true;
            this.dgQTY.Width = 40;
            // 
            // stock_code
            // 
            this.stock_code.HeaderText = "Stock Code";
            this.stock_code.Name = "stock_code";
            this.stock_code.ReadOnly = true;
            this.stock_code.Width = 95;
            // 
            // Unit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Unit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Unit.HeaderText = "UOM";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Particulars";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Unit Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 90;
            // 
            // npos_dbDataSet
            // 
            this.npos_dbDataSet.DataSetName = "npos_dbDataSet";
            this.npos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventorywarehouseBindingSource
            // 
            this.inventorywarehouseBindingSource.DataMember = "inventory_warehouse";
            this.inventorywarehouseBindingSource.DataSource = this.npos_dbDataSet;
            // 
            // inventory_warehouseTableAdapter
            // 
            this.inventory_warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // mPOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 510);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cBoxCourier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBoxWarehouse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdOrderedBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxRemarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.txtBoxSupplierName);
            this.Controls.Add(this.txtBoxSupplierCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdPOno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "mPOrder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.mPOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorywarehouseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rdPOno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSupplierCode;
        private System.Windows.Forms.TextBox txtBoxSupplierName;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxRemarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rdOrderedBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBoxWarehouse;
        private System.Windows.Forms.ComboBox cBoxCourier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBoxUnitPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxUOM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxParticulars;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxStockCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TextBox rdTotal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private npos_dbDataSet npos_dbDataSet;
        private System.Windows.Forms.BindingSource inventorywarehouseBindingSource;
        private npos_dbDataSetTableAdapters.inventory_warehouseTableAdapter inventory_warehouseTableAdapter;
    }
}