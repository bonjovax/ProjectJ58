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
    public partial class mKits : Form
    {
        private Conf.dbs dbcon = new Conf.dbs();
        private MySqlConnection con = new MySqlConnection();
        private String _ean;
        public mKits()
        {
            InitializeComponent();
        }

        public String Ean
        {
            get { return _ean; }
            set { _ean = value; }
        }

        private void getDataTableKits()
        {
            dbcon = new Conf.dbs();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            String connectionString = dbcon.getConnectionString();
            String query = "SELECT inventory_items_kit.kit_qty AS aa, inventory_stocks.stock_code AS a, inventory_stocks.stock_name AS b, inventory_stocks.stock_uom AS c, inventory_stocks.stock_selling_price AS d ";
            query += "FROM inventory_items_kit INNER JOIN inventory_stocks ON inventory_items_kit.stock_code = inventory_stocks.stock_code INNER JOIN inventory_items ON inventory_items_kit.item_ean = inventory_items.item_ean ";
            query += "WHERE (inventory_items_kit.item_ean = ?ean)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.SelectCommand.Parameters.AddWithValue("?ean", Ean);
                        adapter.Fill(dataTable);
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4]);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            } // end using
        }
        private void getDataTableItems()
        {
            dbcon = new Conf.dbs();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            String connectionString = dbcon.getConnectionString();
            String query = "SELECT inventory_stocks.stock_code AS a, inventory_items.item_ean AS b, inventory_stocks.stock_name AS c, ";
            query += "inventory_items.item_retail_price AS d, inventory_category.cat_description AS e ";
            query += "FROM inventory_items ";
            query += "INNER JOIN inventory_stocks ON inventory_items.stock_code = inventory_stocks.stock_code ";
            query += "INNER JOIN inventory_category ON inventory_stocks.stock_cat_code = inventory_category.cat_code ";
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
                            dataGridView2.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4]);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            } // end using
        }

        private void mKits_Load(object sender, EventArgs e)
        {
            getDataTableKits();
            getDataTableItems();
        }
    }
}
