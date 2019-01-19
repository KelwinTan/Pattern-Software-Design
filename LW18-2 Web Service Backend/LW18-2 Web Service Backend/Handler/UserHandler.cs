using LW18_2_Web_Service_Backend.Factory;
using LW18_2_Web_Service_Backend.Models;
using LW18_2_Web_Service_Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Handler
{
    public class UserHandler
    {
        public static Response doLogin(string username, string password)
        {
            if(UserRepository.loginUser(username, password)!=null)
                return ResponseFactory.createResponse(201, "Success in Logging in", UserRepository.loginUser(username, password));
            //Kalau gak ketemu
            return ResponseFactory.createResponse(500, "Fail", "Fail in Logging in");
        }

        public static Response doRegister(string username, string password)
        {
            if (UserRepository.loginUser(username, password) != null)
                return ResponseFactory.createResponse(500, "User already Exists", "Error");
            UserRepository.Register(UserFactory.createUser(username, password));
            return ResponseFactory.createResponse(200, "Success in Registering User", UserFactory.createUser(username, password));
        }

        public static List<User> getAll()
        {
            return UserRepository.getAll();
        }

        public static Response userOrder(int shoeId, int userID, int qty)
        {
            Cart newCart = CartFactory.createCart(shoeId, userID, qty);
            CartRepository.InsertCart(newCart);
            return ResponseFactory.createResponse(200, "Success inserting Cart", "Success");
        }

        public static int getUserID(string username)
        {
            return UserRepository.getID(username);
        }

}
}