using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Factory
{
    public class HTFactory
    {
        public static Header_Transaction createHT(int ht, int userID)
        {
            return new Header_Transaction() { HeaderTransactionID = ht, UserID = userID };
        }



    }
}