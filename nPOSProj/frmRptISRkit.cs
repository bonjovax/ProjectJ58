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
    public partial class frmRptISRkit : Form
    {
        public frmRptISRkit()
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
        private void frmRptISRkit_Load(object sender, EventArgs e)
        {
            rptISRkit rep = new rptISRkit();
            npos_dbDataSet ds = new npos_dbDataSet();
            parkInventoryKitsTableAdapter adp = new parkInventoryKitsTableAdapter();
            rep.SetDataSource(ds);
            rep.SetParameterValue("dateParam", Convert.ToDateTime(DateParam).ToString("yyyy-MM-dd"));
            rep.SetParameterValue("terminalParam", TerminalParam);
            adp.Fill(ds.parkInventoryKits);
            crystalReportViewer1.ReportSource = rep;
        }
    }
}