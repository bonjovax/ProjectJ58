using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;

namespace nPOSProj.DAO
{
    class ReceivingDAO
    {
        private MySqlConnection con;
        private Conf.dbs dbcon;

        public ReceivingDAO()
        {

        }

        public void Receive(Int32 po_no, String order_suppliers_itemno, Int32 quantity)
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "UPDATE po_order_list SET order_quantity = order_quantity - ?order_quantity ";
            query += "WHERE po_no = ?po_no AND order_suppliers_itemno = ?order_suppliers_itemno";
            String query1 = "UPDATE inventory_stocks SET stock_quantity = stock_quantity + ?stock_quantity, stock_total_price = ?stock_total_price ";
            query1 += "WHERE stock_code = ?stock_code";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?order_quantity", quantity);
                cmd.Parameters.AddWithValue("?po_no", po_no);
                cmd.Parameters.AddWithValue("?order_suppliers_itemno", order_suppliers_itemno);
            }
            finally
            {
                con.Close();
            }
        }
    }
}