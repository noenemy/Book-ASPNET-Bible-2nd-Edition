<%@ Page language="c#" Codebehind="col_database.aspx.cs" AutoEventWireup="false" Inherits="databinding_cs.col_database" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>col_database</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="col_database" method="post" runat="server">
			<P><FONT face="굴림">Collection 데이터바인딩 - 데이터베이스</FONT></P>
			<P>
				<asp:DataGrid id=grdDatabase runat="server" DataSource="<%# dsCategories1 %>" DataMember="Categories" DataKeyField="CategoryID">
				</asp:DataGrid></P>
		</form>
	</body>
</HTML>
