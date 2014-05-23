using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;

namespace nPOSProj.DAO
{
    class ItemsDAO
    {
        private MySqlConnection con;
        private Conf.dbs dbcon;
        private Int32 stockQTY;
        private Double stocktotalAmt;
        public ItemsDAO() { }

        public void Update(Int32 qty, String ean, Double r_price, Double w_price, String stock_code)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE inventory_items SET item_quantity = ?item_quantity, item_ean = ?item_ean, item_retail_price = ?item_retail_price, ";
            query += "item_whole_price = ?item_whole_price ";
            query += "WHERE stock_code = ?stock_code";
            String query1 = "UPDATE inventory_stocks SET stock_selling_price = ?stock_selling_price, stock_total_price = ?stock_total_price ";
            query1 += "WHERE stock_code = ?stock_code";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd.Parameters.AddWithValue("?item_quantity", qty);
                cmd.Parameters.AddWithValue("?item_ean", ean);
                cmd.Parameters.AddWithValue("?item_retail_price", r_price);
                cmd.Parameters.AddWithValue("?item_whole_price", w_price);
                cmd.Parameters.AddWithValue("?stock_code", stock_code);
                //
                ComputeTotalAmtStocks(r_price, stock_code);
                cmd1.Parameters.AddWithValue("?stock_selling_price", r_price);
                cmd1.Parameters.AddWithValue("?stock_total_price", stocktotalAmt);
                cmd1.Parameters.AddWithValue("?stock_code", stock_code);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd.Dispose();
                cmd1.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        private void ComputeTotalAmtStocks(Double retail_price, String stock_code)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT stock_quantity AS gay FROM inventory_stocks ";
            query += "WHERE stock_code = ?stock_code";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?stock_code", stock_code);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    stockQTY = Convert.ToInt32(rdr["gay"]);
                }
                stocktotalAmt = retail_price * stockQTY;
            }
            finally
            {
                con.Close();
            }
        }
        public void ReturnToStocks(Int32 qty, String stock_code)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE inventory_items SET item_quantity = item_quantity - ?item_quantity ";
            query += "WHERE stock_code = ?stock_code";
            String query1 = "UPDATE inventory_stocks SET stock_quantity = stock_quantity + ?stock_quantity ";
            query1 += "WHERE stock_code = ?stock_code1";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd.Parameters.AddWithValue("?item_quantity", qty);
                cmd1.Parameters.AddWithValue("?stock_quantity", qty);
                cmd.Parameters.AddWithValue("?stock_code", stock_code);
                cmd1.Parameters.AddWithValue("?stock_code1", stock_code);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd.Dispose();
                cmd1.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
    }
}