<%@ Page language="c#" Codebehind="view_counter.aspx.cs" AutoEventWireup="false" Inherits="WebApp_cs.view_counter" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>view_counter</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="view_counter" method="post" runat="server">
			<P><FONT face="굴림">카운터 예제</FONT></P>
			<P><FONT face="굴림">총접속자 :&nbsp;
					<asp:Label id="lblTotal" runat="server">Label</asp:Label>명&nbsp;&nbsp; 현재접속자 :
					<asp:Label id="lblNow" runat="server">Label</asp:Label>명</FONT></P>
		</form>
	</body>
</HTML>
