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
    public partial class frmDlgSearch : Form
    {
        private Conf.dbs dbcon = new Conf.dbs();
        private MySqlConnection con = new MySqlConnection();
        private bool selected = false;

        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        private String ean;

        public String Ean
        {
            get { return ean; }
            set { ean = value; }
        }

        public frmDlgSearch()
        {
            InitializeComponent();
        }

        private void getDataTable()
        {
            if (chKIKits.Checked == true)
            {
                dbcon = new Conf.dbs();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                String connectionString = dbcon.getConnectionString();
                String query = "SELECT item_ean, kit_name, item_whole_price, item_retail_price ";
                query += "FROM inventory_items ";
                query += "WHERE (is_kit = 1)";
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                    {
                        try
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3]);
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error" + ex);
                        }
                    }
                } // end using
            }
            else
            {
                dbcon = new Conf.dbs();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                String connectionString = dbcon.getConnectionString();
                String query = "SELECT inventory_items.item_ean, inventory_stocks.stock_name, inventory_items.item_whole_price, inventory_items.item_retail_price ";
                query += "FROM inventory_items INNER JOIN inventory_stocks ON inventory_items.stock_code = inventory_stocks.stock_code ";
                query += "WHERE (inventory_items.is_kit = 0)";
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                    {
                        try
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3]);
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error" + ex);
                        }
                    }
                } // end using
            }
        }

        private void frmDlgSearch_Load(object sender, EventArgs e)
        {
            Selected = false;
            getDataTable();
        }

        private void chKIKits_CheckedChanged(object sender, EventArgs e)
        {
            getDataTable();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Ean = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    Selected = true;
                    this.Close();
                    e.Handled = true;
                }
                catch (Exception)
                {
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Ean = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Selected = true;
            this.Close();
        }
    }
}