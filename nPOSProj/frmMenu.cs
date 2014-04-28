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
    }
}
