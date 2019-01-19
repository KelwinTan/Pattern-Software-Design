using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Utilities
{
    public class ConnectionConfig
    {
        public static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + HttpContext.Current.Server.MapPath(@"..\App_Data\Database1.mdf") + ";Integrated Security=True";

    }
}