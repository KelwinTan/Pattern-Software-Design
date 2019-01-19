<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="LW_18_2_PSD.Views.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link href="Style.css" rel="stylesheet" />
    <style>

        @import url('https://fonts.googleapis.com/family=Bitter|Create+Round|Pacifico');

    </style> 
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <div class="container">
                <div class="inner1">
                    <a href="Login.aspx">Login</a>
                    
                    <br />
                </div>

                <div class="inner2">
                    <h3>Sign Up</h3>
                    <asp:TextBox ID="txturname" placeholder="Username" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtemail" placeholder="E-mail" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtpasswd" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtcops" placeholder="Retype Password" TextMode="Password" runat="server"></asp:TextBox>

                    <asp:Button ID="signUpBtn" CssClass="btn" runat="server" Text="Sign Me Up" OnClick="SignUp"/>
                </div>
            </div>
        </section>
    </form>
</body>
</html>
