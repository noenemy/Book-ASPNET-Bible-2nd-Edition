<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_hello.aspx.vb" Inherits="security_vb.form_hello"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_hello</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">안녕하세요.
					<asp:Label id="lblUserName" runat="server">Label</asp:Label>님<BR>
					<BR>
					Forms Authentication으로 인증되었습니다.</FONT>
			</P>
			<P>
				<asp:Button id="btnLogOut" runat="server" Text="로그아웃"></asp:Button></P>
		</form>
	</body>
</HTML>
