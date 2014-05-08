using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace nPOSProj
{
    public partial class mPOrder : Form
    {
        private MySqlConnection con = new MySqlConnection();
        private Conf.dbs dbcon = new Conf.dbs();
        private bool resetRow = false;
        private Int32 currentRow;
        private Int32 currentColumn;
        public mPOrder()
        {
            InitializeComponent();
        }

        private void mPOrder_Load(object sender, EventArgs e)
        {
            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
            dataGridView1.DataBindingComplete +=new DataGridViewBindingCompleteEventHandler(dataGridView1_DataBindingComplete);
        }


        public AutoCompleteStringCollection AutoCompleteLoad()
        {
            AutoCompleteStringCollection str = new AutoCompleteStringCollection();
            con.ConnectionString = dbcon.getConnectionString();
            String sql = "SELECT stock_code FROM inventory_stocks ORDER BY stock_code ASC";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows == true)
                {
                    while (rdr.Read())
                        str.Add(rdr["stock_code"].ToString());
                        //collect.Add(rdr["user_name"].ToString());
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check your Database Server Connection", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
            return str;
        }
        public AutoCompleteStringCollection AutoCompleteLoadSS()
        {
            AutoCompleteStringCollection str = new AutoCompleteStringCollection();
            con.ConnectionString = dbcon.getConnectionString();
            String sql = "SELECT stock_name FROM inventory_stocks ORDER BY stock_name ASC";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows == true)
                {
                    while (rdr.Read())
                        str.Add(rdr["stock_name"].ToString());
                    //collect.Add(rdr["user_name"].ToString());
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check your Database Server Connection", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
            return str;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int column = dataGridView1.CurrentCell.ColumnIndex;
            string headerText = dataGridView1.Columns[column].HeaderText;

            if (headerText.Equals("Stock Code"))
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    tb.AutoCompleteCustomSource = AutoCompleteLoad();
                    tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            if (headerText.Equals("Particulars"))
            {
                TextBox tb1 = e.Control as TextBox;
                if (tb1 != null)
                {
                    tb1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    tb1.AutoCompleteCustomSource = AutoCompleteLoadSS();
                    tb1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            resetRow = true;
            currentRow = e.RowIndex;
            currentColumn = e.ColumnIndex;
            dgQTY.ReadOnly = false;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (resetRow)
            {
                resetRow = false;
                dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[currentColumn];
            }
        }
    }
}