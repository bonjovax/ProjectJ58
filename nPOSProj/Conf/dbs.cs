using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace nPOSProj.Conf
{
    class dbs
    {
        private String connectionString;

        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["nPOSProj.Properties.Settings.npos_dbConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}