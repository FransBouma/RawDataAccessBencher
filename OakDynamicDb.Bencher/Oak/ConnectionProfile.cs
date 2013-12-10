using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Oak
{
    public class ConnectionProfile
    {
        public ConnectionProfile()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["Oak"].ConnectionString;
        }

        public string ConnectionString { get; set; }
    }
}