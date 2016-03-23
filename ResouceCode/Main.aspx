<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main</title>
    <style type="text/css">
        div#A{ width:1000px; margin:auto}
        div#B{ width:1000px; height:100px;}
        div#B1{ width:200px; height:100px;float:left}
        div#B2{ width:400px;height:100px;float:left; background-color:Blue; color:#ffffff; font-size:larger}
        div#B3{ width:400px;height:100px;float:left; background-color:Green}
        div#C{ width:auto; height:350px}
        div#C1{ width:500px;height:350px; float:left}
        div#C2{ width:150px; height:350px; float:left}
        div#C21{ width:150px; height:175px; float:none}
        div#C22{ width:150px; height:175px; float:none}
        div#C3{ width:350px; height:350px; float:left}
        div#D{ width:1000px; height:150px;}
        div#D1{ width:650px; height:150px; float:left; background-color:Gray}
        div#D2{ width:350px; height:150px; float:left}
        div#E{ width:auto; height:50px}
        div#F{ width:auto; height:450px}
        div#G{ width:auto; height:50px}
        div#G1{ width:500px; height:50px;background-color:Fuchsia; float:left}
        div#G2{ width:500px; height:50px; background-color:Lime; float:left}
        div#H{ width:1000px; height:50px; background-color:Silver}
        #abc
        {
            width: 466px;
            height: 40px;
        }
        #bt
        {
            width: 81px;
            height: 31px;
            margin-top: 0px;
        }
        .style1
        {
            height:220px;
            width: 250px;
            border:1px;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
<div id="A" >
    <div id="B">
        <div id="B1"><img src="images/logo.jpg" alt="logo" style="width:196px;height:100px;margin-left:5px"/></div>
        <div id="B2"><center/><br/><h1>L&nbsp;L&nbsp;T</h1></div>
        <div id="B3"><br/><h1>&nbsp;你的生活&nbsp;你的选择</h1></div>
    </div>
    <div id="C">
        <div id="C1"><asp:ImageButton runat="server" ID="ImageButton1" ImageUrl="~/images/11.jpg" Height="345px" Width="486px" OnClick="Imb1"/></div>
        <div id="C2">
            <div id="C21"><asp:ImageButton runat="server" ID="ImageButton2" ImageUrl="~/images/22.jpg" Height="171px" Width="146px" OnClick="Imb2"/></div>
            <div id="C22"><asp:ImageButton runat="server" ID="ImageButton3" ImageUrl="~/images/27232822583.jpg" Height="171px" Width="146px" OnClick="Imb3"/></div>
        </div>
        <div id="C3"><center/><br/><br/>
            <asp:LinkButton ID="LinkButton1" runat="server" Text="蝴蝶书签手工折纸DIY图谱" Font-Size="25px"  OnClick="lkb1"></asp:LinkButton><br/>
            <asp:LinkButton ID="LinkButton2" runat="server" Text="橡皮章制作超酷的人物头像" Font-Size="25px"  OnClick="lkb2"></asp:LinkButton><br/>
            <asp:LinkButton ID="LinkButton3" runat="server" Text="可爱圣诞小雪人" Font-Size="25px"  OnClick="lkb3"></asp:LinkButton><br/>
            <asp:LinkButton ID="LinkButton4" runat="server" Text="简单折纸之阿拉伯数字折纸" Font-Size="25px"  OnClick="lkb4"></asp:LinkButton><br/>
            <asp:LinkButton ID="LinkButton5" runat="server" Text="废瓶盖收集起来制作废纸篓" Font-Size="25px"  OnClick="lkb5"></asp:LinkButton><br/>
            <asp:LinkButton ID="LinkButton6" runat="server" Text="手工咖啡香熏蜡烛图解教程" Font-Size="25px"  OnClick="lkb6"></asp:LinkButton><br/>
            <asp:LinkButton ID="LinkButton7" runat="server" Text="废纸箱手工制作纸板圣诞树" Font-Size="25px"  OnClick="lkb7"></asp:LinkButton><br/>
            <asp:LinkButton ID="LinkButton8" runat="server" Text="塑料瓶制作超萌小猪存钱罐" Font-Size="25px"  OnClick="lkb8"></asp:LinkButton><br/>
            <asp:LinkButton ID="LinkButton9" runat="server" Text="用酒瓶制作的玻璃艺术吊灯" Font-Size="25px"  OnClick="lkb9"></asp:LinkButton><br/>
            <asp:LinkButton ID="LinkButton10" runat="server" Text="用硬纸板装饰台灯 温馨的情调" Font-Size="25px" OnClick="lkb10"></asp:LinkButton><br/>
            <asp:LinkButton ID="LinkButton11" runat="server" Text="废旧光盘制作挂钟 另种艺术美" Font-Size="25px" OnClick="lkb11"></asp:LinkButton><br/>
        </div>
    </div>
    <div id="D">
        <div id="D1">
            <br/><center>你的废弃旧物还没扔吗？快来输入吧！</center>
            <center/><asp:TextBox  ID="input"  runat="server" Visible="true" Width="364px" Height="28px" style="margin-left: 0px"/>
            <asp:Button Id="bt1"  runat="server" text="Search" OnClick="search" Height="28px" style="margin-top: 20px" Width="87px" />
        </div>
        <div id="D2"><center/>
            <asp:LinkButton ID="LinkButton13" runat="server" Text="利用自行车零件制作个性台钟" Font-Size="25px" OnClick="lkb13"></asp:LinkButton><br/>
            <asp:LinkButton ID="LinkButton14" runat="server" Text="磁盘制作iphone平板电脑底座" Font-Size="25px" OnClick="lkb14"></asp:LinkButton><br/> 
            <asp:LinkButton ID="LinkButton15" runat="server" Text="用五金螺丝制作圣诞装饰挂件" Font-Size="25px" OnClick="lkb15"></asp:LinkButton><br/> 
            <asp:LinkButton ID="LinkButton16" runat="server" Text="毛线装饰玻璃瓶制作的五彩花瓶" Font-Size="25px" OnClick="lkb16"></asp:LinkButton><br/> 
            <asp:LinkButton ID="LinkButton17" runat="server" Text="不要的衣服拿来做布兜吊兰盆" Font-Size="25px" OnClick="lkb17"></asp:LinkButton><br/> 
            <asp:LinkButton ID="LinkButton18" runat="server"  ForeColor="Green" Text="厨房田园木质四格餐盘晾干架" Font-Size="25px" OnClick="lkb18"></asp:LinkButton><br/> 
        </div>
    </div>
    <div id="E" style=" font-size:20px"><br/>DIY达人</div>
    <div id="F">
    <table width="1000px">
        <tr style=" width:1000px; height:225px">
            <td class="style1"><asp:ImageButton runat="server" ID="ImageButton4" ImageUrl="~/images/p1.jpg" Height="200px" Width="220px" OnClick="Imb4"/></td>
            <td class="style1"><asp:ImageButton runat="server" ID="ImageButton5" ImageUrl="~/images/p2.jpg" Height="200px" Width="220px" OnClick="Imb5"/></td>
            <td class="style1"><asp:ImageButton runat="server" ID="ImageButton6" ImageUrl="~/images/p3.jpg" Height="200px" Width="220px" OnClick="Imb6"/></td>
            <td class="style1"><asp:ImageButton runat="server" ID="ImageButton7" ImageUrl="~/images/p4.jpg" Height="200px" Width="220px" OnClick="Imb7"/></td>
        </tr>
        <tr>
           <td class="style1"><asp:ImageButton runat="server" ID="ImageButton8" ImageUrl="~/images/p5.jpg" Height="200px" Width="220px" OnClick="Imb8"/></td>
            <td class="style1"><asp:ImageButton runat="server" ID="ImageButton9" ImageUrl="~/images/p6.jpg" Height="200px" Width="220px" OnClick="Imb9"/></td>
            <td class="style1"><asp:ImageButton runat="server" ID="ImageButton10" ImageUrl="~/images/p7.jpg" Height="200px" Width="220px" OnClick="Imb10"/></td>
            <td class="style1" style=" font-size:20px;"><p style=" color:Green">想成为下一位达人吗？</p><p style=" color:Red">那还等什么，快来参与吧！</p></td>
        </tr>
    </table>
    </div>
    <div id="G"><center>
        <div id="G1"><br/><asp:Button ID="Button1" Text="灰常6+1 月末砸大奖" runat="server" OnClick="gift"/></div>
        <div id="G2"><br/><asp:Button ID="Button2" Text="添加新创意" runat="server" OnClick="add"/></div></center>
    </div>
    <div id="H"><br/><center/>保护环境&nbsp;&nbsp;人人有责</div>
</div>
</form>
</body>
</html>
