using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarcodeLib;

namespace nPOSProj
{
    public partial class frmGiftCard : Form
    {
        private Barcode b = new Barcode();
        private VO.GiftCardVO gift;
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
            gift = new VO.GiftCardVO();
            String[,] grabData = gift.ReadGC();
            try
            {
                dataGridView1.Rows.Clear();
                for (int x = 0; x < grabData.GetLength(1); x++)
                {
                    dataGridView1.Rows.Add(grabData[0, x].ToString(), grabData[1, x].ToString(), Convert.ToDouble(grabData[2, x]), grabData[3, x].ToString(), Convert.ToDateTime(grabData[4, x]));
                }
            }
            catch (Exception)
            {
            }
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