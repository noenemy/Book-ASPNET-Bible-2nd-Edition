<%@ Page Language="vb" AutoEventWireup="false" Codebehind="format.aspx.vb" Inherits="databinding.format"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>format</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="����">DataBinder.Eval - format expression</FONT></P>
			<P><asp:datalist id=DataList1 runat="server" DataSource="<%# DsOrders1 %>" DataMember="Orders" DataKeyField="OrderID">
					<ItemTemplate>
						<P><FONT face="����">�ֹ���ȣ :&nbsp;</FONT>
							<asp:Label id=lblOrderID runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.OrderID", "{0:N}") %>'>
							</asp:Label><BR>
							<FONT face="����">�ֹ��� : </FONT>
							<asp:Label id=lblOrderDate runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.OrderDate", "{0:D}") %>'>
							</asp:Label><FONT face="����">&nbsp;</FONT><FONT face="����"><FONT face="����">������ : </FONT>
								<asp:Label id=lblShippedDate runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ShippedDate", "{0:d}") %>'>
								</asp:Label><BR>
								���� : </FONT>
							<asp:Label id=lblFreight runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Freight", "{0:F2}") %>'>
							</asp:Label></P>
					</ItemTemplate>
				</asp:datalist></P>
		</form>
	</body>
</HTML>
