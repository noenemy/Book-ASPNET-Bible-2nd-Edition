<%@ Register TagPrefix="uc1" TagName="custom_login_check" Src="custom_login_check.ascx" %>
<%@ Page language="c#" Codebehind="custom_hello.aspx.cs" AutoEventWireup="false" Inherits="security_cs.custom_hello" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>custom_hello</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="custom_hello" method="post" runat="server">
			<P><FONT face="굴림">안녕하세요.
					<asp:Label id="lblUserName" runat="server">Label</asp:Label>님<BR>
					<BR>
					사용자 정의&nbsp;인증방법으로 인증되었습니다.</FONT>
			</P>
			<P>
				<asp:Button id="btnLogOut" runat="server" Text="로그아웃"></asp:Button><FONT face="굴림"><BR>
				</FONT><FONT face="굴림">
					<BR>
				</FONT>
				<uc1:custom_login_check id="Custom_login_check1" runat="server"></uc1:custom_login_check></P>
		</form>
	</body>
</HTML>
