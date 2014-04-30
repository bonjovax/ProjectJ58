using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nPOSProj.VO
{
    public class UserAccountVO
    {
        private Int32 _user_id;
        private String _user_name;
        private String _user_password;
        private String _date_created;
        private String _first_name;
        private String _middle_name;
        private String _last_name;
        private String _last_login;
        private DAO.UserAccountDAO udao;

        public UserAccountVO()
        {

        }

        public UserAccountVO(String _user_name)
        {
            this._user_name = _user_name;
        }
        public Int32 user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        public String user_name
        {
            get { return _user_name; }
            set { _user_name = value; }
        }
        public String user_password
        {
            get { return _user_password; }
            set { _user_password = value; }
        }
        public String date_created
        {
            get { return _date_created; }
            set { _date_created = value; }
        }
        public String first_name
        {
            get { return _first_name; }
            set { _first_name = value; }
        }
        public String middle_name
        {
            get { return _middle_name; }
            set { _middle_name = value; }
        }
        public String last_name
        {
            get { return _last_name; }
            set { _last_name = value; }
        }
        public String last_login
        {
            get { return _last_login; }
            set { _last_login = value; }
        }

        public void AddUser()
        {
            udao = new DAO.UserAccountDAO();
            udao.Add(user_id, user_name, user_password, first_name, middle_name, last_name);
        }
        public void UpdateUser()
        {
            udao = new DAO.UserAccountDAO();
            udao.Update(user_id, user_name, first_name, middle_name, last_name);
        }
        public void DeleteUser()
        {
            udao = new DAO.UserAccountDAO();
            udao.Delete(user_id, user_name);
        }

        public void PushLog()
        {
            udao = new DAO.UserAccountDAO();
            udao.logs(user_name);
        }

        public Int32 askUserID()
        {
            Int32 UserID;
            udao = new DAO.UserAccountDAO();
            udao.postUserID();
            UserID = udao.postUserID();
            return UserID + 1;
        }
    }
}