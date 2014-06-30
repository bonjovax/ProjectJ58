using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using nPOSProj.npos_dbDataSetTableAdapters;

namespace nPOSProj
{
    public partial class frmRptISR : Form
    {
        public frmRptISR()
        {
            InitializeComponent();
        }
        private String dateParam;

        public String DateParam
        {
            get { return dateParam; }
            set { dateParam = value; }
        }
        private String terminalParam;

        public String TerminalParam
        {
            get { return terminalParam; }
            set { terminalParam = value; }
        }

        private void frmRptISR_Load(object sender, EventArgs e)
        {
            rptItemSalesReport rep = new rptItemSalesReport();
            npos_dbDataSet ds = new npos_dbDataSet();
            parkInventoryItemsTableAdapter adp = new parkInventoryItemsTableAdapter();
            adp.Fill(ds.parkInventoryItems);
            rep.SetDataSource(ds);
            rep.SetParameterValue("dateParam", Convert.ToDateTime(DateParam).ToString("yyyy-MM-dd"));
            rep.SetParameterValue("terminalParam", TerminalParam);
            crystalReportViewer1.ReportSource = rep;
        }
    }
}