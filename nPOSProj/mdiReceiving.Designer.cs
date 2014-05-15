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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiReceiving));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.npos_dbDataSet = new nPOSProj.npos_dbDataSet();
            this.poorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.po_orderTableAdapter = new nPOSProj.npos_dbDataSetTableAdapters.po_orderTableAdapter();
            this.ponoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliercodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pototalamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poprintedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocarrierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potimerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poorderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ponoDataGridViewTextBoxColumn,
            this.podateDataGridViewTextBoxColumn,
            this.potimeDataGridViewTextBoxColumn,
            this.suppliercodeDataGridViewTextBoxColumn,
            this.pototalamtDataGridViewTextBoxColumn,
            this.poprintedDataGridViewTextBoxColumn,
            this.pocarrierDataGridViewTextBoxColumn,
            this.postatusDataGridViewTextBoxColumn,
            this.podaterDataGridViewTextBoxColumn,
            this.potimerDataGridViewTextBoxColumn,
            this.suppliernameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.powarehouseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.poorderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(820, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // npos_dbDataSet
            // 
            this.npos_dbDataSet.DataSetName = "npos_dbDataSet";
            this.npos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poorderBindingSource
            // 
            this.poorderBindingSource.DataMember = "po_order";
            this.poorderBindingSource.DataSource = this.npos_dbDataSet;
            // 
            // po_orderTableAdapter
            // 
            this.po_orderTableAdapter.ClearBeforeFill = true;
            // 
            // ponoDataGridViewTextBoxColumn
            // 
            this.ponoDataGridViewTextBoxColumn.DataPropertyName = "po_no";
            this.ponoDataGridViewTextBoxColumn.HeaderText = "po_no";
            this.ponoDataGridViewTextBoxColumn.Name = "ponoDataGridViewTextBoxColumn";
            this.ponoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // podateDataGridViewTextBoxColumn
            // 
            this.podateDataGridViewTextBoxColumn.DataPropertyName = "po_date";
            this.podateDataGridViewTextBoxColumn.HeaderText = "po_date";
            this.podateDataGridViewTextBoxColumn.Name = "podateDataGridViewTextBoxColumn";
            this.podateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // potimeDataGridViewTextBoxColumn
            // 
            this.potimeDataGridViewTextBoxColumn.DataPropertyName = "po_time";
            this.potimeDataGridViewTextBoxColumn.HeaderText = "po_time";
            this.potimeDataGridViewTextBoxColumn.Name = "potimeDataGridViewTextBoxColumn";
            this.potimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suppliercodeDataGridViewTextBoxColumn
            // 
            this.suppliercodeDataGridViewTextBoxColumn.DataPropertyName = "supplier_code";
            this.suppliercodeDataGridViewTextBoxColumn.HeaderText = "supplier_code";
            this.suppliercodeDataGridViewTextBoxColumn.Name = "suppliercodeDataGridViewTextBoxColumn";
            this.suppliercodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pototalamtDataGridViewTextBoxColumn
            // 
            this.pototalamtDataGridViewTextBoxColumn.DataPropertyName = "po_total_amt";
            this.pototalamtDataGridViewTextBoxColumn.HeaderText = "po_total_amt";
            this.pototalamtDataGridViewTextBoxColumn.Name = "pototalamtDataGridViewTextBoxColumn";
            this.pototalamtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poprintedDataGridViewTextBoxColumn
            // 
            this.poprintedDataGridViewTextBoxColumn.DataPropertyName = "po_printed";
            this.poprintedDataGridViewTextBoxColumn.HeaderText = "po_printed";
            this.poprintedDataGridViewTextBoxColumn.Name = "poprintedDataGridViewTextBoxColumn";
            this.poprintedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pocarrierDataGridViewTextBoxColumn
            // 
            this.pocarrierDataGridViewTextBoxColumn.DataPropertyName = "po_carrier";
            this.pocarrierDataGridViewTextBoxColumn.HeaderText = "po_carrier";
            this.pocarrierDataGridViewTextBoxColumn.Name = "pocarrierDataGridViewTextBoxColumn";
            this.pocarrierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postatusDataGridViewTextBoxColumn
            // 
            this.postatusDataGridViewTextBoxColumn.DataPropertyName = "po_status";
            this.postatusDataGridViewTextBoxColumn.HeaderText = "po_status";
            this.postatusDataGridViewTextBoxColumn.Name = "postatusDataGridViewTextBoxColumn";
            this.postatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // podaterDataGridViewTextBoxColumn
            // 
            this.podaterDataGridViewTextBoxColumn.DataPropertyName = "po_date_r";
            this.podaterDataGridViewTextBoxColumn.HeaderText = "po_date_r";
            this.podaterDataGridViewTextBoxColumn.Name = "podaterDataGridViewTextBoxColumn";
            this.podaterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // potimerDataGridViewTextBoxColumn
            // 
            this.potimerDataGridViewTextBoxColumn.DataPropertyName = "po_time_r";
            this.potimerDataGridViewTextBoxColumn.HeaderText = "po_time_r";
            this.potimerDataGridViewTextBoxColumn.Name = "potimerDataGridViewTextBoxColumn";
            this.potimerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suppliernameDataGridViewTextBoxColumn
            // 
            this.suppliernameDataGridViewTextBoxColumn.DataPropertyName = "supplier_name";
            this.suppliernameDataGridViewTextBoxColumn.HeaderText = "supplier_name";
            this.suppliernameDataGridViewTextBoxColumn.Name = "suppliernameDataGridViewTextBoxColumn";
            this.suppliernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "user_name";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powarehouseDataGridViewTextBoxColumn
            // 
            this.powarehouseDataGridViewTextBoxColumn.DataPropertyName = "po_warehouse";
            this.powarehouseDataGridViewTextBoxColumn.HeaderText = "po_warehouse";
            this.powarehouseDataGridViewTextBoxColumn.Name = "powarehouseDataGridViewTextBoxColumn";
            this.powarehouseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mdiReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 532);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mdiReceiving";
            this.Text = "Receiving";
            this.Load += new System.EventHandler(this.mdiReceiving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poorderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliercodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pototalamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poprintedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocarrierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potimerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powarehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource poorderBindingSource;
        private npos_dbDataSet npos_dbDataSet;
        private npos_dbDataSetTableAdapters.po_orderTableAdapter po_orderTableAdapter;

    }
}