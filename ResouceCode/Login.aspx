<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" style=" border:solid 1px #dcdcdc">
            <tr>
                <td colspan="2" style="height: 35px; background-color: #f5f5f5; text-align: center">
                    <span style="font-size: 24pt; color: #0099ff; font-family: 楷体_GB2312"><strong>用户登录</strong></span></td>
            </tr>
            <tr>
                <td style="width:40%; text-align: right">
                    用户名：</td>
                <td>
                    <asp:TextBox ID="tname" runat="server"></asp:TextBox></td>
            </tr>
            <tr style="font-size: 12pt; color: #000000">
                <td style="width: 345px; text-align: right">
                    密码：</td>
                <td>
                    <asp:TextBox ID="tpass" runat="server" TextMode="Password" Width="148px"></asp:TextBox></td>
            </tr>
            <tr style="font-size: 12pt">
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="btnlog" runat="server" OnClick="btnlog_Click" Text="登录" />
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
                    <asp:HyperLink ID="Back" runat="server"   Text="返回主页"  Font-Size="15px" NavigateUrl="~/Main.aspx"></asp:HyperLink>
                    </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
