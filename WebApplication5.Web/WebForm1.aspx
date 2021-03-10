<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>调研问卷</title>
 <link rel="stylesheet" href="css/bootstrap.css">

</head>
<body>
<form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="Label1">晚上你一般做什么</asp:Label>
        <asp:CheckBoxList runat="server" ID="CheckBoxList1">
        </asp:CheckBoxList>
        <asp:Button runat="server" ID="Button1" Text="提交" OnClick="Button1_OnClick"/>
        <asp:Button runat="server" ID="Button2" Text="查看结果"/>
<table>
            <asp:Repeater runat="server" ID="Repeater1">
                <HeaderTemplate>
                    <thead>
                    <tr>
    
                    </tr>
                    </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                         <td><%#Eval("Options") %>(<%#Eval("Numbers") %>)</td>
                         <%-- <td><%#Eval("Numbers") %></td> --%>
                         <td>
                                <div style="width: 300px;">
                                    <div class="progress">
                                       <%-- <%#Eval("Numbers") %> --%>
                                        <div class="progress-bar" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100"><%#Eval("Numbers") %></div>
                                    </div>
                                </div>
                        </td>
                      </tr>
                </ItemTemplate>
            </asp:Repeater>
</table>


    </div>
</form>
    <script >
    /**
    * 转百分数
* @param point 传入的数值
* @returns {string} 转换后的结果
*/
    function toPercent(point) {
        var str = Number(point * 100).toFixed(2);
        str += "%";
        return str;
    }
    // 获取所有投票的人数
    let sum = 0;
    let NumberCount = document.querySelectorAll('.progress-bar')
    NumberCount.forEach((i) => {
        sum += parseInt(i.innerHTML)
    })
    // 遍历,计算每个所占的份数,并绑定到页面dom上
    NumberCount.forEach((i) => {
        let value = (parseInt(i.innerHTML) / sum);
        i.innerHTML = toPercent(value)
        console.log(value)
        i.setAttribute("aria-valuenow", value * 100)
        i.style.width = value * 100 + "%"
    })
    </script>
<script src="js/bootstrap.js"></script>
</body>
</html>