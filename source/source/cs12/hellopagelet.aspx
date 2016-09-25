<%@ Page language="c#" Codebehind="hellopagelet.aspx.cs" AutoEventWireup="false" Inherits="control_cs.hellopagelet" %>
<%@ Register TagPrefix="uc1" TagName="pagelet1" Src="pagelet1.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>hellopagelet</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="hellopagelet" method="post" runat="server">
			<P><FONT face="굴림">페이지릿&nbsp;예제 1</FONT></P>
			<P>
				<uc1:pagelet1 id="Pagelet11" runat="server"></uc1:pagelet1></P>
		</form>
	</body>
</HTML>
