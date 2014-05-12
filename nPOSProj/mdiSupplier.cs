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
    public partial class mdiSupplier : Form
    {
        public mdiSupplier()
        {
            InitializeComponent();
        }

        private void mdiSupplier_Load(object sender, EventArgs e)
        {
            rdSC.Text = DateTime.Now.Year.ToString();
            // TODO: This line of code loads data into the 'npos_dbDataSet.inventory_supplier' table. You can move, or remove it, as needed.
            this.inventory_supplierTableAdapter.Fill(this.npos_dbDataSet.inventory_supplier);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventory_supplierTableAdapter.UpdateSupplier(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), dataGridView1.SelectedRows[0].Cells[4].Value.ToString(), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value), dataGridView1.SelectedRows[0].Cells[6].Value.ToString(), dataGridView1.SelectedRows[0].Cells[7].Value.ToString(), dataGridView1.SelectedRows[0].Cells[8].Value.ToString(), dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                btnUpdate.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check your Database Server Connection", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do You Wish To Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlgResult == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                    {
                        if (oneCell.Selected)
                        {
                            this.inventory_supplierTableAdapter.DeleteSupplier(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                            dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                            btnDelete.Enabled = false;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Check your Database Server Connection", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.ExitThread();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            mCode.Clear();
            txtBoxNameComp.Clear();
            txtBoxAddress.Clear();
            txtBoxCityMun.Clear();
            txtBoxCountry.Clear();
            txtBoxZipPos.Clear();
            txtBoxContactNo.Clear();
            txtBoxCPerson.Clear();
            txtBoxCPosition.Clear();
        }

        private void rdSC_TextChanged(object sender, EventArgs e)
        {
            if (rdSC.Text != "" && mCode.Text != "" && txtBoxNameComp.Text != "" && txtBoxAddress.Text != "" & txtBoxCityMun.Text != "" && txtBoxCountry.Text != "" && txtBoxZipPos.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void mCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (rdSC.Text != "" && mCode.Text != "" && txtBoxNameComp.Text != "" && txtBoxAddress.Text != "" & txtBoxCityMun.Text != "" && txtBoxCountry.Text != "" && txtBoxZipPos.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void txtBoxNameComp_TextChanged(object sender, EventArgs e)
        {
            if (rdSC.Text != "" && mCode.Text != "" && txtBoxNameComp.Text != "" && txtBoxAddress.Text != "" & txtBoxCityMun.Text != "" && txtBoxCountry.Text != "" && txtBoxZipPos.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void txtBoxAddress_TextChanged(object sender, EventArgs e)
        {
            if (rdSC.Text != "" && mCode.Text != "" && txtBoxNameComp.Text != "" && txtBoxAddress.Text != "" & txtBoxCityMun.Text != "" && txtBoxCountry.Text != "" && txtBoxZipPos.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void txtBoxCityMun_TextChanged(object sender, EventArgs e)
        {
            if (rdSC.Text != "" && mCode.Text != "" && txtBoxNameComp.Text != "" && txtBoxAddress.Text != "" & txtBoxCityMun.Text != "" && txtBoxCountry.Text != "" && txtBoxZipPos.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void txtBoxCountry_TextChanged(object sender, EventArgs e)
        {
            if (rdSC.Text != "" && mCode.Text != "" && txtBoxNameComp.Text != "" && txtBoxAddress.Text != "" & txtBoxCityMun.Text != "" && txtBoxCountry.Text != "" && txtBoxZipPos.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void txtBoxZipPos_TextChanged(object sender, EventArgs e)
        {
            if (rdSC.Text != "" && mCode.Text != "" && txtBoxNameComp.Text != "" && txtBoxAddress.Text != "" & txtBoxCityMun.Text != "" && txtBoxCountry.Text != "" && txtBoxZipPos.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do You Wish To Add Supplier?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                try
                {
                    String sc_combine = rdSC.Text + "-" + mCode.Text.ToUpper();
                    String added = DateTime.Now.ToLongDateString() + " at " + DateTime.Now.ToLongTimeString();
                    Int32 date = DateTime.Now.Year;
                    this.inventory_supplierTableAdapter.InsertSupplier(sc_combine, txtBoxNameComp.Text, txtBoxAddress.Text, txtBoxCityMun.Text, txtBoxCountry.Text, Convert.ToInt32(txtBoxZipPos.Text), txtBoxContactNo.Text, txtBoxCPerson.Text, txtBoxCPosition.Text, added, date);
                    clear();
                    this.inventory_supplierTableAdapter.Fill(this.npos_dbDataSet.inventory_supplier);
                }
                catch (Exception)
                {
                    MessageBox.Show("Supplier Code Existed! or Check Database Server!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void inventorysupplierBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}