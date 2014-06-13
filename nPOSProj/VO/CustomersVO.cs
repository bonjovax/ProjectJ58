using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nPOSProj.VO
{
    class CustomersVO
    {
        private DAO.CustomersDAO customers;
        private String custcode;

        public String Custcode
        {
            get { return custcode; }
            set { custcode = value; }
        }
        private String companyname;

        public String Companyname
        {
            get { return companyname; }
            set { companyname = value; }
        }
        private String firstname;

        public String Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        private String middlename;

        public String Middlename
        {
            get { return middlename; }
            set { middlename = value; }
        }
        private String lastname;

        public String Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        private String phone_no;

        public String Phone_no
        {
            get { return phone_no; }
            set { phone_no = value; }
        }
        private String address;

        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        private String city;

        public String City
        {
            get { return city; }
            set { city = value; }
        }
        private String province;

        public String Province
        {
            get { return province; }
            set { province = value; }
        }
        private String zip_code;

        public String Zip_code
        {
            get { return zip_code; }
            set { zip_code = value; }
        }
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
        public void AddCustomers()
        {
            customers = new DAO.CustomersDAO();
            customers.Add(Custcode, Companyname, Firstname, Middlename, Lastname, Email, Phone_no, Address, City, Province, Zip_code);
        }
        public void UpdateCustomers()
        {
            customers = new DAO.CustomersDAO();
            customers.Update(Custcode, Companyname, Firstname, Middlename, Lastname, Email, Phone_no, Address, City, Province, Zip_code);
        }
        public void DeleteCustomers()
        {
            customers = new DAO.CustomersDAO();
            customers.Delete(Custcode);
        }
        public bool CheckCustCode()
        {
            bool check;
            customers = new DAO.CustomersDAO();
            check = customers.checkCustcode(Custcode);
            return check;
        }
    }
}