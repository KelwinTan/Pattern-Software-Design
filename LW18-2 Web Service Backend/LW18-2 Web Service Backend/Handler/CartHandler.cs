using LW18_2_Web_Service_Backend.Models;
using LW18_2_Web_Service_Backend.Repositories;
using LW18_2_Web_Service_Backend.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Handler
{
    public class CartHandler
    {
        public static Response doInsert(int ShoeID, int UserID, int qty)
        {
            if (CartRepository.findCart(CartFactory.createCart(UserID, ShoeID, qty)) != null)
                return ResponseFactory.createResponse(500, "Shoe Already Exists", CartRepository.findCart(CartFactory.createCart(UserID, ShoeID, qty)));
            CartRepository.InsertCart(CartFactory.createCart(UserID, ShoeID, qty));
            return ResponseFactory.createResponse(200, "Success in Inserting a shoe", CartFactory.createCart(UserID, ShoeID, qty));
        }

        public static Cart doUpdate(int userID, int shoeID, int qty, int updateQty)
        {
            //if (CartRepository.findCart(CartFactory.createCart(userID, shoeID, qty)) == null)
            //    return null;
            return CartRepository.UpdateCartByQuantity(userID, shoeID, qty, updateQty);
        }

        public static Response doDelete(int userID)
        {
            if (CartRepository.findCartByUserID(userID) == null)
                return ResponseFactory.createResponse(500, "Cart does not exist", "Fail");
            CartRepository.DeleteCart(CartRepository.findCartByUserID(userID).FirstOrDefault());
            return ResponseFactory.createResponse(200, "Cart Deleted", "Success");
        }

        public static Response doGet()
        {
            if (CartRepository.getAll() == null)
                return ResponseFactory.createResponse(500, "No Shoe Exists", "Fail");
            List<Cart> cartList = CartRepository.getAll();
            return ResponseFactory.createResponse(200, "Success in getting shoe", cartList);
        }

        public static List<Cart> findUsersCarts(int userID)
        {
            if (CartRepository.findCartByUserID(userID) == null)
                return null;
            List<Cart> cartList = CartRepository.findCartByUserID(userID);
            return cartList;
        }

    }
}