﻿using System;
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
        //
        private Double getAmount;
        //
        private Double tenderAmount;

        public Double TenderAmount
        {
            get { return tenderAmount; }
            set { tenderAmount = value; }
        }
        private Double changeDue;

        public Double ChangeDue
        {
            get { return changeDue; }
            set { changeDue = value; }
        }

        public Double GetAmount
        {
            get { return getAmount; }
            set { getAmount = value; }
        }

        private String cardNo;

        public String CardNo
        {
            get { return cardNo; }
            set { cardNo = value; }
        }

        private String cardType;

        public String CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }

        private String cRef;

        public String CRef
        {
            get { return cRef; }
            set { cRef = value; }
        }

        private bool isCashTX;

        public bool IsCashTX
        {
            get { return isCashTX; }
            set { isCashTX = value; }
        }

        private bool isDCTX;

        public bool IsDCTX
        {
            get { return isDCTX; }
            set { isDCTX = value; }
        }

        private bool isBCTX;

        public bool IsBCTX
        {
            get { return isBCTX; }
            set { isBCTX = value; }
        }

        private bool isARTX;

        public bool IsARTX
        {
            get { return isARTX; }
            set { isARTX = value; }
        }

        private bool isGCTX;

        public bool IsGCTX
        {
            get { return isGCTX; }
            set { isGCTX = value; }
        }

        private String checkNo;

        public String CheckNo
        {
            get { return checkNo; }
            set { checkNo = value; }
        }

        private String bankNBranch;

        public String BankNBranch
        {
            get { return bankNBranch; }
            set { bankNBranch = value; }
        }

        private Int32 gc_code;

        public Int32 Gc_code
        {
            get { return gc_code; }
            set { gc_code = value; }
        }

        public frmDlgCheckout()
        {
            InitializeComponent();
        }

        #region Lock and Unlock
        private void LockCash_Controls()
        {
            txtBoxTender.ReadOnly = true;
        }
        private void LockDC_Controls()
        {
            mskCC.ReadOnly = true;
        }
        private void LockBC_Controls()
        {
            txtBoxCheckNo.ReadOnly = true;
            txtBoxBankNBranch.ReadOnly = true;
        }
        private void LockAR_Controls()
        {
            //Adding thingy here
        }
        private void LockGC_Controls()
        {
            txtBoxGCode.ReadOnly = true;
        }
        //
        private void UnlockCash_Controls()
        {
            txtBoxTender.ReadOnly = false;
        }
        private void UnlockDC_Controls()
        {
            mskCC.ReadOnly = false;
        }
        private void UnlockBC_Controls()
        {
            txtBoxCheckNo.ReadOnly = false;
            txtBoxBankNBranch.ReadOnly = false;
        }
        private void UnlockAR_Controls()
        {
            //Put That Thingy Here Also
        }
        private void UnlockGC_Controls()
        {
            txtBoxGCode.ReadOnly = true;
        }
        #endregion
        //
        private void frmDlgCheckout_Load(object sender, EventArgs e)
        {
            lblTotalAmount.Text = GetAmount.ToString("#,###,##0.00");
            lblTotalAmountDC.Text = GetAmount.ToString("#,###,##0.00");
            lblTotalAmountBC.Text = GetAmount.ToString("#,###,##0.00");
            lblTotalAmountAR.Text = GetAmount.ToString("#,###,##0.00");
            lblTotalAmountGC.Text = GetAmount.ToString("#,###,##0.00");
            //Tx Controls
            IsCashTX = false;
            IsDCTX = false;
            IsBCTX = false;
            IsARTX = false;
            //
            txtBoxTender.Focus();
        }

        private void mskCC_TextChanged(object sender, EventArgs e)
        {
            txtBoxTender.Clear();
            txtBoxCheckNo.Clear();
            txtBoxBankNBranch.Clear();
            //Needs to Add AR
            if (Regex.IsMatch(mskCC.Text, r.Visa()) || Regex.IsMatch(mskCC.Text, r.Mastercard()))
            {
                LockCash_Controls();
                LockBC_Controls();
                LockAR_Controls();
                LockGC_Controls();
                if (mskCC.Text.Substring(0, 1) == "4")
                {
                    pVisa.Visible = true;
                    CardType = "Visa";
                }
                else
                {
                    pVisa.Visible = false;
                }
                if (mskCC.Text.Substring(0, 1) == "5")
                {
                    pMaster.Visible = true;
                    CardType = "MasterCard";
                }
                else
                {
                    pMaster.Visible = false;
                }
            }
            else
            {
                UnlockCash_Controls();
                UnlockBC_Controls();
                UnlockAR_Controls();
                UnlockGC_Controls();
                pVisa.Visible = false;
                pMaster.Visible = false;
                CardType = "";
            }
        }

        private void mskCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Regex.IsMatch(mskCC.Text, r.Visa()) || Regex.IsMatch(mskCC.Text, r.Mastercard()))
                {
                    //Deleted Due to PCI DSS Compliancy
                    CardNo = mskCC.Text;
                    isDCTX = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Card", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //
                LockCash_Controls();
                LockDC_Controls();
                LockAR_Controls();
                LockGC_Controls();
            }
            else
            {
                lblRefNo.Text = "";
                UnlockCash_Controls();
                UnlockDC_Controls();
                UnlockAR_Controls();
                UnlockGC_Controls();
            }
        }

        private void txtBoxBankNBranch_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCheckNo.Text != "" && txtBoxBankNBranch.Text != "")
            {
                a = txtBoxCheckNo.Text;
                b = txtBoxBankNBranch.Text;
                tx.RefHashed(a + b);
                lblRefNo.Text = tx.RefretreiveHash();
                //
                LockCash_Controls();
                LockDC_Controls();
                LockAR_Controls();
                LockGC_Controls();
            }
            else
            {
                lblRefNo.Text = "";
                UnlockCash_Controls();
                UnlockDC_Controls();
                UnlockAR_Controls();
                UnlockGC_Controls();
            }
        }

        private void txtBoxTender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtBoxTender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Regex.IsMatch(txtBoxTender.Text, r.Amount()))
                {
                    if (GetAmount <= Convert.ToDouble(txtBoxTender.Text))
                    {
                        TenderAmount = Convert.ToDouble(txtBoxTender.Text);
                        ChangeDue = TenderAmount - getAmount;
                        IsCashTX = true;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Insufficient Amount!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please Enter Tender Amount Propery!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBoxTender_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxTender.Text != "")
            {
                LockDC_Controls();
                LockBC_Controls();
                LockAR_Controls();
                LockGC_Controls();
            }
            else
            {
                UnlockDC_Controls();
                UnlockBC_Controls();
                UnlockAR_Controls();
                UnlockGC_Controls();
            }
        }


        private void txtBoxCardHoldersName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxCheckNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtBoxCheckNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxBankNBranch.Focus();
            }
        }

        private void txtBoxBankNBranch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxBankNBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckNo = txtBoxCheckNo.Text;
                BankNBranch = txtBoxBankNBranch.Text;
                CRef = lblRefNo.Text;
                IsBCTX = true;
                this.Close();
            }
        }

        private void txtBoxGCode_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxGCode.Text != "")
            {
                LockDC_Controls();
                LockBC_Controls();
                LockAR_Controls();
                LockCash_Controls();
            }
            else
            {
                UnlockDC_Controls();
                UnlockBC_Controls();
                UnlockAR_Controls();
                UnlockCash_Controls();
            }
        }
    }
}