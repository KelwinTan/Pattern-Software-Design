using LW18_2_Web_Service_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Factory
{
    public class ResponseFactory
    {
        public static Response createResponse(int status, string statusText, object obj)
        {
            return new Response(status, statusText, obj);
        }

    }
}