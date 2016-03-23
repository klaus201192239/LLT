<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add</title>
    <style type="text/css">
         div#A{ width:1000px; margin:auto}
         div#B{ width:1000px; height:100px;}
         div#B1{ width:200px; height:100px;float:left}
         div#B2{ width:400px;height:100px;float:left; background-color:Blue}
         div#B3{ width:400px;height:100px;float:left; background-color:Green}
         div#C{ width:1000px; height:200px;}
         div#C1{ height:200px; width:500px; float:left}
         div#C2{ width:400px; height:200px; float:left}
         div#D{ width:1000px; height:50px}
         div#D1{ width:500px; height:50px;background-color:Fuchsia; float:left}
         div#D2{ width:500px; height:50px; background-color:Lime; float:left}
         div#E{ width:1000px; height:50px; background-color:Silver}
         td{ height:40px; width:150px;}
         .style{ height:200px; width:400px}
         .style1{ height:200px; width:600px;}
         .omal{}
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
        <div id="C">
            <div id="C1">
            <table width="500px">
                <tr>
                    <td>用户名<asp:TextBox ID="username" runat="server" Width="180px" Height="20px"></asp:TextBox></td>
                    <td>宝贝名<asp:TextBox ID="thname" runat="server" Width="180px" Height="20px"></asp:TextBox></td>
                </tr>
                <tr>
                   <td>材料一<asp:TextBox ID="m1" runat="server" Width="180px" Height="20px"></asp:TextBox></td>
                   <td>材料二<asp:TextBox ID="m2" runat="server" Width="180px" Height="20px"></asp:TextBox></td>
                </tr>
                <tr>
                   <td>材料三<asp:TextBox ID="m3" runat="server" Width="180px" Height="20px"></asp:TextBox></td>
                   <td>材料四<asp:TextBox ID="m4" runat="server" Width="180px" Height="20px"></asp:TextBox></td>
                </tr>
                <tr>
                  <td>材料五<asp:TextBox ID="m5" runat="server" Width="180px" Height="20px"></asp:TextBox></td>
                   <td>材料六<asp:TextBox ID="m6" runat="server" Width="180px" Height="20px"></asp:TextBox></td>
                </tr>
                <tr>
                   <td>材料七<asp:TextBox ID="m7" runat="server" Width="180px" Height="20px"></asp:TextBox></td>
                   <td>材料八<asp:TextBox ID="m8" runat="server" Width="180px" Height="20px"></asp:TextBox></td>
                </tr>
            </table>
            </div>
            <div id="C2">
                <p>请选择图片：<asp:FileUpload ID="uploadimage" runat="server" Height="24px" />
                <asp:Button ID="btnUpimage" runat="server" Text="上传图片" OnClick="Show"/></p>
                <p><asp:Image ID="img" runat="server" Height="160px" Width="200px" Visible="true" />
                你的宝贝好漂亮哦！</p>
            </div>
        </div>
        <table>
            <tr><td class="omal">方法步骤</td></tr>
            <tr>
                <td class="style"><asp:Label ID="l1" runat="server" Text="步骤一" Visible="true"></asp:Label>
                <asp:TextBox ID="b1" runat="server"  Visible="true" Height="165px" Width="400px"></asp:TextBox></td>
                <td class="style1"><asp:Label ID="c1" runat="server" Text="请选择图片:" Visible="true"></asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server"  Visible="true" Height="24px" Width="300px" />
                <asp:Button ID="Button1" runat="server" Text="上传图片" Visible="true" OnClick="Show1"/>
                <asp:Image ID="Image1" runat="server" Height="160px" Width="200px" Visible="true"/>
                &nbsp;&nbsp;<asp:Button runat="server" ID="n1" Width="73px" Text="下一步" Visible="true" OnClick="next2"/>
                &nbsp;&nbsp;<asp:Button runat="server" ID="f1" Width="118px" Text="所有步骤已完成" Visible="true" OnClick="finish"/>
                </td>
            </tr>
            <tr>
                <td class="style"><asp:Label ID="l2" runat="server" Text="步骤二" Visible="false"></asp:Label>
                <asp:TextBox ID="b2" runat="server" Visible="false" Height="165px" Width="400px"></asp:TextBox>
                <asp:Image ID="rp1" runat="server" Height="160px" Width="200px" Visible="true" ImageUrl="~/images/3B92655925.jpg"/></td>
                <td class="style1"><asp:Label ID="c2" runat="server" Text="请选择图片:" Visible="false"></asp:Label>
                <asp:FileUpload ID="FileUpload2" runat="server" Height="24px" Width="300px" Visible="false"/>
                <asp:Button ID="Button2" runat="server" Text="上传图片" Visible="false" OnClick="Show2"/>
                <asp:Image ID="Image2" runat="server" Height="160px" Width="200px" Visible="false"/>
                &nbsp;&nbsp;<asp:Button runat="server" ID="n2" Visible="false" Width="73px" Text="下一步" OnClick="next3"/>
                &nbsp;&nbsp;<asp:Button runat="server" ID="f2" Visible="false" Width="118px" Text="所有步骤已完成" OnClick="finish"/>
                <asp:Image ID="rp2" runat="server" Height="160px" Width="200px" Visible="true" ImageUrl="~/images/logo.jpg"/></td>
            </tr>
             <tr>
                <td class="style"><asp:Label ID="l3" runat="server" Text="步骤三" Visible="false"></asp:Label>
                <asp:TextBox ID="b3" runat="server" Visible="false" Height="165px" Width="400px"></asp:TextBox>
                <asp:Image ID="rp3" runat="server" Height="160px" Width="200px" Visible="true" ImageUrl="~/images/3B92655925.jpg"/></td>
                <td class="style1"><asp:Label ID="c3" runat="server" Text="请选择图片:" Visible="false"></asp:Label>
                <asp:FileUpload ID="FileUpload3" runat="server" Height="24px" Width="300px"  Visible="false"/>
                <asp:Button ID="Button3" runat="server" Text="上传图片" Visible="false" OnClick="Show3"/>
                <asp:Image ID="Image3" runat="server" Height="160px" Width="200px" Visible="false"/>
                &nbsp;&nbsp;<asp:Button runat="server" ID="n3" Visible="false" Width="73px" Text="下一步" OnClick="next4"/>
                &nbsp;&nbsp;<asp:Button runat="server" ID="f3" Visible="false" Width="118px" Text="所有步骤已完成" OnClick="finish"/>
                <asp:Image ID="rp4" runat="server" Height="160px" Width="200px" Visible="true" ImageUrl="~/images/logo.jpg"/></td>
            </tr>
             <tr>
                <td class="style"><asp:Label ID="l4" runat="server" Text="步骤四" Visible="false"></asp:Label>
                <asp:TextBox ID="b4" runat="server" Visible="false" Height="165px" Width="400px"></asp:TextBox>
                <asp:Image ID="rp5" runat="server" Height="160px" Width="200px" Visible="true" ImageUrl="~/images/3B92655925.jpg" /></td>
                <td class="style1"><asp:Label ID="c4" runat="server" Text="请选择图片:" Visible="false"></asp:Label>
                <asp:FileUpload ID="FileUpload4" runat="server" Height="24px" Width="300px" Visible="false"/>
                <asp:Button ID="Button4" runat="server" Text="上传图片" Visible="false" OnClick="Show4"/>
                <asp:Image ID="Image4" runat="server" Height="160px" Width="200px" Visible="false"/>
                &nbsp;&nbsp;<asp:Button runat="server" ID="n4" Visible="false" Width="73px" Text="下一步" OnClick="next5"/>
                &nbsp;&nbsp;<asp:Button runat="server" ID="f4" Visible="false" Width="118px" Text="所有步骤已完成" OnClick="finish"/>
                <asp:Image ID="rp6" runat="server" Height="160px" Width="200px" Visible="true" ImageUrl="~/images/logo.jpg"/></td>
            </tr>
             <tr>
                <td class="style"><asp:Label ID="l5" runat="server" Text="步骤五" Visible="false"></asp:Label>
                <asp:TextBox ID="b5" runat="server" Visible="false" Height="165px" Width="400px"></asp:TextBox>
                <asp:Image ID="rp7" runat="server" Height="160px" Width="200px" Visible="true" ImageUrl="~/images/8B231018462.jpg" /></td>
                <td class="style1"><asp:Label ID="c5" runat="server" Text="请选择图片:" Visible="false"></asp:Label>
                <asp:FileUpload ID="FileUpload5" runat="server" Height="24px" Width="300px" Visible="false"/>
                <asp:Button ID="Button5" runat="server" Text="上传图片" Visible="false" OnClick="Show5"/>
                <asp:Image ID="Image5" runat="server" Height="160px" Width="200px" Visible="false"/>
                &nbsp;&nbsp;<asp:Button runat="server" ID="n5" Visible="false" Width="73px" Text="下一步" OnClick="next6"/>
                &nbsp;&nbsp;<asp:Button runat="server" ID="f5" Width="118px" Text="所有步骤已完成" Visible="false" OnClick="finish"/>
                <asp:Image ID="rp8" runat="server" Height="160px" Width="200px" Visible="true" ImageUrl="~/images/logo.jpg" /></td>
            </tr>
             <tr>
                <td class="style"><asp:Label ID="l6" runat="server" Text="步骤六" Visible="false"></asp:Label>
                <asp:TextBox ID="b6" runat="server" Visible="false" Height="165px" Width="400px"></asp:TextBox>
                <asp:Image ID="rp9" runat="server" Height="160px" Width="200px" Visible="true" ImageUrl="~/images/3B92655925.jpg" /></td>
                <td class="style1"><asp:Label ID="c6" runat="server" Text="请选择图片:" Visible="false"></asp:Label>
                <asp:FileUpload ID="FileUpload6" runat="server" Height="24px" Width="300px" Visible="false"/>
                <asp:Button ID="Button6" runat="server" Text="上传图片" Visible="false" OnClick="Show6"/>
                <asp:Image ID="Image6" runat="server" Height="160px" Width="200px" Visible="false"/>
                &nbsp;&nbsp;<asp:Button runat="server" ID="f6" Visible="false" Width="118px" Text="所有步骤已完成" OnClick="finish"/>
                <asp:Image ID="rp10" runat="server" Height="160px" Width="200px" Visible="true" ImageUrl="~/images/logo.jpg" /></td>
            </tr>
        </table>
        <div id="E"><br/><center/>保护环境&nbsp;&nbsp;人人有责</div>
    </div>
    </form>
</body>
</html>
