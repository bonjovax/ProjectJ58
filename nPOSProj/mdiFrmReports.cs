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
    public partial class mdiFrmReports : Form
    {
        private DAO.LoginDAO login;
        public mdiFrmReports()
        {
            InitializeComponent();
        }

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
        private Boolean ActivateThisChild(String formName)
        {
            int i;
            Boolean formSetToMdi = false;
            for (i = 0; i < this.MdiChildren.Length; i++)
            // loop for all the mdi children
            {
                if (this.MdiChildren[i].Name == formName)
                // find the Mdi child with the same name as your form
                {
                    // if found just activate it
                    this.MdiChildren[i].Activate();
                    formSetToMdi = true;
                }
            }

            if (i == 0 || formSetToMdi == false)
                // if the given form not found as mdi child return false.
                return false;

            else
                return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String Date = DateTime.Now.ToLongDateString();
            String Time = DateTime.Now.ToLongTimeString();
            tsToday.Text = Date + " at " + Time;
        }

        private void mdiFrmReports_Load(object sender, EventArgs e)
        {
            String userName = frmLogin.User.user_name;
            tsUser.Text = userName.ToString();
            timer1.Start();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            onFormClose();
        }

        private void mdiFrmReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            onFormClose();
        }
    }
}