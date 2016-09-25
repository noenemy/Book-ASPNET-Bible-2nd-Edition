<%@ Page Language="vb" AutoEventWireup="false" Codebehind="datagrid_custompaging.aspx.vb" Inherits="list_control2.datagrid_custompaging"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>datagrid_custompaging</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="±¼¸²">DataGrid - Custom Paging ¿¹Á¦</FONT></P>
			<P>
				<asp:DataGrid id="DataGrid1" runat="server" AllowCustomPaging="True" AllowPaging="True">
					<PagerStyle Mode="NumericPages"></PagerStyle>
				</asp:DataGrid></P>
		</form>
	</body>
</HTML>
