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
    /// Summary description for CartController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CartController : System.Web.Services.WebService
    {
        [WebMethod]
        public string getUserCart(int userId)
        {
            return JSONHelper.Serialize(CartHandler.findUsersCarts(userId));
        }

        [WebMethod]
        public string insertCart(int shoeID, int UserID, int qty)
        {
            return JSONHelper.Serialize(CartHandler.doInsert(shoeID, UserID, qty));
        }

        [WebMethod]
        public string updateCart(int userID, int shoeID, int qty, int updateQty)
        {
            return JSONHelper.Serialize(CartHandler.doUpdate(userID, shoeID, qty, updateQty));
        }

        [WebMethod]
        public string deleteCart(int userID)
        {
            return JSONHelper.Serialize(CartHandler.doDelete(userID));
        }



    }
}
