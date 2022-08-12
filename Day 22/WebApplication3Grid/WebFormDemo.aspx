<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebFormDemo.aspx.vb" Inherits="WebApplication3Grid.WebFormDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Emp_id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Emp_id" HeaderText="Emp_id" ReadOnly="True" SortExpression="Emp_id" />
                <asp:BoundField DataField="P_id" HeaderText="P_id" SortExpression="P_id" />
                <asp:BoundField DataField="Emp_Name" HeaderText="Emp_Name" SortExpression="Emp_Name" />
                <asp:BoundField DataField="Tech_familiar" HeaderText="Tech_familiar" SortExpression="Tech_familiar" />
                <asp:BoundField DataField="Exp_Y" HeaderText="Exp_Y" SortExpression="Exp_Y" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:demo_1ConnectionString %>" SelectCommand="SELECT * FROM [Emp1_Table]"></asp:SqlDataSource>
    </form>
</body>
</html>
