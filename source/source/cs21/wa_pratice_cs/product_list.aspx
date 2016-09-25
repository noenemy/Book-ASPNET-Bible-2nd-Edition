<%@ Page language="c#" Codebehind="product_list.aspx.cs" AutoEventWireup="false" Inherits="wa_pratice_cs.product_list" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>product_list</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="product_list" method="post" runat="server">
			<P><FONT face="굴림">WebService를 이용한 ProductList</FONT></P>
			<P>
				<asp:DropDownList id="comCategories" runat="server" AutoPostBack="True"></asp:DropDownList></P>
			<P>
				<asp:DataGrid id="grdProducts" runat="server"></asp:DataGrid></P>
		</form>
	</body>
</HTML>
