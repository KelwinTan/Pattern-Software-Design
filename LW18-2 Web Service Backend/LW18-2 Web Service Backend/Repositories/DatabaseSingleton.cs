using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Repositories
{
    public class DatabaseSingleton
    {
        private static Database1Entities DB;

        private DatabaseSingleton() { }
        public static Database1Entities GetSingletonInstance() {
            if (DB == null)
                DB = new Database1Entities();
            return DB;
        } 

    }
}