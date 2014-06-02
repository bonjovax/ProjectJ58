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
    }
}
