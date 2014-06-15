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
    public partial class mdiPayment : Form
    {
        private Conf.Rgx r = new Conf.Rgx();
        private VO.CustomersVO customer;
        public mdiPayment()
        {
            InitializeComponent();
        }

        private void txtBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxAmount.Text != "" && txtBoxAmount.Text != "0.00" && txtBoxAmount.Text != "0")
            {
                if (Regex.IsMatch(txtBoxAmount.Text, r.Amount()))
                {
                    if (Convert.ToDouble(txtBoxAmount.Text) <= Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value) && Convert.ToDouble(txtBoxAmount.Text) != 0)
                    {
                        txtBoxAmount.ReadOnly = false;
                        btnPay.Enabled = true;
                    }
                    else
                    {
                        btnPay.Enabled = false;
                        txtBoxAmount.Focus();
                    }
                }
                else
                {
                    btnPay.Enabled = false;
                    txtBoxAmount.Focus();
                }
            }
            else
            {
                txtBoxAmount.Focus();
                btnPay.Enabled = false;
            }
        }

        private void mdiPayment_Load(object sender, EventArgs e)
        {
            try
            {
                customer = new VO.CustomersVO();
                String[,] grabData = customer.ReadCustomersPayment();
                dataGridView1.Rows.Clear();
                for (int x = 0; x < grabData.GetLength(1); x++)
                {
                    dataGridView1.Rows.Add(grabData[0, x].ToString(), grabData[1, x].ToString(), Convert.ToDouble(grabData[2, x]), Convert.ToDouble(grabData[3, x]), Convert.ToDouble(grabData[4, x]));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check Database!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxAmount.ReadOnly = false;
            txtBoxAmount.Text = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value).ToString("#,###,##0.00");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (mCrmBasic crm = new mCrmBasic())
            {
                crm.Custcode = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                crm.ShowDialog();
            }
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Payment");
            saveFileDialog1.DefaultExt = ".xml";
            saveFileDialog1.FileName = "Export";
            saveFileDialog1.Filter = "Extensible Markup Language (*.xml)|*.xml";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dt.Columns.Add(dataGridView1.Columns[i].Name, typeof(System.String));
                }

                DataRow dickrow;
                int cols = dataGridView1.Columns.Count;
                foreach (DataGridViewRow drow in this.dataGridView1.Rows)
                {
                    dickrow = dt.NewRow();
                    for (int i = 0; i <= cols - 1; i++)
                    {
                        dickrow[i] = drow.Cells[i].Value;
                    }
                    dt.Rows.Add(dickrow);
                }
                dt.WriteXml(saveFileDialog1.FileName);
            }
        }
    }
}