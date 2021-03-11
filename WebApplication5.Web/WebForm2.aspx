<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication5.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>管理员提交题目</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <style >
       .main{
       text-align:center;
       margin-top: 100px;
       }
       .radio{
       width:100% ;
       text-align:center;
       }
   </style>
</head>
<body>
<form id="form1" runat="server">
    <div class="main">
        <p>
            <label>题目标题:</label>
            <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
        </p>
        <p>
            <label>单/多选:</label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" class="radio">
                <asp:ListItem Value="0">单选</asp:ListItem>
                <asp:ListItem Value="1">多选</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click"/>
    </div>
</form>
<script src="js/bootstrap.js"></script>
</body>
</html>