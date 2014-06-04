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
    public partial class frmPOS : Form
    {
        private MySqlConnection con = new MySqlConnection();
        private Conf.dbs dbcon = new Conf.dbs();
        private DAO.LoginDAO login;
        private VO.PosVO pos = new VO.PosVO();
        private bool wholsale_select = false;
        private bool proceeds = false;
        private Double price;
        //
        private Double computerItemQty;
        private bool found = false;

        #region Discount Variable
        private Double getTotalAmt;
        private bool discountTx = false;
        #endregion

        public frmPOS()
        {
            InitializeComponent();
        }
        #region Secretive Override Form
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:             //preventing the form from being moved by the mouse.
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)       //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }
        #endregion
        private void onFormClose()
        {
            login = new DAO.LoginDAO();
            String userName = frmLogin.User.user_name;
            login.catchUsername(userName);
            frmMenu fm = new frmMenu();
            if (login.hasSales())
            {
                fm.unlockSales();
            }
            if (login.hasCustomers())
            {
                fm.unlockCustomers();
            }
            if (login.hasInventory())
            {
                fm.unlockInventory();
            }
            if (login.hasReports())
            {
                fm.unlockGeneralReports();
            }
            if (login.hasGC())
            {
                fm.unlockGiftCards();
            }
            if (login.hasUser_Accounts())
            {
                fm.unlockUserAccounts();
            }
            if (login.hasUserConf())
            {
                fm.unlockConfig();
            }
            fm.Show();
            this.Hide();
        }

        private void frmPOS_DoubleClick(object sender, EventArgs e)
        {
            
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                MessageBox.Show("You pressed the F1 key");
                return true;
            }
            if (keyData == Keys.F3 && wholsale_select == false && btnWholesale.Enabled == true)
            {
                gotoWholesale();
                return true;
            }
            if (keyData == Keys.F8 && btnCheckout.Enabled == true)
            {
                frmDlgCheckout checkout = new frmDlgCheckout();
                checkout.ShowDialog();
            }
            if (keyData == Keys.F9 && btnDiscount.Enabled == true && discountTx == true)
            {
                MessageBox.Show("F9");
            }
            if (keyData == Keys.F10)
            {
                onFormClose();
                return true;
            }
            if (keyData == Keys.F12 && proceeds == false)
            {
                frmLogin lg = new frmLogin(); //we'll use that ^_^
                //
                String userName = frmLogin.User.user_name;
                lblSeriesNo.Text = pos.GetOrNo().ToString();
                pos.Pos_orno = pos.GetOrNo();
                pos.Pos_terminal = lg.tN;
                pos.Pos_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                pos.Pos_time = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
                pos.Pos_user = userName;
                pos.BeginTransaction();
                //
                proceed.Visible = false;
                proceeds = true; //important
                timer2.Stop();
                //
                txtBoxEAN.ReadOnly = false;
                txtBoxQty.ReadOnly = false;
                txtBoxQty.Text = "1";
                rdDescription.Clear();
                //
                btnSearch.Enabled = true;
                btnRefund.Enabled = true;
                btnWholesale.Enabled = true;
                btnCancelSale.Enabled = true;
                btnParkSale.Enabled = false;
                //
                timer3.Start();
                rdDescription.Text = "3M Groceries & Supplies";
                timer3.Interval = 3000;
                timer3.Tick += new EventHandler(timer3_Tick);
                return true;
            }
            if (keyData == Keys.Q)
            {
                txtBoxQty.Focus();
                return true;
            }
            if (keyData == Keys.A)
            {
                txtBoxEAN.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        void timer3_Tick(object sender, EventArgs e)
        {
            rdDescription.Text = "Ready";
            rdPrice.Text = "0.00";
            rdTotal.Text = "0.00";
            txtBoxQty.Text = "1";
            timer3.Stop();
        }

        private void frmPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            onFormClose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            rdDescription.Text = "3M Groceries & Supplies";
            timer1.Start();
            String userName = frmLogin.User.user_name;
            lblUserAccount.Text = userName;
            lblProgversion.Text = "nPOS System v" + ProductVersion.ToString();
            //
            timer2.Start();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 250;
        }

        void timer2_Tick(object sender, EventArgs e)
        {
            if (proceed.BackColor == Color.Red)
            {
                proceed.BackColor = Color.White;
                proceed.ForeColor = Color.Black;
            }
            else
            {
                proceed.BackColor = Color.Red;
                proceed.ForeColor = Color.White;
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmDlgCheckout checkout = new frmDlgCheckout();
            checkout.ShowDialog();
        }

        private void gotoWholesale()
        {
            DialogResult dr = MessageBox.Show("Do You Wish To Set Your Transaction to Wholesale?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                btnWholesale.Enabled = false;
                wholsale_select = true;
            }
        }

        private void btnWholesale_Click(object sender, EventArgs e)
        {
            gotoWholesale();
        }

        private void rdPrice_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                txtBoxEAN.Focus();
            }
        }

        private void rdTotal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                txtBoxEAN.Focus();
            }
        }

        private void rdTotal_MouseHover(object sender, EventArgs e)
        {
            txtBoxEAN.Focus();
        }

        private void rdPrice_MouseHover(object sender, EventArgs e)
        {
            txtBoxEAN.Focus();
        }

        private void txtBoxEAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void getInfoItem()
        {
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT inventory_stocks.stock_name AS a , inventory_items.kit_name AS b, ";
            query += "inventory_items.item_retail_price AS c, inventory_items.item_whole_price AS d ";
            query += "FROM inventory_items ";
            query += "INNER JOIN inventory_stocks ON inventory_items.stock_code = inventory_stocks.stock_code ";
            query += "WHERE (inventory_items.item_ean = ?item_ean)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?item_ean", txtBoxEAN.Text);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    rdDescription.Text = rdr["a"].ToString() + "" + rdr["b"].ToString();
                    if (btnWholesale.Enabled == false && wholsale_select == true) //If Teller Select to Wholse
                    {
                        price = Convert.ToDouble(rdr["d"]);
                        rdPrice.Text = Convert.ToDouble(rdr["d"]).ToString("#,###,##0.00");
                    }
                    else //Others Retail
                    {
                        price = Convert.ToDouble(rdr["c"]);
                        rdPrice.Text = Convert.ToDouble(rdr["c"]).ToString("#,###,##0.00");
                    }
                    found = true;
                }
                else
                    found = false;
                con.Close();
            }
            catch (Exception)
            {
                rdDescription.Text = "Error 11: Check Database Server";
            }
        }

        private void RecalculateSameItem()
        {
            computerItemQty = Convert.ToDouble(txtBoxQty.Text) * price;
            rdTotal.Text = computerItemQty.ToString("#,###,##0.00");
            Double total_fin = 0;
            foreach (ListViewItem lv in lviewPOS.Items)
            {
                total_fin += Double.Parse(lv.SubItems[5].Text);
            }
            lblTotalAmount.Text = total_fin.ToString("###,###,##0.00");
            txtBoxEAN.Clear();
            txtBoxEAN.Focus();
            txtBoxQty.Text = "1";
        }

        private void txtBoxEAN_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && proceeds == true)
                {
                    if (txtBoxQty.Text != "0" && txtBoxQty.Text != "00" && txtBoxQty.Text != "000" && txtBoxQty.Text != "0000" && txtBoxQty.Text != "00000" && txtBoxQty.Text != "000000")
                    {
                        getInfoItem();
                        if (found == true)
                        {
                            //
                            if (this.checkEANList(txtBoxEAN.Text, Convert.ToInt32(txtBoxQty.Text)) == false)
                            {
                                computerItemQty = Convert.ToDouble(txtBoxQty.Text) * price;
                                rdTotal.Text = computerItemQty.ToString("#,###,##0.00");
                                ListViewItem item = new ListViewItem(txtBoxEAN.Text);
                                item.SubItems.Add(txtBoxQty.Text);
                                item.SubItems.Add(rdDescription.Text);
                                item.SubItems.Add(price.ToString("#,###,##0.00"));
                                item.SubItems.Add("0.00");
                                item.SubItems.Add(computerItemQty.ToString("#,###,##0.00"));
                                lviewPOS.Items.Add(item);
                                btnWholesale.Enabled = false;
                                Double total_fin = 0;
                                foreach (ListViewItem lv in lviewPOS.Items)
                                {
                                    total_fin += Double.Parse(lv.SubItems[5].Text);
                                }
                                lblTotalAmount.Text = total_fin.ToString("###,###,##0.00");
                                txtBoxEAN.Clear();
                                txtBoxEAN.Focus();
                                txtBoxQty.Text = "1";
                            }
                            else
                            {
                                RecalculateSameItem();
                            }
                        }
                        else
                        {
                            timer3.Start();
                            rdDescription.Text = "Item Not Found!";
                            timer3.Interval = 3000;
                            timer3.Tick += new EventHandler(timer3_Tick);
                            txtBoxEAN.Clear();
                            txtBoxEAN.Focus();
                        }
                    }
                    else
                    {
                        timer3.Start();
                        rdDescription.Text = "Zero [0] Quantity Is Not Allowed!";
                        timer3.Interval = 3000;
                        timer3.Tick += new EventHandler(timer3_Tick);
                    }
                }
            }
            catch (Exception)
            {
                txtBoxQty.Focus();
            }
        }
        #region Checking
        private bool checkEANList(String Ean, Int32 qty)
        {
            bool check = false;
            Int32 uQTY;
            Double uTotal;
            try
            {
                foreach (ListViewItem item in lviewPOS.Items)
                {
                    String _ean = item.SubItems[0].Text;
                    if (_ean.Equals(Ean))
                    {
                        computerItemQty = Convert.ToDouble(txtBoxQty.Text) * price;
                        check = true;
                        uQTY = Convert.ToInt32(txtBoxQty.Text) + Convert.ToInt32(item.SubItems[1].Text);
                        uTotal = Convert.ToDouble(item.SubItems[5].Text) + computerItemQty;
                        item.SubItems[1].Text = uQTY.ToString();
                        item.SubItems[5].Text = uTotal.ToString("#,###,##0.00");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("frmMain::checkPLUList" + ex);
            }

            return check;
        }
        #endregion

        private void lviewPOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviewPOS.SelectedItems.Count > 0)
            {
                ListViewItem item = lviewPOS.SelectedItems[0];
                //Discount
                getTotalAmt = Convert.ToDouble(item.SubItems[5].Text);
                btnDiscount.Enabled = true;
                discountTx = true;
                //
            }
        }

        private void gotoDiscount()
        {
            //using (mPOrder newPO = new mPOrder())
            //{
            //    newPO.ShowDialog();
            //    var poDate = newPO.PurchaseOrderDate;
            //    this.po_orderTableAdapter.Fill(this.npos_dbDataSet.po_order, Convert.ToDateTime(poDate));
            //}
        }
    }
}