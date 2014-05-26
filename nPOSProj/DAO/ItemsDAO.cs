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
        private Int32 qty;
        private Double price;
        private Double finale;
        private String kitName;
        private String itemEAN;
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
        private void ComputeTotalAmtQty(String stock_code)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT stock_quantity AS a, stock_selling_price AS b FROM inventory_stocks ";
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
                    qty = Convert.ToInt32(rdr["a"]);
                    price = Convert.ToDouble(rdr["b"]);
                }
                finale = qty * price;
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
            String query2 = "UPDATE inventory_stocks SET stock_total_price = ?stock_total_price ";
            query2 += "WHERE stock_code = ?stock_code";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                cmd.Parameters.AddWithValue("?item_quantity", qty);
                cmd1.Parameters.AddWithValue("?stock_quantity", qty);
                cmd.Parameters.AddWithValue("?stock_code", stock_code);
                cmd1.Parameters.AddWithValue("?stock_code1", stock_code);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd.Dispose();
                cmd1.Dispose();
                this.ComputeTotalAmtQty(stock_code);
                cmd2.Parameters.AddWithValue("?stock_total_price", finale);
                cmd2.Parameters.AddWithValue("?stock_code", stock_code);
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void SendToItem(Int32 qty, String stock_code)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE inventory_items SET item_quantity = item_quantity + ?item_quantity ";
            query += "WHERE stock_code = ?stock_code";
            String query1 = "UPDATE inventory_stocks SET stock_quantity = stock_quantity - ?stock_quantity ";
            query1 += "WHERE stock_code = ?stock_code1";
            String query2 = "UPDATE inventory_stocks SET stock_total_price = ?stock_total_price ";
            query2 += "WHERE stock_code = ?stock_code";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                cmd.Parameters.AddWithValue("?item_quantity", qty);
                cmd1.Parameters.AddWithValue("?stock_quantity", qty);
                cmd.Parameters.AddWithValue("?stock_code", stock_code);
                cmd1.Parameters.AddWithValue("?stock_code1", stock_code);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd.Dispose();
                cmd1.Dispose();
                this.ComputeTotalAmtQty(stock_code);
                cmd2.Parameters.AddWithValue("?stock_total_price", finale);
                cmd2.Parameters.AddWithValue("?stock_code", stock_code);
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();                
            }
            finally
            {
                con.Close();
            }
        }
        public String pushKitName(String item_ean)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT kit_name AS a FROM inventory_items ";
            query += "WHERE item_ean = ?item_ean";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?item_ean", item_ean);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    kitName = rdr["a"].ToString();
                }
            }
            finally
            {
                con.Close();
            }
            return kitName;
        }
        public String pushEan(String kit_name)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT item_ean AS ean FROM inventory_items ";
            query += "WHERE kit_name = ?kit_name";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?kit_name", kit_name);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    itemEAN = rdr["ean"].ToString();
                }
            }
            finally
            {
                con.Close();
            }
            return itemEAN;
        }

        #region Item Kits
        public void InsertKit(Int32 kit_qty, String item_ean, String stock_code)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "INSERT INTO inventory_items_kit (kit_qty, item_ean, stock_code) VALUES";
            query += "(?qty, ?ean, ?stock_code)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?qty", kit_qty);
                cmd.Parameters.AddWithValue("?ean", item_ean);
                cmd.Parameters.AddWithValue("?stock_code", stock_code);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void UpdateKit(Int32 kit_qty, String item_ean, String stock_code)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE inventory_items_kit SET kit_qty = ?qty ";
            query += "WHERE item_ean = ?ean AND stock_code = ?stock_code";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?qty", kit_qty);
                cmd.Parameters.AddWithValue("?ean", item_ean);
                cmd.Parameters.AddWithValue("?stock_code", stock_code);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void DeleteKit(String item_ean, String stock_code)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "DELETE FROM inventory_items_kit ";
            query += "WHERE item_ean = ?ean AND stock_code = ?stock_code";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?ean", item_ean);
                cmd.Parameters.AddWithValue("?stock_code", stock_code);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}