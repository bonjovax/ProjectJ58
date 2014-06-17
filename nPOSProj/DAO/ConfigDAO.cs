using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace nPOSProj.DAO
{
    class ConfigDAO
    {
        private Conf.dbs dbcon;
        private MySqlConnection con;
        private String Company_Name;
        private String Company_Address;
        private String Tin_Number;
        private String Tax_Type;
        private Double Vat_Rate;
        private String Contact_Number;

        public ConfigDAO()
        {

        }

        public void PatchInfo(String company_name, String company_address, String tin_number, String tax_type, Double vat_rate, String contact_number)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE system_config SET company_name = ?company_name, ";
            query += "company_address = ?company_address, tin_number = ?tin_number, tax_type = ?tax_type, vat_rate = ?vat_rate, ";
            query += "contact_number = ?contact_number";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?company_name", company_name);
                cmd.Parameters.AddWithValue("?company_address", company_address);
                cmd.Parameters.AddWithValue("?tin_number", tin_number);
                cmd.Parameters.AddWithValue("?tax_type", tax_type);
                cmd.Parameters.AddWithValue("?vat_rate", vat_rate);
                cmd.Parameters.AddWithValue("?contact_number", contact_number);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public String readCompany_Name()
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT company_name FROM system_config";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Company_Name = rdr["company_name"].ToString();
                }
            }
            finally
            {
                con.Close();
            }
            return Company_Name;
        }
        public String readCompany_Address()
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT company_address FROM system_config";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Company_Address = rdr["company_address"].ToString();
                }
            }
            finally
            {
                con.Close();
            }
            return Company_Address;
        }
        public String readTin_Number()
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT tin_number FROM system_config";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Tin_Number = rdr["tin_number"].ToString();
                }
            }
            finally
            {
                con.Close();
            }
            return Tin_Number;
        }
        public String readTax_Type()
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT tax_type FROM system_config";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Tax_Type = rdr["tax_type"].ToString();
                }
            }
            finally
            {
                con.Close();
            }
            return Tax_Type;
        }
        public Double readVat_Rate()
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT vat_rate FROM system_config";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Vat_Rate = Convert.ToDouble(rdr["vat_rate"]);
                }
            }
            finally
            {
                con.Close();
            }
            return Vat_Rate;
        }
        public String readContact_Number()
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT company_contact FROM system_config";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Contact_Number = rdr["company_contact"].ToString();
                }
            }
            finally
            {
                con.Close();
            }
            return Contact_Number;
        }
    }
}