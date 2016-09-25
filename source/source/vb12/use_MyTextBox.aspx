<%@ Page Language="vb" AutoEventWireup="false" Codebehind="use_MyTextBox.aspx.vb" Inherits="control.use_MyTextBox"%>
<%@ Register TagPrefix="cc1" Namespace="CustomControl" Assembly="CustomControl" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>use_MyTextBox</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">MyTextBox&nbsp;컨트롤</FONT></P>
			<P>
				<cc1:MyTextBox id="MyTextBox1" runat="server"></cc1:MyTextBox>
				<asp:Button id="Button1" runat="server" Text="Button"></asp:Button></P>
		</form>
	</body>
</HTML>
