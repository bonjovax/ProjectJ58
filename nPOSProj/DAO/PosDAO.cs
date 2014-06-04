﻿using System;
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

        public void Park_I(Int32 pos_orno, Int32 pos_ean, Int32 pos_quantity, Double pos_discount, Double pos_discount_amt, Double pos_amt)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "INSERT INTO pos_park (pos_orno, pos_ean, pos_quantity, pos_discount, pos_discount_amt, pos_amt) VALUES";
            query += "(?pos_orno, ?pos_ean, ?pos_quantity, ?pos_discount, ?pos_discount_amt, ?pos_amt)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.Parameters.AddWithValue("?pos_ean", pos_ean);
                cmd.Parameters.AddWithValue("?pos_quantity", pos_quantity);
                cmd.Parameters.AddWithValue("?pos_discount", pos_discount);
                cmd.Parameters.AddWithValue("?pos_discount_amt", pos_discount_amt);
                cmd.Parameters.AddWithValue("?pos_amt", pos_amt);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void ParkU_I(Int32 pos_orno, Int32 pos_ean, Double pos_discount, Double pos_discount_amt, Int32 pos_quantity, Double pos_amt)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE pos_park SET pos_quantity = ?pos_quantity, pos_discount = ?pos_discount, pos_discount_amt = ?pos_discount_amt, pos_amt = ?pos_amt ";
            query += "WHERE pos_orno = ?pos_orno AND pos_ean = ?pos_ean";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.Parameters.AddWithValue("?pos_ean", pos_ean);
                cmd.Parameters.AddWithValue("?pos_discount", pos_discount);
                cmd.Parameters.AddWithValue("?pos_discount_amt", pos_discount_amt);
                cmd.Parameters.AddWithValue("?pos_quantity", pos_quantity);
                cmd.Parameters.AddWithValue("?pos_amt", pos_amt);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void ParkUwD_I(Int32 pos_orno, Int32 pos_ean, Double pos_discount, Double pos_discount_amt, Double pos_amt)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE pos_park SET pos_discount = ?pos_discount, pos_discount_amt = ?pos_discount_amt, pos_amt = ?pos_amt ";
            query += "WHERE pos_orno = ?pos_orno AND pos_ean = ?pos_ean";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.Parameters.AddWithValue("?pos_ean", pos_ean);
                cmd.Parameters.AddWithValue("?pos_discount", pos_discount);
                cmd.Parameters.AddWithValue("?pos_discount_amt", pos_discount_amt);
                cmd.Parameters.AddWithValue("?pos_amt", pos_amt);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void ParkVoid_I(Int32 pos_orno, Int32 pos_ean)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "DELETE FROM pos_park ";
            query += "WHERE pos_orno = ?pos_orno AND pos_ean = ?pos_ean";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.Parameters.AddWithValue("?pos_ean", pos_ean);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void CancelT(Int32 pos_orno)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "DELETE FROM pos_store ";
            query += "WHERE pos_orno = ?pos_orno";
            String query1 = "DELETE FROM pos_park ";
            query1 += "DELETE pos_orno = ?pos_orno";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd1.Parameters.AddWithValue("?pos_orno", pos_orno);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd.Dispose();
                cmd1.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
    }
}