using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LW_18_2_PSD.UserService;
using LW_18_2_PSD.ShoesService;
using LW_18_2_PSD.CartReference;
using LW18_2_Web_Service_Backend.Utilities;
using LW_18_2_PSD.DTService;
using LW_18_2_PSD.HTService;

namespace LW_18_2_PSD.Views.Cart
{
    public partial class CartPage : System.Web.UI.Page
    {
        protected int userID = 0, shoeId = 0, qty = 0;
        protected UserControllerSoapClient userController = new UserControllerSoapClient();
        protected CartControllerSoapClient cartController = new CartControllerSoapClient();
        protected ShoesControllerSoapClient shoeController = new ShoesControllerSoapClient();
        protected DTControllerSoapClient dtController = new DTControllerSoapClient();
        protected HTControllerSoapClient htController = new HTControllerSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loadCartData()
        {
            userID = Int32.Parse(userController.getUserID(usernameTxt.Text));
            string json = cartController.getUserCart(userID);
            List<Model.Cart> cartList = JSONHelper.Deserializer<List<Model.Cart>>(json);
            cartGrid.DataSource = cartList;
            cartGrid.DataBind();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            loadCartData();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            loadShoeDetail();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            loadShoeDetail();
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            updateCart();
        }

        protected void loadShoeDetail()
        {
            shoeId = Int32.Parse(shoe.Text);
            string json = shoeController.doGetByID(shoeId);
            List<Model.Sho> shoeList = JSONHelper.Deserializer<List<Model.Sho>>(json);
            shoeGrid.DataSource = shoeList;
            shoeGrid.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int headerID = JSONHelper.Deserializer<int>(htController.getLastHT());
            htController.insertHT( headerID, Int32.Parse(userFinish.Text));
            Model.Cart currCart = JSONHelper.Deserializer<Model.Cart>(cartController.getUserCart(Int32.Parse(userFinish.Text)));
            dtController.insertDT(headerID, currCart.Quantity, currCart.ShoeID);
        }

        protected void updateCart()
        {
            userID = Int32.Parse(updateUser.Text);
            shoeId = Int32.Parse(updateShoe.Text);
            qty = Int32.Parse(updateQty.Text);
            string json = cartController.updateCart(userID, shoeId, Int32.Parse(oldQty.Text), qty);
            Model.Cart cart = JSONHelper.Deserializer<Model.Cart>(json);
            List<Model.Cart> cartList = new List<Model.Cart>();
            cartList.Add(cart);
            updateCartGrid.DataSource = cartList;
            updateCartGrid.DataBind();
        }


    }
}