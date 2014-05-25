using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nPOSProj
{
    public partial class mKits : Form
    {
        public mKits()
        {
            InitializeComponent();
        }

        private void mKits_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'npos_dbDataSet.inventory_items_kit' table. You can move, or remove it, as needed.
            this.inventory_items_kitTableAdapter.Fill(this.npos_dbDataSet.inventory_items_kit, "1234328948393");
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
