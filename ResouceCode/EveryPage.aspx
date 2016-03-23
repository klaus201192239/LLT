<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EveryPage.aspx.cs" Inherits="EveryPage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Every</title>
    <style type="text/css">
         div#A{ width:1000px; margin:auto}
         div#B{ width:1000px; height:100px;}
         div#B1{ width:200px; height:100px;float:left}
         div#B2{ width:400px;height:100px;float:left; background-color:Blue}
         div#B3{ width:400px;height:100px;float:left; background-color:Green}
         div#C{ width:1000px; height:50px;}
         div#D{ width:1000px; height:180px;}
         div#E{ width:1000px; height:180px;}
         div#F{ width:1000px; height:180px;}
         div#G{ width:1000px; height:180px;}
         div#H{ width:1000px; height:180px;}
         div#I{ width:1000px; height:50px}
         div#I1{ width:500px; height:50px;background-color:Fuchsia; float:left}
         div#I2{ width:500px; height:50px; background-color:Lime; float:left}
         div#J{ width:1000px; height:50px; background-color:Silver}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="A">
        <div id="B">
            <div id="B1"><img src="images/logo.jpg" alt="logo" style="width: 196px; height: 100px; margin-left: 5px"/></div>
            <div id="B2"><center><br/><h1>ROR</h1></center></div>
            <div id="B3"><br/><h1>&nbsp;你的生活&nbsp;你的选择</h1></div>
        </div>
        <div id="C"><br/>&nbsp;您可以制作:</div>
        <div id="D">
            <table>
                <tr>
                    <td style="width:160px; height:180px"><asp:Image ID="p1" runat="server" Visible="false" Width="150px" Height="180px"/></td>
                    <td style="width:140px;height:180px; background-color:Lime"><asp:HyperLink ID="name1" runat="server" NavigateUrl="~/EveryPage.aspx" Visible="false"/></td>
                    <td style="width:700px; height:180px; background-color:Lime"><asp:label ID="m1" runat="server" Visible="false"></asp:label></td>
                </tr>
            </table>        
        </div>
        <div id="E">
            <table>
                <tr>
                    <td style="width:160px; height:180px"><asp:Image ID="p2" runat="server" Visible="false" Width="150px" Height="180px"/></td>
                    <td style="width:140px;height:180px; background-color:Aqua"><asp:HyperLink ID="name2" runat="server" NavigateUrl="~/EveryPage.aspx" Visible="false"/></td>
                    <td style="width:700px; height:180px; background-color:Aqua"><asp:label ID="m2" runat="server" Visible="false"></asp:label></td>
                </tr>
            </table>        
        </div>
        <div id="F">
            <table>
                <tr>
                    <td style="width:160px; height:180px"><asp:Image ID="p3" runat="server" Visible="false" Width="150px" Height="180px"/></td>
                    <td style="width:140px;height:180px; background-color:Red"><asp:HyperLink ID="name3" runat="server" NavigateUrl="~/EveryPage.aspx" Visible="true"/></td>
                    <td style="width:700px; height:180px; background-color:Red"><asp:label ID="m3" runat="server" Visible="true"></asp:label></td>
                </tr>
            </table>        
        </div>
        <div id="G">
            <table>
                <tr>
                    <td style="width:160px; height:180px"><asp:Image ID="p4" runat="server" Visible="false" Width="150px" Height="180px"/></td>
                    <td style="width:140px;height:180px; background-color:Blue"><asp:HyperLink ID="name4" runat="server" NavigateUrl="~/EveryPage.aspx" Visible="true"/></td>
                    <td style="width:700px; height:180px; background-color:Blue"><asp:label ID="m4" runat="server" Visible="true"></asp:label></td>
                </tr>
            </table>        
        </div>
        <div id="H">
            <table>
                <tr>
                    <td style="width:160px; height:180px"><asp:Image ID="p5" runat="server" Visible="false" Width="150px" Height="180px"/></td>
                    <td style="width:140px;height:180px; background-color:Maroon"><asp:HyperLink ID="name5" runat="server" NavigateUrl="~/EveryPage.aspx" Visible="false"/></td>
                    <td style="width:700px; height:180px; background-color:Maroon"><asp:label ID="m5" runat="server" Visible="true"></asp:label></td>
                </tr>
            </table>        
        </div>
        <div id="I"><center>
            <div id="I1"><br/><asp:Button  runat="server" ID="btt" text="灰常6+1 月末砸大奖"/></div>
            <div id="I2"><br/><asp:Button ID="login" runat="server" text="添加新创意"/></div></center>
        </div>
        <div id="J"><br/><center/>保护环境&nbsp;&nbsp;人人有责</div>
    </div>
    </form>
</body>
</html>