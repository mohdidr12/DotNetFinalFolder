<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NavDemo.aspx.cs" Inherits="WebApplication2.NavDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
         ul {
          list-style-type: none;
          margin: 0;
           padding: 0;
            }
         li {
         display: inline;
             }
         </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                 <li><a href="default.asp">Home</a></li>
                 <li><a href="news.asp">News</a></li>
                 <li><a href="contact.asp">Contact</a></li>
                <li><a href="about.asp">About</a></li>
                </ul>
        </div>
    </form>
</body>
</html>
