using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nPOSProj
{
    public partial class mFilter : Form
    {
        private Conf.dbs dbcon = new Conf.dbs();
        private MySqlConnection con = new MySqlConnection();
        private String sup;
        private String ware;
        public mFilter()
        {
            InitializeComponent();
        }
        public String Supplier
        {
            get { return sup; }
        }
        public String Warehouse
        {
            get { return ware; }
        }

        private void mFilter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'npos_dbDataSet.inventory_warehouse' table. You can move, or remove it, as needed.
            this.inventory_warehouseTableAdapter.Fill(this.npos_dbDataSet.inventory_warehouse);
            // TODO: This line of code loads data into the 'npos_dbDataSet.inventory_supplier' table. You can move, or remove it, as needed.
            this.inventory_supplierTableAdapter.Fill(this.npos_dbDataSet.inventory_supplier);

        }

        private void cBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT supplier_code AS a FROM inventory_supplier ";
            query += "WHERE supplier_name = ?supplier_name";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?supplier_name", cBoxSupplier.Text);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    sup = rdr["a"].ToString();
                }
            }
            catch (Exception)
            {
                Application.ExitThread();
            }
            finally
            {
                con.Close();
                this.Close();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT warehouse_code AS a FROM inventory_warehouse ";
            query += "WHERE warehouse_name = ?warehouse_name";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?warehouse_name", cBoxWarehouse.Text);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    ware = rdr["a"].ToString();
                }
            }
            catch (Exception)
            {
                Application.ExitThread();
            }
            finally
            {
                con.Close();
                this.Close();
            }
        }
    }
}