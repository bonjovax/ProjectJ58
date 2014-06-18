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
        #region System Config
        private Double taxP;
        private String taxDisplay;
        private String compName;
        private String address1;
        private String address2;
        private String contact;
        private String store_op;
        private String permit_no;
        private String TIN;
        private String TaxT;
        private String accreditation;
        private String serial_no;
        private String machine_no;
        private Int16 all_items_tax;
        #endregion
        private String itemTT;
        private MySqlConnection con = new MySqlConnection();
        private Conf.dbs dbcon = new Conf.dbs();
        private Conf.Crypto crypt = new Conf.Crypto();
        private DAO.LoginDAO login;
        private VO.ItemVO itemvo = new VO.ItemVO();
        private VO.PosVO pos = new VO.PosVO();
        private VO.CustomersVO customer = new VO.CustomersVO();
        private VO.GiftCardVO gcard = new VO.GiftCardVO();
        private bool wholsale_select = false;
        private bool proceeds = false;
        private Double price;
        private Double totalVar = 0;
        //
        private Int32 OrNo;
        //
        private Double computerItemQty;
        private bool found = false;
        private bool found_kit = false;

        #region Discount Variable
        private Double getTotalAmt;
        private bool discountTx = false;
        #endregion
        //
        private Int32 orderNo = 0;
        //Catch
        private Int32 catchEan = 0;
        private Int32 catchQty = 0;
        private Double catchPrice = 0;
        //

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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1 && btnSearch.Enabled == true)
            {
                gotoSearch();
                return true;
            }
            if (keyData == Keys.F3 && wholsale_select == false && btnWholesale.Enabled == true)
            {
                gotoWholesale();
                return true;
            }
            if (keyData == Keys.F4 && btnVoid.Enabled == true)
            {
                gotoVoid();
                return true;
            }
            if (keyData == Keys.F5 && btnVoid.Enabled == true)
            {
                gotoEdit();
                return true;
            }
            if (keyData == Keys.F6 && btnCancelSale.Enabled == true)
            {
                gotoCancelT();
                return true;
            }
            if (keyData == Keys.F7 && btnParkSale.Enabled == true)
            {
                gotoPark();
                return true;
            }
            if (keyData == Keys.F8 && btnCheckout.Enabled == true)
            {
                gotoCheckout();
            }
            if (keyData == Keys.F9 && btnDiscount.Enabled == true && discountTx == true)
            {
                gotoDiscount();
            }
            if (keyData == Keys.F10)
            {
                onFormClose();
                return true;
            }
            if (keyData == Keys.F12 && proceeds == false)
            {
                try
                {
                    frmLogin lg = new frmLogin(); //we'll use that ^_^
                    //
                    String userName = frmLogin.User.user_name;
                    lblSeriesNo.Text = pos.GetOrNo().ToString();
                    OrNo = pos.GetOrNo();
                    pos.Pos_orno = pos.GetOrNo();
                    pos.Pos_terminal = lg.tN;
                    pos.Pos_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                    pos.Pos_time = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
                    pos.Pos_user = userName;
                    pos.BeginTransaction();
                    //
                    proceed.Visible = false;
                    proceeds = true; //important
                    //
                    txtBoxQty.ReadOnly = false;
                    txtBoxQty.Text = "1";
                    txtBoxEAN.ReadOnly = false;
                    rdDescription.Clear();
                    //
                    btnSearch.Enabled = true;
                    btnRefund.Enabled = true;
                    btnWholesale.Enabled = true;
                    //btnParkSale.Enabled = false;
                    //
                    wholsale_select = false;
                    found = false;
                    found_kit = false;
                    discountTx = false;
                    //
                    rdDescription.Text = "Ready";
                    rdPrice.Text = "0.00";
                    rdTotal.Text = "0.00";
                    lblTotalAmount.Text = "0.00";
                    lblChangeDue.Text = "0.00";
                    lblVatable.Text = "0.00";
                    lviewPOS.Items.Clear();
                    txtBoxEAN.Focus();
                }
                catch (Exception)
                {
                    rdDescription.Text = "Error 10: Network Connection";
                }
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
            if (keyData == Keys.S)
            {
                lviewPOS.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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
            ConfigCheck();
            rdDescription.Text = compName;
            timer1.Start();
            String userName = frmLogin.User.user_name;
            lblUserAccount.Text = userName;
            lblProgversion.Text = "nPOS System v" + ProductVersion.ToString();
            //
            timer2.Start();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 250;
            //
            lblTax.Text = taxDisplay.ToString();
        }
        private void ConfigCheck()
        {
            frmLogin fl = new frmLogin();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT * FROM system_config";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr["tax_type"].ToString() == "V")
                    {
                        taxP = Convert.ToDouble("." + rdr["vat_rate"]);
                        taxDisplay = rdr["vat_rate"].ToString() + "%";
                        compName = rdr["company_name"].ToString();
                        address1 = rdr["company_address"].ToString();
                        address2 = rdr["company_address2"].ToString();
                        contact = rdr["company_contact"].ToString();
                        store_op = rdr["company_operator"].ToString();
                        TIN = rdr["tin_number"].ToString();
                        TaxT = rdr["tax_type"].ToString();
                        accreditation = rdr["accreditation_no"].ToString();
                        serial_no = rdr["serial_no"].ToString();
                        machine_no = rdr["machine_no"].ToString() + fl.tN;
                        all_items_tax = Convert.ToInt16(rdr["all_items_tax"]);
                    }
                    else
                    {
                        taxP = 0;
                        taxDisplay = "0%";
                        compName = rdr["company_name"].ToString();
                        address1 = rdr["company_address"].ToString();
                        address2 = rdr["company_address2"].ToString();
                        contact = rdr["company_contact"].ToString();
                        store_op = rdr["company_operator"].ToString();
                        TIN = rdr["tin_number"].ToString();
                        TaxT = rdr["tax_type"].ToString();
                        accreditation = rdr["accreditation_no"].ToString();
                        serial_no = rdr["serial_no"].ToString();
                        machine_no = rdr["machine_no"].ToString() + fl.tN;
                        all_items_tax = Convert.ToInt16(rdr["all_items_tax"]);
                    }
                }
                con.Close();
            }
            catch (Exception)
            {
                rdDescription.Text = "Error 11: Check Database Server";
            }
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
            gotoCheckout();
        }

        private void gotoWholesale()
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do You Wish To Set Your Transaction to Wholesale?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    pos.Pos_orno = OrNo;
                    pos.SwitchToWholeSale();
                    btnWholesale.Enabled = false;
                    wholsale_select = true;
                }
            }
            catch (Exception)
            {
                rdDescription.Text = "Error 11: Check Database Server";
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
            query += "inventory_items.item_retail_price AS c, inventory_items.item_whole_price AS d, inventory_items.item_tax_type AS e ";
            query += "FROM inventory_items ";
            query += "INNER JOIN inventory_stocks ON inventory_items.stock_code = inventory_stocks.stock_code ";
            query += "WHERE (inventory_items.item_ean = ?item_ean) AND (inventory_items.is_kit = 0)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?item_ean", txtBoxEAN.Text);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    rdDescription.Text = rdr["a"].ToString();
                    if (btnWholesale.Enabled == false && wholsale_select == true) //If Teller Select to Wholse
                    {
                        price = Convert.ToDouble(rdr["d"]);
                        rdPrice.Text = Convert.ToDouble(rdr["d"]).ToString("#,###,##0.00");
                        itemTT = rdr["e"].ToString();
                    }
                    else //Others Retail
                    {
                        price = Convert.ToDouble(rdr["c"]);
                        rdPrice.Text = Convert.ToDouble(rdr["c"]).ToString("#,###,##0.00");
                        itemTT = rdr["e"].ToString();
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
        private void getInfoItemKit()
        {
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT kit_name AS a, ";
            query += "item_retail_price AS b, item_whole_price AS c, item_tax_type AS d ";
            query += "FROM inventory_items ";
            query += "WHERE (item_ean = ?item_ean) AND (is_kit = 1)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?item_ean", txtBoxEAN.Text);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    rdDescription.Text = rdr["a"].ToString();
                    if (btnWholesale.Enabled == false && wholsale_select == true) //If Teller Select to Wholse
                    {
                        price = Convert.ToDouble(rdr["c"]);
                        rdPrice.Text = Convert.ToDouble(rdr["c"]).ToString("#,###,##0.00");
                        itemTT = rdr["d"].ToString();
                    }
                    else //Others Retail
                    {
                        price = Convert.ToDouble(rdr["b"]);
                        rdPrice.Text = Convert.ToDouble(rdr["b"]).ToString("#,###,##0.00");
                        itemTT = rdr["d"].ToString();
                    }
                    found_kit = true;
                }
                else
                    found_kit = false;
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
            Double total_fins = 0;
            Double a = 0;
            Double b = 0; //To Data Tax Amount
            Double vATable = 0;
            Double v1 = 0;
            Double v2 = 0;
            Double vExempt = 0;
            Double vZero = 0;
            foreach (ListViewItem lv in lviewPOS.Items)
            {
                total_fin += Double.Parse(lv.SubItems[5].Text);
                total_fins += Double.Parse(lv.SubItems[5].Text);
                if (lv.SubItems[6].Text == "V")
                {
                    if (all_items_tax == 1) //If All Items are Taxable
                    {
                        v1 += Double.Parse(lv.SubItems[5].Text);
                        v2 = v1 * taxP;
                        vATable = v1 - v2;
                    }
                    else //Otherwise
                    {
                        v1 += Double.Parse(lv.SubItems[5].Text);
                    }
                }
                if (lv.SubItems[6].Text == "E")
                {
                    vExempt += Double.Parse(lv.SubItems[5].Text);
                }
                if (lv.SubItems[6].Text == "Z")
                {
                    vZero += Double.Parse(lv.SubItems[5].Text);
                }
            }
            if (all_items_tax == 1) //If All Items are Taxable
            {
                if (TaxT == "V")
                {
                    lblVatable.Text = vATable.ToString("#,###,##0.00");
                    lblVATe.Text = vExempt.ToString("###,###,##0.00");
                    lblVATz.Text = vZero.ToString("###,###,##0.00");
                }
                else
                {
                    vATable = 0;
                    vExempt = 0;
                    vZero = 0;
                }
                lblTotalAmount.Text = total_fin.ToString("###,###,##0.00");
                if (itemTT == "V")
                {
                    if (TaxT == "V")
                    {
                        //Tax
                        a = v1 * taxP;
                        //Please Add Condition if Sale is VAT
                        lblTAXamt.Text = v2.ToString("#,###,##0.00");
                        b = v1 - a;
                        lblVatable.Text = b.ToString("#,###,##0.00");
                    }
                    else
                    {
                        a = 0;
                        v2 = 0;
                        b = 0;
                    }
                }

            }
            else
            {
                if (TaxT == "V")
                {
                    lblVatable.Text = v1.ToString("#,###,##0.00");
                    lblVATe.Text = vExempt.ToString("###,###,##0.00");
                    lblVATz.Text = vZero.ToString("###,###,##0.00");
                }
                if (itemTT == "V")
                {
                    if (TaxT == "V")
                    {
                        a = v1 * taxP;
                        lblTAXamt.Text = a.ToString("###,###,##0.00");
                    }
                    else
                    {
                        a = 0;
                    }
                }
                a = v1 * taxP;
                totalVar = v1 + vExempt + vZero + a;
                lblTotalAmount.Text = totalVar.ToString("###,###,##0.00");
            }
            pos.Pos_tax_perc = taxP;
            // Trunk Data
            if (all_items_tax == 1)
            {
                pos.Pos_tax_amt = v2;
                pos.Pos_total_amt = total_fin;
            }
            else
            {
                pos.Pos_tax_amt = a;
                pos.Pos_total_amt = totalVar;
            }
            pos.Pos_orno = OrNo;
            pos.UpdateTrunk();
            //
            txtBoxEAN.Clear();
            txtBoxEAN.Focus();
            txtBoxQty.Text = "1";
        }

        private void txtBoxEAN_KeyDown(object sender, KeyEventArgs e)
        {
            Int32 getQty = 0;
            try
            {
                if (e.KeyCode == Keys.Enter && proceeds == true)
                {
                    if (txtBoxQty.Text != "0" && txtBoxQty.Text != "00" && txtBoxQty.Text != "000" && txtBoxQty.Text != "0000" && txtBoxQty.Text != "00000" && txtBoxQty.Text != "000000")
                    {
                        getInfoItem();
                        getInfoItemKit();
                        if (found == true || found_kit == true)
                        {
                            itemvo.item_ean = txtBoxEAN.Text;
                            itemvo.askQty();
                            getQty = itemvo.askQty();
                            if (Convert.ToInt32(txtBoxQty.Text) <= getQty)
                            {
                                if (getQty <= 5) //Notifier if Item is Almost Exhausted
                                {
                                    using (cstDlgAlert alert = new cstDlgAlert())
                                    {
                                        alert.MsgDiri = getQty + " Item(s) Left in your Item Inventory";
                                        alert.ShowDialog();
                                    }
                                }
                                //
                                if (this.checkEANList(txtBoxEAN.Text, Convert.ToInt32(txtBoxQty.Text)) == false)
                                {
                                    itemvo.item_quantity = Convert.ToInt32(txtBoxQty.Text);
                                    itemvo.OrderItem();
                                    computerItemQty = Convert.ToDouble(txtBoxQty.Text) * price;
                                    rdTotal.Text = computerItemQty.ToString("#,###,##0.00");
                                    ListViewItem item = new ListViewItem(txtBoxEAN.Text);
                                    item.SubItems.Add(txtBoxQty.Text);
                                    item.SubItems.Add(rdDescription.Text);
                                    item.SubItems.Add(price.ToString("#,###,##0.00"));
                                    item.SubItems.Add("0.00");
                                    item.SubItems.Add(computerItemQty.ToString("#,###,##0.00"));
                                    item.SubItems.Add(itemTT);
                                    lviewPOS.Items.Add(item);
                                    //Data
                                    pos.Pos_orno = OrNo;
                                    pos.Pos_ean = Convert.ToInt32(txtBoxEAN.Text);
                                    pos.Pos_quantity = Convert.ToInt32(txtBoxQty.Text);
                                    pos.Pos_amt = computerItemQty;
                                    pos.ParkItem();
                                    //
                                    //
                                    btnWholesale.Enabled = false;
                                    Double total_fin = 0;
                                    Double total_fins = 0;
                                    Double a = 0;
                                    Double b = 0; //To Data Tax Amount
                                    Double vATable = 0;
                                    Double v1 = 0;
                                    Double v2 = 0;
                                    Double vExempt = 0;
                                    Double vZero = 0;
                                    foreach (ListViewItem lv in lviewPOS.Items)
                                    {
                                        total_fin += Double.Parse(lv.SubItems[5].Text);
                                        total_fins += Double.Parse(lv.SubItems[5].Text);
                                        if (lv.SubItems[6].Text == "V")
                                        {
                                            if (all_items_tax == 1) //If All Items are Taxable
                                            {
                                                v1 += Double.Parse(lv.SubItems[5].Text);
                                                v2 = v1 * taxP;
                                                vATable = v1 - v2;
                                            }
                                            else //Otherwise
                                            {
                                                v1 += Double.Parse(lv.SubItems[5].Text);
                                            }
                                        }
                                        if (lv.SubItems[6].Text == "E")
                                        {
                                            vExempt += Double.Parse(lv.SubItems[5].Text);
                                        }
                                        if (lv.SubItems[6].Text == "Z")
                                        {
                                            vZero += Double.Parse(lv.SubItems[5].Text);
                                        }
                                    }
                                    if (all_items_tax == 1) //If All Items are Taxable
                                    {
                                        if (TaxT == "V")
                                        {
                                            lblVatable.Text = vATable.ToString("#,###,##0.00");
                                            lblVATe.Text = vExempt.ToString("###,###,##0.00");
                                            lblVATz.Text = vZero.ToString("###,###,##0.00");
                                        }
                                        else
                                        {
                                            vATable = 0;
                                            vExempt = 0;
                                            vZero = 0;
                                        }
                                        lblTotalAmount.Text = total_fin.ToString("###,###,##0.00");
                                        if (itemTT == "V")
                                        {
                                            if (TaxT == "V")
                                            {
                                                //Tax
                                                a = v1 * taxP;
                                                //Please Add Condition if Sale is VAT
                                                lblTAXamt.Text = v2.ToString("#,###,##0.00");
                                                b = v1 - a;
                                                lblVatable.Text = b.ToString("#,###,##0.00");
                                            }
                                            else
                                            {
                                                a = 0;
                                                v2 = 0;
                                                b = 0;
                                            }
                                        }
                                        
                                    }
                                    else
                                    {
                                        if (TaxT == "V")
                                        {
                                            lblVatable.Text = v1.ToString("#,###,##0.00");
                                            lblVATe.Text = vExempt.ToString("###,###,##0.00");
                                            lblVATz.Text = vZero.ToString("###,###,##0.00");
                                        }
                                        if (itemTT == "V")
                                        {
                                            if (TaxT == "V")
                                            {
                                                a = v1 * taxP;
                                                lblTAXamt.Text = a.ToString("###,###,##0.00");
                                            }
                                            else
                                            {
                                                a = 0;
                                            }
                                        }
                                        a = v1 * taxP;
                                        totalVar = v1 + vExempt + vZero + a;
                                        lblTotalAmount.Text = totalVar.ToString("###,###,##0.00");
                                    }                                  
                                    pos.Pos_tax_perc = taxP;
                                    // Trunk Data
                                    if (all_items_tax == 1)
                                    {
                                        pos.Pos_tax_amt = v2;
                                        pos.Pos_total_amt = total_fin;
                                    }
                                    else
                                    {
                                        pos.Pos_tax_amt = a;
                                        pos.Pos_total_amt = totalVar;
                                    }
                                    pos.Pos_orno = OrNo;
                                    pos.UpdateTrunk();
                                    //
                                    if (lviewPOS.Items.Count != 0)
                                    {
                                        btnCheckout.Enabled = true;
                                        btnCancelSale.Enabled = true;
                                        btnParkSale.Enabled = false;
                                    }
                                    else
                                    {
                                        btnCheckout.Enabled = false;
                                        btnCancelSale.Enabled = false;
                                        btnParkSale.Enabled = true;
                                    }
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
                                using (cstDlgAlert alert = new cstDlgAlert())
                                {
                                    if (getQty == 0)
                                    {
                                        alert.MsgDiri = "Insufficient Quantity Inventory Item!";
                                        alert.ShowDialog();
                                        txtBoxEAN.Clear();
                                        txtBoxEAN.Focus();
                                    }
                                    else
                                    {
                                        alert.MsgDiri = getQty + " Item Available! Insufficient Quantity Inventory Item";
                                        alert.ShowDialog();
                                        txtBoxEAN.Clear();
                                        txtBoxEAN.Focus();
                                    }
                                }
                            }
                        }
                        else
                        {
                            rdDescription.Text = "Item Not Found!";
                            txtBoxEAN.Clear();
                            txtBoxEAN.Focus();
                        }
                    }
                    else
                    {
                        rdDescription.Text = "Zero [0] Quantity Is Not Allowed!";
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
                        itemvo.item_ean = txtBoxEAN.Text;
                        itemvo.item_quantity = Convert.ToInt32(txtBoxQty.Text);
                        itemvo.OrderItem();
                        computerItemQty = Convert.ToDouble(txtBoxQty.Text) * price;
                        check = true;
                        uQTY = Convert.ToInt32(txtBoxQty.Text) + Convert.ToInt32(item.SubItems[1].Text);
                        uTotal = Convert.ToDouble(item.SubItems[5].Text) + computerItemQty;
                        item.SubItems[1].Text = uQTY.ToString();
                        item.SubItems[5].Text = uTotal.ToString("#,###,##0.00");
                        //Data
                        pos.Pos_orno = OrNo;
                        pos.Pos_ean = Convert.ToInt32(txtBoxEAN.Text);
                        pos.Pos_quantity = Convert.ToInt32(txtBoxQty.Text);
                        pos.Pos_amt = uTotal;
                        pos.ParkItemSameUpdate();
                        //
                    }
                }
            }
            catch (Exception)
            {
                rdDescription.Text = "Error 11: Check Database Server";
            }

            return check;
        }
        #endregion

        private void lviewPOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviewPOS.SelectedItems.Count > 0)
            {
                ListViewItem item = lviewPOS.SelectedItems[0];
                catchEan = Convert.ToInt32(item.Text);
                catchQty = Convert.ToInt32(item.SubItems[1].Text);
                catchPrice = Convert.ToDouble(item.SubItems[3].Text);
                //Discount
                getTotalAmt = Convert.ToDouble(item.SubItems[5].Text);
                btnDiscount.Enabled = true;
                btnVoid.Enabled = true; //Void
                discountTx = true;
                //
                login = new DAO.LoginDAO();
                String userName = frmLogin.User.user_name;
                login.catchUsername(userName);
                if (login.hasUser_Accounts())
                {
                    btnEdit.Enabled = true;
                }   
            }
        }

        #region GotoKing
        private void gotoDiscount()
        {
            try
            {
                Double a = 0;
                Double b = 0;
                using (frmDlgDiscount disc = new frmDlgDiscount())
                {
                    ListViewItem item = lviewPOS.SelectedItems[0];
                    disc.ShowDialog();
                    var discp = disc.Percentage;
                    if (disc.Percentage != 0)
                    {
                        a = getTotalAmt * disc.Percentage;
                        b = getTotalAmt - a;
                        item.SubItems[4].Text = a.ToString("#,###,##0.00");
                        item.SubItems[5].Text = b.ToString("#,###,##0.00");
                        Double total_disc = 0;
                        Double total_discs = 0;
                        Double x = 0;
                        Double y = 0;
                        foreach (ListViewItem items in lviewPOS.Items)
                        {
                            total_disc += Double.Parse(items.SubItems[5].Text);
                            total_discs += Double.Parse(items.SubItems[5].Text);
                        }
                        lblTotalAmount.Text = total_disc.ToString("###,###,##0.00");
                        //Tax
                        x = total_discs * taxP;
                        //Please Add Condition if Sale is VAT
                        lblTAXamt.Text = x.ToString("#,###,##0.00");
                        y = total_disc - x;
                        lblVatable.Text = y.ToString("#,###,##0.00");
                        //
                        // Trunk Data
                        pos.Pos_tax_perc = taxP;
                        pos.Pos_tax_amt = x;
                        pos.Pos_total_amt = total_disc;
                        pos.Pos_orno = OrNo;
                        pos.UpdateTrunk();
                        //Update Park Item With Discount
                        pos.Pos_ean = catchEan;
                        pos.Pos_discount = disc.Percentage;
                        pos.Pos_discount_amt = a;
                        pos.Pos_amt = b;
                        pos.ParkDiscountItemUpdate();
                        //
                        btnDiscount.Enabled = false;
                        btnEdit.Enabled = false;
                        btnVoid.Enabled = false;
                        discountTx = false;
                    }
                    else
                    {
                        btnDiscount.Enabled = false;
                        btnEdit.Enabled = false;
                        btnVoid.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                rdDescription.Text = "Error 10: Network Connection";
            }
        }

        private void gotoEdit()
        {
            try
            {
                Int32 qty = 0;
                Double x = 0;
                using (frmDlgEditQty edit = new frmDlgEditQty())
                {
                    ListViewItem item = lviewPOS.SelectedItems[0];
                    Int32 uEan = Convert.ToInt32(item.Text);
                    edit.dQty = Convert.ToInt32(item.SubItems[1].Text); //Display
                    edit.ShowDialog();
                    if (edit.Qty != 0)
                    {
                        item.SubItems[1].Text = edit.Qty.ToString();
                        qty = Convert.ToInt32(item.SubItems[1].Text); //Computation
                        x = qty * Convert.ToDouble(item.SubItems[3].Text); // Get Initial Total
                        item.SubItems[4].Text = "0.00"; //Discount
                        item.SubItems[5].Text = x.ToString("#,###,##0.00"); //Total
                        btnEdit.Enabled = false;
                        btnDiscount.Enabled = false;
                        btnVoid.Enabled = false;
                        Double a = 0;
                        Double b = 0; //To Data Tax Amount
                        Double total_fin = 0;
                        Double vATable = 0;
                        Double v1 = 0;
                        Double v2 = 0;
                        Double vExempt = 0;
                        Double vZero = 0;
                        foreach (ListViewItem lv in lviewPOS.Items)
                        {
                            total_fin += Double.Parse(lv.SubItems[5].Text);
                            //total_fins += Double.Parse(lv.SubItems[5].Text);
                            if (lv.SubItems[6].Text == "V")
                            {
                                if (all_items_tax == 1) //If All Items are Taxable
                                {
                                    v1 += Double.Parse(lv.SubItems[5].Text);
                                    v2 = v1 * taxP;
                                    vATable = v1 - v2;
                                }
                                else //Otherwise
                                {
                                    v1 += Double.Parse(lv.SubItems[5].Text);
                                }
                            }
                            if (lv.SubItems[6].Text == "E")
                            {
                                vExempt += Double.Parse(lv.SubItems[5].Text);
                            }
                            if (lv.SubItems[6].Text == "Z")
                            {
                                vZero += Double.Parse(lv.SubItems[5].Text);
                            }
                        }
                        if (all_items_tax == 1) //If All Items are Taxable
                        {
                            if (TaxT == "V")
                            {
                                lblVatable.Text = vATable.ToString("#,###,##0.00");
                                lblVATe.Text = vExempt.ToString("###,###,##0.00");
                                lblVATz.Text = vZero.ToString("###,###,##0.00");
                            }
                            else
                            {
                                vATable = 0;
                                vExempt = 0;
                                vZero = 0;
                            }
                            lblTotalAmount.Text = total_fin.ToString("###,###,##0.00");
                            if (itemTT == "V")
                            {
                                if (TaxT == "V")
                                {
                                    //Tax
                                    a = v1 * taxP;
                                    //Please Add Condition if Sale is VAT
                                    lblTAXamt.Text = v2.ToString("#,###,##0.00");
                                    b = v1 - a;
                                    lblVatable.Text = b.ToString("#,###,##0.00");
                                }
                                else
                                {
                                    a = 0;
                                    v2 = 0;
                                    b = 0;
                                }
                            }

                        }
                        else
                        {
                            if (TaxT == "V")
                            {
                                lblVatable.Text = v1.ToString("#,###,##0.00");
                                lblVATe.Text = vExempt.ToString("###,###,##0.00");
                                lblVATz.Text = vZero.ToString("###,###,##0.00");
                            }
                            if (itemTT == "V")
                            {
                                if (TaxT == "V")
                                {
                                    a = v1 * taxP;
                                    lblTAXamt.Text = a.ToString("###,###,##0.00");
                                }
                                else
                                {
                                    a = 0;
                                }
                            }
                            a = v1 * taxP;
                            totalVar = v1 + vExempt + vZero + a;
                            lblTotalAmount.Text = totalVar.ToString("###,###,##0.00");
                        }
                        pos.Pos_tax_perc = taxP;
                        // Trunk Data
                        if (all_items_tax == 1)
                        {
                            pos.Pos_tax_amt = v2;
                            pos.Pos_total_amt = total_fin;
                        }
                        else
                        {
                            pos.Pos_tax_amt = a;
                            pos.Pos_total_amt = totalVar;
                        }
                        //Update Data
                        pos.Pos_orno = OrNo;
                        pos.Pos_ean = uEan;
                        pos.Pos_quantity = qty;
                        pos.Pos_amt = x;
                        pos.ParkItemUpdate();
                        //
                        // Trunk Data
                        pos.Pos_tax_perc = taxP;
                        pos.Pos_orno = OrNo;
                        pos.UpdateTrunk();
                        //
                    }
                    else
                    {
                        btnDiscount.Enabled = false;
                        btnEdit.Enabled = false;
                        btnVoid.Enabled = false;
                    }
                    txtBoxEAN.Focus();
                }
            }
            catch (Exception)
            {
                rdDescription.Text = "Error 10: Network Connection";
            }
        }

        private void gotoVoid()
        {
            DialogResult dlg = MessageBox.Show("Do you wish to Continue?", "Void Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Int32 eanX = catchEan;
                    lviewPOS.SelectedItems[0].Remove();
                    Double total_fin = 0;
                    Double total_fins = 0;
                    Double a = 0;
                    Double b = 0; //To Data Tax Amount
                    Double vATable = 0;
                    Double v1 = 0;
                    Double v2 = 0;
                    Double vExempt = 0;
                    Double vZero = 0;
                    foreach (ListViewItem lv in lviewPOS.Items)
                    {
                        total_fin += Double.Parse(lv.SubItems[5].Text);
                        total_fins += Double.Parse(lv.SubItems[5].Text);
                        if (lv.SubItems[6].Text == "V")
                        {
                            if (all_items_tax == 1) //If All Items are Taxable
                            {
                                v1 += Double.Parse(lv.SubItems[5].Text);
                                v2 = v1 * taxP;
                                vATable = v1 - v2;
                            }
                            else //Otherwise
                            {
                                v1 += Double.Parse(lv.SubItems[5].Text);
                            }
                        }
                        if (lv.SubItems[6].Text == "E")
                        {
                            vExempt += Double.Parse(lv.SubItems[5].Text);
                        }
                        if (lv.SubItems[6].Text == "Z")
                        {
                            vZero += Double.Parse(lv.SubItems[5].Text);
                        }
                    }
                    if (all_items_tax == 1) //If All Items are Taxable
                    {
                        if (TaxT == "V")
                        {
                            lblVatable.Text = vATable.ToString("#,###,##0.00");
                            lblVATe.Text = vExempt.ToString("###,###,##0.00");
                            lblVATz.Text = vZero.ToString("###,###,##0.00");
                        }
                        else
                        {
                            vATable = 0;
                            vExempt = 0;
                            vZero = 0;
                        }
                        lblTotalAmount.Text = total_fin.ToString("###,###,##0.00");
                        if (itemTT == "V")
                        {
                            if (TaxT == "V")
                            {
                                //Tax
                                a = v1 * taxP;
                                //Please Add Condition if Sale is VAT
                                lblTAXamt.Text = v2.ToString("#,###,##0.00");
                                b = v1 - a;
                                lblVatable.Text = b.ToString("#,###,##0.00");
                            }
                            else
                            {
                                a = 0;
                                v2 = 0;
                                b = 0;
                            }
                        }

                    }
                    else
                    {
                        if (TaxT == "V")
                        {
                            lblVatable.Text = v1.ToString("#,###,##0.00");
                            lblVATe.Text = vExempt.ToString("###,###,##0.00");
                            lblVATz.Text = vZero.ToString("###,###,##0.00");
                        }
                        if (itemTT == "V")
                        {
                            if (TaxT == "V")
                            {
                                a = v1 * taxP;
                                lblTAXamt.Text = a.ToString("###,###,##0.00");
                            }
                            else
                            {
                                a = 0;
                            }
                        }
                        a = v1 * taxP;
                        totalVar = v1 + vExempt + vZero + a;
                        lblTotalAmount.Text = totalVar.ToString("###,###,##0.00");
                    }
                    pos.Pos_tax_perc = taxP;
                    // Trunk Data
                    if (all_items_tax == 1)
                    {
                        pos.Pos_tax_amt = v2;
                        pos.Pos_total_amt = total_fin;
                    }
                    else
                    {
                        pos.Pos_tax_amt = a;
                        pos.Pos_total_amt = totalVar;
                    }
                    pos.Pos_orno = OrNo;
                    pos.UpdateTrunk();
                    //Void Item Data
                    pos.Pos_ean = eanX;
                    pos.Pos_quantity = catchQty;
                    pos.ParkVoidItem();
                    //
                    btnVoid.Enabled = false;
                    if (lviewPOS.Items.Count != 0)
                    {
                        btnCheckout.Enabled = true;
                        btnCancelSale.Enabled = true;
                        btnParkSale.Enabled = false;
                    }
                    else
                    {
                        btnCheckout.Enabled = false;
                        btnCancelSale.Enabled = false;
                        btnParkSale.Enabled = true;
                    }
                    btnDiscount.Enabled = false;
                    btnEdit.Enabled = false;
                    btnVoid.Enabled = false;
                    txtBoxEAN.Focus();
                }
                catch (Exception)
                {
                    rdDescription.Text = "Error 10: Network Connection";
                }
            }
        }

        private void gotoCheckout()
        {
            try
            {
                frmDlgCheckout checkout = new frmDlgCheckout();
                frmLogin lg = new frmLogin(); //we'll use that ^_^
                checkout.GetAmount = Double.Parse(lblTotalAmount.Text);
                checkout.ShowDialog();
                //For Cash
                if (checkout.IsCashTX == true)
                {
                    lblChangeDue.Text = checkout.ChangeDue.ToString("#,###,##0.00");
                    btnSearch.Enabled = false;
                    btnRefund.Enabled = false;
                    btnWholesale.Enabled = false;
                    btnCancelSale.Enabled = false;
                    btnParkSale.Enabled = true;
                    btnVoid.Enabled = false;
                    btnEdit.Enabled = false;
                    btnCancelSale.Enabled = false;
                    btnCheckout.Enabled = false; //Very Important La
                    btnDiscount.Enabled = false;
                    txtBoxQty.ReadOnly = true;
                    txtBoxEAN.ReadOnly = true;
                    txtBoxEAN.Focus();
                    proceeds = false; //Important
                    //
                    pos.Pos_tender = checkout.TenderAmount;
                    pos.Pos_change = checkout.ChangeDue;
                    pos.Pos_orno = OrNo;
                    pos.Pos_terminal = lg.tN;
                    pos.CashCheckout();
                    //
                    newFlash();
                }
                if (checkout.IsDCTX == true) //Debit Credit Card
                {
                    btnSearch.Enabled = false;
                    btnRefund.Enabled = false;
                    btnWholesale.Enabled = false;
                    btnCancelSale.Enabled = false;
                    btnParkSale.Enabled = true;
                    btnVoid.Enabled = false;
                    btnEdit.Enabled = false;
                    btnCancelSale.Enabled = false;
                    btnCheckout.Enabled = false; //Very Important La
                    btnDiscount.Enabled = false;
                    txtBoxQty.ReadOnly = true;
                    txtBoxEAN.ReadOnly = true;
                    txtBoxEAN.Focus();
                    proceeds = false; //Important
                    //
                    pos.Pos_tender = Double.Parse(lblTotalAmount.Text);
                    pos.Pos_orno = OrNo;
                    pos.Pos_terminal = lg.tN;
                    String enx = crypt.EncryptText(checkout.CardNo, lg.tN);
                    pos.Card_data = enx;
                    pos.Card_lastfour = checkout.CardNo.Substring(checkout.CardNo.Length - 4, 4);
                    pos.Card_type = checkout.CardType;
                    pos.Tx_amount = Double.Parse(lblTotalAmount.Text);
                    pos.DCCardCheckout();
                    //
                    newFlash();
                }
                if (checkout.IsBCTX == true) //Bank Cheque
                {
                    btnSearch.Enabled = false;
                    btnRefund.Enabled = false;
                    btnWholesale.Enabled = false;
                    btnCancelSale.Enabled = false;
                    btnParkSale.Enabled = true;
                    btnVoid.Enabled = false;
                    btnEdit.Enabled = false;
                    btnCancelSale.Enabled = false;
                    btnCheckout.Enabled = false; //Very Important La
                    btnDiscount.Enabled = false;
                    txtBoxQty.ReadOnly = true;
                    txtBoxEAN.ReadOnly = true;
                    txtBoxEAN.Focus();
                    proceeds = false; //Important
                    //
                    pos.Pos_tender = Double.Parse(lblTotalAmount.Text);
                    pos.Pos_orno = OrNo;
                    pos.Pos_terminal = lg.tN;
                    pos.Bc_checkno = checkout.CheckNo;
                    pos.Bc_banknbranch = checkout.BankNBranch;
                    pos.Bc_refcode = checkout.CRef;
                    pos.Tx_amount = Double.Parse(lblTotalAmount.Text);
                    pos.BankCheckout();
                    //
                    newFlash();
                }
                if (checkout.IsGCTX == true)
                {
                    btnSearch.Enabled = false;
                    btnRefund.Enabled = false;
                    btnWholesale.Enabled = false;
                    btnCancelSale.Enabled = false;
                    btnParkSale.Enabled = true;
                    btnVoid.Enabled = false;
                    btnEdit.Enabled = false;
                    btnCancelSale.Enabled = false;
                    btnCheckout.Enabled = false; //Very Important La
                    btnDiscount.Enabled = false;
                    txtBoxQty.ReadOnly = true;
                    txtBoxEAN.ReadOnly = true;
                    txtBoxEAN.Focus();
                    proceeds = false; //Important
                    //
                    pos.Pos_tender = checkout.GetAmount;
                    pos.Pos_orno = OrNo;
                    pos.Pos_terminal = lg.tN;
                    pos.Gc_cardo = checkout.Gc_code;
                    pos.Tx_amount = checkout.GetAmount; //Same
                    pos.GiftCardCheckout();
                    //
                    gcard.Gc_amount = checkout.GetAmount;
                    gcard.Gc_cardno = checkout.Gc_code;
                    gcard.DebitGC();
                    //
                    newFlash();
                }
                if (checkout.IsARTX == true) //CRM A/R Basic Codes
                {
                    btnSearch.Enabled = false;
                    btnRefund.Enabled = false;
                    btnWholesale.Enabled = false;
                    btnCancelSale.Enabled = false;
                    btnParkSale.Enabled = true;
                    btnVoid.Enabled = false;
                    btnEdit.Enabled = false;
                    btnCancelSale.Enabled = false;
                    btnCheckout.Enabled = false; //Very Important La
                    btnDiscount.Enabled = false;
                    txtBoxQty.ReadOnly = true;
                    txtBoxEAN.ReadOnly = true;
                    txtBoxEAN.Focus();
                    proceeds = false; //Important
                    //
                    pos.Pos_customer = checkout.Company;
                    pos.Pos_tender = checkout.GetAmount;
                    pos.Pos_orno = OrNo;
                    pos.Pos_terminal = lg.tN;
                    pos.Crm_custcode = checkout.Custcode;
                    pos.Tx_amount = checkout.GetAmount; //Same
                    pos.ARBasicCheckout();
                    //
                    customer.Balance = checkout.GetAmount;
                    customer.Payable = checkout.GetAmount;
                    customer.Custcode = checkout.Custcode;
                    customer.CreditToAccount();
                    //
                    newFlash();
                }
            }
            catch (Exception)
            {
                rdDescription.Text = "Error 10: Network Connection";
            }
        }

        private void gotoPark()
        {
            try
            {
                using (frmDlgPark park = new frmDlgPark())
                {
                    park.ShowDialog();
                    if (park.Selected == true)
                    {
                        orderNo = park.OrderNo;
                        lblSeriesNo.Text = orderNo.ToString();
                        detectWholesale();
                        loadParkedData();
                        OrNo = park.OrderNo;
                        //
                        proceed.Visible = false;
                        proceeds = true; //important
                        //
                        txtBoxQty.ReadOnly = false;
                        txtBoxQty.Text = "1";
                        txtBoxEAN.ReadOnly = false;
                        rdDescription.Clear();
                        rdDescription.Text = "Ready";
                        lblChangeDue.Text = "0.00";
                        //
                        btnSearch.Enabled = true;
                        btnRefund.Enabled = true;
                        btnCancelSale.Enabled = true;
                        //
                        Double total_fin = 0;
                        Double total_fins = 0;
                        Double a = 0;
                        Double b = 0; //To Data Tax Amount
                        Double vATable = 0;
                        Double v1 = 0;
                        Double v2 = 0;
                        Double vExempt = 0;
                        Double vZero = 0;
                        
                        foreach (ListViewItem lv in lviewPOS.Items)
                        {
                            total_fin += Double.Parse(lv.SubItems[5].Text);
                            total_fins += Double.Parse(lv.SubItems[5].Text);
                            if (lv.SubItems[6].Text == "V")
                            {
                                if (all_items_tax == 1) //If All Items are Taxable
                                {
                                    itemTT = lv.SubItems[6].Text;
                                    v1 += Double.Parse(lv.SubItems[5].Text);
                                    v2 = v1 * taxP;
                                    vATable = v1 - v2;
                                }
                                else //Otherwise
                                {
                                    itemTT = lv.SubItems[6].Text;
                                    v1 += Double.Parse(lv.SubItems[5].Text);
                                }
                            }
                            if (lv.SubItems[6].Text == "E")
                            {
                                vExempt += Double.Parse(lv.SubItems[5].Text);
                            }
                            if (lv.SubItems[6].Text == "Z")
                            {
                                vZero += Double.Parse(lv.SubItems[5].Text);
                            }
                        }
                        if (all_items_tax == 1) //If All Items are Taxable
                        {
                            if (TaxT == "V")
                            {
                                lblVatable.Text = vATable.ToString("#,###,##0.00");
                                lblVATe.Text = vExempt.ToString("###,###,##0.00");
                                lblVATz.Text = vZero.ToString("###,###,##0.00");
                            }
                            else
                            {
                                vATable = 0;
                                vExempt = 0;
                                vZero = 0;
                            }
                            lblTotalAmount.Text = total_fin.ToString("###,###,##0.00");
                            if (itemTT == "V")
                            {
                                if (TaxT == "V")
                                {
                                    //Tax
                                    a = v1 * taxP;
                                    //Please Add Condition if Sale is VAT
                                    lblTAXamt.Text = v2.ToString("#,###,##0.00");
                                    b = v1 - a;
                                    lblVatable.Text = b.ToString("#,###,##0.00");
                                }
                                else
                                {
                                    a = 0;
                                    v2 = 0;
                                    b = 0;
                                }
                            }

                        }
                        else
                        {
                            if (TaxT == "V")
                            {
                                lblVatable.Text = v1.ToString("#,###,##0.00");
                                lblVATe.Text = vExempt.ToString("###,###,##0.00");
                                lblVATz.Text = vZero.ToString("###,###,##0.00");
                            }
                            if (itemTT == "V")
                            {
                                if (TaxT == "V")
                                {
                                    a = v1 * taxP;
                                    lblTAXamt.Text = a.ToString("###,###,##0.00");
                                }
                                else
                                {
                                    a = 0;
                                }
                            }
                            a = v1 * taxP;
                            totalVar = v1 + vExempt + vZero + a;
                            lblTotalAmount.Text = totalVar.ToString("###,###,##0.00");
                        }
                        pos.Pos_tax_perc = taxP;
                        if (lviewPOS.Items.Count != 0)
                        {
                            btnCancelSale.Enabled = true;
                            btnCheckout.Enabled = true;
                            btnParkSale.Enabled = false;
                        }
                        else
                        {
                            btnCancelSale.Enabled = false;
                            btnCheckout.Enabled = false;
                            btnParkSale.Enabled = true;
                        }

                        txtBoxEAN.Focus();
                    }
                }
            }
            catch (Exception)
            {
                rdDescription.Text = "Error 10: Network Connection";
            }
        }

        private void gotoCancelT()
        {
            DialogResult dlg = MessageBox.Show("Do you Wish To Cancel Transaction Made By You?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                String query = "SELECT pos_ean, pos_quantity FROM pos_park ";
                query += "WHERE pos_orno = ?pos_orno";
                using (MySqlConnection con = new MySqlConnection(dbcon.getConnectionString()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                    {
                        try
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("?pos_orno", OrNo);
                            pos.Pos_orno = OrNo;
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                Int32 Eans = 0;
                                Int32 qtys = 0;
                                Eans = Convert.ToInt32(dataTable.Rows[i][0]);
                                qtys = Convert.ToInt32(dataTable.Rows[i][1]);
                                //Data Integration Return Sale to Item
                                pos.Pos_ean = Eans;
                                pos.Pos_quantity = qtys;
                                pos.ReturnCancelItems();
                                //
                            }
                            //Wipe all Park Item and Switch Core Table to Cancelled
                            pos.CancelSale();
                            //
                            //Event
                            lviewPOS.Items.Clear();
                            btnSearch.Enabled = false;
                            btnRefund.Enabled = false;
                            btnWholesale.Enabled = false;
                            btnCancelSale.Enabled = false;
                            btnVoid.Enabled = false;
                            btnEdit.Enabled = false;
                            btnCancelSale.Enabled = false;
                            btnCheckout.Enabled = false; //Very Important La
                            btnDiscount.Enabled = false;
                            txtBoxQty.ReadOnly = true;
                            txtBoxEAN.ReadOnly = true;
                            txtBoxEAN.Focus();
                            proceeds = false; //Important
                            //
                            proceed.Visible = true;
                            txtBoxQty.Text = "1";
                            rdDescription.Text = "Transaction Cancelled!";
                            lblVatable.Text = "0.00";
                            rdPrice.Text = "0.00";
                            rdTotal.Text = "0.00";
                            lblTotalAmount.Text = "0.00";
                            //
                        }
                        catch (MySqlException)
                        {
                            rdDescription.Text = "Error 10: Network Connection";
                        }
                    }
                }
            }
        }

        private void gotoSearch()
        {
            try
            {
                using (frmDlgSearch search = new frmDlgSearch())
                {
                    search.ShowDialog();
                    if (search.Selected == true)
                    {
                        txtBoxEAN.Text = search.Ean;
                        txtBoxEAN.Focus();
                    }
                    else
                        txtBoxEAN.Focus();
                }
            }
            catch (Exception)
            {
                rdDescription.Text = "Error 10: Network Connection";
            }
        }

        private void newFlash()
        {
            proceed.Visible = true;
            txtBoxQty.Text = "1";
            rdDescription.Text = "Thank You For Shopping!";
            rdPrice.Text = "0.00";
            rdTotal.Text = "0.00";
        }

        void timer4_Tick(object sender, EventArgs e)
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

        #endregion

        private void detectWholesale()
        {
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT pos_iswholesale AS a FROM pos_store ";
            query += "WHERE (pos_orno = ?pos_orno) AND (pos_iswholesale = 1)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_orno", orderNo);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr["a"].ToString() == "1")
                    {
                        wholsale_select = true;
                        btnWholesale.Enabled = false;
                    }
                    else
                    {
                        wholsale_select = false;
                        btnWholesale.Enabled = false;
                    }
                }
                con.Close();
            }
            catch (Exception)
            {
                rdDescription.Text = "Error 10: Network Connection";
            }
        }
        private void loadParkedData()
        {
            try
            {
                lviewPOS.Items.Clear();
                con.ConnectionString = dbcon.getConnectionString();
                con.Open();
                String query = "SELECT pos_park.pos_ean AS a, pos_park.pos_quantity AS b, inventory_stocks.stock_name AS c, inventory_items.item_retail_price AS d, inventory_items.item_whole_price AS e, pos_park.pos_discount_amt AS f, pos_park.pos_amt AS g, inventory_items.item_tax_type AS h ";
                query += "FROM pos_park INNER JOIN inventory_items ON pos_park.pos_ean = inventory_items.item_ean INNER JOIN inventory_stocks ON inventory_items.stock_code = inventory_stocks.stock_code ";
                query += "WHERE (pos_park.pos_orno = ?pos_orno) ";
                query += "UNION ALL "; //Thanks to this Clause It Made My Life Easier ^_^
                query += "SELECT pos_park.pos_ean AS a, pos_park.pos_quantity AS b, inventory_items.kit_name AS c, inventory_items.item_retail_price AS d, inventory_items.item_whole_price AS e, pos_park.pos_discount_amt AS f, pos_park.pos_amt AS g, inventory_items.item_tax_type AS h ";
                query += "FROM pos_park INNER JOIN inventory_items ON pos_park.pos_ean = inventory_items.item_ean ";
                query += "WHERE (pos_park.pos_orno = ?pos_orno) AND (inventory_items.is_kit = 1)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos_orno", orderNo);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lviewPOS.BeginUpdate();
                    ListViewItem lv = new ListViewItem(rdr["a"].ToString());
                    lv.SubItems.Add(rdr["b"].ToString());
                    lv.SubItems.Add(rdr["c"].ToString());
                    if (wholsale_select == true && btnWholesale.Enabled == false)
                    {
                        lv.SubItems.Add(Convert.ToDouble(rdr["e"]).ToString("#,###,##0.00")); // Wholesale
                    }
                    else
                    {
                        lv.SubItems.Add(Convert.ToDouble(rdr["d"]).ToString("#,###,##0.00")); // Retail
                    }
                    lv.SubItems.Add(Convert.ToDouble(rdr["f"]).ToString("#,###,##0.00"));
                    lv.SubItems.Add(Convert.ToDouble(rdr["g"]).ToString("#,###,##0.00"));
                    lv.SubItems.Add(rdr["h"].ToString());
                    lviewPOS.Items.Add(lv);
                    lviewPOS.EndUpdate();
                }
                con.Close();
            }
            catch (Exception)
            {
                rdDescription.Text = "Error 10: Network Connection";
            }
        }
        
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            gotoDiscount();
        }

        private void frmPOS_Click(object sender, EventArgs e)
        {
            btnDiscount.Enabled = false;
            discountTx = false;
            btnVoid.Enabled = false;
            //
            btnEdit.Enabled = false;
            //
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            gotoVoid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gotoEdit();
        }

        private void btnParkSale_Click(object sender, EventArgs e)
        {
            gotoPark();
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            gotoCancelT();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gotoSearch();
        }
    }
}