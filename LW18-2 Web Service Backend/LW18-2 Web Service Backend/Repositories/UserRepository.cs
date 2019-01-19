using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Diagnostics;

using LW18_2_Web_Service_Backend.Utilities;
using LW18_2_Web_Service_Backend.Models;
using LW18_2_Web_Service_Backend.Factory;

namespace LW18_2_Web_Service_Backend.Repositories
{
    public class UserRepository
    {
        private static Database1Entities DB = DatabaseSingleton.GetSingletonInstance();

        //Get All Users
        public static List<User> getAll()
        {
            return DB.Users.ToList<User>();
        }
        
        //Get Users by Limit
        public static List<User> getUserByLimit(int limit)
        {
            return DB.Users.Take(limit).ToList<User>();
        }

        //Get User By Username
        public static User loginUser(string username, string password)
        {
            try{
                return DB.Users.Where(user => user.Username == username && user.Password == password).FirstOrDefault();
            }
            catch (Exception){
                return null;
            }
        }

        //Register new User
        public static void Register(User newUser)
        {
            DB.Users.Add(newUser);
            DB.SaveChanges();
        }

        //Get latest ID
        public static int getLatestID()
        {
            return DB.Users.Last().UserID;
        }

        public static int getID(string username)
        {
            return DB.Users.Where(x => x.Username == username).FirstOrDefault().UserID;
        }

    }
}