<%@ Page Language="vb" AutoEventWireup="false" Codebehind="xml.aspx.vb" Inherits="intrinsic_control.xml" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:Xml id="Xml1" runat="server" DocumentSource="address.xml" TransformSource="address.xsl"></asp:Xml>
		</form>
	</body>
</HTML>
