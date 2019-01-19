using LW_18_2_PSD.Dataset;
using LW_18_2_PSD.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LW_18_2_PSD.DTService;
using LW_18_2_PSD.HTService;
using LW18_2_Web_Service_Backend.Utilities;
using System.Web.Script.Serialization;

namespace LW_18_2_PSD.Views.ReportView
{
    public partial class ReportViewForm : System.Web.UI.Page
    {
        protected HTControllerSoapClient htController = new HTControllerSoapClient();
        protected DTControllerSoapClient dtController = new DTControllerSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportTransactions rep = new ReportTransactions();
            rep.SetDataSource(getDATA());
        }

        protected DetailTransaction getDATA()
        {
            DetailTransaction apa = new DetailTransaction();
            var detailTran = apa._DetailTransaction;
            var headerTran = apa.HeaderTransaction;
            List<Model.Header_Transaction> htList = new JavaScriptSerializer().Deserialize<List<Model.Header_Transaction>>(htController.getALLHTLIST());
            foreach (Model.Header_Transaction obj in htList)
            {
                var tempHeader =headerTran.NewRow();
                tempHeader["UserName"] = obj.User.Username; //TODO
                tempHeader["HeaderTransactionID"] = obj.HeaderTransactionID; //TODO
                headerTran.Rows.Add(tempHeader);
                List<Model.Detail_Transaction> dtList = new JavaScriptSerializer().Deserialize<List<Model.Detail_Transaction>>(dtController.GetDTBYHEADERID(obj.HeaderTransactionID));
                foreach (Model.Detail_Transaction obj2 in dtList)
                {
                    var dtRows = detailTran.NewRow();
                    dtRows["HeaderTransactionID"] = obj2.HeaderTransactionID;
                    dtRows["ShoeName"] = obj2.Sho.ShoeName;
                    dtRows["Quantity"] = obj2.Quantity;
                    detailTran.Rows.Add(dtRows);
                }
            }
            return apa;
        }



    }
}