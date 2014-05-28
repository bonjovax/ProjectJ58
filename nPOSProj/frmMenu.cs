using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nPOSProj
{
    public partial class frmMenu : Form
    {
        private mdiFrmUserAccounts mdiUA = new mdiFrmUserAccounts();
        private mdiConfiguration mdiConfig = new mdiConfiguration();
        private mdiFrmInv mdiInv = new mdiFrmInv();
        private frmPOS pos = new frmPOS();
        private String userName = frmLogin.User.user_name;
        public frmMenu()
        {
            InitializeComponent();
        }

        public void unlockSales()
        {
            btnSales.Enabled = true;
        }
        public void unlockCustomers()
        {
            btnCustomers.Enabled = true;
        }
        public void unlockInventory()
        {
            btnInventory.Enabled = true;
        }
        public void unlockGeneralReports()
        {
            btnGenReports.Enabled = true;
        }
        public void unlockGiftCards()
        {
            btnGC.Enabled = true;
        }
        public void unlockUserAccounts()
        {
            btnUserAccounts.Enabled = true;
        }
        public void unlockConfig()
        {
            btnConfig.Enabled = true;
        }
        private void closingForm()
        {
            frmLogin fl = new frmLogin();
            this.Hide();
            fl.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.closingForm();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.closingForm();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePass fcp = new frmChangePass();
            fcp.ShowDialog();
        }

        private void btnUserAccounts_Click(object sender, EventArgs e)
        {
            mdiUA.Show();
            this.Hide();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            mdiConfig = new mdiConfiguration();
            mdiConfig.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            mdiInv.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongDateString() + " at " + DateTime.Now.ToLongTimeString();
            if (DateTime.Now.ToString("tt") == "AM")
            {
                greetings.Text = "Good Morning, " + userName;
            }
            if (DateTime.Now.ToString("tt") == "PM" && Convert.ToInt32(DateTime.Now.Hour) <= 17)
            {
                greetings.Text = "Good Afternoon, " + userName;
            }
            if (DateTime.Now.ToString("tt") == "PM" && Convert.ToInt32(DateTime.Now.Hour)  >= 17)
            {
                greetings.Text = "Good Evening, " + userName;
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            String nows;
            if (DateTime.Now.Year.ToString() == "2014")
            {
                nows = "";
            }
            else
                nows = DateTime.Now.Year.ToString();
            lblProgversion.Text = "nPOS System v" + ProductVersion.ToString();
            lblAdlib.Text = "© Copyright 2014 - " + nows;
            timer1.Start();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            pos.Show();
            this.Hide();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1 && btnSales.Enabled == true)
            {
                pos.Show();
                this.Hide();
                return true;    // indicate that you handled this keystroke
            }
            if (keyData == Keys.F3 && btnInventory.Enabled == true)
            {
                mdiInv.Show();
                this.Hide();
                return true;
            }
            if (keyData == Keys.F6 && btnUserAccounts.Enabled == true)
            {
                mdiUA.Show();
                this.Hide();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}