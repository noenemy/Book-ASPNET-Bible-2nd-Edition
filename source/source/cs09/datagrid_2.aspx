<%@ Page language="c#" Codebehind="datagrid_2.aspx.cs" AutoEventWireup="false" Inherits="list2_cs.datagrid_2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>datagrid_2</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="datagrid_2" method="post" runat="server">
			<P><FONT face="굴림">DataGrid - 예제2</FONT></P>
			<P>
				<asp:DataGrid id=DataGrid1 runat="server" DataSource="<%# dsCategories1 %>" AutoGenerateColumns="False">
					<Columns>
						<asp:BoundColumn DataField="CategoryName" SortExpression="CategoryName" HeaderText="카테고리명"></asp:BoundColumn>
						<asp:BoundColumn DataField="Description" SortExpression="Description" HeaderText="설명"></asp:BoundColumn>
					</Columns>
				</asp:DataGrid></P>
		</form>
	</body>
</HTML>
