using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nPOSProj.VO
{
    class ReceivingVO
    {
        private Int32 _po_no;
        private String _stock_code;
        private Int32 _quantity;
        private DAO.ReceivingDAO rdao;

        public ReceivingVO()
        {

        }

        public Int32 po_no
        {
            get { return _po_no; }
            set { _po_no = value; }
        }
        public String stock_code
        {
            get { return _stock_code; }
            set { _stock_code = value; }
        }
        public Int32 quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public void ReceiveStocks()
        {
            rdao = new DAO.ReceivingDAO();
            rdao.Receive(po_no, stock_code, quantity);
        }
        public Int32 askQty()
        {
            Int32 qty;
            rdao = new DAO.ReceivingDAO();
            rdao.aQuantity(stock_code);
            qty = rdao.aQuantity(stock_code);
            return qty;
        }
    }
}