<%@ Page Language="vb" AutoEventWireup="false" Codebehind="product_list.aspx.vb" Inherits="wa_practice.product_list"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>product_list</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">WebService를 이용한 ProductList</FONT></P>
			<P>
				<asp:DropDownList id="comCategories" runat="server" AutoPostBack="True"></asp:DropDownList></P>
			<P>
				<asp:DataGrid id="grdProducts" runat="server"></asp:DataGrid></P>
		</form>
	</body>
</HTML>
