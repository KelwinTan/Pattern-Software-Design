using LW18_2_Web_Service_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Factory
{
    public class UserFactory
    {
        public static User createUser(string username, string password)
        {
             return new User() { Username = username, Password = password };
        }
        
    }
}