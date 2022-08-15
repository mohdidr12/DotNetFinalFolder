<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="WebApplicationHelloWorld.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
           
        </div>
        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" OnTextChanged="TextBox1_TextChanged" Width="204px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:ListBox ID="IstLocation" runat="server">
            <asp:ListItem>Mumbai</asp:ListItem>
            <asp:ListItem>Bangalore</asp:ListItem>
            <asp:ListItem>Hyderabad</asp:ListItem>
        </asp:ListBox>
        <p>
            <asp:RadioButton ID="rdMale" runat="server" Text="Male" />
        </p>
        <asp:RadioButton ID="rdFemale" runat="server" Text="Female" />
        <br />
        <p>
            <asp:CheckBox ID="chkC" runat="server" Text="C#" />
        </p>
        <asp:CheckBox ID="chkASP" runat="server" Text="ASP.NET" />
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
