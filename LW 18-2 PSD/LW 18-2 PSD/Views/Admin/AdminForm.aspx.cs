using LW18_2_Web_Service_Backend.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LW_18_2_PSD.UserService;
using LW_18_2_PSD.ShoesService;
using LW18_2_Web_Service_Backend.Models;

namespace LW_18_2_PSD.Views.Admin
{
    public partial class AdminForm : System.Web.UI.Page
    {
        protected UserControllerSoapClient userService = new UserControllerSoapClient();
        protected ShoesControllerSoapClient shoeService = new ShoesControllerSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            displayUsers();
            displayShoes();
        }

        protected void displayUsers()
        {
            string json = userService.getAll();
            List<Model.User> userList = JSONHelper.Deserializer<List<Model.User>>(json);
            userListGrid.DataSource = userList;
            userListGrid.DataBind();
        }

        protected void displayShoes()
        {
            string json = shoeService.doGet();
            List<Model.Sho> shoeList = JSONHelper.Deserializer<List<Model.Sho>>(json);
            shoeListGrid.DataSource = shoeList;
            shoeListGrid.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string json = shoeService.doDelete(shoeName.Text);
            Response result = JSONHelper.Deserializer<Response>(json);
            Label5.Text = result.statusText;
        }
    }
}