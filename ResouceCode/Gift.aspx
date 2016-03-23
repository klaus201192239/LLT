<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Gift.aspx.cs" Inherits="Gift" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>gift</title>
    <style type="text/css">
        div#A{ width:1000px; margin:auto}
        div#B{ width:1000px; height:100px;}
        div#B1{ width:200px; height:100px;float:left}
        div#B2{ width:400px;height:100px;float:left; background-color:Blue}
        div#B3{ width:400px;height:100px;float:left; background-color:Green}
        div#D{ width:1000px; height:50px; background-color:Silver}
        .style{ width:500px; height:200px; float:left}
        .style1{ width:1000px; height:200px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="A">
        <div id="B">
            <div id="B1"><img src="images/logo.jpg" alt="logo" style="width: 196px; height: 100px; margin-left: 5px"/></div>
            <div id="B2"><center/><br/><h1>ROR</h1></div>
            <div id="B3"><br/><h1>&nbsp;你的生活&nbsp;你的选择</h1></div>
        </div>
        <div class="style1">
            <div class="style">
                <br/><br/><br/><br/><asp:Label ID="Label1" runat="server" Visible="false" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                <asp:ImageButton ID="Image1" runat="server" Visible="true" ImageUrl="~/images/a.jpg" Width="400px" Height="180px" OnClick="function1"/>
                <asp:Image ID="Ima1" runat="server" Visible="false" ImageUrl="~/images/a.jpg" Width="400px" Height="180px"/></div>
            <div class="style">
                <br/><br/><br/><br/><asp:Label ID="Label2" runat="server" Visible="false" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                <asp:ImageButton ID="Image2" runat="server" Visible="true" ImageUrl="~/images/b.jpg" Width="400px" Height="180px" OnClick="function2"/>
                <asp:Image ID="Ima2" runat="server" Visible="false" ImageUrl="~/images/b.jpg" Width="400px" Height="180px"/></div>
        </div>
        <div class="style1">
            <div class="style">
               <br/><br/><br/><br/><asp:Label ID="Label3" runat="server" Visible="false" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                <asp:ImageButton ID="Image3" runat="server" Visible="true" ImageUrl="~/images/f.jpg" Width="400px" Height="180px" OnClick="function3"/>
                <asp:Image ID="Ima3" runat="server" Visible="false" ImageUrl="~/images/f.jpg" Width="400px" Height="180px"/></div>
            <div class="style">
                <asp:Image ID="Image4" runat="server" Visible="true" ImageUrl="~/images/6.jpg" Width="400px" Height="180px"/></div>
        </div>
        <div class="style1">
            <div class="style">
                <br/><br/><br/><br/><asp:Label ID="Label5" runat="server" Visible="false" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                <asp:ImageButton ID="Image5" runat="server" Visible="true" ImageUrl="~/images/d.jpg" Width="400px" Height="180px" OnClick="function5"/>
                <asp:Image ID="Ima5" runat="server" Visible="false" ImageUrl="~/images/d.jpg" Width="400px" Height="180px"/></div>
            <div class="style">
                <br/><br/><br/><br/><asp:Label ID="Label6" runat="server" Visible="false" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                <asp:ImageButton ID="Image6" runat="server" Visible="true" ImageUrl="~/images/e.jpg" Width="400px" Height="180px" OnClick="function6"/>
                <asp:Image ID="Ima6" runat="server" Visible="false" ImageUrl="~/images/e.jpg" Width="400px" Height="180px"/></div>
        </div>
        <div class="style1">
            <div class="style">
                <br/><br/><br/><br/><asp:Label ID="Label7" runat="server" Visible="false" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                <asp:ImageButton ID="Image7" runat="server" Visible="true" ImageUrl="~/images/g.jpg" Width="400px" Height="180px" OnClick="function7"/>
                <asp:Image ID="Ima7" runat="server" Visible="false" ImageUrl="~/images/g.jpg" Width="400px" Height="180px"/></div>
            <div class="style">
                <br/><br/><br/><br/><asp:Label ID="Label8" runat="server" Visible="false" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                <asp:ImageButton ID="Image8" runat="server" Visible="true" ImageUrl="~/images/c.jpg" Width="400px" Height="180px" OnClick="function8"/>
                <asp:Image ID="Ima8" runat="server" Visible="false" ImageUrl="~/images/c.jpg" Width="400px" Height="180px"/></div>
        </div><br/><br/><br/>
        <div id="D"><br/><center/>保护环境&nbsp;&nbsp;人人有责
        <asp:HyperLink ID="Back" runat="server"   Text="返回主页"  Font-Size="15px" NavigateUrl="~/Main.aspx"></asp:HyperLink></div>
    </div>
    </form>
</body>
</html>