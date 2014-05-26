namespace nPOSProj
{
    partial class mKits
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inventoryitemskitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.npos_dbDataSet = new nPOSProj.npos_dbDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxTQTY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxTDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxTEAN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inventory_items_kitTableAdapter = new nPOSProj.npos_dbDataSetTableAdapters.inventory_items_kitTableAdapter();
            this.kitqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockuomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryitemskitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitqtyDataGridViewTextBoxColumn,
            this.stockcodeDataGridViewTextBoxColumn,
            this.stocknameDataGridViewTextBoxColumn,
            this.stockuomDataGridViewTextBoxColumn,
            this.stock_selling_price});
            this.dataGridView1.DataSource = this.inventoryitemskitBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(750, 215);
            this.dataGridView1.TabIndex = 17;
            // 
            // inventoryitemskitBindingSource
            // 
            this.inventoryitemskitBindingSource.DataMember = "inventory_items_kit";
            this.inventoryitemskitBindingSource.DataSource = this.npos_dbDataSet;
            // 
            // npos_dbDataSet
            // 
            this.npos_dbDataSet.DataSetName = "npos_dbDataSet";
            this.npos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtBoxTQTY);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBoxTDesc);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtBoxTEAN);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(2, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 84);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transfer to Kits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 11);
            this.label8.TabIndex = 6;
            this.label8.Text = "Press Enter";
            // 
            // txtBoxTQTY
            // 
            this.txtBoxTQTY.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTQTY.Location = new System.Drawing.Point(37, 59);
            this.txtBoxTQTY.MaxLength = 6;
            this.txtBoxTQTY.Name = "txtBoxTQTY";
            this.txtBoxTQTY.ReadOnly = true;
            this.txtBoxTQTY.Size = new System.Drawing.Size(50, 21);
            this.txtBoxTQTY.TabIndex = 5;
            this.txtBoxTQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Qty";
            // 
            // txtBoxTDesc
            // 
            this.txtBoxTDesc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTDesc.Location = new System.Drawing.Point(37, 37);
            this.txtBoxTDesc.MaxLength = 50;
            this.txtBoxTDesc.Name = "txtBoxTDesc";
            this.txtBoxTDesc.ReadOnly = true;
            this.txtBoxTDesc.Size = new System.Drawing.Size(105, 21);
            this.txtBoxTDesc.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Desc.";
            // 
            // txtBoxTEAN
            // 
            this.txtBoxTEAN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTEAN.Location = new System.Drawing.Point(37, 15);
            this.txtBoxTEAN.MaxLength = 13;
            this.txtBoxTEAN.Name = "txtBoxTEAN";
            this.txtBoxTEAN.ReadOnly = true;
            this.txtBoxTEAN.Size = new System.Drawing.Size(105, 21);
            this.txtBoxTEAN.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "EAN";
            // 
            // inventory_items_kitTableAdapter
            // 
            this.inventory_items_kitTableAdapter.ClearBeforeFill = true;
            // 
            // kitqtyDataGridViewTextBoxColumn
            // 
            this.kitqtyDataGridViewTextBoxColumn.DataPropertyName = "kit_qty";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kitqtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.kitqtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.kitqtyDataGridViewTextBoxColumn.Name = "kitqtyDataGridViewTextBoxColumn";
            this.kitqtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitqtyDataGridViewTextBoxColumn.Width = 50;
            // 
            // stockcodeDataGridViewTextBoxColumn
            // 
            this.stockcodeDataGridViewTextBoxColumn.DataPropertyName = "stock_code";
            this.stockcodeDataGridViewTextBoxColumn.HeaderText = "Stock Code";
            this.stockcodeDataGridViewTextBoxColumn.Name = "stockcodeDataGridViewTextBoxColumn";
            this.stockcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockcodeDataGridViewTextBoxColumn.Width = 130;
            // 
            // stocknameDataGridViewTextBoxColumn
            // 
            this.stocknameDataGridViewTextBoxColumn.DataPropertyName = "stock_name";
            this.stocknameDataGridViewTextBoxColumn.HeaderText = "Description";
            this.stocknameDataGridViewTextBoxColumn.Name = "stocknameDataGridViewTextBoxColumn";
            this.stocknameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stocknameDataGridViewTextBoxColumn.Width = 270;
            // 
            // stockuomDataGridViewTextBoxColumn
            // 
            this.stockuomDataGridViewTextBoxColumn.DataPropertyName = "stock_uom";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stockuomDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.stockuomDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.stockuomDataGridViewTextBoxColumn.Name = "stockuomDataGridViewTextBoxColumn";
            this.stockuomDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockuomDataGridViewTextBoxColumn.Width = 130;
            // 
            // stock_selling_price
            // 
            this.stock_selling_price.DataPropertyName = "stock_selling_price";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.stock_selling_price.DefaultCellStyle = dataGridViewCellStyle4;
            this.stock_selling_price.HeaderText = "Selling Price";
            this.stock_selling_price.Name = "stock_selling_price";
            this.stock_selling_price.ReadOnly = true;
            this.stock_selling_price.Width = 125;
            // 
            // mKits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 529);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mKits";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.mKits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryitemskitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxTQTY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxTDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxTEAN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource inventoryitemskitBindingSource;
        private npos_dbDataSet npos_dbDataSet;
        private npos_dbDataSetTableAdapters.inventory_items_kitTableAdapter inventory_items_kitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockuomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_selling_price;
    }
}