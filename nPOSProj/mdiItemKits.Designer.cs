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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiItemKits));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.npos_dbDataSet = new nPOSProj.npos_dbDataSet();
            this.inventoryitems1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventory_items1TableAdapter = new nPOSProj.npos_dbDataSetTableAdapters.inventory_items1TableAdapter();
            this.itemquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemeanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemretailpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemwholepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryitems1BindingSource)).BeginInit();
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
            this.itemquantityDataGridViewTextBoxColumn,
            this.itemeanDataGridViewTextBoxColumn,
            this.kitnameDataGridViewTextBoxColumn,
            this.itemretailpriceDataGridViewTextBoxColumn,
            this.itemwholepriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryitems1BindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(4, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(708, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // npos_dbDataSet
            // 
            this.npos_dbDataSet.DataSetName = "npos_dbDataSet";
            this.npos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryitems1BindingSource
            // 
            this.inventoryitems1BindingSource.DataMember = "inventory_items1";
            this.inventoryitems1BindingSource.DataSource = this.npos_dbDataSet;
            // 
            // inventory_items1TableAdapter
            // 
            this.inventory_items1TableAdapter.ClearBeforeFill = true;
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
            // itemeanDataGridViewTextBoxColumn
            // 
            this.itemeanDataGridViewTextBoxColumn.DataPropertyName = "item_ean";
            this.itemeanDataGridViewTextBoxColumn.HeaderText = "EAN";
            this.itemeanDataGridViewTextBoxColumn.Name = "itemeanDataGridViewTextBoxColumn";
            this.itemeanDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemeanDataGridViewTextBoxColumn.Width = 130;
            // 
            // kitnameDataGridViewTextBoxColumn
            // 
            this.kitnameDataGridViewTextBoxColumn.DataPropertyName = "kit_name";
            this.kitnameDataGridViewTextBoxColumn.HeaderText = "Description";
            this.kitnameDataGridViewTextBoxColumn.Name = "kitnameDataGridViewTextBoxColumn";
            this.kitnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitnameDataGridViewTextBoxColumn.Width = 260;
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
            this.itemwholepriceDataGridViewTextBoxColumn.Width = 122;
            // 
            // mdiItemKits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 296);
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
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryitems1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private npos_dbDataSet npos_dbDataSet;
        private System.Windows.Forms.BindingSource inventoryitems1BindingSource;
        private npos_dbDataSetTableAdapters.inventory_items1TableAdapter inventory_items1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemeanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemretailpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemwholepriceDataGridViewTextBoxColumn;

    }
}