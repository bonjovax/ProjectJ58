using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace nPOSProj
{
    public partial class frmLogin : Form
    {
        private MySqlConnection con = new MySqlConnection();
        private Conf.dbs dbcon = new Conf.dbs();
        AutoCompleteStringCollection collect = new AutoCompleteStringCollection();
        private DAO.LoginDAO login = new DAO.LoginDAO();


        public frmLogin()
        {
            InitializeComponent();
        }

        private void autoComplete()
        {
            con.ConnectionString = dbcon.getConnectionString();
            String sql = "SELECT DISTINCT user_name FROM user_account ORDER BY user_name ASC";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows == true)
                {
                    while (rdr.Read())
                        collect.Add(rdr["user_name"].ToString());
                }
                rdr.Close();
                txtBoxUsername.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBoxUsername.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBoxUsername.AutoCompleteCustomSource = collect;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check your Database Server Connection", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void enterKey()
        {
            try
            {
                if (login.isAuth(txtBoxUsername.Text, txtPassword.Text.Trim()))
                {
                    currentUser = hvo;
                    txtBoxUsername.Text = hvo.h_username;
                    loginDAO.catchUsername(txtBoxUsername.Text);
                    if (loginDAO.canAccess())
                    {
                        hvo.h_username = txtBoxUsername.Text; //Addon
                        hvo.PushLog(); //Addon
                        this.Hide();
                        frmMenu fm = new frmMenu();
                        fm.Show();
                        if (loginDAO.hasApplicants())
                        {
                            fm.enableApplicant();
                        }
                        if (loginDAO.hasClient())
                        {
                            fm.enableClient();
                        }
                        if (loginDAO.hasGuards())
                        {
                            fm.enableGuards();
                        }
                        if (loginDAO.hasPayroll())
                        {
                            fm.enablePayroll();
                        }
                        if (loginDAO.hasSupervisor())
                        {
                            fm.enableSupervisor();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your Account is Disable!\nContact Account Supervisor to Enable your Account", "Account Security", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtBoxUsername.Text = "";
                        txtBoxUsername.ReadOnly = false;
                        txtBoxUsername.Focus();
                        txtPassword.Text = "";
                        txtPassword.ReadOnly = true;
                    }
                }
                else
                {
                    MessageBox.Show("Username and/or Password is Incorrect or Not Completed", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBoxUsername.Text = "";
                    txtBoxUsername.ReadOnly = false;
                    txtBoxUsername.Focus();
                    txtPassword.Text = "";
                    txtPassword.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.autoComplete();
            lblAdlib.Text = "© Copyright 2014";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.ReadOnly = false;
                txtBoxUsername.ReadOnly = true;
                txtPassword.Focus();
            }
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text != "" && txtPassword.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
                btnLogin.Enabled = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text != "" && txtPassword.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
                btnLogin.Enabled = false;
        }
    }
}