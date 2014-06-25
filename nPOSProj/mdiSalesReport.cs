﻿using System;
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
    public partial class mdiSalesReport : Form
    {
        private MySqlConnection con = new MySqlConnection();
        private Conf.dbs dbcon = new Conf.dbs();
        private Conf.BIR bir = new Conf.BIR(); //Bureau of Internal Revenue - PH
        private String userName = frmLogin.User.user_name;
        #region System Config
        private Double taxP;
        private String taxDisplay;
        private String compName;
        private String address1;
        private String address2;
        private String contact;
        private String store_op;
        private String permit_no;
        private String TIN;
        private String TaxT;
        private String machine_no;
        private Int16 all_items_tax;
        #endregion
        private void ConfigCheck()
        {
            frmLogin fl = new frmLogin();
            con.ConnectionString = dbcon.getConnectionString();
            String query = "SELECT * FROM system_config";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr["tax_type"].ToString() == "V")
                    {
                        taxP = Convert.ToDouble("." + rdr["vat_rate"]);
                        taxDisplay = rdr["vat_rate"].ToString() + "%";
                        compName = rdr["company_name"].ToString();
                        address1 = rdr["company_address"].ToString();
                        address2 = rdr["company_address2"].ToString();
                        contact = rdr["company_contact"].ToString();
                        store_op = rdr["company_operator"].ToString();
                        permit_no = rdr["permit_no"].ToString();
                        TIN = rdr["tin_number"].ToString();
                        TaxT = rdr["tax_type"].ToString();
                        machine_no = rdr["machine_no"].ToString() + fl.tN;
                        all_items_tax = Convert.ToInt16(rdr["all_items_tax"]);
                    }
                    else
                    {
                        taxP = 0;
                        taxDisplay = "0%";
                        compName = rdr["company_name"].ToString();
                        address1 = rdr["company_address"].ToString();
                        address2 = rdr["company_address2"].ToString();
                        contact = rdr["company_contact"].ToString();
                        store_op = rdr["company_operator"].ToString();
                        permit_no = rdr["permit_no"].ToString();
                        TIN = rdr["tin_number"].ToString();
                        TaxT = rdr["tax_type"].ToString();
                        machine_no = rdr["machine_no"].ToString() + fl.tN;
                        all_items_tax = Convert.ToInt16(rdr["all_items_tax"]);
                    }
                }
                con.Close();
            }
            catch (Exception)
            {
                
            }
        }
        public mdiSalesReport()
        {
            InitializeComponent();
        }

        private void PrintXTicket()
        {
            printX.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printX_PrintPage);
            printX.Print();
        }

        void printX_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            frmLogin fl = new frmLogin();
            Graphics graphic = e.Graphics;
            Font font = new Font("Telidon", 10);

            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            //int offset = 40;

            #region Header
            graphic.DrawString(compName, new Font("Telidon", 14), new SolidBrush(Color.Black), startX, startY);
            graphic.DrawString(address1, new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 50, 30);
            graphic.DrawString(address2, new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 43, 45);
            graphic.DrawString(contact, new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 53, 60);
            graphic.DrawString("Owned & Operated By: " + store_op, new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 5, 75);
            graphic.DrawString("Permit No: " + permit_no, new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 62, 90);
            graphic.DrawString("TIN: " + TIN + "" + TaxT, new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 62, 105);
            graphic.DrawString("Accreditation No: " + bir.AccreditationNo(), new Font("Telidon Cd", 9), new SolidBrush(Color.Black), 11, 120);
            graphic.DrawString("Serial No: " + bir.SerialNo(), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 68, 135);
            graphic.DrawString("Machine Code: " + machine_no, new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 56, 150);
            graphic.DrawString("X Reports", new Font("Telidon CdHv", 13), new SolidBrush(Color.Black), 90, 165);
            graphic.DrawString(dtX.Text, new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 5, 185);
            graphic.DrawString(userName + " at Terminal: " + fl.tN, new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 5, 200);
            graphic.DrawString("-------------------------------------------", new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 3, 215);
            #endregion
            #region Content Reading
            graphic.DrawString("Gross Sales:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 230);
            //
            graphic.DrawString("Discounts:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 246);
            //
            graphic.DrawString("Net Sales:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 262);
            //
            //
            //Space
            //
            graphic.DrawString("Non-VAT Sales:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 295);
            //
            graphic.DrawString("VAT Sales:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 310);
            //
            graphic.DrawString("VAT:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 325);
            //
            //
            //Space
            //
            graphic.DrawString("Counter No. Start:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 358);
            //
            graphic.DrawString("Counter No. End:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 373);
            //
            //
            //Space
            //
            graphic.DrawString("Cancelled Txn:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 406);
            //
            graphic.DrawString("Cancelled Amount:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 421);
            //
            //
            //Space
            //
            graphic.DrawString("No of Transactions:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 454);
            //
            graphic.DrawString("No of EAN:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 469);
            //
            graphic.DrawString("Total Quantity:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 484);
            //
            //
            //Space
            //
            graphic.DrawString("Previous Reading:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 517);
            //
            graphic.DrawString("Net Sales:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 532);
            //
            graphic.DrawString("Running Total:".PadRight(10), new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 25, 547);
            //
            #endregion
            #region Footer
            graphic.DrawString("-------------------------------------------", new Font("Telidon Cd", 11), new SolidBrush(Color.Black), 3, 570);
            graphic.DrawString("End of X Reports", new Font("Telidon CdHv", 13), new SolidBrush(Color.Black), 70, 579);
            #endregion
        }

        private void btnPrintX_Click(object sender, EventArgs e)
        {
            PrintXTicket();
        }

        private void mdiSalesReport_Load(object sender, EventArgs e)
        {
            ConfigCheck();
        }
    }
}
