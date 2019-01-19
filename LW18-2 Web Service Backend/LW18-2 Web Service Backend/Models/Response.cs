using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Models
{
    public class Response
    {
        public int status { get; set; }
        public string statusText { get; set; }
        public object data { get; set; }
        public Response()
        {

        }
        public Response(int status, string statustext, object obj)
        {
            this.status = status;
            this.statusText = statustext;
            this.data = obj;
        }
    }
}