<%@ Page Language="vb" AutoEventWireup="false" Codebehind="image.aspx.vb" Inherits="intrinsic_control.image" %>
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
			<asp:Image id="Image1" runat="server" ImageUrl="images/logo_xpert.gif" Width="170px" Height="40px" ImageAlign="TextTop" AlternateText=".netXpert ·Î°í"></asp:Image>
			<FONT face="±¼¸²">&nbsp;align : texttop
				<BR>
			</FONT>
			<asp:Image id="Image2" runat="server" ImageUrl="images/logo_xpert.gif" BorderWidth="1px" ImageAlign="Middle"></asp:Image>
			<FONT face="±¼¸²">&nbsp;align : middle
				<BR>
			</FONT>
			<asp:Image id="Image3" runat="server" ImageUrl="images/logo_xpert.gif" Width="210px" Height="50px" BorderWidth="5px" ImageAlign="Bottom" BorderStyle="Double"></asp:Image>
			<FONT face="±¼¸²">&nbsp;align : bottom</FONT>
		</form>
	</body>
</HTML>
