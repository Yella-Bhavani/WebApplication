<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="WebApplication.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 370px;
        }
        .auto-style3 {
            width: 376px;
        }
        .auto-style4 {
            margin-left: 234px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblusername" runat="server" Text="UserName"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblpwd" runat="server" Text="Password"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtpwd" TextMode="Password" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="lblMsg" runat="server" Width="338px"></asp:TextBox>
            </td>
        </tr>
    </table>
        <div>
            <asp:Button ID="btnreg" runat="server" Text="Register" CssClass="auto-style4" OnClick="btnreg_Click" />
        </div>
    </form>
</body>
</html>
