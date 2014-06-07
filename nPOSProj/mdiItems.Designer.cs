namespace nPOSProj
{
    partial class mdiItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiItems));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemeanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemretailpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemwholepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.npos_dbDataSet = new nPOSProj.npos_dbDataSet();
            this.inventory_itemsTableAdapter = new nPOSProj.npos_dbDataSetTableAdapters.inventory_itemsTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.txtBoxWholesalePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxRPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBonxEAN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bcSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemquantityDataGridViewTextBoxColumn,
            this.stockcodeDataGridViewTextBoxColumn,
            this.itemeanDataGridViewTextBoxColumn,
            this.stocknameDataGridViewTextBoxColumn,
            this.itemretailpriceDataGridViewTextBoxColumn,
            this.itemwholepriceDataGridViewTextBoxColumn,
            this.catdescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryitemsBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(7, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Empty;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(816, 289);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // itemquantityDataGridViewTextBoxColumn
            // 
            this.itemquantityDataGridViewTextBoxColumn.DataPropertyName = "item_quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.itemquantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemquantityDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.itemquantityDataGridViewTextBoxColumn.Name = "itemquantityDataGridViewTextBoxColumn";
            this.itemquantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemquantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // stockcodeDataGridViewTextBoxColumn
            // 
            this.stockcodeDataGridViewTextBoxColumn.DataPropertyName = "stock_code";
            this.stockcodeDataGridViewTextBoxColumn.HeaderText = "Stock Code";
            this.stockcodeDataGridViewTextBoxColumn.Name = "stockcodeDataGridViewTextBoxColumn";
            this.stockcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockcodeDataGridViewTextBoxColumn.Width = 95;
            // 
            // itemeanDataGridViewTextBoxColumn
            // 
            this.itemeanDataGridViewTextBoxColumn.DataPropertyName = "item_ean";
            this.itemeanDataGridViewTextBoxColumn.HeaderText = "EAN";
            this.itemeanDataGridViewTextBoxColumn.Name = "itemeanDataGridViewTextBoxColumn";
            this.itemeanDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemeanDataGridViewTextBoxColumn.Width = 230;
            // 
            // stocknameDataGridViewTextBoxColumn
            // 
            this.stocknameDataGridViewTextBoxColumn.DataPropertyName = "stock_name";
            this.stocknameDataGridViewTextBoxColumn.HeaderText = "Description";
            this.stocknameDataGridViewTextBoxColumn.Name = "stocknameDataGridViewTextBoxColumn";
            this.stocknameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stocknameDataGridViewTextBoxColumn.Width = 330;
            // 
            // itemretailpriceDataGridViewTextBoxColumn
            // 
            this.itemretailpriceDataGridViewTextBoxColumn.DataPropertyName = "item_retail_price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.itemretailpriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemretailpriceDataGridViewTextBoxColumn.HeaderText = "Retail Price";
            this.itemretailpriceDataGridViewTextBoxColumn.Name = "itemretailpriceDataGridViewTextBoxColumn";
            this.itemretailpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemretailpriceDataGridViewTextBoxColumn.Width = 115;
            // 
            // itemwholepriceDataGridViewTextBoxColumn
            // 
            this.itemwholepriceDataGridViewTextBoxColumn.DataPropertyName = "item_whole_price";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.itemwholepriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.itemwholepriceDataGridViewTextBoxColumn.HeaderText = "Wholesale Price";
            this.itemwholepriceDataGridViewTextBoxColumn.Name = "itemwholepriceDataGridViewTextBoxColumn";
            this.itemwholepriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemwholepriceDataGridViewTextBoxColumn.Width = 123;
            // 
            // catdescriptionDataGridViewTextBoxColumn
            // 
            this.catdescriptionDataGridViewTextBoxColumn.DataPropertyName = "cat_description";
            this.catdescriptionDataGridViewTextBoxColumn.HeaderText = "Category";
            this.catdescriptionDataGridViewTextBoxColumn.Name = "catdescriptionDataGridViewTextBoxColumn";
            this.catdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.catdescriptionDataGridViewTextBoxColumn.Width = 175;
            // 
            // inventoryitemsBindingSource
            // 
            this.inventoryitemsBindingSource.DataMember = "inventory_items";
            this.inventoryitemsBindingSource.DataSource = this.npos_dbDataSet;
            // 
            // npos_dbDataSet
            // 
            this.npos_dbDataSet.DataSetName = "npos_dbDataSet";
            this.npos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventory_itemsTableAdapter
            // 
            this.inventory_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.txtBoxWholesalePrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxRPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBonxEAN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxQty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Information";
            // 
            // btnReturn
            // 
            this.btnReturn.Enabled = false;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(374, 87);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(62, 66);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUp
            // 
            this.btnUp.Enabled = false;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(436, 87);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(62, 66);
            this.btnUp.TabIndex = 8;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtBoxWholesalePrice
            // 
            this.txtBoxWholesalePrice.Location = new System.Drawing.Point(119, 99);
            this.txtBoxWholesalePrice.MaxLength = 10;
            this.txtBoxWholesalePrice.Name = "txtBoxWholesalePrice";
            this.txtBoxWholesalePrice.ReadOnly = true;
            this.txtBoxWholesalePrice.Size = new System.Drawing.Size(96, 23);
            this.txtBoxWholesalePrice.TabIndex = 7;
            this.txtBoxWholesalePrice.Text = "0.00";
            this.txtBoxWholesalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wholesale Price";
            // 
            // txtBoxRPrice
            // 
            this.txtBoxRPrice.Location = new System.Drawing.Point(119, 72);
            this.txtBoxRPrice.MaxLength = 10;
            this.txtBoxRPrice.Name = "txtBoxRPrice";
            this.txtBoxRPrice.ReadOnly = true;
            this.txtBoxRPrice.Size = new System.Drawing.Size(96, 23);
            this.txtBoxRPrice.TabIndex = 5;
            this.txtBoxRPrice.Text = "0.00";
            this.txtBoxRPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Retail Price";
            // 
            // txtBonxEAN
            // 
            this.txtBonxEAN.Location = new System.Drawing.Point(119, 45);
            this.txtBonxEAN.MaxLength = 13;
            this.txtBonxEAN.Name = "txtBonxEAN";
            this.txtBonxEAN.ReadOnly = true;
            this.txtBonxEAN.Size = new System.Drawing.Size(378, 23);
            this.txtBonxEAN.TabIndex = 3;
            this.txtBonxEAN.TextChanged += new System.EventHandler(this.txtBonxEAN_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "EAN/Code";
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQty.Location = new System.Drawing.Point(119, 18);
            this.txtBoxQty.MaxLength = 6;
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.ReadOnly = true;
            this.txtBoxQty.Size = new System.Drawing.Size(52, 23);
            this.txtBoxQty.TabIndex = 1;
            this.txtBoxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qty";
            // 
            // barcode
            // 
            this.barcode.BackColor = System.Drawing.Color.Transparent;
            this.barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcode.Location = new System.Drawing.Point(11, 20);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(250, 100);
            this.barcode.TabIndex = 14;
            this.barcode.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bcSave);
            this.groupBox2.Controls.Add(this.barcode);
            this.groupBox2.Location = new System.Drawing.Point(516, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 130);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barcode Section";
            // 
            // bcSave
            // 
            this.bcSave.Enabled = false;
            this.bcSave.Image = ((System.Drawing.Image)(resources.GetObject("bcSave.Image")));
            this.bcSave.Location = new System.Drawing.Point(267, 20);
            this.bcSave.Name = "bcSave";
            this.bcSave.Size = new System.Drawing.Size(33, 100);
            this.bcSave.TabIndex = 15;
            this.bcSave.UseVisualStyleBackColor = true;
            this.bcSave.Click += new System.EventHandler(this.bcSave_Click);
            // 
            // mdiItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "mdiItems";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.mdiItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private npos_dbDataSet npos_dbDataSet;
        private System.Windows.Forms.BindingSource inventoryitemsBindingSource;
        private npos_dbDataSetTableAdapters.inventory_itemsTableAdapter inventory_itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemeanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemretailpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemwholepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox barcode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox txtBoxWholesalePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxRPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBonxEAN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bcSave;
        private System.Windows.Forms.Button btnReturn;
    }
}