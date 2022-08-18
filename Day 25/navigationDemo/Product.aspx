<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="navigationDemo.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
    <style type="text/css">
         ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
  background-color: #333;
}

li {
  float: left;
}

li a {
  display: block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
}

/* Change the link color to #111 (black) on hover */
li a:hover {
  background-color: #111;
            }
         </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/Clothes">Clothes</a></li>
                        <li><a runat="server" href="~/Food">Food</a></li>
                        <li><a runat="server" href="~/Electronics">Electronics</a></li>
                         <li><a runat="server" href="~/Utensils">Utensils</a></li>
                    </ul>
                </div>
    </form>
</body>
</html>
