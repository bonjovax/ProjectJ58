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
    public partial class mditemKits : Form
    {
        public mditemKits()
        {
            InitializeComponent();
        }

        private void mditemKits_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'npos_dbDataSet.inventory_items_kit' table. You can move, or remove it, as needed.
            this.inventory_items_kitTableAdapter.Fill(this.npos_dbDataSet.inventory_items_kit);
            // TODO: This line of code loads data into the 'npos_dbDataSet.inventory_items_kit' table. You can move, or remove it, as needed.
            this.inventory_items_kitTableAdapter.Fill(this.npos_dbDataSet.inventory_items_kit);

        }
    }
}
