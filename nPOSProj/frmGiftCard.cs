using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarcodeLib;
using MySql.Data.MySqlClient;

namespace nPOSProj
{
    public partial class frmGiftCard : Form
    {
        private Barcode b = new Barcode();
        private Conf.dbs dbcon = new Conf.dbs();
        private MySqlConnection con = new MySqlConnection();
        public frmGiftCard()
        {
            InitializeComponent();
        }

        private void frmGiftCard_Load(object sender, EventArgs e)
        {
            b.Alignment = AlignmentPositions.CENTER;
            b.Width = 775;
            b.Height = 55;
            TYPE t = TYPE.CODE39;
            b.IncludeLabel = true;
            b.LabelPosition = LabelPositions.BOTTOMCENTER;
            barcode.Image = b.Encode(t, "0");
            txtBoxCardNo.Focus();
            //
            dbcon = new Conf.dbs();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            String connectionString = dbcon.getConnectionString();
            String query = "SELECT * ";
            query += "FROM gc_core";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4]);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            } // end using
        }

        private void txtBoxCardNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxCardNo.Text != "")
                {
                    b.Alignment = AlignmentPositions.CENTER;
                    b.Width = 775;
                    b.Height = 55;
                    TYPE t = TYPE.CODE39;
                    b.IncludeLabel = true;
                    b.LabelPosition = LabelPositions.BOTTOMCENTER;
                    barcode.Image = b.Encode(t, txtBoxCardNo.Text);
                    bcSave.Enabled = true;
                }
                else
                {
                    TYPE t = TYPE.CODE39;
                    b.IncludeLabel = true;
                    b.LabelPosition = LabelPositions.BOTTOMCENTER;
                    barcode.Image = b.Encode(t, "0");
                    bcSave.Enabled = false;
                }
                if (txtBoxCardNo.Text != "" && txtBoxAmount.Text != "" && dateTimePicker1.Text != "")
                {
                    btnAdd.Enabled = true;
                }
                else
                    btnAdd.Enabled = false;
            }
            catch (Exception)
            {
            }
        }

        private void txtBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCardNo.Text != "" && txtBoxAmount.Text != "" && dateTimePicker1.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void txtBoxHolder_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCardNo.Text != "" && txtBoxAmount.Text != "" && dateTimePicker1.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (txtBoxCardNo.Text != "" && txtBoxAmount.Text != "" && dateTimePicker1.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void txtBoxCardNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxAmount.Focus();
            }
        }

        private void txtBoxAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxHolder.Focus();
            }
        }
    }
}