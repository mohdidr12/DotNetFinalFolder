<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Demo5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Demo5.DataClasses1DataContext" EntityTypeName="" Select="new (EmployeeID, LastName, FirstName, City, PostalCode, Country)" TableName="Employees">
            </asp:LinqDataSource>
        </div>
    </form>
</body>
</html>
