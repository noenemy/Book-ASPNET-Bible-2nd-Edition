<%@ Page Language="vb" AutoEventWireup="false" Codebehind="checkboxlist.aspx.vb" Inherits="list_control1.checkboxlist" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">관심품목을 모두 선택하세요.</FONT>
			</P>
			<P><asp:checkboxlist id=chkCategories runat="server" RepeatColumns="3" DataValueField="CategoryID" DataTextField="CategoryName" DataSource="<%# DsCategories1 %>"></asp:checkboxlist></P>
			<P><asp:button id="btnOK" runat="server" Text="Button"></asp:button></P>
		</form>
	</body>
</HTML>
