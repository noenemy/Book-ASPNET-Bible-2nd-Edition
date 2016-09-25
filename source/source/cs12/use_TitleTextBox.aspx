<%@ Register TagPrefix="cc1" Namespace="CustomControl" Assembly="CustomControl" %>
<%@ Page language="c#" Codebehind="use_TitleTextBox.aspx.cs" AutoEventWireup="false" Inherits="control_cs.use_TitleTextBox" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>use_TitleTextBox</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="use_TitleTextBox" method="post" runat="server">
			<P><FONT face="굴림">TitleTextBox 컨트롤</FONT></P>
			<cc1:TitleTextBox id="TitleTextBox1" Title="이름" Text="놀래미" runat="server"></cc1:TitleTextBox><BR>
			<cc1:TitleTextBox id="TitleTextBox2" Title="아이디" Text="noenemy" runat="server"></cc1:TitleTextBox><BR>
			<cc1:TitleTextBox id="TitleTextBox3" Title="소속" Text=".NETXPERT" runat="server"></cc1:TitleTextBox></FONT>
			<P><FONT face="굴림"></FONT></P>
		</form>
	</body>
</HTML>
