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
        private String userName = frmLogin.User.user_name;
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
        public void Add(String custcode, String companyname, String firstname, String middlename, String lastname, String email, String phone_no, String address, String city, String province, String zip_code)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "INSERT INTO crm_customer (crm_custcode, crm_companyname, crm_firstname, crm_middlename, crm_lastname, crm_email, crm_phone_no, crm_address, crm_city, crm_state_province, crm_zip_code, encoded) VALUES";
            query += "(?a, ?b, ?c, ?d, ?e, ?f, ?g, ?h, ?i, ?j, ?k, ?l)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?a", custcode);
                cmd.Parameters.AddWithValue("?b", companyname);
                cmd.Parameters.AddWithValue("?c", firstname);
                cmd.Parameters.AddWithValue("?d", middlename);
                cmd.Parameters.AddWithValue("?e", lastname);
                cmd.Parameters.AddWithValue("?f", email);
                cmd.Parameters.AddWithValue("?g", phone_no);
                cmd.Parameters.AddWithValue("?h", address);
                cmd.Parameters.AddWithValue("?i", city);
                cmd.Parameters.AddWithValue("?j", province);
                cmd.Parameters.AddWithValue("?k", zip_code);
                cmd.Parameters.AddWithValue("?l", userName);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void Update(String custcode, String companyname, String firstname, String middlename, String lastname, String email, String phone_no, String address, String city, String province, String zip_code)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE crm_customer SET crm_company_name = ?a, crm_firstname = ?b, crm_middlename = ?c, crm_lastname = ?d, crm_email = ?e, ";
            query += "crm_phone_no = ?f, crm_address = ?g, crm_city = ?h, crm_state_province = ?i, crm_zipcode = ?j ";
            query += "WHERE crm_custcode = ?k";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con); 
                cmd.Parameters.AddWithValue("?a", companyname);
                cmd.Parameters.AddWithValue("?b", firstname);
                cmd.Parameters.AddWithValue("?c", middlename);
                cmd.Parameters.AddWithValue("?d", lastname);
                cmd.Parameters.AddWithValue("?e", email);
                cmd.Parameters.AddWithValue("?f", phone_no);
                cmd.Parameters.AddWithValue("?g", address);
                cmd.Parameters.AddWithValue("?h", city);
                cmd.Parameters.AddWithValue("?i", province);
                cmd.Parameters.AddWithValue("?j", zip_code);
                cmd.Parameters.AddWithValue("?k", custcode);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void Delete(String custcode)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "DELETE FROM crm_customer ";
            query += "WHERE crm_custcode = ?a";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?a", custcode);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public bool checkCustcode(String custcode)
        {
            bool found = false;
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT crm_custcode FROM crm_customer ";
            query += "WHERE crm_custcode = ?a";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?a", custcode);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    found = true;
                }
            }
            finally
            {
                con.Close();
            }
            return found;
        }
    }
}