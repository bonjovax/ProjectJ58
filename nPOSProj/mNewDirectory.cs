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
    public partial class mNewDirectory : Form
    {
        private bool activity = false;
        private bool found = true;
        private VO.CustomersVO customers;

        public bool Activity
        {
            get { return activity; }
            set { activity = value; }
        }
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
            if (txtBoxCustomerCode.Text != "" && txtBoxCompany.Text != "" && txtBoxFirst.Text != "" && txtBoxMiddle.Text != "" && txtBoxLast.Text != "" && txtBoxPhone.Text != "" && txtBoxAddress.Text != "" && txtBoxCity.Text != "" && txtBoxProv.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxCustomerCode_TextChanged(object sender, EventArgs e)
        {
            customers = new VO.CustomersVO();
            customers.Custcode = txtBoxCustomerCode.Text;
            if (found == customers.CheckCustCode())
            {
                txtBoxCompany.ReadOnly = true;
                txtBoxFirst.ReadOnly = true;
                txtBoxMiddle.ReadOnly = true;
                txtBoxLast.ReadOnly = true;
                txtBoxEmail.ReadOnly = true;
                txtBoxPhone.ReadOnly = true;
                txtBoxAddress.ReadOnly = true;
                txtBoxCity.ReadOnly = true;
                txtBoxProv.ReadOnly = true;
                txtBoxZip.ReadOnly = true;
                //
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
                lblWarning.Text = "Customer Code has been Existed!";
            }
            else
            {
                txtBoxCompany.ReadOnly = false;
                txtBoxFirst.ReadOnly = false;
                txtBoxMiddle.ReadOnly = false;
                txtBoxLast.ReadOnly = false;
                txtBoxEmail.ReadOnly = false;
                txtBoxPhone.ReadOnly = false;
                txtBoxAddress.ReadOnly = false;
                txtBoxCity.ReadOnly = false;
                txtBoxProv.ReadOnly = false;
                txtBoxZip.ReadOnly = false;
                lblWarning.Text = "";
            }
            if (txtBoxCustomerCode.Text != "" && txtBoxCompany.Text != "" && txtBoxFirst.Text != "" && txtBoxMiddle.Text != "" && txtBoxLast.Text != "" && txtBoxPhone.Text != "" && txtBoxAddress.Text != "" && txtBoxCity.Text != "" && txtBoxProv.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtBoxFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxMiddle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxLast_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxFirst_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCustomerCode.Text != "" && txtBoxCompany.Text != "" && txtBoxFirst.Text != "" && txtBoxMiddle.Text != "" && txtBoxLast.Text != "" && txtBoxPhone.Text != "" && txtBoxAddress.Text != "" && txtBoxCity.Text != "" && txtBoxProv.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtBoxMiddle_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCustomerCode.Text != "" && txtBoxCompany.Text != "" && txtBoxFirst.Text != "" && txtBoxMiddle.Text != "" && txtBoxLast.Text != "" && txtBoxPhone.Text != "" && txtBoxAddress.Text != "" && txtBoxCity.Text != "" && txtBoxProv.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtBoxLast_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCustomerCode.Text != "" && txtBoxCompany.Text != "" && txtBoxFirst.Text != "" && txtBoxMiddle.Text != "" && txtBoxLast.Text != "" && txtBoxPhone.Text != "" && txtBoxAddress.Text != "" && txtBoxCity.Text != "" && txtBoxProv.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCustomerCode.Text != "" && txtBoxCompany.Text != "" && txtBoxFirst.Text != "" && txtBoxMiddle.Text != "" && txtBoxLast.Text != "" && txtBoxPhone.Text != "" && txtBoxAddress.Text != "" && txtBoxCity.Text != "" && txtBoxProv.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtBoxAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCustomerCode.Text != "" && txtBoxCompany.Text != "" && txtBoxFirst.Text != "" && txtBoxMiddle.Text != "" && txtBoxLast.Text != "" && txtBoxPhone.Text != "" && txtBoxAddress.Text != "" && txtBoxCity.Text != "" && txtBoxProv.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtBoxCity_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCustomerCode.Text != "" && txtBoxCompany.Text != "" && txtBoxFirst.Text != "" && txtBoxMiddle.Text != "" && txtBoxLast.Text != "" && txtBoxPhone.Text != "" && txtBoxAddress.Text != "" && txtBoxCity.Text != "" && txtBoxProv.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtBoxProv_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCustomerCode.Text != "" && txtBoxCompany.Text != "" && txtBoxFirst.Text != "" && txtBoxMiddle.Text != "" && txtBoxLast.Text != "" && txtBoxPhone.Text != "" && txtBoxAddress.Text != "" && txtBoxCity.Text != "" && txtBoxProv.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            customers = new VO.CustomersVO();
            DialogResult dr = MessageBox.Show("Do you wish to Continue?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                customers.Custcode = txtBoxCustomerCode.Text;
                customers.Companyname = txtBoxCompany.Text;
                customers.Firstname = txtBoxFirst.Text;
                customers.Middlename = txtBoxMiddle.Text;
                customers.Lastname = txtBoxLast.Text;
                customers.Email = txtBoxEmail.Text;
                customers.Phone_no = txtBoxPhone.Text;
                customers.Address = txtBoxAddress.Text;
                customers.City = txtBoxCity.Text;
                customers.Province = txtBoxProv.Text;
                customers.Zip_code = txtBoxZip.Text;
                customers.AddCustomers();
                activity = true;
                clearBoxes();
            }
        }
    }
}