using LW18_2_Web_Service_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LW_18_2_PSD.Views
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void SignUp(object sender, EventArgs e)
        {
            //Response result = UserController.doLogin(userTxt.Text, passTxt.Text);
            //if (result.status != 201)
            //{
            //    Response.Redirect("Login.aspx?msg=" + result.data.ToString());
            //}
            //else
            //{
            //    Session.Timeout = 60;
            //    Response.Redirect("~/Views/Cart/Cart.aspx");
            //}


        }


    }
}