<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Store.aspx.cs" Inherits="LW_18_2_PSD.Views.Store.Store" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <div style="margin-left: 80px">
            <asp:GridView ID="shoeListView" runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="Buy">
                        <ItemTemplate>
                            <asp:Button ID="Button4" runat="server" OnClick ="testing" UseSubmitBehavior ="false" CausesValidation="false" CommandArgument='<%#Eval("ShoeName") %>'/><br />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                
        
            </asp:GridView><br />
            <asp:Label ID="Label4" runat="server" Text="Enter Your Username"></asp:Label><br /> <br />
                <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox><br /><br />
                <asp:Button ID="Button1" runat="server" Text="" OnClick="Button1_Click1" /><br />
                <asp:Button ID="Button5" runat="server" Text="" OnClick="Button5_Click"/><br />
                <asp:Button ID="Button6" runat="server" Text="" OnClick="Button6_Click"/><br />
            
            
            <div style="margin:20px;">
                <a href="../Cart/CartPage.aspx">Cart</a>
            </div>

        </div>


    </div>
    </form>
</body>
</html>
