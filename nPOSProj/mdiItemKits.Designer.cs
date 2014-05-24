namespace nPOSProj
{
    partial class mditemKits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mditemKits));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.npos_dbDataSet = new nPOSProj.npos_dbDataSet();
            this.nposdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryitemskitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventory_items_kitTableAdapter = new nPOSProj.npos_dbDataSetTableAdapters.inventory_items_kitTableAdapter();
            this.kitidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemeanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nposdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryitemskitBindingSource)).BeginInit();
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
            this.kitidDataGridViewTextBoxColumn,
            this.kitqtyDataGridViewTextBoxColumn,
            this.stockcodeDataGridViewTextBoxColumn,
            this.itemeanDataGridViewTextBoxColumn,
            this.stocknameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryitemskitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(703, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // npos_dbDataSet
            // 
            this.npos_dbDataSet.DataSetName = "npos_dbDataSet";
            this.npos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nposdbDataSetBindingSource
            // 
            this.nposdbDataSetBindingSource.DataSource = this.npos_dbDataSet;
            this.nposdbDataSetBindingSource.Position = 0;
            // 
            // inventoryitemskitBindingSource
            // 
            this.inventoryitemskitBindingSource.DataMember = "inventory_items_kit";
            this.inventoryitemskitBindingSource.DataSource = this.nposdbDataSetBindingSource;
            // 
            // inventory_items_kitTableAdapter
            // 
            this.inventory_items_kitTableAdapter.ClearBeforeFill = true;
            // 
            // kitidDataGridViewTextBoxColumn
            // 
            this.kitidDataGridViewTextBoxColumn.DataPropertyName = "kit_id";
            this.kitidDataGridViewTextBoxColumn.HeaderText = "kit_id";
            this.kitidDataGridViewTextBoxColumn.Name = "kitidDataGridViewTextBoxColumn";
            this.kitidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitqtyDataGridViewTextBoxColumn
            // 
            this.kitqtyDataGridViewTextBoxColumn.DataPropertyName = "kit_qty";
            this.kitqtyDataGridViewTextBoxColumn.HeaderText = "kit_qty";
            this.kitqtyDataGridViewTextBoxColumn.Name = "kitqtyDataGridViewTextBoxColumn";
            this.kitqtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockcodeDataGridViewTextBoxColumn
            // 
            this.stockcodeDataGridViewTextBoxColumn.DataPropertyName = "stock_code";
            this.stockcodeDataGridViewTextBoxColumn.HeaderText = "stock_code";
            this.stockcodeDataGridViewTextBoxColumn.Name = "stockcodeDataGridViewTextBoxColumn";
            this.stockcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemeanDataGridViewTextBoxColumn
            // 
            this.itemeanDataGridViewTextBoxColumn.DataPropertyName = "item_ean";
            this.itemeanDataGridViewTextBoxColumn.HeaderText = "item_ean";
            this.itemeanDataGridViewTextBoxColumn.Name = "itemeanDataGridViewTextBoxColumn";
            this.itemeanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stocknameDataGridViewTextBoxColumn
            // 
            this.stocknameDataGridViewTextBoxColumn.DataPropertyName = "stock_name";
            this.stocknameDataGridViewTextBoxColumn.HeaderText = "stock_name";
            this.stocknameDataGridViewTextBoxColumn.Name = "stocknameDataGridViewTextBoxColumn";
            this.stocknameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mditemKits
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
            this.Name = "mditemKits";
            this.Text = "Item Kits";
            this.Load += new System.EventHandler(this.mditemKits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nposdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryitemskitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource nposdbDataSetBindingSource;
        private npos_dbDataSet npos_dbDataSet;
        private System.Windows.Forms.BindingSource inventoryitemskitBindingSource;
        private npos_dbDataSetTableAdapters.inventory_items_kitTableAdapter inventory_items_kitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemeanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocknameDataGridViewTextBoxColumn;
    }
}