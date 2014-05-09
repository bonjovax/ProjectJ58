using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nPOSProj.VO
{
    class PurchaseOrderVO
    {
        private DAO.PurchaseOrderDAO podao;
        private String _supplier_code;
        private String _supplier_name;
        public PurchaseOrderVO()
        {
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
    }
}
