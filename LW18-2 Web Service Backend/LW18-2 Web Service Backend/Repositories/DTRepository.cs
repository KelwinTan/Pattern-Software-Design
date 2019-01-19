using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Repositories
{
    public class DTRepository
    {
        private static Database1Entities DB = DatabaseSingleton.GetSingletonInstance();
        public static void insertDT(Detail_Transaction newDT)
        {
            DB.Detail_Transactions.Add(newDT);
            DB.SaveChanges();
        }

        public static List<Detail_Transaction> getAll()
        {
            return DB.Detail_Transactions.ToList();
        }

        public static List<Detail_Transaction> getUsersDT(int headerID)
        {
            return DB.Detail_Transactions.Where(x => x.HeaderTransactionID == headerID).ToList();
        }


    }
}