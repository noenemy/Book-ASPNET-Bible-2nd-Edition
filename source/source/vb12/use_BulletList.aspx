<%@ Register TagPrefix="cc1" Namespace="CustomControl" Assembly="CustomControl" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="use_BulletList.aspx.vb" Inherits="control.use_BulletList"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>use_BulletList</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="����">BulletList ��Ʈ��</FONT></P>
			<cc1:BulletList id="BList1" runat="server" DataSource="<%# DsCategories1 %>" DataTextField="CategoryName" DataMember="Categories">
			</cc1:BulletList>
		</form>
	</body>
</HTML>
