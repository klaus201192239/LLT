<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sum.aspx.cs" Inherits="Sum" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sum</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style=" width:1000px; margin:auto">
    <table style="border:solid 1px green;width:100%">
	<tr>
		<td style="background-color:Green" colspan="2">
            <span style="font-size: 14pt; color: #ffffff"><strong>与您输入的材料相关的宝贝有：</strong></span></td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;<asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnPageIndexChanged="GridView1_PageIndexChanged" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" HorizontalAlign="Center" >
                        <Columns>
                            <asp:HyperLinkField  HeaderText="名称" DataTextField = "pdt_name" DataNavigateUrlFields = "pdt_name" 
                                 DataNavigateUrlFormatString = "Show.aspx?pdt_name={0}" />
                            <asp:BoundField DataField="m1" HeaderText="原材料1" />
                            <asp:BoundField DataField="m2" HeaderText="原材料2" />
                            <asp:BoundField DataField="m3" HeaderText="原材料3" />
                            <asp:BoundField DataField="m4" HeaderText="原材料4" />
                            <asp:BoundField DataField="m5" HeaderText="原材料5" />
                            <asp:BoundField DataField="m6" HeaderText="原材料6" />
                            <asp:BoundField DataField="m7" HeaderText="原材料7" />
                            <asp:BoundField DataField="m8" HeaderText="原材料8" />
                        </Columns>
                        <PagerSettings FirstPageText="首页" LastPageText="最后一页" Mode="NextPreviousFirstLast"
                            NextPageText="下一页" PreviousPageText="上一页" />
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" Wrap="True" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    </asp:GridView>
    
    </td>
            </tr>
            <tr>
                <td style="text-align: left">
                    每页显示<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>40</asp:ListItem>
                        <asp:ListItem>50</asp:ListItem>
                    </asp:DropDownList>条记录</td>
                <td style="text-align: right">
                <asp:Label ID="lcurr" runat="server"></asp:Label></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
