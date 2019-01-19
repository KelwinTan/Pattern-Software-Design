using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LW_18_2_PSD.ShoesService;
using LW18_2_Web_Service_Backend.Utilities;
using LW_18_2_PSD.UserService;

namespace LW_18_2_PSD.Views.Store
{
    public partial class Store : System.Web.UI.Page
    {
        protected ShoesControllerSoapClient shoeControl = new ShoesControllerSoapClient();
        protected UserControllerSoapClient userService = new UserControllerSoapClient();

        protected int buyAJ32 = 0;
        protected int buyAM90 = 0;
        protected int buyAJ12 = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            displayShoe();
            //List<Model.Sho> shoeList = JSONHelper.Deserializer<List<Model.Sho>>(shoeControl.doGet());
            //Button1.Text = "Buy " + shoeList.ElementAt(0).ShoeName;
            //Button5.Text = "Buy " + shoeList.ElementAt(1).ShoeName;
            //Button6.Text = "Buy " + shoeList.ElementAt(2).ShoeName;
        }

        protected void displayShoe()
        {
            string json = shoeControl.doGet();
            List<Model.Sho> shoeList = JSONHelper.Deserializer<List<Model.Sho>>(json);
            shoeListView.DataSource = shoeList;
            shoeListView.DataBind();
        }
        protected void testing(object sender,EventArgs e)
        {
            Button b = (Button)sender;
            string a = b.CommandArgument;
            usernameTxt.Text = a;
        }
        //Finish Transaction
        protected void Button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string a = b.CommandArgument;
            usernameTxt.Text = a;
            int userID = Int32.Parse(userService.getUserID(usernameTxt.Text));
            if (buyAJ12 != 0)
                userService.doOrder(7, userID, buyAJ12);
            if (buyAJ32 != 0)
                userService.doOrder(5, userID, buyAJ32);
            if (buyAM90 != 0)
                userService.doOrder(6, userID, buyAM90);
            Console.WriteLine("Thank You For Your Purchase");
        }
        

        protected void Button1_Click1(object sender, EventArgs e)
        {
            buyAJ32 += 1;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            buyAM90 += 1;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            buyAJ12 += 1;
        }
    }
}