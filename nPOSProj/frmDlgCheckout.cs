using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace nPOSProj
{
    public partial class frmDlgCheckout : Form
    {
        private String a;
        private String b;
        private Conf.Rgx r = new Conf.Rgx();
        private Conf.Crypto tx = new Conf.Crypto();
        public frmDlgCheckout()
        {
            InitializeComponent();
        }

        private void frmDlgCheckout_Load(object sender, EventArgs e)
        {

        }

        private void mskCC_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(mskCC.Text, r.Visa()))
            {
                pVisa.Visible = true;
            }
            else
            {
                pVisa.Visible = false;
            }
            if (Regex.IsMatch(mskCC.Text, r.Mastercard()))
            {
                pMaster.Visible = true;
            }
            else
            {
                pMaster.Visible = false;
            }
        }

        private void mskCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Regex.IsMatch(mskCC.Text, r.Visa()) || Regex.IsMatch(mskCC.Text, r.Mastercard()))
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("Not OK");
                }
            }
        }

        private void txtBoxCheckNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCheckNo.Text != "" && txtBoxBankNBranch.Text != "")
            {
                a = txtBoxCheckNo.Text;
                b = txtBoxBankNBranch.Text;
                tx.RefHashed(a + b);
                lblRefNo.Text = tx.RefretreiveHash();
            }
            else
                lblRefNo.Text = "";
        }

        private void txtBoxBankNBranch_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCheckNo.Text != "" && txtBoxBankNBranch.Text != "")
            {
                a = txtBoxCheckNo.Text;
                b = txtBoxBankNBranch.Text;
                tx.RefHashed(a + b);
                lblRefNo.Text = tx.RefretreiveHash();
            }
            else
                lblRefNo.Text = "";
        }
    }
}