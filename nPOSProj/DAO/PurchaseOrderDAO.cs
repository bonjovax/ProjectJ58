using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;

namespace nPOSProj.DAO
{
    class PurchaseOrderDAO
    {
        private MySqlConnection con;
        private Conf.dbs dbcon;
        private Int32 PONumber = 0;

        public PurchaseOrderDAO()
        {

        }

        public Int32 postPONumber()
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT COUNT(*) AS gayminerva FROM po_order;";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    PONumber = Convert.ToInt32(rdr["gayminerva"]);
                    sendPONumber();
                }
                else
                {
                    PONumber = 0;
                    sendPONumber();
                }
            }
            finally
            {
                con.Close();
            }
            return PONumber;
        }
        private Int32 sendPONumber()
        {
            return PONumber;
        }
    }
}
