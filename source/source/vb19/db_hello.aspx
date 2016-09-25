<%@ Page Language="vb" AutoEventWireup="false" Codebehind="db_hello.aspx.vb" Inherits="security_vb.db_hello"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>db_hello</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">안녕하세요.
					<asp:Label id="lblUserName" runat="server">Label</asp:Label>님<BR>
					<BR>
					Forms Authentication(DB 사용)으로 인증되었습니다.</FONT>
			</P>
			<P>
				<asp:Button id="btnLogOut" runat="server" Text="로그아웃"></asp:Button></P>
		</form>
	</body>
</HTML>
