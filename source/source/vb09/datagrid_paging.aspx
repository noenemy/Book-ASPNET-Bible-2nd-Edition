<%@ Page Language="vb" AutoEventWireup="false" Codebehind="datagrid_paging.aspx.vb" Inherits="list_control2.datagrid_paging"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>datagrid_paging</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="±¼¸²">DataGrid - ÆäÀÌÂ¡ ¿¹Á¦</FONT></P>
			<P>
				<asp:DataGrid id=DataGrid1 runat="server" DataSource="<%# DsCustomers1 %>" DataMember="Customers" DataKeyField="CustomerID" AllowPaging="True">
					<PagerStyle Mode="NumericPages"></PagerStyle>
				</asp:DataGrid></P>
		</form>
	</body>
</HTML>
