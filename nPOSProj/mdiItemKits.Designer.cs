namespace nPOSProj
{
    partial class mdiItemKits
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiItemKits));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxWholesalePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxRetailPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxEAN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.itemquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemeanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemretailpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemwholepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryitems1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.npos_dbDataSet = new nPOSProj.npos_dbDataSet();
            this.inventory_items1TableAdapter = new nPOSProj.npos_dbDataSetTableAdapters.inventory_items1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryitems1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemquantityDataGridViewTextBoxColumn,
            this.itemeanDataGridViewTextBoxColumn,
            this.kitnameDataGridViewTextBoxColumn,
            this.itemretailpriceDataGridViewTextBoxColumn,
            this.itemwholepriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryitems1BindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(4, 1);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(708, 175);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtBoxWholesalePrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxRetailPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxEAN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxQty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 108);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Kits";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(402, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxWholesalePrice
            // 
            this.txtBoxWholesalePrice.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtBoxWholesalePrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWholesalePrice.Location = new System.Drawing.Point(420, 39);
            this.txtBoxWholesalePrice.MaxLength = 15;
            this.txtBoxWholesalePrice.Name = "txtBoxWholesalePrice";
            this.txtBoxWholesalePrice.Size = new System.Drawing.Size(83, 23);
            this.txtBoxWholesalePrice.TabIndex = 9;
            this.txtBoxWholesalePrice.Text = "0.00";
            this.txtBoxWholesalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxWholesalePrice.TextChanged += new System.EventHandler(this.txtBoxWholesalePrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Wholesale Price";
            // 
            // txtBoxRetailPrice
            // 
            this.txtBoxRetailPrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtBoxRetailPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRetailPrice.Location = new System.Drawing.Point(420, 15);
            this.txtBoxRetailPrice.MaxLength = 15;
            this.txtBoxRetailPrice.Name = "txtBoxRetailPrice";
            this.txtBoxRetailPrice.Size = new System.Drawing.Size(83, 23);
            this.txtBoxRetailPrice.TabIndex = 7;
            this.txtBoxRetailPrice.Text = "0.00";
            this.txtBoxRetailPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxRetailPrice.TextChanged += new System.EventHandler(this.txtBoxRetailPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Retail Price";
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(86, 63);
            this.txtBoxDescription.MaxLength = 25;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(301, 23);
            this.txtBoxDescription.TabIndex = 5;
            this.txtBoxDescription.TextChanged += new System.EventHandler(this.txtBoxDescription_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // txtBoxEAN
            // 
            this.txtBoxEAN.Location = new System.Drawing.Point(86, 39);
            this.txtBoxEAN.MaxLength = 13;
            this.txtBoxEAN.Name = "txtBoxEAN";
            this.txtBoxEAN.Size = new System.Drawing.Size(223, 23);
            this.txtBoxEAN.TabIndex = 3;
            this.txtBoxEAN.TextChanged += new System.EventHandler(this.txtBoxEAN_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "EAN";
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.Location = new System.Drawing.Point(86, 15);
            this.txtBoxQty.MaxLength = 6;
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.Size = new System.Drawing.Size(46, 23);
            this.txtBoxQty.TabIndex = 1;
            this.txtBoxQty.TextChanged += new System.EventHandler(this.txtBoxQty_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Qty";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(521, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 108);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update/Delete Kits";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(98, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 80);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(6, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 80);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // itemquantityDataGridViewTextBoxColumn
            // 
            this.itemquantityDataGridViewTextBoxColumn.DataPropertyName = "item_quantity";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.itemquantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.itemquantityDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.itemquantityDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.itemquantityDataGridViewTextBoxColumn.Name = "itemquantityDataGridViewTextBoxColumn";
            this.itemquantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // itemeanDataGridViewTextBoxColumn
            // 
            this.itemeanDataGridViewTextBoxColumn.DataPropertyName = "item_ean";
            this.itemeanDataGridViewTextBoxColumn.HeaderText = "EAN";
            this.itemeanDataGridViewTextBoxColumn.MaxInputLength = 13;
            this.itemeanDataGridViewTextBoxColumn.Name = "itemeanDataGridViewTextBoxColumn";
            this.itemeanDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemeanDataGridViewTextBoxColumn.Width = 130;
            // 
            // kitnameDataGridViewTextBoxColumn
            // 
            this.kitnameDataGridViewTextBoxColumn.DataPropertyName = "kit_name";
            this.kitnameDataGridViewTextBoxColumn.HeaderText = "Description";
            this.kitnameDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.kitnameDataGridViewTextBoxColumn.Name = "kitnameDataGridViewTextBoxColumn";
            this.kitnameDataGridViewTextBoxColumn.Width = 260;
            // 
            // itemretailpriceDataGridViewTextBoxColumn
            // 
            this.itemretailpriceDataGridViewTextBoxColumn.DataPropertyName = "item_retail_price";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.itemretailpriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.itemretailpriceDataGridViewTextBoxColumn.HeaderText = "Retail Price";
            this.itemretailpriceDataGridViewTextBoxColumn.MaxInputLength = 15;
            this.itemretailpriceDataGridViewTextBoxColumn.Name = "itemretailpriceDataGridViewTextBoxColumn";
            // 
            // itemwholepriceDataGridViewTextBoxColumn
            // 
            this.itemwholepriceDataGridViewTextBoxColumn.DataPropertyName = "item_whole_price";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.itemwholepriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.itemwholepriceDataGridViewTextBoxColumn.HeaderText = "Wholesale Price";
            this.itemwholepriceDataGridViewTextBoxColumn.MaxInputLength = 15;
            this.itemwholepriceDataGridViewTextBoxColumn.Name = "itemwholepriceDataGridViewTextBoxColumn";
            this.itemwholepriceDataGridViewTextBoxColumn.Width = 122;
            // 
            // inventoryitems1BindingSource
            // 
            this.inventoryitems1BindingSource.DataMember = "inventory_items1";
            this.inventoryitems1BindingSource.DataSource = this.npos_dbDataSet;
            // 
            // npos_dbDataSet
            // 
            this.npos_dbDataSet.DataSetName = "npos_dbDataSet";
            this.npos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventory_items1TableAdapter
            // 
            this.inventory_items1TableAdapter.ClearBeforeFill = true;
            // 
            // mdiItemKits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 297);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "mdiItemKits";
            this.Text = "Item Kits";
            this.Load += new System.EventHandler(this.mditemKits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryitems1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private npos_dbDataSet npos_dbDataSet;
        private System.Windows.Forms.BindingSource inventoryitems1BindingSource;
        private npos_dbDataSetTableAdapters.inventory_items1TableAdapter inventory_items1TableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxRetailPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxEAN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxWholesalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemeanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemretailpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemwholepriceDataGridViewTextBoxColumn;

    }
}