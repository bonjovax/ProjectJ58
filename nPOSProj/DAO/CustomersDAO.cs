using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nPOSProj.DAO
{
    class CustomersDAO
    {
        private MySqlConnection con;
        private Conf.dbs dbcon;
        public CustomersDAO()
        {

        }
        public Int32 PositionCount()
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String sql = "SELECT COUNT(*) AS a FROM crm_customer ORDER BY crm_id";
            Int32 count = 0;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    count = Convert.ToInt32(rdr["a"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error :: ERROR " + ex);
            }
            finally
            {
                con.Close();
            }
            return count;
        }
        public String[,] ReadCustomer()
        {
            Int32 count = this.PositionCount();
            String[,] xxx = new String[6, count];
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT crm_custcode AS a, crm_companyname AS b, crm_firstname AS c, ";
            query += "crm_middlename AS d, crm_lastname AS e, crm_balance AS f ";
            query += "FROM crm_customer";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int counts = 0;
                while (rdr.Read())
                {
                    xxx[0, counts] = rdr["a"].ToString();
                    xxx[1, counts] = rdr["b"].ToString();
                    xxx[2, counts] = rdr["c"].ToString();
                    xxx[3, counts] = rdr["d"].ToString();
                    xxx[4, counts] = rdr["e"].ToString();
                    xxx[5, counts] = rdr["f"].ToString();
                    counts++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Err :: ERROR " + ex);
            }
            finally
            {
                con.Close();
            }
            return xxx;
        }
    }
}