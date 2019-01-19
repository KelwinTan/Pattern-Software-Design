<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="LW_18_2_PSD.Views.Cart.CartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Welcome to your cart page"></asp:Label>
        <div style="margin:20px;">
            <asp:Label ID="Label2" runat="server" Text="Get Your Cart"></asp:Label> <br />
                <asp:Label ID="Label3" runat="server" Text="Enter Your Username"></asp:Label> <br />
                    <asp:TextBox ID="usernameTxt" runat="server" ></asp:TextBox><br/>
                    <asp:Button ID="Button1" runat="server" Text="Enter Username" OnClick="Button1_Click" />
            <asp:GridView ID="cartGrid" runat="server"></asp:GridView>
        </div>
        <div style="margin:20px;">
            <asp:Label ID="Label4" runat="server" Text="Enter Shoe ID"></asp:Label> <br />
            <asp:TextBox ID="shoe" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button2" runat="server" Text="Enter Shoe ID" OnClick="Button2_Click"/>
            <asp:GridView ID="shoeGrid" runat="server"></asp:GridView>
        </div>
        <div style="margin:20px;">
            <asp:Label ID="Label5" runat="server" Text="Update Cart"></asp:Label> <br />
            <asp:Label ID="Label6" runat="server" Text="Enter User ID"></asp:Label> <br />
            <asp:TextBox ID="updateUser" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label7" runat="server" Text="Enter Shoe ID"></asp:Label> <br />
            <asp:TextBox ID="updateShoe" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Label8" runat="server" Text="Enter old Quantity"></asp:Label> <br />
            <asp:TextBox ID="oldQty" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label9" runat="server" Text="Enter New Quantity to be updated"></asp:Label><br />
            <asp:TextBox ID="updateQty" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button3" runat="server" Text="Update Cart" OnClick="Button3_Click1"/><br />
            <asp:GridView ID="updateCartGrid" runat="server"></asp:GridView>
        </div>
        <div style="margin:20px;">
            <asp:Label ID="Label10" runat="server" Text="Finish Your Transaction"></asp:Label> <br />
            <asp:Label ID="Label11" runat="server" Text="UserID"></asp:Label>
            <asp:TextBox ID="userFinish" runat="server"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="Finish transaction" OnClick="Button4_Click" />
        </div>


    </div>
    </form>
</body>
</html>
