using LW18_2_Web_Service_Backend.Handler;
using LW18_2_Web_Service_Backend.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LW18_2_Web_Service_Backend.Controllers
{
    /// <summary>
    /// Summary description for UserController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserController : System.Web.Services.WebService
    {

        [WebMethod]
        public string doLogin(string username, string password)
        {
            return JSONHelper.Serialize(UserHandler.doLogin(username, password));
        }

        [WebMethod]
        public string doRegister(string username, string password)
        {
            return JSONHelper.Serialize(UserHandler.doRegister(username, password));
        }

        [WebMethod]
        public string getAll()
        {
            return JSONHelper.Serialize(UserHandler.getAll());  
        }

        [WebMethod]
        public string getUserID(string username)
        {
            return JSONHelper.Serialize(UserHandler.getUserID(username));
        }

    }
}
