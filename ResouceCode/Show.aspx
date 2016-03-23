<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Show.aspx.cs" Inherits="Show"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!doctype html>
<html>
<head runat="server">
	<title></title>
	<meta charset="utf-8">
<!--	<link rel="stylesheet" href="http://yui.yahooapis.com/pure/0.3.0/pure-min.css"> -->
	<script src="scripts/jquery-latest.js"/></script>
	<script src="scripts/jquery.scrollTo-1.4.3.1-min.js"></script>
	<link rel="stylesheet" href="styles/basic.css">
	<link rel="stylesheet" href="styles/chararcter.css">
	<script src="scripts/basic.js"></script>
</head>
<body>
	<div id="wrapper">
		<header>header</header>
		<nav>nav</nav>
		<aside>
			<div class="clips">
				<a id="clip-to-prev" class="clip-button">上一步</a>
			</div>
			<div class="clips">
				<a id="clip-to-next" class="clip-button">下一步</a>
			</div>
			<div class="clips">
			<a id="clip-to-top" class="clip-button">顶部</a>
			</div>
		</aside>
		<article>
			<section id="s1">
                <p><asp:Label ID="Label1" CssClass="procedure-title" runat="server" Visible="true"></asp:Label></p>
                <asp:Image  ID="li1" CssClass="procedure-img"  runat="server" />
                <asp:Label ID="la1" CssClass="procedure-description" runat="server"></asp:Label>
			</section>
			<section id="s2">
                <p><asp:Label ID="Label2" CssClass="procedure-title" Text="第一步" runat="server" Visible="true" /></p>
                <asp:Image  ID="li2" CssClass="procedure-img" runat="server" />
                <asp:Label ID="la2" CssClass="procedure-description" runat="server"></asp:Label>			
			</section>
			<section id="s3">
                <p><asp:Label ID="Label3" CssClass="procedure-title" runat="server" Visible="true" /></p>
                <asp:Image  ID="li3" CssClass="procedure-img"  runat="server" />
                <asp:Label ID="la3" CssClass="procedure-description"  runat="server"></asp:Label>
			</section>
			<section id="s4">
                <p><asp:Label ID="Label4" CssClass="procedure-title"  runat="server" Visible="true" /></p>
                <asp:Image  ID="li4" CssClass="procedure-img"  runat="server" />
                <asp:Label ID="la4" CssClass="procedure-description" runat="server"></asp:Label>
			</section>
			<section id="s5">
                <p><asp:Label ID="Label5" CssClass="procedure-title"  runat="server" Visible="true" /></p>
                <asp:Image  ID="li5" CssClass="procedure-img"  runat="server" />
                <asp:Label ID="la5" CssClass="procedure-description"  runat="server"></asp:Label>
			</section>
			<section id="s6">
                 <p><asp:Label ID="Label6" CssClass="procedure-title" runat="server" Visible="true"></asp:Label></p>
                <asp:Image  ID="li6" CssClass="procedure-img"  runat="server" />
                <asp:Label ID="la6" CssClass="procedure-description" runat="server"></asp:Label>
			</section>
			<section id="s7">
                <p><asp:Label ID="Label7" CssClass="procedure-title"  runat="server" Visible="true"></asp:Label></p>
                <asp:Image  ID="li7" CssClass="procedure-img"  runat="server" Visible="true" />
                <asp:Label ID="la7" CssClass="procedure-description"  runat="server" Visible="true"></asp:Label>
			</section>
		</article>
		<footer>It's over!!!!<asp:HyperLink ID="Back" runat="server"   Text="返回主页"  Font-Size="15px" NavigateUrl="~/Main.aspx"></asp:HyperLink>
       </footer>
	</div>
</body>
</html>
