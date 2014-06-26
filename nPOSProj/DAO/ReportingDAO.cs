using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;

namespace nPOSProj.DAO
{
    class ReportingDAO
    {
        private MySqlConnection con;
        private Conf.dbs dbcon;

        public ReportingDAO()
        {

        }

        public Double ReadGrossAmount(String pos_date, String pos_terminal)
        {
            Double GrossAmount = 0;
            con = new MySqlConnection();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT SUM(pos_total_amt) AS x FROM pos_store ";
            query += "WHERE (pos_date = ?pos_date) AND (pos_terminal = ?pos_terminal)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_date", pos_date);
                cmd.Parameters.AddWithValue("?pos_terminal", pos_terminal);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    GrossAmount = Convert.ToDouble(rdr["x"]);
                }
            }
            finally
            {
                con.Close();
            }
            return GrossAmount;
        }
        public Double ReadDiscounts(String pos_date, String pos_terminal)
        {
            Double GrossAmount = 0;
            con = new MySqlConnection();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT SUM(pos_total_amt) AS x FROM pos_store ";
            query += "WHERE (pos_date = ?pos_date) AND (pos_terminal = ?pos_terminal)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_date", pos_date);
                cmd.Parameters.AddWithValue("?pos_terminal", pos_terminal);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    GrossAmount = Convert.ToDouble(rdr["x"]);
                }
            }
            finally
            {
                con.Close();
            }
            return GrossAmount;
        }
    }
}