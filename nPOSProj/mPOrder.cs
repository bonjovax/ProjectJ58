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
        //
        AutoCompleteStringCollection collect2 = new AutoCompleteStringCollection();
        AutoCompleteStringCollection collect3 = new AutoCompleteStringCollection();
        public mPOrder()
        {
            InitializeComponent();
        }
        public DateTime PurchaseOrderDate
        {
            get { return dt.Value; }  // your PO date picker control
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
        //
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

        private void mPOrder_Load(object sender, EventArgs e)
        {
            String userName = frmLogin.User.user_name;
            rdOrderedBy.Text = userName;
            rdPOno.Text = po.askPOno().ToString();
            txtBoxSupplierCode.Focus();
            autoCompleteSupplierCode();
            autoCompleteSupplierName();
        }

        private void unlockBox()
        {
            txtBoxRemarks.ReadOnly = false;
            cBoxWarehouse.Enabled = true;
            cBoxCarrier.Enabled = true;
            //
            txtBoxStockCode.ReadOnly = false;
            txtBoxParticulars.ReadOnly = false;
        }
        private void lockBox()
        {
            txtBoxRemarks.ReadOnly = true;
            cBoxWarehouse.Enabled = false;
            cBoxCarrier.Enabled = false;
            //
            txtBoxStockCode.ReadOnly = true;
            txtBoxParticulars.ReadOnly = true;
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
                lAddress.Text = "";
            }
            checkifTheSame();
        }

        private void txtBoxSupplierName_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSupplierName.Text == "")
            {
                txtBoxSupplierCode.Clear();
                btnProceed.Enabled = false;
            }
            checkifTheSame();
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
                {
                    btnProceed.Enabled = false;
                    txtBoxQty.Clear();
                }
            }
            catch (Exception)
            {
                btnProceed.Enabled = false;
                txtBoxQty.Clear();
            }
        }
        public void checkifTheSameStockToQty()
        {
            Double stock_cost_price;
            String UOM;
            con = new MySqlConnection();
            dbcon = new Conf.dbs();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT * FROM inventory_stocks ";
            query += "WHERE stock_code = ?stock_code AND stock_name = ?stock_name";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?stock_code", txtBoxStockCode.Text);
                cmd.Parameters.AddWithValue("?stock_name", txtBoxParticulars.Text);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    stock_cost_price = Convert.ToDouble(rdr["stock_cost_price"]);
                    UOM = rdr["stock_uom"].ToString();
                    txtBoxUnitPrice.Text = stock_cost_price.ToString("#,###,###.00");
                    txtBoxUOM.Text = UOM;
                    txtBoxQty.ReadOnly = false;
                }
                else
                {
                    txtBoxQty.ReadOnly = true;
                    txtBoxQty.Text = "0";
                    txtBoxUnitPrice.Text = "0.00";
                    txtBoxUOM.Clear();
                }
            }
            catch (Exception)
            {
                txtBoxQty.ReadOnly = true;
                txtBoxQty.Text = "0";
                txtBoxUnitPrice.Text = "0.00";
                txtBoxUOM.Clear();
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
                toAddress();
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
                unlockBox();
                btnCancel.Enabled = true;
                btnOk.Enabled = true;
                txtBoxStockCode.Focus();
                txtBoxSupplierCode.ReadOnly = true;
                txtBoxSupplierName.ReadOnly = true;
                //
                autoCompleteStockCode();
                autoCompleteStockName();
            }
        }

        private void mPOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxStockCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                po.stock_code = txtBoxStockCode.Text;
                po.supplier_code = txtBoxSupplierCode.Text;
                txtBoxParticulars.Text = po.askStockName();
                txtBoxUnitPrice.Text = po.askStockPriceStockCode().ToString("#,###,###.00");
                txtBoxUOM.Text = po.askUOM();
                txtBoxQty.Focus();
            }
        }

        private void txtBoxParticulars_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                po.stock_name = txtBoxParticulars.Text;
                po.supplier_code = txtBoxSupplierCode.Text;
                txtBoxStockCode.Text = po.askStockCode();
                txtBoxUnitPrice.Text = po.askStockPriceStockName().ToString("#,###,###.00");
                txtBoxUOM.Text = po.askUOM_N();
                txtBoxQty.Focus();
            }
        }

        private void txtBoxStockCode_TextChanged(object sender, EventArgs e)
        {
            checkifTheSameStockToQty();
            if (txtBoxStockCode.Text == "")
            {
                txtBoxQty.Text = "0";
                txtBoxUnitPrice.Text = "0.00";
                txtBoxUOM.Clear();
            }
        }

        private void txtBoxParticulars_TextChanged(object sender, EventArgs e)
        {
            checkifTheSameStockToQty();
            if (txtBoxParticulars.Text == "")
            {
                txtBoxQty.Text = "0";
                txtBoxUnitPrice.Text = "0.00";
                txtBoxUOM.Clear();
            }
        }

        private void txtBoxQty_TextChanged(object sender, EventArgs e)
        {
            Double totalPrice;
            try
            {
                totalPrice = Convert.ToDouble(txtBoxUnitPrice.Text) * Convert.ToDouble(txtBoxQty.Text);
                rdTotal.Text = totalPrice.ToString("#,###,###.00");
            }
            catch (Exception)
            {
                txtBoxQty.Text = "0";
                rdTotal.Text = "0.00";
            }
        }

        private void txtBoxUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxUnitPrice.Text == "0.00")
                rdTotal.Text = "0.00";
        }
    }
}