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
    public partial class mdiSalesReport : Form
    {
        private MySqlConnection con = new MySqlConnection();
        private Conf.dbs dbcon = new Conf.dbs();
        private DAO.LoginDAO login;
        private Conf.BIR bir = new Conf.BIR(); //Bureau of Internal Revenue - PH
        private VO.ReportingVO reports = new VO.ReportingVO();
        private VO.ConfigVO config;
        private VO.PosVO vo = new VO.PosVO();
        private String userName = frmLogin.User.user_name;
        private String terminalSelect;
        private String terminalSelectZ;
        private String terminalSelectSR;
        private String terminalSelectSDR;
        private String terminalSelectCBR;
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
        private String machine_no;
        private Int16 all_items_tax;
        #endregion
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
                        permit_no = rdr["permit_no"].ToString();
                        TIN = rdr["tin_number"].ToString();
                        TaxT = rdr["tax_type"].ToString();
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
                        permit_no = rdr["permit_no"].ToString();
                        TIN = rdr["tin_number"].ToString();
                        TaxT = rdr["tax_type"].ToString();
                        machine_no = rdr["machine_no"].ToString() + fl.tN;
                        all_items_tax = Convert.ToInt16(rdr["all_items_tax"]);
                    }
                }
                con.Close();
            }
            catch (Exception)
            {
                
            }
        }
        public mdiSalesReport()
        {
            InitializeComponent();
        }

        private void checkRes()
        {
            login = new DAO.LoginDAO();
            String userName = frmLogin.User.user_name;
            login.catchUsername(userName);
            if (login.hasUser_Accounts())
            {
                lblX.Visible = true;
                cBTerminalX.Visible = true;
                lblZ.Visible = true;
                cBTerminalZ.Visible = true;
                lblSR.Visible = true;
                cBTerminalSR.Visible = true;
                lblSDR.Visible = true;
                cBTerminalSDR.Visible = true;
                lblCDR.Visible = true;
                cBTerminalCDR.Visible = true;
            }
        }
        private void getTerminal()
        {
            try
            {
                config = new VO.ConfigVO();
                cBTerminalX.Items.Clear();
                cBTerminalZ.Items.Clear();
                cBTerminalSR.Items.Clear();
                cBTerminalSDR.Items.Clear();
                String[,] grabData = config.ReadTerminal();
                for (int x = 0; x < grabData.GetLength(1); x++)
                {
                    cBTerminalX.Items.Add(grabData[0, x].ToString());
                    cBTerminalZ.Items.Add(grabData[0, x].ToString());
                    cBTerminalSR.Items.Add(grabData[0, x].ToString());
                    cBTerminalSDR.Items.Add(grabData[0, x].ToString());
                    cBTerminalCDR.Items.Add(grabData[0, x].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void DrawerPing()
        {
            try
            {
                Conf.Drawer drawer = new Conf.Drawer();
                drawer.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Check Cash Drawer Please!", "Drawer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintXTicket()
        {
            printX.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printX_PrintPage);
            printX.Print();
        }
        private void PrintZTicket()
        {
            //DrawerPing();
            printZ.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printZ_PrintPage);
            printZ.Print();
        }
        void printZ_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                frmLogin fl = new frmLogin();
                Graphics graphic = e.Graphics;
                Font font = new Font("Tahoma", 10);

                float fontHeight = font.GetHeight();
                int startX = 2;
                int startY = 10;
                //int offset = 40;
                reports.Pos_date = Convert.ToDateTime(dtZ.Text).ToString("yyyy-MM-dd");
                reports.Pos_terminal = terminalSelectZ;
                Double Gross = reports.GrossAmount();
                Double Discounts = reports.Discounts();
                Double VATAMT = reports.TaxAmount();
                Double Net = Gross - Discounts;
                Double V = 0;
                Double NV = 0;
                Int32 CtrStart = reports.SeriesStart();
                Int32 CtrEnd = reports.SeriesEnd();
                Int32 CancelledTxn = reports.CountCancel();
                Int32 NOTrans = reports.NumberOfTrans();
                Int32 NoOfEAN = reports.NumberOfEan();
                Int32 OverallQ = reports.OverallQty();
                Double PreviousNET = reports.PreviousNETAmt();
                Double Running = PreviousNET + Net;

                #region Header
                graphic.DrawString(compName, new Font("Tahoma", 14), new SolidBrush(Color.Black), startX, startY);
                graphic.DrawString(address1, new Font("Tahoma", 11), new SolidBrush(Color.Black), 45, 30);
                graphic.DrawString(address2, new Font("Tahoma", 11), new SolidBrush(Color.Black), 38, 45);
                //graphic.DrawString(contact, new Font("Tahoma", 11), new SolidBrush(Color.Black), 53, 60);
                //graphic.DrawString("Owned & Operated By: " + store_op, new Font("Tahoma", 11), new SolidBrush(Color.Black), 5, 75);
                graphic.DrawString("Permit No: " + permit_no, new Font("Tahoma", 11), new SolidBrush(Color.Black), 47, 60);
                graphic.DrawString("TIN: " + TIN + "" + TaxT, new Font("Tahoma", 11), new SolidBrush(Color.Black), 47, 75);
                graphic.DrawString("Accreditation No: " + bir.AccreditationNo(), new Font("Tahoma", 7), new SolidBrush(Color.Black), 11, 95);
                graphic.DrawString("Serial No: " + bir.SerialNo(), new Font("Tahoma", 11), new SolidBrush(Color.Black), 61, 105);
                graphic.DrawString("Machine Code: " + machine_no, new Font("Tahoma", 11), new SolidBrush(Color.Black), 43, 120);
                graphic.DrawString("Z Reports", new Font("Tahoma", 13), new SolidBrush(Color.Black), 85, 135);
                graphic.DrawString(dtZ.Text, new Font("Tahoma", 9), new SolidBrush(Color.Black), 5, 150);
                graphic.DrawString(userName + " at Terminal: " + terminalSelectZ, new Font("Tahoma", 9), new SolidBrush(Color.Black), 5, 165);
                graphic.DrawString("-------------------------------------------", new Font("Tahoma", 11), new SolidBrush(Color.Black), 3, 180);
                #endregion
                #region Content Reading
                graphic.DrawString("Gross Sales:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 200);
                graphic.DrawString(Gross.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 200);
                graphic.DrawString("Discounts:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 220);
                graphic.DrawString(Discounts.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 220);
                graphic.DrawString("Net Sales:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 240);
                graphic.DrawString(Net.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 240);
                //
                //Space
                //
                if (TaxT == "V")
                {
                    V = Net;
                }
                else
                {
                    NV = Net;
                }
                graphic.DrawString("Non-VAT Sales:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 270);
                graphic.DrawString(NV.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 270);
                graphic.DrawString("VAT Sales:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 290);
                graphic.DrawString(V.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 290);
                graphic.DrawString("VAT:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 310);
                graphic.DrawString(VATAMT.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 310);
                //
                //Space
                //
                graphic.DrawString("Counter # Start:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 340);
                graphic.DrawString(CtrStart.ToString().PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 340);
                graphic.DrawString("Counter # End:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 360);
                graphic.DrawString(CtrEnd.ToString().PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 360);
                //
                //Space
                //
                graphic.DrawString("Cancelled Txn:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 390);
                graphic.DrawString(CancelledTxn.ToString().PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 390);
                //
                //Space
                //
                graphic.DrawString("No of Transactions:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 420);
                graphic.DrawString(NOTrans.ToString().PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 420);
                graphic.DrawString("No of EAN:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 440);
                graphic.DrawString(NoOfEAN.ToString().PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 440);
                graphic.DrawString("Total Quantity:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 460);
                graphic.DrawString(OverallQ.ToString().PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 460);
                //
                //Space
                //
                graphic.DrawString("Previous Reading:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 490);
                graphic.DrawString(PreviousNET.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 490);
                graphic.DrawString("Net Sales:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 510);
                graphic.DrawString(Net.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 510);
                graphic.DrawString("Running Total:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 530);
                graphic.DrawString(Running.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 530);
                #endregion
                #region Footer
                graphic.DrawString("-------------------------------------------", new Font("Tahoma", 11), new SolidBrush(Color.Black), 3, 550);
                graphic.DrawString("End of Z Reports", new Font("Tahoma", 13), new SolidBrush(Color.Black), 70, 560);
                #endregion
            }
            catch (Exception)
            {
                MessageBox.Show("Contact Developer!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void printX_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                frmLogin fl = new frmLogin();
                Graphics graphic = e.Graphics;
                Font font = new Font("Tahoma", 10);

                float fontHeight = font.GetHeight();
                int startX = 2;
                int startY = 10;
                //int offset = 40;
                reports.Pos_date = Convert.ToDateTime(dtX.Text).ToString("yyyy-MM-dd");
                reports.Pos_terminal = terminalSelect;
                Double Gross = reports.GrossAmount();
                Double Discounts = reports.Discounts();
                Double VATAMT = reports.TaxAmount();
                Double Net = Gross - Discounts;
                Double V = 0;
                Double NV = 0;
                Int32 CtrStart = reports.SeriesStart();
                Int32 CtrEnd = reports.SeriesEnd();
                Int32 CancelledTxn = reports.CountCancel();
                Int32 NOTrans = reports.NumberOfTrans();
                Int32 NoOfEAN = reports.NumberOfEan();
                Int32 OverallQ = reports.OverallQty();
                Double PreviousNET = reports.PreviousNETAmt();
                Double Running = PreviousNET + Net;

                #region Header
                graphic.DrawString(compName, new Font("Tahoma", 14), new SolidBrush(Color.Black), startX, startY);
                graphic.DrawString(address1, new Font("Tahoma", 11), new SolidBrush(Color.Black), 45, 30);
                graphic.DrawString(address2, new Font("Tahoma", 11), new SolidBrush(Color.Black), 38, 45);
                //graphic.DrawString(contact, new Font("Tahoma", 11), new SolidBrush(Color.Black), 53, 60);
                //graphic.DrawString("Owned & Operated By: " + store_op, new Font("Tahoma", 11), new SolidBrush(Color.Black), 5, 75);
                graphic.DrawString("Permit No: " + permit_no, new Font("Tahoma", 11), new SolidBrush(Color.Black), 47, 60);
                graphic.DrawString("TIN: " + TIN + "" + TaxT, new Font("Tahoma", 11), new SolidBrush(Color.Black), 47, 75);
                graphic.DrawString("Accreditation No: " + bir.AccreditationNo(), new Font("Tahoma", 7), new SolidBrush(Color.Black), 11, 95);
                graphic.DrawString("Serial No: " + bir.SerialNo(), new Font("Tahoma", 11), new SolidBrush(Color.Black), 61, 105);
                graphic.DrawString("Machine Code: " + machine_no, new Font("Tahoma", 11), new SolidBrush(Color.Black), 43, 120);
                graphic.DrawString("X Reports", new Font("Tahoma", 13), new SolidBrush(Color.Black), 85, 135);
                graphic.DrawString(dtX.Text, new Font("Tahoma", 9), new SolidBrush(Color.Black), 5, 150);
                graphic.DrawString(userName + " at Terminal: " + terminalSelect, new Font("Tahoma", 9), new SolidBrush(Color.Black), 5, 165);
                graphic.DrawString("-------------------------------------------", new Font("Tahoma", 11), new SolidBrush(Color.Black), 3, 180);
                #endregion
                #region Content Reading
                graphic.DrawString("Gross Sales:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 200);
                graphic.DrawString(Gross.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 200);
                graphic.DrawString("Discounts:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 220);
                graphic.DrawString(Discounts.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 220);
                graphic.DrawString("Net Sales:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 240);
                graphic.DrawString(Net.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 240);
                //
                //Space
                //
                if (TaxT == "V")
                {
                    V = Net;
                }
                else
                {
                    NV = Net;
                }
                graphic.DrawString("Non-VAT Sales:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 270);
                graphic.DrawString(NV.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 270);
                graphic.DrawString("VAT Sales:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 290);
                graphic.DrawString(V.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 290);
                graphic.DrawString("VAT:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 310);
                graphic.DrawString(VATAMT.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 310);
                //
                //Space
                //
                graphic.DrawString("Counter # Start:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 340);
                graphic.DrawString(CtrStart.ToString().PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 340);
                graphic.DrawString("Counter # End:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 360);
                graphic.DrawString(CtrEnd.ToString().PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 360);
                //
                //Space
                //
                graphic.DrawString("Cancelled Txn:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 390);
                graphic.DrawString(CancelledTxn.ToString().PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 390);
                //
                //Space
                //
                graphic.DrawString("No of Transactions:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 420);
                graphic.DrawString(NOTrans.ToString().PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 420);
                graphic.DrawString("No of EAN:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 440);
                graphic.DrawString(NoOfEAN.ToString().PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 440);
                graphic.DrawString("Total Quantity:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 460);
                graphic.DrawString(OverallQ.ToString().PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 460);
                //
                //Space
                //
                graphic.DrawString("Previous Reading:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 490);
                graphic.DrawString(PreviousNET.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 490);
                graphic.DrawString("Net Sales:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 510);
                graphic.DrawString(Net.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 510);
                graphic.DrawString("Running Total:".PadRight(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 25, 530);
                graphic.DrawString(Running.ToString("#,###,##0.00").PadLeft(10), new Font("Tahoma", 11), new SolidBrush(Color.Black), 166, 530);
                #endregion
                #region Footer
                graphic.DrawString("-------------------------------------------", new Font("Tahoma", 11), new SolidBrush(Color.Black), 3, 550);
                graphic.DrawString("End of X Reports", new Font("Tahoma", 13), new SolidBrush(Color.Black), 70, 560);
                #endregion
            }
            catch (Exception)
            {
                MessageBox.Show("Contact Developer!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintX_Click(object sender, EventArgs e)
        {
            PrintXTicket();
        }

        private void mdiSalesReport_Load(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            ConfigCheck();
            getTerminal();
            checkRes();
            terminalSelect = fl.tN;
            terminalSelectZ = fl.tN;
            terminalSelectSR = fl.tN;
            terminalSelectSDR = fl.tN;
            terminalSelectCBR = fl.tN;
        }

        private void btnPrintZ_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Do You Wish Proceed?\nCash Drawer Amount will be reset!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                vo.Pos_terminal = terminalSelectZ;
                vo.ResetD();
                //
                vo.CashAmount = 0;
                vo.DrawerPurpose = "Z Reading";
                vo.Pos_user = userName;
                vo.DebitD();
                //
                PrintZTicket();
            }
        }

        private void cBTerminalX_SelectedIndexChanged(object sender, EventArgs e)
        {
            terminalSelect = cBTerminalX.Text;
        }

        private void cBTerminalZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            terminalSelectZ = cBTerminalZ.Text;
        }

        private void btnPrintSummarySR_Click(object sender, EventArgs e)
        {
            using (frmRptSR sr = new frmRptSR())
            {
                sr.DateParam = dtSR.Text;
                sr.TerminalParam = terminalSelectSR;
                sr.ShowDialog();
            }
        }

        private void cBTerminalSR_SelectedIndexChanged(object sender, EventArgs e)
        {
            terminalSelectSR = cBTerminalSR.Text;
        }

        private void btnPrintSummarySDR_Click(object sender, EventArgs e)
        {
            using (frmRptSDR sdr = new frmRptSDR())
            {
                sdr.DateParam = dtSDR.Text;
                sdr.TerminalParam = terminalSelectSDR;
                sdr.ShowDialog();
            }
        }

        private void cBTerminalSDR_SelectedIndexChanged(object sender, EventArgs e)
        {
            terminalSelectSDR = cBTerminalSDR.Text;
        }

        private void btnPrintKits_Click(object sender, EventArgs e)
        {
            using (frmRptKit sdrkit = new frmRptKit())
            {
                sdrkit.DateParam = dtSDR.Text;
                sdrkit.TerminalParam = terminalSelectSDR;
                sdrkit.ShowDialog();
            }
        }

        private void cBTerminalCDR_SelectedIndexChanged(object sender, EventArgs e)
        {
            terminalSelectCBR = cBTerminalCDR.Text;
        }

        private void btnCDR_Click(object sender, EventArgs e)
        {
            using (frmRptCDrawer cdr = new frmRptCDrawer())
            {
                cdr.DateParam = dtCDR.Text;
                cdr.TerminalParam = terminalSelectCBR;
                cdr.ShowDialog();
            }
        }
    }
}