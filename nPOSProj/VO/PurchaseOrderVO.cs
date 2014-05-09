using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nPOSProj.VO
{
    class PurchaseOrderVO
    {
        private DAO.PurchaseOrderDAO podao;
        private Int32 _po_no;
        private String _po_date;
        private String _po_time;
        private String _supplier_code;
        private String _supplier_name;
        private String _user_name;
        public PurchaseOrderVO()
        {
        }

        public Int32 po_no
        {
            get { return _po_no; }
            set { _po_no = value; }
        }
        public String po_date
        {
            get { return _po_date; }
            set { _po_date = value; }
        }
        public String po_time
        {
            get { return _po_time; }
            set { _po_time = value; }
        }
        public String supplier_code
        {
            get { return _supplier_code; }
            set { _supplier_code = value; }
        }
        public String supplier_name
        {
            get { return _supplier_name; }
            set { _supplier_name = value; }
        }
        public String user_name
        {
            get { return _user_name; }
            set { _user_name = value; }
        }

        public Int32 askPOno()
        {
            Int32 POno;
            podao = new DAO.PurchaseOrderDAO();
            podao.postPONumber();
            POno = podao.postPONumber();
            return POno + 1;
        }

        public String askSupplierName()
        {
            String supplier_name;
            podao = new DAO.PurchaseOrderDAO();
            podao.katsSupplierName(supplier_code);
            supplier_name = podao.katsSupplierName(supplier_code);
            return supplier_name;
        }
        public String askSupplierCode()
        {
            String supplier_code;
            podao = new DAO.PurchaseOrderDAO();
            podao.katsSupplierCode(supplier_name);
            supplier_code = podao.katsSupplierCode(supplier_name);
            return supplier_code;
        }
        public void PO_Issue()
        {
            podao = new DAO.PurchaseOrderDAO();
            podao.IssuePO(po_no, po_date, po_time, supplier_code, user_name);
        }
    }
}
