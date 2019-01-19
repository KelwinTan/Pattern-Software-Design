using LW18_2_Web_Service_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Factory
{
    public class CartFactory
    {
        public static Cart createCart(int UserID, int ShoesID, int quantity)
        {
            return new Cart() { UserID = UserID, ShoeID = ShoesID, Quantity = quantity};
        }
    
    }
}