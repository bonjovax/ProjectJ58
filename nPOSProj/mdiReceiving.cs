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
    public partial class mdiReceiving : Form
    {
        public mdiReceiving()
        {
            InitializeComponent();
        }

        private void mdiReceiving_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'npos_dbDataSet.po_order' table. You can move, or remove it, as needed.
            //this.po_orderTableAdapter.Fill(this.npos_dbDataSet.po_order, Convert.ToDateTime(dateTimePicker1.Text));
            this.po_orderTableAdapter.FillByPending(this.npos_dbDataSet.po_order, Convert.ToDateTime("5/15/14"));
        }
    }
}
