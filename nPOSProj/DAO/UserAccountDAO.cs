using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text;
using System.Text.RegularExpressions;

namespace nPOSProj.DAO
{
    public class UserAccountDAO
    {
        private MySqlConnection con;
        private Conf.Crypto crypts;
        private Conf.dbs dbcon;
        private String passcrypt = "";
        private static String defaultPassword = "12345654321";

        public UserAccountDAO()
        {

        }

        public static bool Validate(String inString)
        {
            Regex r = new Regex("^[A-Za-z0-9]{5}$");
            return r.IsMatch(inString);
        }
        public void logs(String user_name)
        {
            String now = DateTime.Now.ToString();
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE user_account SET last_login = ?last_login";
            query += " WHERE user_name = ?user_name";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?last_login", now);
                cmd.Parameters.AddWithValue("?user_name", user_name);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
        public void resetPassword(String user_name)
        {
            crypts = new Conf.Crypto();
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE user_accounts SET user_password = ?user_password";
            query += " WHERE user_accounts = ?user_accounts";
            try
            {
                con.Open();
                crypts.Hashed(defaultPassword);
                passcrypt = crypts.retreiveHash();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?user_password", passcrypt);
                cmd.Parameters.AddWithValue("?user_accounts", user_name);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
