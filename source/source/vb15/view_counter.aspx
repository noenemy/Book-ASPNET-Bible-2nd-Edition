<%@ Page Language="vb" AutoEventWireup="false" Codebehind="view_counter.aspx.vb" Inherits="WebApp.view_counter"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>view_counter</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">카운터 예제</FONT></P>
			<P><FONT face="굴림">총접속자 :&nbsp;
					<asp:Label id="lblTotal" runat="server">Label</asp:Label>명&nbsp;&nbsp; 현재접속자 :
					<asp:Label id="lblNow" runat="server">Label</asp:Label>명</FONT></P>
		</form>
	</body>
</HTML>
