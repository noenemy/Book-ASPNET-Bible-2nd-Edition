<%@ Page Language="vb" AutoEventWireup="false" Codebehind="radiobuttonlist.aspx.vb" Inherits="list_control1.radiobuttonlist" %>
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
			<P>
				<FONT face="굴림">관심품목을 선택하세요.</FONT>
			</P>
			<P>
				<asp:radiobuttonlist id="optCategories" runat="server" DataSource="<%# DsCategories1 %>" RepeatColumns="3" DataValueField="CategoryID" DataTextField="CategoryName">
				</asp:radiobuttonlist>
			</P>
			<P>
				<asp:button id="btnOK" runat="server" Text="Button"></asp:button>
			</P>
		</form>
	</body>
</HTML>
