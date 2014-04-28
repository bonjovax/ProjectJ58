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
    public partial class mdiUserAcc : Form
    {
        public mdiUserAcc()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtBoxUserID.Clear();
            txtBoxUserName.Clear();
            txtBoxPassword.Clear();
            txtBoxFirstName.Clear();
            txtBoxMiddleName.Clear();
            txtBoxLastName.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
