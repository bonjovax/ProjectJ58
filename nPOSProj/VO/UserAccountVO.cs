using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nPOSProj.VO
{
    public class UserAccountVO
    {
        private String _user_id;
        private String _user_name;
        private String _user_password;
        private String _last_login;
        private DAO.UserAccountDAO udao;

        public UserAccountVO()
        {

        }

        public UserAccountVO(String _user_name)
        {
            this._user_name = _user_name;
        }
        public String user_id
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
        public String last_login
        {
            get { return _last_login; }
            set { _last_login = value; }
        }

        public void PushLog()
        {
            udao = new DAO.UserAccountDAO();
            udao.logs(user_name);
        }
    }
}