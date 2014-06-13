using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nPOSProj.VO
{
    class CustomersVO
    {
        private DAO.CustomersDAO customers;
        public CustomersVO() { }

        public String[,] ReadCustomers()
        {
            customers = new DAO.CustomersDAO();
            Int32 count = customers.PositionCount();
            String[,] xxx = new String[6, count];
            customers.ReadCustomer();
            xxx = customers.ReadCustomer();
            return xxx;
        }
    }
}