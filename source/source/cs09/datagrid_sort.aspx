<%@ Page language="c#" Codebehind="datagrid_sort.aspx.cs" AutoEventWireup="false" Inherits="list2_cs.datagrid_sort" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>datagrid_sort</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="datagrid_sort" method="post" runat="server">
			<P><FONT face="±¼¸²">DataGrid - Sort ¿¹Á¦</FONT></P>
			<P>
				<asp:DataGrid id=DataGrid1 runat="server" DataSource="<%# dataView1 %>" AllowSorting="True">
				</asp:DataGrid></P>
		</form>
	</body>
</HTML>
