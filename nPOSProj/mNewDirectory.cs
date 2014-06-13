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
    public partial class mNewDirectory : Form
    {
        public mNewDirectory()
        {
            InitializeComponent();
        }

        private void clearBoxes()
        {
            txtBoxCustomerCode.Clear();
            txtBoxCompany.Clear();
            txtBoxFirst.Clear();
            txtBoxMiddle.Clear();
            txtBoxLast.Clear();
            txtBoxEmail.Clear();
            txtBoxPhone.Clear();
            txtBoxAddress.Clear();
            txtBoxCity.Clear();
            txtBoxProv.Clear();
            txtBoxZip.Clear();
            txtBoxCustomerCode.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearBoxes();
        }

        private void txtBoxCompany_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCompany.Text != "")
            {
                this.Text = txtBoxCompany.Text;
            }
            else
            {
                this.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}