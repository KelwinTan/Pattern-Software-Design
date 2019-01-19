using LW18_2_Web_Service_Backend.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LW_18_2_PSD.Constant;
using LW_18_2_PSD.UserService;
using LW18_2_Web_Service_Backend.Utilities;

namespace LW_18_2_PSD.Views.User
{
    public partial class Login : System.Web.UI.Page
    {
        protected UserControllerSoapClient userController = new UserControllerSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Key.USER_SESSION] != null)
            {
                Response.Redirect("Cart.aspx");
            }

        }

        protected void LoginBtn(object sender, EventArgs e)
        {
            string json = userController.doLogin(userTxt.Text, passTxt.Text);
            Response result = JSONHelper.Deserializer<Response>(json);
            if (userTxt.Text.Equals("admin") && passTxt.Text.Equals("admin"))
            {
                Response.Redirect("~/Views/Admin/AdminForm.aspx");
            }
            else if (result.status != 201)
            {
                Response.Redirect("Login.aspx?msg="+result.data.ToString());
            }
            else
            {
                Session.Timeout = 60;
                Response.Redirect("~/Views/Store/Store.aspx");
            }

        }
    }
}