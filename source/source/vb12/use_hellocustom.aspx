<%@ Register TagPrefix="cc1" Namespace="CustomControl" Assembly="CustomControl" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="use_hellocustom.aspx.vb" Inherits="control.use_hellocustom"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>use_hellocustom</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">HelloCustom 컨트롤</FONT></P>
			<P>
				<cc1:HelloCustom id="HelloCustom1" Text="프로퍼티 사용하기" runat="server"></cc1:HelloCustom></P>
		</form>
	</body>
</HTML>
