<%@ Register TagPrefix="uc1" TagName="pagelet1" Src="pagelet1.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="hellopagelet.aspx.vb" Inherits="control.hellopagelet"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>hellopagelet</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">페이지릿 예제 1</FONT></P>
			<P>
				<uc1:pagelet1 id="Pagelet11" runat="server"></uc1:pagelet1></P>
		</form>
	</body>
</HTML>
