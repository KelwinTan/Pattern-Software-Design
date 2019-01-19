<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LW_18_2_PSD.Views.User.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Username">
        </asp:Label>
        <asp:TextBox ID="userTxt" runat="server"></asp:TextBox>

        <asp:Label ID="Label2" runat="server" Text="Password">
        </asp:Label>
        <asp:TextBox ID="passTxt" runat="server" type="password"></asp:TextBox>


        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="LoginBtn"/>
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
