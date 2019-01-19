<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminForm.aspx.cs" Inherits="LW_18_2_PSD.Views.Admin.AdminForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Welcome Admin!"></asp:Label> 
        <div style="display:flex; flex-direction:row; flex-wrap:wrap;">
            <div style="margin:20px">
                <asp:Label ID="Label2" runat="server" Text="User Database"></asp:Label>
                <asp:GridView runat="server" ID="userListGrid"></asp:GridView>
            </div>
            <div style="margin:20px">
                <asp:Label ID="Label3" runat="server" Text="Shoe Database"></asp:Label>
                <asp:GridView ID="shoeListGrid" runat="server"></asp:GridView>
                <asp:Label ID="Label4" runat="server" Text="Enter Shoe Name to Be deleted"></asp:Label><br />
                <asp:TextBox ID="shoeName" runat="server"></asp:TextBox><br />
                <asp:Button ID="Button1" runat="server" Text="Delete Shoe" OnClick="Button1_Click"/><br />
                <asp:Label ID="Label5" runat="server" Text=""></asp:Label><br />
            </div>
        </div>
        



            
    </div>
    </form>
</body>
</html>
