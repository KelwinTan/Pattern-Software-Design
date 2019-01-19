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
    /// Summary description for DTController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DTController : System.Web.Services.WebService
    {

        [WebMethod]
        public string getAllDT()
        {
            return JSONHelper.Serialize(DTHandler.getALLDT());
        }
        [WebMethod]
        public string getUserDT(int headerID)
        {
            return JSONHelper.Serialize(DTHandler.getDTbyID(headerID));
        }
        [WebMethod]
        public string insertDT(int headerID, int qty, int shoeID)
        {
            return JSONHelper.Serialize(DTHandler.doInsert(headerID, qty, shoeID));
        }

        [WebMethod]
        public string GetDTBYHEADERID(int headerID)
        {
            return JSONHelper.Serialize(DTHandler.getallDTList(headerID));
        }


    }
}
