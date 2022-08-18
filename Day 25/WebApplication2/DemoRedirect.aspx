<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoRedirect.aspx.cs" Inherits="WebApplication2.DemoRedirect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: small;
        }
        .auto-style3 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>
            <br class="auto-style1" />
            </strong><span class="auto-style1"><strong>Welcome to Server Objects</strong></span></div>
        <p>
            <span class="auto-style3">Redirect within Same Application </span>&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Response.Redirect" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Server.Transfer" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <span class="auto-style3">Redirect to Outside Application </span><span class="auto-style2">&nbsp; </span>&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Response.Redirect" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Server.Transfer" />
        </p>
    </form>
</body>
</html>
