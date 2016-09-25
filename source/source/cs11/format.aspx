<%@ Page language="c#" Codebehind="format.aspx.cs" AutoEventWireup="false" Inherits="databinding_cs.format" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>format</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="format" method="post" runat="server">
			<P><FONT face="굴림">DataBinder.Eval - format expression</FONT></P>
			<P><asp:datalist id=DataList1 runat="server" DataSource="<%# dsOrders1 %>" DataMember="Orders" DataKeyField="OrderID">
					<ItemTemplate>
						<P><FONT face="굴림">주문번호 :&nbsp;</FONT>
							<asp:Label id=lblOrderID runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.OrderID", "{0:N}") %>'>
							</asp:Label><BR>
							<FONT face="굴림">주문일 : </FONT>
							<asp:Label id=lblOrderDate runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.OrderDate", "{0:D}") %>'>
							</asp:Label><FONT face="굴림">&nbsp;</FONT><FONT face="굴림"><FONT face="굴림">선적일 : </FONT>
								<asp:Label id=lblShippedDate runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ShippedDate", "{0:d}") %>'>
								</asp:Label><BR>
								운임 : </FONT>
							<asp:Label id=lblFreight runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Freight", "{0:F2}") %>'>
							</asp:Label></P>
					</ItemTemplate>
				</asp:datalist></P>
		</form>
	</body>
</HTML>
