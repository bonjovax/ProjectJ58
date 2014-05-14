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
    public partial class mEditPO : Form
    {
        private MySqlConnection con = new MySqlConnection();
        private Conf.dbs dbcon = new Conf.dbs();
        private VO.PurchaseOrderVO po = new VO.PurchaseOrderVO();
        public String DatePass { get; set; }
        AutoCompleteStringCollection collect2 = new AutoCompleteStringCollection();
        AutoCompleteStringCollection collect3 = new AutoCompleteStringCollection();
        public DateTime PurchaseOrderDate
        {
            get { return dt.Value; }  // your PO date picker control
        }
        public mEditPO()
        {
            InitializeComponent();
        }

        public void orderPO(Int32 po_no)
        {
            rdPOno.Text = po_no.ToString();
        }

        public void displayDataUpper()
        {
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT supplier_code AS a, po_date AS b, user_name AS c, po_warehouse AS d, po_carrier AS e, po_remarks AS f FROM po_order ";
            query += "WHERE po_no = ?po_no";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?po_no", rdPOno.Text);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    txtBoxSupplierCode.Text = rdr["a"].ToString();
                    dt.Text = rdr["b"].ToString();
                    rdOrderedBy.Text = rdr["c"].ToString();
                    rdWarehouse.Text = rdr["d"].ToString();
                    rdCarrier.Text = rdr["e"].ToString();
                    txtBoxRemarks.Text = rdr["f"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Reading: " + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void toAddress()
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT supplier_address FROM inventory_supplier ";
            query += "WHERE supplier_code = ?supplier_code";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?supplier_code", txtBoxSupplierCode.Text);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    lAddress.Text = rdr["supplier_address"].ToString();
                }
                else
                    lAddress.Text = "";
            }
            catch (Exception)
            {
                lAddress.Text = "";
            }
        }

        private void autoCompleteStockCode()
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String sql = "SELECT stock_code FROM inventory_stocks WHERE supplier_code = ?supplier_code ORDER BY stock_code ASC";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("?supplier_code", txtBoxSupplierCode.Text);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows == true)
                {
                    while (rdr.Read())
                        collect2.Add(rdr["stock_code"].ToString());
                }
                rdr.Close();
                txtBoxStockCode.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBoxStockCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBoxStockCode.AutoCompleteCustomSource = collect2;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check your Database Server Connection", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }
        private void autoCompleteStockName()
        {
            con.ConnectionString = dbcon.getConnectionString();
            String sql = "SELECT stock_name FROM inventory_stocks WHERE supplier_code = ?supplier_code ORDER BY stock_code ASC";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("?supplier_code", txtBoxSupplierCode.Text);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows == true)
                {
                    while (rdr.Read())
                        collect3.Add(rdr["stock_name"].ToString());
                }
                rdr.Close();
                txtBoxParticulars.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBoxParticulars.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBoxParticulars.AutoCompleteCustomSource = collect3;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check your Database Server Connection", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void txtBoxSupplierCode_TextChanged(object sender, EventArgs e)
        {
            po.supplier_code = txtBoxSupplierCode.Text;
            txtBoxSupplierName.Text = po.askSupplierName();
            toAddress();
        }

        private void rdPOno_TextChanged(object sender, EventArgs e)
        {
            displayDataUpper();
        }

        private void mEditPO_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtBoxStockCode.ReadOnly = false;
            txtBoxParticulars.ReadOnly = false;
            txtBoxStockCode.Focus();
            autoCompleteStockCode();
            autoCompleteStockName();
        }

        private void txtBoxStockCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}