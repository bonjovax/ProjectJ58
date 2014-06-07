using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nPOSProj.VO
{
    class PosVO
    {
        private DAO.PosDAO POSDAO;
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

        private String pos_terminal;

        public String Pos_terminal
        {
            get { return pos_terminal; }
            set { pos_terminal = value; }
        }

        private Int32 pos_quantity;

        public Int32 Pos_quantity
        {
            get { return pos_quantity; }
            set { pos_quantity = value; }
        }

        private Double pos_discount;

        public Double Pos_discount
        {
            get { return pos_discount; }
            set { pos_discount = value; }
        }

        private Double pos_discount_amt;

        public Double Pos_discount_amt
        {
            get { return pos_discount_amt; }
            set { pos_discount_amt = value; }
        }

        private Int32 pos_ean;

        public Int32 Pos_ean
        {
            get { return pos_ean; }
            set { pos_ean = value; }
        }

        private Double pos_amt;

        public Double Pos_amt
        {
            get { return pos_amt; }
            set { pos_amt = value; }
        }

        public Int32 GetOrNo()
        {
            Int32 Or;
            POSDAO = new DAO.PosDAO();
            POSDAO.GenerateOR();
            Or = POSDAO.GenerateOR();
            return Or + 1;
        }

        public void BeginTransaction()
        {
            POSDAO = new DAO.PosDAO();
            POSDAO.Begin(Pos_orno, Pos_terminal, Pos_date, Pos_time, Pos_user);
        }

        public void SwitchToWholeSale()
        {
            POSDAO = new DAO.PosDAO();
            POSDAO.SwitchWS(Pos_orno);
        }

        public void ParkItem()
        {
            POSDAO = new DAO.PosDAO();
            POSDAO.Park_I(Pos_orno, Pos_ean, Pos_quantity, Pos_amt);
        }
        public void ParkItemSameUpdate()
        {
            POSDAO = new DAO.PosDAO();
            POSDAO.Park_I_Update(Pos_orno, Pos_ean, Pos_quantity, Pos_amt);
        }

        public void ParkItemUpdate()
        {
            POSDAO = new DAO.PosDAO();
            POSDAO.ParkU_I(Pos_orno, Pos_ean, Pos_discount, Pos_discount_amt, Pos_quantity, Pos_amt);
        }

        public void ParkDiscountItemUpdate()
        {
            POSDAO = new DAO.PosDAO();
            POSDAO.ParkUwD_I(Pos_orno, Pos_ean, Pos_discount, Pos_discount_amt, Pos_amt);
        }

        public void ParkVoidItem()
        {
            POSDAO = new DAO.PosDAO();
            POSDAO.ParkVoid_I(Pos_orno, Pos_ean);
        }

        public void CancelSale()
        {
            POSDAO = new DAO.PosDAO();
            POSDAO.CancelT(Pos_orno);
        }
    }
}