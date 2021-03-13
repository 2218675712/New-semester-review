<%@ Page Language="C#" CodeBehind="aaaaa.aspx.cs" Inherits="WebApplication5.aaaaa" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="WebApplication5.BLL" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Title</title>
</head>
<body>
<form id="Form" runat="server">
    <%--<div>
        <%
            int[] arr = {1, 2, 3, 4};
            var p = "";
            foreach (var i in arr)
                p += "<p>" + i + "</p>";
        %>
        $1$前台代码拼接案例#1#
        <%= p %>
    </div>--%>
    <div>
        <%
            var data = new V_WenJuan_BLL().GetAllList();
            var dom1 = "<ul>";
            var isrepeat = new ArrayList();
            foreach (DataRow item in data.Tables[0].Rows)
            {
                // isrepeat.Add(item["T_Id"]);
                if (!isrepeat.Contains(item["T_Id"]))
                {
                    isrepeat.Add(item["T_Id"]);
                    dom1 += "<li>" + item["T_Title"] + "</li>";
                }
                dom1 += "<ul>";
                dom1 += "<li>" + item["X_Options"] + "</li>";
                dom1 += "</ul>";
            }
            dom1 += "</ul>";
        %>
        <%= dom1 %>
    </div>
</form>
</body>
</html>
