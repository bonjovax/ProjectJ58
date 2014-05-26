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
            String query = "SELECT inventory_items_kit.kit_qty AS a, inventory_stocks.stock_code AS b, inventory_stocks.stock_name AS c, inventory_stocks.stock_uom AS d, inventory_stocks.stock_selling_price AS e ";
            query += "FROM inventory_items_kit INNER JOIN inventory_stocks ON inventory_items_kit.stock_code = inventory_stocks.stock_code INNER JOIN inventory_items ON inventory_items_kit.item_ean = inventory_items.item_ean ";
            query += "WHERE  (inventory_items_kit.item_ean = ?ean)";
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

        private void mKits_Load(object sender, EventArgs e)
        {
            getDataTableKits();
        }

        //private void autoComplete_EANKIT()
        //{
        //    con.ConnectionString = dbcon.getConnectionString();
        //    String sql = "SELECT DISTINCT item_ean FROM inventory_items WHERE is_kit = 1 ORDER BY item_ean ASC";
        //    try
        //    {
        //        con.Open();
        //        MySqlCommand cmd = new MySqlCommand(sql, con);
        //        cmd.CommandType = CommandType.Text;
        //        MySqlDataReader rdr = cmd.ExecuteReader();
        //        if (rdr.HasRows == true)
        //        {
        //            while (rdr.Read())
        //                collect.Add(rdr["item_ean"].ToString());
        //        }
        //        rdr.Close();
        //        txtBoxTEAN.AutoCompleteMode = AutoCompleteMode.Suggest;
        //        txtBoxTEAN.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //        txtBoxTEAN.AutoCompleteCustomSource = collect;
        //        con.Close();
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Please Check your Database Server Connection", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Application.ExitThread();
        //    }
        //}
        //private void autoComplete_KITNAME()
        //{
        //    con.ConnectionString = dbcon.getConnectionString();
        //    String sql = "SELECT DISTINCT kit_name FROM inventory_items WHERE is_kit = 1 ORDER BY kit_name ASC";
        //    try
        //    {
        //        con.Open();
        //        MySqlCommand cmd = new MySqlCommand(sql, con);
        //        cmd.CommandType = CommandType.Text;
        //        MySqlDataReader rdr = cmd.ExecuteReader();
        //        if (rdr.HasRows == true)
        //        {
        //            while (rdr.Read())
        //                collect1.Add(rdr["kit_name"].ToString());
        //        }
        //        rdr.Close();
        //        txtBoxTDesc.AutoCompleteMode = AutoCompleteMode.Suggest;
        //        txtBoxTDesc.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //        txtBoxTDesc.AutoCompleteCustomSource = collect1;
        //        con.Close();
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Please Check your Database Server Connection", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Application.ExitThread();
        //    }
        //}

        //private void checkIfValid()
        //{
        //    con.ConnectionString = dbcon.getConnectionString();
        //    String query = "SELECT * FROM inventory_items WHERE item_ean = ?item_ean AND kit_name = ?kit_name";
        //    try
        //    {
        //        con.Open();
        //        MySqlCommand cmd = new MySqlCommand(query, con);
        //        cmd.Parameters.AddWithValue("?item_ean", txtBoxTEAN.Text);
        //        cmd.Parameters.AddWithValue("?kit_name", txtBoxTDesc.Text);
        //        cmd.ExecuteScalar();
        //        MySqlDataReader rdr = cmd.ExecuteReader();
        //        if (rdr.Read())
        //        {
        //            txtBoxTQTY.ReadOnly = false;
        //        }
        //        else
        //            txtBoxTQTY.ReadOnly = true;
        //        con.Close();
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Please Check your Database Server Connection", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
