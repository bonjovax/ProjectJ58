using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nPOSProj.DAO
{
    class PosDAO
    {
        private MySqlConnection con;
        private Conf.dbs dbcon;
        private Int32 OrNo;

        public PosDAO() { }
        #region Main Course
        public void Begin(Int32 pos_orno, String pos_terminal, DateTime pos_date, DateTime pos_time, String pos_user)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "INSERT INTO pos_store (pos_orno, pos_terminal, pos_date, pos_time, pos_user) VALUES";
            query += "(?pos_orno, ?pos_terminal, ?pos_date, ?pos_time, ?pos_user)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.Parameters.AddWithValue("?pos_terminal", pos_terminal);
                cmd.Parameters.AddWithValue("?pos_date", pos_date);
                cmd.Parameters.AddWithValue("?pos_time", pos_time);
                cmd.Parameters.AddWithValue("?pos_user", pos_user);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public Int32 GenerateOR()
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT COUNT(*) AS a FROM pos_store";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    OrNo = Convert.ToInt32(rdr["a"]);
                }
            }
            finally
            {
                con.Close();
            }
            return OrNo;
        }
        public void SwitchWS(Int32 pos_orno)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE pos_store SET pos_iswholesale = 1 ";
            query += "WHERE pos_orno = ?pos_orno";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void Park_I(Int32 pos_orno, Int32 pos_ean, Int32 pos_quantity, Double pos_amt)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "INSERT INTO pos_park (pos_orno, pos_ean, pos_quantity, pos_amt) VALUES";
            query += "(?pos_orno, ?pos_ean, ?pos_quantity, ?pos_amt)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.Parameters.AddWithValue("?pos_ean", pos_ean);
                cmd.Parameters.AddWithValue("?pos_quantity", pos_quantity);
                cmd.Parameters.AddWithValue("?pos_amt", pos_amt);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void Park_I_Update(Int32 pos_orno, Int32 pos_ean, Int32 pos_quantity, Double pos_amt)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE pos_park SET pos_quantity = pos_quantity + ?pos_quantity, pos_discount = 0, pos_discount_amt = 0, pos_amt = ?pos_amt ";
            query += "WHERE (pos_orno = ?pos_orno) AND (pos_ean = ?pos_ean)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_quantity", pos_quantity);
                cmd.Parameters.AddWithValue("?pos_amt", pos_amt);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.Parameters.AddWithValue("?pos_ean", pos_ean);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void ParkU_I(Int32 pos_orno, Int32 pos_ean, Double pos_discount, Double pos_discount_amt, Int32 pos_quantity, Double pos_amt)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE pos_park SET pos_quantity = ?pos_quantity, pos_discount = ?pos_discount, pos_discount_amt = ?pos_discount_amt, pos_amt = ?pos_amt ";
            query += "WHERE (pos_orno = ?pos_orno) AND (pos_ean = ?pos_ean)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.Parameters.AddWithValue("?pos_ean", pos_ean);
                cmd.Parameters.AddWithValue("?pos_discount", pos_discount);
                cmd.Parameters.AddWithValue("?pos_discount_amt", pos_discount_amt);
                cmd.Parameters.AddWithValue("?pos_quantity", pos_quantity);
                cmd.Parameters.AddWithValue("?pos_amt", pos_amt);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void ParkUwD_I(Int32 pos_orno, Int32 pos_ean, Double pos_discount, Double pos_discount_amt, Double pos_amt)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE pos_park SET pos_discount = ?pos_discount, pos_discount_amt = ?pos_discount_amt, pos_amt = ?pos_amt ";
            query += "WHERE (pos_orno = ?pos_orno) AND (pos_ean = ?pos_ean)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.Parameters.AddWithValue("?pos_ean", pos_ean);
                cmd.Parameters.AddWithValue("?pos_discount", pos_discount);
                cmd.Parameters.AddWithValue("?pos_discount_amt", pos_discount_amt);
                cmd.Parameters.AddWithValue("?pos_amt", pos_amt);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void ParkVoid_I(Int32 pos_orno, Int32 pos_ean, Int32 pos_quantity)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE inventory_items SET item_quantity = item_quantity + ?item_quantity ";
            query += "WHERE (item_ean = ?item_ean)";
            String query1 = "DELETE FROM pos_park ";
            query1 += "WHERE (pos_orno = ?pos_orno) AND (pos_ean = ?pos_ean)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd.Parameters.AddWithValue("?item_quantity", pos_quantity);
                cmd.Parameters.AddWithValue("?item_ean", pos_ean);
                cmd1.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd1.Parameters.AddWithValue("?pos_ean", pos_ean);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void ReturnCancelI(Int32 pos_ean, Int32 pos_quantity, Int32 pos_orno)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE pos_park SET pos_quantity = pos_quantity - ?pos_quantity ";
            query += "WHERE (pos_ean = ?pos_ean) AND (pos_orno = ?pos_orno)";
            String query1 = "UPDATE inventory_items SET item_quantity = item_quantity + ?item_quantity ";
            query1 += "WHERE (item_ean = ?item_ean)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd.Parameters.AddWithValue("?pos_ean", pos_ean);
                cmd1.Parameters.AddWithValue("?item_quantity", pos_quantity);
                cmd.Parameters.AddWithValue("?pos_quantity", pos_quantity);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd1.Parameters.AddWithValue("?item_ean", pos_ean);
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
        public void CancelT(Int32 pos_orno)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE pos_store SET is_cancel = 1, pos_park = 0, pos_tax_perc = 0, pos_tax_amt = 0, pos_total_amt = 0, pos_total_amt = 0 ";
            query += "WHERE pos_orno = ?pos_orno";
            String query1 = "DELETE FROM pos_park ";
            query1 += "WHERE pos_orno = ?pos_orno";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd1.Parameters.AddWithValue("?pos_orno", pos_orno);
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
        #endregion
        #region Attribute
        public void UpdateTrunkSales(Double tax_p, Double tax_amt, Double pos_total_amt, Int32 pos_orno)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE pos_store SET pos_tax_perc = ?a, pos_tax_amt = ?b, pos_total_amt = ?c ";
            query += "WHERE pos_orno = ?pos_orno";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?a", tax_p);
                cmd.Parameters.AddWithValue("?b", tax_amt);
                cmd.Parameters.AddWithValue("?c", pos_total_amt);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region Gift Card
        #endregion
        #region Checkout Stuffs
        public void Cash(Double pos_tender, Double pos_change, Int32 pos_orno, String pos_terminal)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE pos_store SET crm_custcode = 'WLKIN', pos_customer = 'Walk-In', pos_paymethod = 'Cash', ";
            query += "pos_tender = ?pos_tender, pos_change = ?pos_change, pos_park = 0 ";
            query += "WHERE (pos_orno = ?pos_orno) AND (pos_terminal = ?pos_terminal)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_tender", pos_tender);
                cmd.Parameters.AddWithValue("?pos_change", pos_change);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.Parameters.AddWithValue("?pos_terminal", pos_terminal);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void DBCCard(Double pos_tender, Int32 pos_orno, String pos_terminal, String card_data, String card_lastfour, String card_type, Double tx_amount)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE pos_store SET crm_custcode = 'WLKIN', pos_customer = 'Walk-In', pos_paymethod = 'Debit/Credit Card', ";
            query += "pos_tender = ?pos_tender, pos_park = 0 ";
            query += "WHERE (pos_orno = ?pos_orno) AND (pos_terminal = ?pos_terminal)";
            String query1 = "INSERT INTO pos_dc_tx (pos_orno, card_data, card_lastfour, card_type, tx_amount, date_tx, time_tx) VALUES";
            query1 += "(?pos_orno, ?card_data, ?card_lastfour, ?card_type, ?tx_amount,?date_tx, ?time_tx)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                //
                cmd.Parameters.AddWithValue("?pos_tender", pos_tender);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.Parameters.AddWithValue("?pos_terminal", pos_terminal);
                //
                cmd1.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd1.Parameters.AddWithValue("?card_data", card_data);
                cmd1.Parameters.AddWithValue("?card_lastfour", card_lastfour);
                cmd1.Parameters.AddWithValue("?card_type", card_type);
                cmd1.Parameters.AddWithValue("?tx_amount", tx_amount);
                cmd1.Parameters.AddWithValue("?date_tx", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd1.Parameters.AddWithValue("?time_tx", DateTime.Now.ToString("HH:mm:ss"));
                //
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
        public void BCheck(Double pos_tender, Int32 pos_orno, String pos_terminal, String bc_checkno, String bc_banknbranch, String bc_refcode, Double tx_amount)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE pos_store SET crm_custcode = 'WLKIN', pos_customer = 'Walk-In', pos_paymethod = 'Bank Cheque', ";
            query += "pos_tender = ?pos_tender, pos_park = 0 ";
            query += "WHERE (pos_orno = ?pos_orno) AND (pos_terminal = ?pos_terminal)";
            String query1 = "INSERT INTO pos_bc_tx (pos_orno, bc_checkno, bc_banknbranch, bc_refcode, tx_amount, date_tx, time_tx) VALUES";
            query1 += "(?pos_orno, ?bc_checkno, ?bc_banknbranch, bc_refcode, tx_amount, date_tx, time_tx)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                //
                cmd.Parameters.AddWithValue("?pos_tender", pos_tender);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.Parameters.AddWithValue("?pos_terminal", pos_terminal);
                //
                cmd1.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd1.Parameters.AddWithValue("?bc_checkno", bc_checkno);
                cmd1.Parameters.AddWithValue("?bc_banknbranch", bc_banknbranch);
                cmd1.Parameters.AddWithValue("?bc_refcode", bc_refcode);
                cmd1.Parameters.AddWithValue("?tx_amount", tx_amount);
                cmd1.Parameters.AddWithValue("?date_tx", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd1.Parameters.AddWithValue("?time_tx", DateTime.Now.ToString("HH:mm:ss"));
                //
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
        public void GiftDick(Double pos_tender, Int32 pos_orno, String pos_terminal, Int32 gc_cardno, Double tx_amount)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE pos_store SET crm_custcode = 'WLKIN', pos_customer = 'Walk-In', pos_paymethod = 'Gift Card', ";
            query += "pos_tender = ?pos_tender, pos_park = 0 ";
            query += "WHERE (pos_orno = ?pos_orno) AND (pos_terminal = ?pos_terminal)";
            String query1 = "INSERT INTO pos_gc_tx (pos_orno, gc_cardno, tx_amount, date_tx, time_tx) VALUES";
            query1 += "(?pos_orno, ?gc_cardno, ?tx_amount, ?date_tx, ?time_tx)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                //
                cmd.Parameters.AddWithValue("?pos_tender", pos_tender);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.Parameters.AddWithValue("?pos_terminal", pos_terminal);
                //
                cmd1.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd1.Parameters.AddWithValue("?gc_cardno", gc_cardno);
                cmd1.Parameters.AddWithValue("?tx_amount", tx_amount);
                cmd1.Parameters.AddWithValue("?date_tx", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd1.Parameters.AddWithValue("?time_tx", DateTime.Now.ToString("HH:mm:ss"));
                //
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
        #endregion
    }
}