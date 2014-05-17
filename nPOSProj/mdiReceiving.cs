using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace nPOSProj
{
    public partial class mdiReceiving : Form
    {
        private Conf.dbs dbcon = new Conf.dbs();
        private MySqlConnection con = new MySqlConnection();
        public mdiReceiving()
        {
            InitializeComponent();
        }

        private void getDataTable()
        {
            dbcon = new Conf.dbs();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            String connectionString = dbcon.getConnectionString();
            String query = "SELECT order_quantity AS a, order_suppliers_itemno AS b, order_uom AS c, order_description AS d, ";
            query += "order_unitcost AS e, order_amount AS f FROM po_order_list ";
            query += "WHERE po_no = ?po_no";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.SelectCommand.Parameters.AddWithValue("?po_no", dataGridView1.SelectedRows[0].Cells[0].Value);
                        adapter.Fill(dataTable);
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            dataGridView2.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5]);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            } // end using
        }

        private void mdiReceiving_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'npos_dbDataSet.po_order' table. You can move, or remove it, as needed.
            this.po_orderTableAdapter.FillByPending(this.npos_dbDataSet.po_order, Convert.ToDateTime(dateTimePicker1.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataTable();
            rdPONo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            rdSupplierCode.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            rdSupplierName.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'npos_dbDataSet.po_order' table. You can move, or remove it, as needed.
            this.po_orderTableAdapter.FillByPending(this.npos_dbDataSet.po_order, Convert.ToDateTime(dateTimePicker1.Text));
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxQty.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            rdStockCode.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            rdParticulars.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            txtBoxQty.ReadOnly = false;
        }

        private void rdPONo_TextChanged(object sender, EventArgs e)
        {
            if (rdPONo.Text != "" && rdStockCode.Text != "" && txtBoxQty.Text != "" && txtBoxQty.Text != "0" && txtBoxQty.Text != "00" && txtBoxQty.Text != "000" && txtBoxQty.Text != "0000" && txtBoxQty.Text != "00000" && txtBoxQty.Text != "000000" && txtBoxQty.Text != "0000000" && txtBoxQty.Text != "00000000")
            {
                btnImport.Enabled = true;
            }
            else
                btnImport.Enabled = false;
        }

        private void rdStockCode_TextChanged(object sender, EventArgs e)
        {
            if (rdPONo.Text != "" && rdStockCode.Text != "" && txtBoxQty.Text != "" && txtBoxQty.Text != "0" && txtBoxQty.Text != "00" && txtBoxQty.Text != "000" && txtBoxQty.Text != "0000" && txtBoxQty.Text != "00000" && txtBoxQty.Text != "000000" && txtBoxQty.Text != "0000000" && txtBoxQty.Text != "00000000")
            {
                btnImport.Enabled = true;
            }
            else
                btnImport.Enabled = false;
        }

        private void txtBoxQty_TextChanged(object sender, EventArgs e)
        {
            if (rdPONo.Text != "" && rdStockCode.Text != "" && txtBoxQty.Text != "" && txtBoxQty.Text != "0" && txtBoxQty.Text != "00" && txtBoxQty.Text != "000" && txtBoxQty.Text != "0000" && txtBoxQty.Text != "00000" && txtBoxQty.Text != "000000" && txtBoxQty.Text != "0000000" && txtBoxQty.Text != "00000000")
            {
                btnImport.Enabled = true;
            }
            else
                btnImport.Enabled = false;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            txtBoxQty.ReadOnly = true;
        }
    }
}