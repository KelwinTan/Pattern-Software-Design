using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Repositories
{
    public class CartRepository
    {
        private static Database1Entities DB = DatabaseSingleton.GetSingletonInstance();
        
        //Insert Cart
        public static void InsertCart(Cart cart)
        {
            DB.Carts.Add(cart);
            DB.SaveChanges();
        }

        //Update Shoe Quantity in Cart
        public static Cart UpdateCartByQuantity(int userId, int shoeID, int quantity, int updateQuantity)
        {
            //Cart target = (from x in DB.Carts where x == cart select x).FirstOrDefault();
            //target = updateCart;
            Cart target = DB.Carts.Where(x => x.ShoeID == shoeID && x.UserID == userId && x.Quantity == quantity).FirstOrDefault();
            target.Quantity = updateQuantity;
            DB.SaveChanges();
            return target;
        }

        //Delete Cart
        public static void DeleteCart(Cart deleteCart)
        {
            DB.Carts.Remove(deleteCart);
            DB.SaveChanges();
        }

        //Find Cart
        public static Cart findCart(Cart findCart)
        {
            try
            {
                return DB.Carts.Where(x => x.ShoeID == findCart.ShoeID && x.UserID == findCart.UserID && x.Quantity == findCart.Quantity).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        //Find Cart By Attributes
        public static Cart findCartByAttributes(int UserID, int ShoeID)
        {
            return DB.Carts.Where(x => x.UserID == UserID && x.ShoeID == ShoeID).FirstOrDefault();
        }

        //Find user's carts
        public static List<Cart> findCartByUserID(int UserID)
        {
            return DB.Carts.Where(x => x.UserID == UserID).ToList();
        }

        //Get All Carts
        public static List<Cart> getAll()
        {
            return DB.Carts.ToList();
        }

        //Get the last user ID
        public static int getLatestUserID()
        {
            return DB.Carts.Last().UserID;
        }

        public static int getLatestShoeID()
        {
            return DB.Carts.Last().ShoeID;
        }


    }
}