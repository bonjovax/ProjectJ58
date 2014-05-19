﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nPOSProj
{
    public partial class mdiPO : Form
    {
        public String DatePass { get; set; }
        
        public mdiPO()
        {
            InitializeComponent();
        }

        private void mdiPO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'npos_dbDataSet.po_order' table. You can move, or remove it, as needed.
            this.po_orderTableAdapter.Fill(this.npos_dbDataSet.po_order, Convert.ToDateTime(dateTimePicker1.Text));
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (mPOrder newPO = new mPOrder())
            {
                newPO.ShowDialog();
                var poDate = newPO.PurchaseOrderDate;
                this.po_orderTableAdapter.Fill(this.npos_dbDataSet.po_order, Convert.ToDateTime(poDate));
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.po_orderTableAdapter.Fill(this.npos_dbDataSet.po_order, Convert.ToDateTime(dateTimePicker1.Text));
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (mEditPO edit = new mEditPO())
            {
                edit.orderPO(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                edit.ShowDialog();
                var poDate = edit.PurchaseOrderDate;
                this.po_orderTableAdapter.Fill(this.npos_dbDataSet.po_order, Convert.ToDateTime(poDate));
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (mFilter filter = new mFilter())
            {
                filter.ShowDialog();
                var Warehouse = filter.Warehouse;
                var Supplier = filter.Supplier;
                if (Warehouse != "")
                {
                    this.po_orderTableAdapter.FillByWarehouse(this.npos_dbDataSet.po_order, Warehouse);
                }
                if (Supplier != "")
                {
                    this.po_orderTableAdapter.FillSupplierBy(this.npos_dbDataSet.po_order, Supplier);
                }
            }
        }
    }
}