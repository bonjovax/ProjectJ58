using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nPOSProj.VO
{
    class PosVO
    {
        private Int32 pos_orno;

        public Int32 Pos_orno
        {
            get { return pos_orno; }
            set { pos_orno = value; }
        }
        private DateTime pos_date;

        public DateTime Pos_date
        {
            get { return pos_date; }
            set { pos_date = value; }
        }
        private DateTime pos_time;

        public DateTime Pos_time
        {
            get { return pos_time; }
            set { pos_time = value; }
        }
        private String crm_custcode;

        public String Crm_custcode
        {
            get { return crm_custcode; }
            set { crm_custcode = value; }
        }
        private String pos_customer;

        public String Pos_customer
        {
            get { return pos_customer; }
            set { pos_customer = value; }
        }
        private String pos_user;

        public String Pos_user
        {
            get { return pos_user; }
            set { pos_user = value; }
        }
        private Int32 pos_iswholesale;

        public Int32 Pos_iswholesale
        {
            get { return pos_iswholesale; }
            set { pos_iswholesale = value; }
        }
        private Double pos_tax_perc;

        public Double Pos_tax_perc
        {
            get { return pos_tax_perc; }
            set { pos_tax_perc = value; }
        }
        private Double pos_tax_amt;

        public Double Pos_tax_amt
        {
            get { return pos_tax_amt; }
            set { pos_tax_amt = value; }
        }
        private Double pos_total_amt;

        public Double Pos_total_amt
        {
            get { return pos_total_amt; }
            set { pos_total_amt = value; }
        }
        private String pos_paymethod;

        public String Pos_paymethod
        {
            get { return pos_paymethod; }
            set { pos_paymethod = value; }
        }
        private Double pos_change;

        public Double Pos_change
        {
            get { return pos_change; }
            set { pos_change = value; }
        }
        private Int32 pos_park;

        public Int32 Pos_park
        {
            get { return pos_park; }
            set { pos_park = value; }
        }
    }
}