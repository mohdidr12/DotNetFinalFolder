<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageEvent.aspx.cs" Inherits="WebApplication2.PageEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Controls being monitored for change events</strong>
        <p>
            <asp:TextBox ID="txt" runat="server" AutoPostBack="True" OnTextChanged="CtrlChanged"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chk" runat="server" Text="chk" AutoPostBack="True" OnCheckedChanged="CtrlChanged" />
        <p>
            <asp:RadioButton ID="opt1" runat="server" AutoPostBack="True" GroupName="Sample" OnCheckedChanged="CtrlChanged" Text="[opt1]" />
&nbsp;&nbsp;
            <asp:RadioButton ID="opt2" runat="server" Text="[opt2]" GroupName="Sample" OnCheckedChanged="CtrlChanged" />
        </p>
        <p class="auto-style2">
            <strong>List of events:</strong></p>
        <asp:ListBox ID="ListBox1" runat="server" Height="122px" Width="425px"></asp:ListBox>
            </div>
    </form>
</body>
</html>
