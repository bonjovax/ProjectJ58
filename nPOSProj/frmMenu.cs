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

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}