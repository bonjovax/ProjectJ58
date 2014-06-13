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
    public partial class mdiDirectory : Form
    {
        private VO.CustomersVO customer;
        public mdiDirectory()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            customer = new VO.CustomersVO();
            String[,] grabData = customer.ReadCustomers();
            try
            {
                dataGridView1.Rows.Clear();
                for (int x = 0; x < grabData.GetLength(1); x++)
                {
                    dataGridView1.Rows.Add(grabData[0, x].ToString(), grabData[1, x].ToString(), grabData[2, x].ToString(), grabData[3, x].ToString(), grabData[4, x].ToString(), Convert.ToDouble(grabData[5, x].ToString()));
                }
            }
            catch (Exception)
            {
            }
        }

        private void mdiDirectory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (mNewDirectory newdir = new mNewDirectory())
            {
                newdir.ShowDialog();
                if (newdir.Activity == true)
                {
                    LoadData();
                }
            }
        }
    }
}