<%@ Page language="c#" Codebehind="xml.aspx.cs" AutoEventWireup="false" Inherits="intrinsic_cs.xml" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>xml</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="xml" method="post" runat="server">
			<asp:Xml id="Xml1" runat="server" DocumentSource="address.xml" TransformSource="address.xsl"></asp:Xml>		
		</form>
	</body>
</HTML>
