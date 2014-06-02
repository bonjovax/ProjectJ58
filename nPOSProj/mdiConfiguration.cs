﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nPOSProj
{
    public partial class mdiConfiguration : Form
    {
        VO.ConfigVO confvo;
        public mdiConfiguration()
        {
            InitializeComponent();
        }

        private void loadInfo()
        {
            confvo = new VO.ConfigVO();
            try
            {
                txtBoxCompanyName.Text = confvo.askCompanyName();
                txtBoxCompanyAddress.Text = confvo.askCompanyAddress();
                mTIN.Text = confvo.askTIN();
                cBoxTaxType.Text = confvo.askTaxType();
                txtBoxVatRate.Text = confvo.askVATRate().ToString();
                txtBoxContactNo.Text = confvo.askContactNumber();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Database Server if Active!", "Database Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mdiConfiguration_Load(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            confvo = new VO.ConfigVO();
            try
            {
                confvo.company_name = txtBoxCompanyName.Text;
                confvo.company_address = txtBoxCompanyAddress.Text;
                confvo.tin_number = mTIN.Text;
                confvo.tax_type = cBoxTaxType.Text;
                confvo.vat_rate = Convert.ToDouble(txtBoxVatRate.Text);
                confvo.contact_number = txtBoxContactNo.Text;
                confvo.Patch();
                MessageBox.Show("Information has been Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Your Input or Server is Not Active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Terminal()
        {
            confvo = new VO.ConfigVO();
            try
            {
            }
            catch (Exception)
            {
                MessageBox.Show("Terminal No has been use or Check Your Database Server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cBoxTaxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxTaxType.Text == "NV")
            {
                txtBoxVatRate.Text = "0";
                txtBoxVatRate.ReadOnly = true;
            }
            else
                txtBoxVatRate.ReadOnly = false;
        }
    }
}