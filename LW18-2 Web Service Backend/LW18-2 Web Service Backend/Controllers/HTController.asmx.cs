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
    /// Summary description for HTController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HTController : System.Web.Services.WebService
    {

        [WebMethod]
        public string getAllHT()
        {
            return JSONHelper.Serialize(HTHandler.getAllHT());
        }
        [WebMethod]
        public string getHTByID(int userID)
        {
            return JSONHelper.Serialize(HTHandler.getHT(userID));
        }
        [WebMethod]
        public string insertHT(int headerID, int userID)
        {
            return JSONHelper.Serialize(HTHandler.doInsert(headerID, userID));
        }

        [WebMethod]
        public string getLastHT()
        {
            return JSONHelper.Serialize(HTHandler.getLastID());
        }

        [WebMethod]
        public string getALLHTLIST()
        {
            return JSONHelper.Serialize(HTHandler.getLISTHT());
        }


    }
}
