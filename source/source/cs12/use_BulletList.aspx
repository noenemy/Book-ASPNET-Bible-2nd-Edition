<%@ Register TagPrefix="cc1" Namespace="CustomControl" Assembly="CustomControl" %>
<%@ Page language="c#" Codebehind="use_BulletList.aspx.cs" AutoEventWireup="false" Inherits="control_cs.use_BulletList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>use_BulletList</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="use_BulletList" method="post" runat="server">
			<P><FONT face="굴림">BulletList 컨트롤</FONT></P>
			<cc1:BulletList id="BList1" runat="server" DataTextField="CategoryName" DataSource="<%# dsCategories1%>" DataMember="Categories"></cc1:BulletList>
		</form>
	</body>
</HTML>
