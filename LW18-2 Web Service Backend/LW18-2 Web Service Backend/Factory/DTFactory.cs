using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Factory
{
    public class DTFactory
    {
        public static Detail_Transaction createDT(int headID, int qty, int shoeID)
        {
            return new Detail_Transaction() { HeaderTransactionID = headID, Quantity = qty, ShoeID = shoeID };
        }

    }
}