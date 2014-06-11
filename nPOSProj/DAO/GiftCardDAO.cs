using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;

namespace nPOSProj.DAO
{
    class GiftCardDAO
    {
        private MySqlConnection con;
        private Conf.dbs dbcon;

        public GiftCardDAO() { }

        public Int32 PositionCount()
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String sql = "SELECT COUNT(*) AS a FROM gc_core ORDER BY gc_id";
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

        public String[,] Read()
        {
            Int32 count = this.PositionCount();
            String[,] xxx = new String[5, count];
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT * FROM gc_core";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int counts = 0;
                while (rdr.Read())
                {
                    xxx[0, counts] = rdr["gc_id"].ToString();
                    xxx[1, counts] = rdr["gc_cardno"].ToString();
                    xxx[2, counts] = rdr["gc_amount"].ToString();
                    xxx[3, counts] = rdr["gc_holder"].ToString();
                    xxx[4, counts] = rdr["gc_validuntil"].ToString();
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
