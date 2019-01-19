using LW18_2_Web_Service_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Factory
{
    public class ShoeFactory
    {
        public static Shoes createShoe(string shoeName, int price)
        {
            return new Shoes() { ShoeName = shoeName, Price = price };
        }
        
    }

}