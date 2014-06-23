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
    public partial class frmDlgRefund : Form
    {
        private DAO.LoginDAO login;
        private VO.PosVO pos;
        private VO.ConfigVO config = new VO.ConfigVO();
        frmLogin fl = new frmLogin();
        private Double Price = 0;
        public frmDlgRefund()
        {
            InitializeComponent();
        }

        private void closeDlg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getData()
        {
            pos = new VO.PosVO();
            pos.Pos_orno = Convert.ToInt32(txtBoxOR.Text);
            pos.Pos_terminal = fl.tN;
            try
            {
                String[,] grabData = pos.ReadRefunData();
                dataGridView1.Rows.Clear();
                for (int x = 0; x < grabData.GetLength(1); x++)
                {
                    Double priceDetect = 0;
                    if (pos.checkWS() == true) //If Wholesale
                    {
                        priceDetect = Convert.ToDouble(grabData[4, x]);
                    }
                    else
                        priceDetect = Convert.ToDouble(grabData[3, x]);
                    dataGridView1.Rows.Add(grabData[0, x].ToString(), grabData[1, x].ToString(), grabData[2, x].ToString(), priceDetect, Convert.ToDouble(grabData[5, x]), Convert.ToDouble(grabData[6, x]), grabData[7, x].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void getDataSelect()
        {
            pos = new VO.PosVO();
            pos.Pos_orno = Convert.ToInt32(txtBoxOR.Text);
            pos.Pos_terminal = cBTerminal.Text;
            try
            {
                String[,] grabData = pos.ReadRefunData();
                dataGridView1.Rows.Clear();
                for (int x = 0; x < grabData.GetLength(1); x++)
                {
                    Double priceDetect = 0;
                    if (pos.checkWS() == true) //If Wholesale
                    {
                        priceDetect = Convert.ToDouble(grabData[4, x]);
                    }
                    else
                        priceDetect = Convert.ToDouble(grabData[3, x]);
                    dataGridView1.Rows.Add(grabData[0, x].ToString(), grabData[1, x].ToString(), grabData[2, x].ToString(), priceDetect, Convert.ToDouble(grabData[5, x]), Convert.ToDouble(grabData[6, x]), grabData[7, x].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void getTerminal()
        {
            try
            {
                config = new VO.ConfigVO();
                cBTerminal.Items.Clear();
                String[,] grabData = config.ReadTerminal();
                for (int x = 0; x < grabData.GetLength(1); x++)
                {
                    cBTerminal.Items.Add(grabData[0, x].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmDlgRefund_Load(object sender, EventArgs e)
        {
            login = new DAO.LoginDAO();
            String userName = frmLogin.User.user_name;
            login.catchUsername(userName);
            if (login.hasUser_Accounts())
            {
                lbl1.Visible = true;
                cBTerminal.Visible = true;
            }
        }

        private void txtBoxOR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getData();
                cBTerminal.Enabled = true;
                getTerminal();
            }
        }

        private void txtBoxOR_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cBTerminal.Enabled = false;
        }

        private void cBTerminal_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataSelect();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxQty.ReadOnly = false;
            txtBoxQty.Focus();
            txtBoxQty.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void txtBoxOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxQty_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxQty.Text == "")
            {
                btnRefund.Enabled = false;
            }
            try
            {
                if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value) >= Convert.ToInt32(txtBoxQty.Text))
                {
                    btnRefund.Enabled = true;
                }
                else
                    btnRefund.Enabled = false;
            }
            catch (Exception)
            {
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do You Wish To Continue?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    Int32 compute = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value) - Convert.ToInt32(txtBoxQty.Text);
                    dataGridView1.SelectedRows[0].Cells[1].Value = compute;
                    Double finale = Price * Convert.ToDouble(txtBoxQty.Text);
                    dataGridView1.SelectedRows[0].Cells[5].Value = finale;
                    if (Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[1].Value) == Convert.ToDouble(0))
                    {
                        dataGridView1.SelectedRows[0].Cells[5].Value = Convert.ToDouble(0);
                    }
                    txtBoxQty.Clear();
                    btnRefund.Enabled = false;
                    CellSum();
                }
            }
            catch (Exception)
            {
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Price = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[5].Value) / Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[1].Value);
        }

        private Double CellSum()
        {
            Double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                Double d = 0;
                Double.TryParse(dataGridView1.Rows[i].Cells[5].Value.ToString(), out d);
                sum += d;
            }
            return sum;
        }
    }
}