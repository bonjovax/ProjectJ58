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
        private String supplier_name;
        private String supplier_code;

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

        public String katsSupplierName(String supplier_code)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT supplier_name AS gay FROM inventory_supplier ";
            query += "WHERE supplier_code = ?supplier_code";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?supplier_code", supplier_code);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    supplier_name = rdr["gay"].ToString();
                    sendSupplierName();
                }
            }
            finally
            {
                con.Close();
            }
            return supplier_name;
        }
        public String sendSupplierName()
        {
            return supplier_name;
        }
        //
        public String katsSupplierCode(String supplier_name)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT supplier_code AS glennisgay FROM inventory_supplier ";
            query += "WHERE supplier_name = ?supplier_name";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?supplier_name", supplier_name);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    supplier_code = rdr["glennisgay"].ToString();
                    sendSupplierCode();
                }
            }
            finally
            {
                con.Close();
            }
            return supplier_code;
        }
        public String sendSupplierCode()
        {
            return supplier_code;
        }
    }
}
