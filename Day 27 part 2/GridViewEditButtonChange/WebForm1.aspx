<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GridView_Update.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit"   
  
OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" DataSourceID="SqlDataSource1">  
            <Columns>  
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            </Columns>  
            <%--<HeaderStyle BackColor="#663300" ForeColor="#ffffff"/>--%>  
            <%--<RowStyle BackColor="#e7ceb6"/>--%>  
        </asp:GridView>  
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:demo_1ConnectionString %>" SelectCommand="SELECT [ID], [Name], [City] FROM [tbl_Employee]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
