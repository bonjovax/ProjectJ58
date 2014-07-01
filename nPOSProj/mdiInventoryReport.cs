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
    public partial class mdiInventoryReport : Form
    {
        private MySqlConnection con = new MySqlConnection();
        private Conf.dbs dbcon = new Conf.dbs();
        private DAO.LoginDAO login;
        private Conf.BIR bir = new Conf.BIR(); //Bureau of Internal Revenue - PH
        private VO.ReportingVO reports = new VO.ReportingVO();
        private VO.ConfigVO config;
        private String userName = frmLogin.User.user_name;
        private String terminalIR;

        public mdiInventoryReport()
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
                cBTerminalIR.Visible = true;
            }
        }

        private void getTerminal()
        {
            try
            {
                config = new VO.ConfigVO();
                cBTerminalIR.Items.Clear();
                String[,] grabData = config.ReadTerminal();
                for (int x = 0; x < grabData.GetLength(1); x++)
                {
                    cBTerminalIR.Items.Add(grabData[0, x].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mdiInventoryReport_Load(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            terminalIR = fl.tN;
            getTerminal();
            checkRes();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cBoxKitSelect.Checked == true)
            {
                using (frmRptISRkit isrkit = new frmRptISRkit())
                {
                    isrkit.DateParam = dtSIR.Text;
                    isrkit.TerminalParam = terminalIR;
                    isrkit.ShowDialog();
                }
            }
            else
            {
                using (frmRptISR isr = new frmRptISR())
                {
                    isr.DateParam = dtSIR.Text;
                    isr.TerminalParam = terminalIR;
                    isr.ShowDialog();
                }
            }
        }

        private void cBTerminalIR_SelectedIndexChanged(object sender, EventArgs e)
        {
            terminalIR = cBTerminalIR.Text;
        }

        private void btnPrintSR_Click(object sender, EventArgs e)
        {
            frmRptStocksR stockr = new frmRptStocksR();
            stockr.ShowDialog();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            frmRptItem rptitem = new frmRptItem();
            rptitem.ShowDialog();
        }

        private void btnKits_Click(object sender, EventArgs e)
        {
            frmRptIkits ikits = new frmRptIkits();
            ikits.ShowDialog();
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            frmRptStocks stocks = new frmRptStocks();
            stocks.ShowDialog();
        }
    }
}