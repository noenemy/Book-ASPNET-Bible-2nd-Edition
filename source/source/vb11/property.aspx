<%@ Page Language="vb" AutoEventWireup="false" Codebehind="property.aspx.vb" Inherits="databinding._property"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>property</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<FONT face="굴림">Simple Property 데이터바인딩<BR>
				<BR>
				안녕하세요.
				<asp:Label id="lblName" runat="server" Text="<%# CustomerName %>">
				</asp:Label>님 반갑습니다.</FONT>
		</form>
	</body>
</HTML>
