<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LoginForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #00CC00;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            font-size: large;
            width: 145px;
        }
        .auto-style4 {
            width: 145px;
        }
        .auto-style5 {
            font-size: large;
            width: 145px;
            height: 37px;
        }
        .auto-style6 {
            height: 37px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="font-size: x-large; text-align: center">
            Login Form</div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3"><strong>Username</strong></td>
                <td>
                    <asp:TextBox ID="txtuser" runat="server" Width="271px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>Password</strong></td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtpass" runat="server" Width="269px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="119px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
