namespace nPOSProj
{
    partial class mdiReceiving
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiReceiving));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ponoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliercodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pototalamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poprintedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocarrierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.npos_dbDataSet = new nPOSProj.npos_dbDataSet();
            this.po_orderTableAdapter = new nPOSProj.npos_dbDataSetTableAdapters.po_orderTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtBoxQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdParticulars = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdStockCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdSupplierName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdSupplierCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdPONo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ponoDataGridViewTextBoxColumn,
            this.podateDataGridViewTextBoxColumn,
            this.potimeDataGridViewTextBoxColumn,
            this.suppliercodeDataGridViewTextBoxColumn,
            this.suppliernameDataGridViewTextBoxColumn,
            this.pototalamtDataGridViewTextBoxColumn,
            this.postatusDataGridViewTextBoxColumn,
            this.poprintedDataGridViewTextBoxColumn,
            this.powarehouseDataGridViewTextBoxColumn,
            this.pocarrierDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.poorderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 252);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ponoDataGridViewTextBoxColumn
            // 
            this.ponoDataGridViewTextBoxColumn.DataPropertyName = "po_no";
            this.ponoDataGridViewTextBoxColumn.HeaderText = "PO No";
            this.ponoDataGridViewTextBoxColumn.Name = "ponoDataGridViewTextBoxColumn";
            this.ponoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ponoDataGridViewTextBoxColumn.Width = 75;
            // 
            // podateDataGridViewTextBoxColumn
            // 
            this.podateDataGridViewTextBoxColumn.DataPropertyName = "po_date";
            this.podateDataGridViewTextBoxColumn.HeaderText = "Ordered Date";
            this.podateDataGridViewTextBoxColumn.Name = "podateDataGridViewTextBoxColumn";
            this.podateDataGridViewTextBoxColumn.ReadOnly = true;
            this.podateDataGridViewTextBoxColumn.Width = 135;
            // 
            // potimeDataGridViewTextBoxColumn
            // 
            this.potimeDataGridViewTextBoxColumn.DataPropertyName = "po_time";
            this.potimeDataGridViewTextBoxColumn.HeaderText = "Ordered Time";
            this.potimeDataGridViewTextBoxColumn.Name = "potimeDataGridViewTextBoxColumn";
            this.potimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.potimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // suppliercodeDataGridViewTextBoxColumn
            // 
            this.suppliercodeDataGridViewTextBoxColumn.DataPropertyName = "supplier_code";
            this.suppliercodeDataGridViewTextBoxColumn.HeaderText = "Supplier Code";
            this.suppliercodeDataGridViewTextBoxColumn.Name = "suppliercodeDataGridViewTextBoxColumn";
            this.suppliercodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.suppliercodeDataGridViewTextBoxColumn.Width = 140;
            // 
            // suppliernameDataGridViewTextBoxColumn
            // 
            this.suppliernameDataGridViewTextBoxColumn.DataPropertyName = "supplier_name";
            this.suppliernameDataGridViewTextBoxColumn.HeaderText = "Supplier Name";
            this.suppliernameDataGridViewTextBoxColumn.Name = "suppliernameDataGridViewTextBoxColumn";
            this.suppliernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.suppliernameDataGridViewTextBoxColumn.Width = 300;
            // 
            // pototalamtDataGridViewTextBoxColumn
            // 
            this.pototalamtDataGridViewTextBoxColumn.DataPropertyName = "po_total_amt";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.pototalamtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.pototalamtDataGridViewTextBoxColumn.HeaderText = "Total Amount";
            this.pototalamtDataGridViewTextBoxColumn.Name = "pototalamtDataGridViewTextBoxColumn";
            this.pototalamtDataGridViewTextBoxColumn.ReadOnly = true;
            this.pototalamtDataGridViewTextBoxColumn.Width = 130;
            // 
            // postatusDataGridViewTextBoxColumn
            // 
            this.postatusDataGridViewTextBoxColumn.DataPropertyName = "po_status";
            this.postatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.postatusDataGridViewTextBoxColumn.Name = "postatusDataGridViewTextBoxColumn";
            this.postatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poprintedDataGridViewTextBoxColumn
            // 
            this.poprintedDataGridViewTextBoxColumn.DataPropertyName = "po_printed";
            this.poprintedDataGridViewTextBoxColumn.HeaderText = "Printed";
            this.poprintedDataGridViewTextBoxColumn.Name = "poprintedDataGridViewTextBoxColumn";
            this.poprintedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powarehouseDataGridViewTextBoxColumn
            // 
            this.powarehouseDataGridViewTextBoxColumn.DataPropertyName = "po_warehouse";
            this.powarehouseDataGridViewTextBoxColumn.HeaderText = "Warehouse";
            this.powarehouseDataGridViewTextBoxColumn.Name = "powarehouseDataGridViewTextBoxColumn";
            this.powarehouseDataGridViewTextBoxColumn.ReadOnly = true;
            this.powarehouseDataGridViewTextBoxColumn.Width = 300;
            // 
            // pocarrierDataGridViewTextBoxColumn
            // 
            this.pocarrierDataGridViewTextBoxColumn.DataPropertyName = "po_carrier";
            this.pocarrierDataGridViewTextBoxColumn.HeaderText = "Carrier";
            this.pocarrierDataGridViewTextBoxColumn.Name = "pocarrierDataGridViewTextBoxColumn";
            this.pocarrierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Encoded By";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poorderBindingSource
            // 
            this.poorderBindingSource.DataMember = "po_order";
            this.poorderBindingSource.DataSource = this.npos_dbDataSet;
            // 
            // npos_dbDataSet
            // 
            this.npos_dbDataSet.DataSetName = "npos_dbDataSet";
            this.npos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // po_orderTableAdapter
            // 
            this.po_orderTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.txtBoxQty);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rdParticulars);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdStockCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rdSupplierName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdSupplierCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdPONo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receiving Information";
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImport.Location = new System.Drawing.Point(386, 150);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(56, 68);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "&Import";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.Location = new System.Drawing.Point(104, 150);
            this.txtBoxQty.MaxLength = 8;
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.ReadOnly = true;
            this.txtBoxQty.Size = new System.Drawing.Size(43, 23);
            this.txtBoxQty.TabIndex = 13;
            this.txtBoxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxQty.TextChanged += new System.EventHandler(this.txtBoxQty_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Qty";
            // 
            // rdParticulars
            // 
            this.rdParticulars.BackColor = System.Drawing.Color.PaleGreen;
            this.rdParticulars.Location = new System.Drawing.Point(104, 124);
            this.rdParticulars.Name = "rdParticulars";
            this.rdParticulars.ReadOnly = true;
            this.rdParticulars.Size = new System.Drawing.Size(337, 23);
            this.rdParticulars.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Particulars";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "PO Date";
            // 
            // rdStockCode
            // 
            this.rdStockCode.BackColor = System.Drawing.Color.PaleGreen;
            this.rdStockCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdStockCode.Location = new System.Drawing.Point(104, 98);
            this.rdStockCode.Name = "rdStockCode";
            this.rdStockCode.ReadOnly = true;
            this.rdStockCode.Size = new System.Drawing.Size(108, 23);
            this.rdStockCode.TabIndex = 7;
            this.rdStockCode.TextChanged += new System.EventHandler(this.rdStockCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock Code";
            // 
            // rdSupplierName
            // 
            this.rdSupplierName.BackColor = System.Drawing.Color.Khaki;
            this.rdSupplierName.Location = new System.Drawing.Point(104, 72);
            this.rdSupplierName.Name = "rdSupplierName";
            this.rdSupplierName.ReadOnly = true;
            this.rdSupplierName.Size = new System.Drawing.Size(337, 23);
            this.rdSupplierName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Supplier Name";
            // 
            // rdSupplierCode
            // 
            this.rdSupplierCode.BackColor = System.Drawing.Color.Khaki;
            this.rdSupplierCode.Location = new System.Drawing.Point(104, 46);
            this.rdSupplierCode.Name = "rdSupplierCode";
            this.rdSupplierCode.ReadOnly = true;
            this.rdSupplierCode.Size = new System.Drawing.Size(94, 23);
            this.rdSupplierCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier Code";
            // 
            // rdPONo
            // 
            this.rdPONo.BackColor = System.Drawing.Color.Khaki;
            this.rdPONo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPONo.Location = new System.Drawing.Point(104, 20);
            this.rdPONo.Name = "rdPONo";
            this.rdPONo.ReadOnly = true;
            this.rdPONo.Size = new System.Drawing.Size(65, 23);
            this.rdPONo.TabIndex = 1;
            this.rdPONo.TextChanged += new System.EventHandler(this.rdPONo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PO No.:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgQTY,
            this.stock_code,
            this.Unit,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.Location = new System.Drawing.Point(456, 2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(564, 223);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dgQTY
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgQTY.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Unit.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column4.HeaderText = "Unit Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 227);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 23);
            this.dateTimePicker1.TabIndex = 37;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(278, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 23);
            this.dateTimePicker2.TabIndex = 38;
            // 
            // mdiReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 540);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "mdiReceiving";
            this.Text = "Receiving";
            this.Load += new System.EventHandler(this.mdiReceiving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource poorderBindingSource;
        private npos_dbDataSet npos_dbDataSet;
        private npos_dbDataSetTableAdapters.po_orderTableAdapter po_orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliercodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pototalamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poprintedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powarehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocarrierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox rdParticulars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rdStockCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rdSupplierName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rdSupplierCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox rdPONo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;

    }
}