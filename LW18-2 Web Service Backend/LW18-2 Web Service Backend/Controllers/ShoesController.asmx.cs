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
    /// Summary description for ShoesController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ShoesController : System.Web.Services.WebService
    {

        [WebMethod]
        public string doInsert(string shoeName, int price)
        {
            return JSONHelper.Serialize(ShoeHandler.doInsert(shoeName, price));
        }
        [WebMethod]
        public string doUpdate(string oldShoeName, int oldPrice, string updateName, int updatePrice)
        {
            return JSONHelper.Serialize(ShoeHandler.doUpdate(oldShoeName, oldPrice, updateName, updatePrice));
        }
        [WebMethod]
        public string doDelete(string shoeName)
        {
            return JSONHelper.Serialize(ShoeHandler.doDelete(shoeName));
        }
        [WebMethod]
        public string doGet()
        {
            return JSONHelper.Serialize(ShoeHandler.doGet());
        }

        [WebMethod]
        public string doGetByID(int id)
        {
            return JSONHelper.Serialize(ShoeHandler.getByID(id));
        }



    }
}
