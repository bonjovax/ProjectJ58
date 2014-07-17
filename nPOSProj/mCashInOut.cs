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
    public partial class mCashInOut : Form
    {
        public mCashInOut()
        {
            InitializeComponent();
        }

        private void mCashInOut_Load(object sender, EventArgs e)
        {
            txtBoxAmount.Focus();
            frmLogin fl = new frmLogin();
            lblTerminal.Text = fl.tN;
        }

        private void mCashInOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}