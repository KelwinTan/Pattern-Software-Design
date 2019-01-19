using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using LW18_2_Web_Service_Backend;
using LW_18_2_PSD.UserService;

namespace LW_18_2_PSD.Controllers
{
    /// <summary>
    /// Summary description for UserServicesWebView
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserServicesWebView : System.Web.Services.WebService
    {
        protected UserControllerSoapClient userService = new UserControllerSoapClient();

        [WebMethod]
        public void displayUsers()
        {
            string json = userService.getAll();
            //List<@Model1.>
        }



    }
}
