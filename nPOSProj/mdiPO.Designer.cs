﻿namespace nPOSProj
{
    partial class mdiPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiPO));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReprintPO = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.poorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.npos_dbDataSet = new nPOSProj.npos_dbDataSet();
            this.po_orderTableAdapter = new nPOSProj.npos_dbDataSetTableAdapters.po_orderTableAdapter();
            this.ponoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliercodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pototalamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poprintedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocarrierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potimerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(0, 1);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(69, 32);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Enabled = false;
            this.btnDuplicate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuplicate.Image = ((System.Drawing.Image)(resources.GetObject("btnDuplicate.Image")));
            this.btnDuplicate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuplicate.Location = new System.Drawing.Point(69, 1);
            this.btnDuplicate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(90, 32);
            this.btnDuplicate.TabIndex = 1;
            this.btnDuplicate.Text = "&Duplicate";
            this.btnDuplicate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuplicate.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(159, 1);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(62, 32);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(221, 1);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(301, 1);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
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
            this.poprintedDataGridViewTextBoxColumn,
            this.pocarrierDataGridViewTextBoxColumn,
            this.postatusDataGridViewTextBoxColumn,
            this.podaterDataGridViewTextBoxColumn,
            this.potimerDataGridViewTextBoxColumn,
            this.user_name});
            this.dataGridView1.DataSource = this.poorderBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(2, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(815, 496);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnReprintPO
            // 
            this.btnReprintPO.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprintPO.Image = ((System.Drawing.Image)(resources.GetObject("btnReprintPO.Image")));
            this.btnReprintPO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReprintPO.Location = new System.Drawing.Point(381, 1);
            this.btnReprintPO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReprintPO.Name = "btnReprintPO";
            this.btnReprintPO.Size = new System.Drawing.Size(103, 32);
            this.btnReprintPO.TabIndex = 6;
            this.btnReprintPO.Text = "&Reprint P.O";
            this.btnReprintPO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReprintPO.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(715, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 23);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            // ponoDataGridViewTextBoxColumn
            // 
            this.ponoDataGridViewTextBoxColumn.DataPropertyName = "po_no";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.ponoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ponoDataGridViewTextBoxColumn.HeaderText = "PO No";
            this.ponoDataGridViewTextBoxColumn.Name = "ponoDataGridViewTextBoxColumn";
            this.ponoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // podateDataGridViewTextBoxColumn
            // 
            this.podateDataGridViewTextBoxColumn.DataPropertyName = "po_date";
            this.podateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.podateDataGridViewTextBoxColumn.Name = "podateDataGridViewTextBoxColumn";
            this.podateDataGridViewTextBoxColumn.ReadOnly = true;
            this.podateDataGridViewTextBoxColumn.Width = 150;
            // 
            // potimeDataGridViewTextBoxColumn
            // 
            this.potimeDataGridViewTextBoxColumn.DataPropertyName = "po_time";
            this.potimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.potimeDataGridViewTextBoxColumn.Name = "potimeDataGridViewTextBoxColumn";
            this.potimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.potimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // suppliercodeDataGridViewTextBoxColumn
            // 
            this.suppliercodeDataGridViewTextBoxColumn.DataPropertyName = "supplier_code";
            this.suppliercodeDataGridViewTextBoxColumn.HeaderText = "Supplier Code";
            this.suppliercodeDataGridViewTextBoxColumn.Name = "suppliercodeDataGridViewTextBoxColumn";
            this.suppliercodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.suppliercodeDataGridViewTextBoxColumn.Width = 115;
            // 
            // suppliernameDataGridViewTextBoxColumn
            // 
            this.suppliernameDataGridViewTextBoxColumn.DataPropertyName = "supplier_name";
            this.suppliernameDataGridViewTextBoxColumn.HeaderText = "Supplier Name";
            this.suppliernameDataGridViewTextBoxColumn.Name = "suppliernameDataGridViewTextBoxColumn";
            this.suppliernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.suppliernameDataGridViewTextBoxColumn.Width = 200;
            // 
            // pototalamtDataGridViewTextBoxColumn
            // 
            this.pototalamtDataGridViewTextBoxColumn.DataPropertyName = "po_total_amt";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.pototalamtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.pototalamtDataGridViewTextBoxColumn.HeaderText = "Total Amount";
            this.pototalamtDataGridViewTextBoxColumn.Name = "pototalamtDataGridViewTextBoxColumn";
            this.pototalamtDataGridViewTextBoxColumn.ReadOnly = true;
            this.pototalamtDataGridViewTextBoxColumn.Width = 110;
            // 
            // poprintedDataGridViewTextBoxColumn
            // 
            this.poprintedDataGridViewTextBoxColumn.DataPropertyName = "po_printed";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.poprintedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.poprintedDataGridViewTextBoxColumn.HeaderText = "Printed";
            this.poprintedDataGridViewTextBoxColumn.Name = "poprintedDataGridViewTextBoxColumn";
            this.poprintedDataGridViewTextBoxColumn.ReadOnly = true;
            this.poprintedDataGridViewTextBoxColumn.Width = 50;
            // 
            // pocarrierDataGridViewTextBoxColumn
            // 
            this.pocarrierDataGridViewTextBoxColumn.DataPropertyName = "po_carrier";
            this.pocarrierDataGridViewTextBoxColumn.HeaderText = "Carrier";
            this.pocarrierDataGridViewTextBoxColumn.Name = "pocarrierDataGridViewTextBoxColumn";
            this.pocarrierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postatusDataGridViewTextBoxColumn
            // 
            this.postatusDataGridViewTextBoxColumn.DataPropertyName = "po_status";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.postatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.postatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.postatusDataGridViewTextBoxColumn.Name = "postatusDataGridViewTextBoxColumn";
            this.postatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.postatusDataGridViewTextBoxColumn.Width = 65;
            // 
            // podaterDataGridViewTextBoxColumn
            // 
            this.podaterDataGridViewTextBoxColumn.DataPropertyName = "po_date_r";
            this.podaterDataGridViewTextBoxColumn.HeaderText = "Date Received";
            this.podaterDataGridViewTextBoxColumn.Name = "podaterDataGridViewTextBoxColumn";
            this.podaterDataGridViewTextBoxColumn.ReadOnly = true;
            this.podaterDataGridViewTextBoxColumn.Width = 200;
            // 
            // potimerDataGridViewTextBoxColumn
            // 
            this.potimerDataGridViewTextBoxColumn.DataPropertyName = "po_time_r";
            this.potimerDataGridViewTextBoxColumn.HeaderText = "Time Received";
            this.potimerDataGridViewTextBoxColumn.Name = "potimerDataGridViewTextBoxColumn";
            this.potimerDataGridViewTextBoxColumn.Width = 200;
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "Encoder";
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            // 
            // mdiPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnReprintPO);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnDuplicate);
            this.Controls.Add(this.btnNew);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "mdiPO";
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.mdiPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private npos_dbDataSet npos_dbDataSet;
        private System.Windows.Forms.BindingSource poorderBindingSource;
        private npos_dbDataSetTableAdapters.po_orderTableAdapter po_orderTableAdapter;
        private System.Windows.Forms.Button btnReprintPO;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliercodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pototalamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poprintedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocarrierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potimerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
    }
}