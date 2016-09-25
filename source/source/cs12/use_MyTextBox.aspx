<%@ Page language="c#" Codebehind="use_MyTextBox.aspx.cs" AutoEventWireup="false" Inherits="control_cs.use_MyTextBox" %>
<%@ Register TagPrefix="cc1" Namespace="CustomControl" Assembly="CustomControl" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>use_MyTextBox</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="use_MyTextBox" method="post" runat="server">
			<P><FONT face="굴림">MyTextBox 컨트롤</FONT></P>
			<cc1:MyTextBox id="MyTextBox1" runat="server"></cc1:MyTextBox>
			<asp:Button id="Button1" runat="server" Text="Button"></asp:Button>
		</form>
	</body>
</HTML>
