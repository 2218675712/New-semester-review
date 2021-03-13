<%@ Page Language="C#" CodeBehind="aaaaa.aspx.cs" Inherits="WebApplication5.aaaaa" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Title</title>
</head>
<body>
<form id="Form" runat="server">
    <div>
        <%
            int[] arr = {1, 2, 3, 4};
            var p = "";
            foreach (var i in arr)
                p += "<p>" + i + "</p>";
        %>
        <%--前台代码拼接案例--%>
        <%= p %>
    </div>
</form>
</body>
</html>
