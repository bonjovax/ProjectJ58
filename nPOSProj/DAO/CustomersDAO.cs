﻿using System;
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
        private Int32 count1 = 0;
        private Int32 count2 = 0;
        private Int32 count3 = 0;
        private String cmpName;
        private String custC;
        private bool korek = false;
        public CustomersDAO()
        {

        }
        #region Customer Core
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
        public Int32 PositionCountFilter(Double crm_balance)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String sql = "SELECT COUNT(*) AS a FROM crm_customer WHERE crm_balance = ?a ORDER BY crm_id";
            Int32 count = 0;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("?a", crm_balance);
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
        public String[,] ReadCustomerForPayment()
        {
            Int32 count = this.PositionCount();
            String[,] yyy = new String[5, count];
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT crm_custcode AS a, crm_companyname AS b, crm_payable AS c, crm_paidamt AS d, crm_balance AS e ";
            query += "FROM crm_customer ORDER BY crm_custcode";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int counts = 0;
                while (rdr.Read())
                {
                    yyy[0, counts] = rdr["a"].ToString();
                    yyy[1, counts] = rdr["b"].ToString();
                    yyy[2, counts] = rdr["c"].ToString();
                    yyy[3, counts] = rdr["d"].ToString();
                    yyy[4, counts] = rdr["e"].ToString();
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
            return yyy;
        }
        public String[,] ReadCustomerFilter(Double crm_balance)
        {
            Int32 count = this.PositionCountFilter(crm_balance);
            String[,] xxx = new String[6, count];
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT crm_custcode AS a, crm_companyname AS b, crm_firstname AS c, ";
            query += "crm_middlename AS d, crm_lastname AS e, crm_balance AS f ";
            query += "FROM crm_customer ";
            query += "WHERE crm_balance = ?crm_balance";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?crm_balance", crm_balance);
                cmd.ExecuteScalar();
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
            String query = "UPDATE crm_customer SET crm_companyname = ?a, crm_firstname = ?b, crm_middlename = ?c, crm_lastname = ?d, crm_email = ?e, ";
            query += "crm_phone_no = ?f, crm_address = ?g, crm_city = ?h, crm_state_province = ?i, crm_zip_code = ?j ";
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
        public String[] ReadEdit(String crm_custcode)
        {
            String[] cabilat = new String[11];
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT crm_custcode AS a, crm_companyname AS b, crm_firstname AS c, crm_middlename AS d, crm_lastname AS e, crm_email AS f, ";
            query += "crm_phone_no AS g, crm_address AS h, crm_city AS i, crm_state_province AS j, crm_zip_code AS k ";
            query += "FROM crm_customer ";
            query += "WHERE crm_custcode = ?crm_custcode";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?crm_custcode", crm_custcode);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    cabilat[0] = rdr["a"].ToString();
                    cabilat[1] = rdr["b"].ToString();
                    cabilat[2] = rdr["c"].ToString();
                    cabilat[3] = rdr["d"].ToString();
                    cabilat[4] = rdr["e"].ToString();
                    cabilat[5] = rdr["f"].ToString();
                    cabilat[6] = rdr["g"].ToString();
                    cabilat[7] = rdr["h"].ToString();
                    cabilat[8] = rdr["i"].ToString();
                    cabilat[9] = rdr["j"].ToString();
                    cabilat[10] = rdr["k"].ToString();
                }
            }
            finally
            {
                con.Close();
            }
            return cabilat;
        }
        #endregion
        #region CRM Basic
        public Int32 PositionCountCRM(String crm_custcode, DateTime filterToday)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String sql = "SELECT COUNT(*) AS a FROM crm_basic WHERE crm_custcode = ?a AND crm_paydate = ?b ORDER BY basic_id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("?a", crm_custcode);
                cmd.Parameters.AddWithValue("?b", filterToday);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    count1 = Convert.ToInt32(rdr["a"].ToString());
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
            return count1;
        }
        public Int32 PositionCountCRMFilter(String crm_custcode, DateTime from, DateTime to)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String sql = "SELECT COUNT(*) AS a FROM crm_basic WHERE (crm_custcode = ?a) AND ((crm_paydate >= ?from) AND (crm_paydate <= ?to)) ORDER BY basic_id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("?a", crm_custcode);
                cmd.Parameters.AddWithValue("?from", from);
                cmd.Parameters.AddWithValue("?to", to);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    count2 = Convert.ToInt32(rdr["a"].ToString());
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
            return count2;
        }
        public Int32 PositionCountCRMAll(String crm_custcode)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String sql = "SELECT COUNT(*) AS a FROM crm_basic WHERE (crm_custcode = ?a) ORDER BY basic_id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("?a", crm_custcode);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    count3 = Convert.ToInt32(rdr["a"].ToString());
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
            return count3;
        }
        public String[,] ReadCRMToday(String crm_custcode, DateTime crm_paydate)
        {
            this.PositionCountCRM(crm_custcode, crm_paydate);
            Int32 count = count1;
            String[,] xxx = new String[3, count];
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT crm_paydate AS a, crm_paytime AS b, crm_payamount AS c ";
            query += "FROM crm_basic ";
            query += "WHERE crm_custcode = ?a AND crm_paydate = ?b ORDER BY crm_paydate";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?a", crm_custcode);
                cmd.Parameters.AddWithValue("?b", crm_paydate);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                int counts = 0;
                while (rdr.Read())
                {
                    xxx[0, counts] = rdr["a"].ToString();
                    xxx[1, counts] = rdr["b"].ToString();
                    xxx[2, counts] = rdr["c"].ToString();
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
        //
        public String[,] ReadCRMFilterDate(String crm_custcode, DateTime from, DateTime to)
        {
            this.PositionCountCRMFilter(crm_custcode, from, to);
            Int32 count = count2;
            String[,] yyy = new String[3, count];
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT crm_paydate AS a, crm_paytime AS b, crm_payamount AS c ";
            query += "FROM crm_basic ";
            query += "WHERE (crm_custcode = ?a) AND ((crm_paydate >= ?from) AND (crm_paydate <= ?to)) ORDER By crm_paydate";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?a", crm_custcode);
                cmd.Parameters.AddWithValue("?from", from);
                cmd.Parameters.AddWithValue("?to", to);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                int counts = 0;
                while (rdr.Read())
                {
                    yyy[0, counts] = rdr["a"].ToString();
                    yyy[1, counts] = rdr["b"].ToString();
                    yyy[2, counts] = rdr["c"].ToString();
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
            return yyy;
        }
        //
        public String[,] ReadCRMAll(String crm_custcode)
        {
            this.PositionCountCRMAll(crm_custcode);
            Int32 count = count3;
            String[,] zzz = new String[3, count];
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT crm_paydate AS a, crm_paytime AS b, crm_payamount AS c ";
            query += "FROM crm_basic ";
            query += "WHERE (crm_custcode = ?a) ORDER BY crm_paydate";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?a", crm_custcode);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                int counts = 0;
                while (rdr.Read())
                {
                    zzz[0, counts] = rdr["a"].ToString();
                    zzz[1, counts] = rdr["b"].ToString();
                    zzz[2, counts] = rdr["c"].ToString();
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
            return zzz;
        }
        #endregion
        #region Misc
        public String DisplayCmp(String crm_custcode)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT crm_companyname FROM crm_customer WHERE crm_custcode = ?a";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?a", crm_custcode);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    cmpName = rdr["crm_companyname"].ToString();
                }
            }
            finally
            {
                con.Close();
            }
            return cmpName;
        }
        public String DisplayCustC(String crm_companyname)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT crm_custcode FROM crm_customer WHERE crm_companyname = ?a";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?a", crm_companyname);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    custC = rdr["crm_custcode"].ToString();
                }
            }
            finally
            {
                con.Close();
            }
            return custC;
        }
        public bool correct(String crm_custcode, String crm_companyname)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT * FROM crm_customer ";
            query += "WHERE (crm_custcode = ?a) AND (crm_companyname = ?b)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?a", crm_custcode);
                cmd.Parameters.AddWithValue("?b", crm_companyname);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    korek = true;
                }
            }
            finally
            {
                con.Close();
            }
            return korek;
        }
        #endregion
    }
}