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
    public partial class frmPOS : Form
    {
        private DAO.LoginDAO login;
        public frmPOS()
        {
            InitializeComponent();
        }
        #region Secretive Override Form
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:             //preventing the form from being moved by the mouse.
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)       //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }
        #endregion
        private void onFormClose()
        {
            login = new DAO.LoginDAO();
            String userName = frmLogin.User.user_name;
            login.catchUsername(userName);
            frmMenu fm = new frmMenu();
            if (login.hasSales())
            {
                fm.unlockSales();
            }
            if (login.hasCustomers())
            {
                fm.unlockCustomers();
            }
            if (login.hasInventory())
            {
                fm.unlockInventory();
            }
            if (login.hasReports())
            {
                fm.unlockGeneralReports();
            }
            if (login.hasGC())
            {
                fm.unlockGiftCards();
            }
            if (login.hasUser_Accounts())
            {
                fm.unlockUserAccounts();
            }
            if (login.hasUserConf())
            {
                fm.unlockConfig();
            }
            fm.Show();
            this.Hide();
        }

        private void frmPOS_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("HOY");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                MessageBox.Show("You pressed the F1 key");
                return true;    // indicate that you handled this keystroke
            }
            if (keyData == Keys.F8)
            {
                frmDlgCheckout checkout = new frmDlgCheckout();
                checkout.ShowDialog();
            }
            if (keyData == Keys.F10)
            {
                onFormClose();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            onFormClose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            timer1.Start();
            String userName = frmLogin.User.user_name;
            lblUserAccount.Text = userName;
            lblProgversion.Text = "nPOS System v" + ProductVersion.ToString();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmDlgCheckout checkout = new frmDlgCheckout();
            checkout.ShowDialog();
        }
    }
}