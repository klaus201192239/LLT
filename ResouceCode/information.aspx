<%@ Page Language="C#" AutoEventWireup="true" CodeFile="information.aspx.cs" Inherits="information" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center"  style="border:solid  1px #dcdcdc;width:60%">
            <tr>
                <td  colspan="4" style="height: 35px; background-color: #f5f5f5; text-align: center">
                    <span style="font-size: 24pt; color: #0099ff; font-family: 楷体_GB2312"><strong>注册个人信息</strong></span></td>
            </tr>
            <tr>
                <td width="15%">
                    用户名：</td>
                <td style="width:30%">
                    <asp:TextBox ID="tname" runat="server"></asp:TextBox></td>
                 <td width="15%">
                     性别：</td>
                <td width="35%">
                    <asp:TextBox ID="tsex" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 77px">
                    年龄：</td>
                <td style="width: 415px">
                    <asp:TextBox ID="tage" runat="server"></asp:TextBox></td>
                 <td>
                     Email：</td>
                <td>
                    <asp:TextBox ID="tmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                 <td>电话号码：</td>
                 <td><asp:TextBox ID="tphone" runat="server" Width="219px" style="margin-left: 0px"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="label" runat="server" Text="请选择图片:" Visible="true"></asp:Label></td>
                <td><asp:FileUpload ID="FileUpload" runat="server" Height="24px" Width="300px"  Visible="true"/></td>
                <td><asp:Button ID="Button" runat="server" Text="上传图片" Visible="true"  OnClick="btncal"/></td>
             </tr>
             <tr style=" height:200px;"><td>必须是真实的个人照哦！</td>
                 <td><asp:Image ID="Image" runat="server" Height="160px" Width="200px" Visible="true"/></td>
             </tr>
            <tr>
                <td align="center" colspan="4">
                    &nbsp;<asp:Button ID="btnupdate" runat="server" Text="注册完成" OnClick="finish" />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:HyperLink ID="Back" runat="server"   Text="返回主页"  Font-Size="15px" NavigateUrl="~/Main.aspx"></asp:HyperLink></td>
            </tr>
        </table>
    </div>                    
    </form>
</body>
</html>
