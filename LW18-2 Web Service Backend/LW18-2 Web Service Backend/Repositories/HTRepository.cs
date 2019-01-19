using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Repositories
{
    public class HTRepository
    {
        private static Database1Entities DB = DatabaseSingleton.GetSingletonInstance();

        public static int getLastHTID()
        {
            try
            {
                return DB.Header_Transactions.Last().HeaderTransactionID;
            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }

        public static void insertHT(Header_Transaction newHT)
        {
            DB.Header_Transactions.Add(newHT);
            DB.SaveChanges();
        }

        public static List<Header_Transaction> getAllHT()
        {
            return DB.Header_Transactions.ToList();
        }

        public static int getUsersHT(int userID)
        {
            return DB.Header_Transactions.Where(x => x.UserID == userID).FirstOrDefault().HeaderTransactionID;
        }

        public static Header_Transaction getHT(int userID)
        {
            return DB.Header_Transactions.Where(x => x.UserID == userID).FirstOrDefault();
        }


    }
}