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
    public partial class mdiItemKits : Form
    {
        public mdiItemKits()
        {
            InitializeComponent();
        }

        private void mditemKits_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'npos_dbDataSet.inventory_items1' table. You can move, or remove it, as needed.
                this.inventory_items1TableAdapter.Fill(this.npos_dbDataSet.inventory_items1);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Server!", "Database Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtBoxQty.Text) >= 0 && Convert.ToDouble(txtBoxRetailPrice.Text) >= 0 && Convert.ToDouble(txtBoxWholesalePrice.Text) >= 0)
                {
                    this.inventory_items1TableAdapter.InsertQueryKit(Convert.ToInt32(txtBoxQty.Text), txtBoxEAN.Text, txtBoxDescription.Text, Convert.ToDecimal(txtBoxRetailPrice.Text), Convert.ToDecimal(txtBoxWholesalePrice.Text));
                    this.inventory_items1TableAdapter.Fill(this.npos_dbDataSet.inventory_items1);
                    txtBoxRetailPrice.Text = "0.00";
                    txtBoxWholesalePrice.Text = "0.00";
                    txtBoxQty.Clear();
                    txtBoxEAN.Clear();
                    txtBoxDescription.Clear();
                    btnAdd.Enabled = false;
                }
                else
                    MessageBox.Show("Negative Value will not consider", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Server or Check Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxQty_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxQty.Text != "" && txtBoxEAN.Text != "" && txtBoxDescription.Text != "" && txtBoxRetailPrice.Text != "0.00" && txtBoxWholesalePrice.Text != "0.00" && txtBoxRetailPrice.Text != "" && txtBoxWholesalePrice.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void txtBoxEAN_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxQty.Text != "" && txtBoxEAN.Text != "" && txtBoxDescription.Text != "" && txtBoxRetailPrice.Text != "0.00" && txtBoxWholesalePrice.Text != "0.00" && txtBoxRetailPrice.Text != "" && txtBoxWholesalePrice.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void txtBoxDescription_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxQty.Text != "" && txtBoxEAN.Text != "" && txtBoxDescription.Text != "" && txtBoxRetailPrice.Text != "0.00" && txtBoxWholesalePrice.Text != "0.00" && txtBoxRetailPrice.Text != "" && txtBoxWholesalePrice.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void txtBoxRetailPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxQty.Text != "" && txtBoxEAN.Text != "" && txtBoxDescription.Text != "" && txtBoxRetailPrice.Text != "0.00" && txtBoxWholesalePrice.Text != "0.00" && txtBoxRetailPrice.Text != "" && txtBoxWholesalePrice.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void txtBoxWholesalePrice_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxQty.Text != "" && txtBoxEAN.Text != "" && txtBoxDescription.Text != "" && txtBoxRetailPrice.Text != "0.00" && txtBoxWholesalePrice.Text != "0.00" && txtBoxRetailPrice.Text != "" && txtBoxWholesalePrice.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value) >= 0 && Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[3].Value) >= 0 && Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value) >= 0)
                {
                    this.inventory_items1TableAdapter.UpdateQueryKit(dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[3].Value), Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[4].Value), dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                    MessageBox.Show("Negative Value will not consider", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Server or Check Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do You Want to Delete This Item Kit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (dlgResult == DialogResult.Yes)
                {
                    foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                    {
                        if (oneCell.Selected)
                        {
                            this.inventory_items1TableAdapter.DeleteQueryKit(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                            this.inventory_items1TableAdapter.DeleteQueryItemsList(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                            btnDelete.Enabled = false;
                            btnUpdate.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check Server or Check Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mKits kits = new mKits();
            kits.Ean = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            kits.ShowDialog();
        }
    }
}