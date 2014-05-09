using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace nPOSProj
{
    public partial class mPOrder : Form
    {
        private MySqlConnection con = new MySqlConnection();
        private Conf.dbs dbcon = new Conf.dbs();
        private VO.PurchaseOrderVO po = new VO.PurchaseOrderVO();
        AutoCompleteStringCollection collect = new AutoCompleteStringCollection();
        AutoCompleteStringCollection collect1 = new AutoCompleteStringCollection();
        public mPOrder()
        {
            InitializeComponent();
        }
        private void autoCompleteSupplierCode()
        {
            con.ConnectionString = dbcon.getConnectionString();
            String sql = "SELECT supplier_code FROM inventory_supplier ORDER BY supplier_code ASC";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows == true)
                {
                    while (rdr.Read())
                        collect.Add(rdr["supplier_code"].ToString());
                }
                rdr.Close();
                txtBoxSupplierCode.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBoxSupplierCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBoxSupplierCode.AutoCompleteCustomSource = collect;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check your Database Server Connection", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }
        private void autoCompleteSupplierName()
        {
            con.ConnectionString = dbcon.getConnectionString();
            String sql = "SELECT supplier_name FROM inventory_supplier ORDER BY supplier_name ASC";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows == true)
                {
                    while (rdr.Read())
                        collect1.Add(rdr["supplier_name"].ToString());
                }
                rdr.Close();
                txtBoxSupplierName.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBoxSupplierName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBoxSupplierName.AutoCompleteCustomSource = collect1;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check your Database Server Connection", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void mPOrder_Load(object sender, EventArgs e)
        {
            String userName = frmLogin.User.user_name;
            rdOrderedBy.Text = userName;
            rdPOno.Text = po.askPOno().ToString();
            txtBoxSupplierCode.Focus();
            autoCompleteSupplierCode();
            autoCompleteSupplierName();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBoxSupplierCode_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSupplierCode.Text == "")
            {
                txtBoxSupplierName.Clear();
                btnProceed.Enabled = false;
            }
        }

        private void txtBoxSupplierName_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSupplierName.Text == "")
            {
                txtBoxSupplierCode.Clear();
                btnProceed.Enabled = false;
            }
        }

        public void checkifTheSame()
        {
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT * FROM inventory_supplier ";
            query += "WHERE supplier_code = ?supplier_code AND supplier_name = ?supplier_name";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?supplier_name", txtBoxSupplierName.Text);
                cmd.Parameters.AddWithValue("?supplier_code", txtBoxSupplierCode.Text);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    btnProceed.Enabled = true;
                }
                else
                    btnProceed.Enabled = false;
            }
            catch (Exception)
            {
                btnProceed.Enabled = false;
            }
        }

        private void txtBoxSupplierCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                po.supplier_code = txtBoxSupplierCode.Text;
                txtBoxSupplierName.Text = po.askSupplierName();
                checkifTheSame();
            }
        }

        private void txtBoxSupplierName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                po.supplier_name = txtBoxSupplierName.Text;
                txtBoxSupplierCode.Text = po.askSupplierCode();
                checkifTheSame();
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do You Wish To Proceed?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                po.po_no = Convert.ToInt32(rdPOno.Text);
                po.po_date = Convert.ToDateTime(dt.Text).ToString("yyyy-MM-dd");
                po.po_time = DateTime.Now.ToLongTimeString();
                po.supplier_code = txtBoxSupplierCode.Text;
                po.user_name = rdOrderedBy.Text;
                po.PO_Issue();
                btnProceed.Visible = false;
            }
        }
    }
}