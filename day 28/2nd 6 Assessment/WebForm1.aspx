<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2nd_6_Assessment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem>Bombay</asp:ListItem>
                <asp:ListItem>Goa</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            Choose&nbsp; City<br />
            <br />
            </div>
        <asp:ListBox ID="ListBox2" runat="server">
            <asp:ListItem>Maharahtra</asp:ListItem>
            <asp:ListItem>Gujarat</asp:ListItem>
        </asp:ListBox>
        <br />
        <p>
            Choose State</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Merge" />
        </p>
    </form>
</body>
</html>
