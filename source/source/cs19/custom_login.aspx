<%@ Page language="c#" Codebehind="custom_login.aspx.cs" AutoEventWireup="false" Inherits="security_cs.custom_login" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>custom_login</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="custom_login" method="post" runat="server">
			<P><FONT face="굴림">Login 페이지(사용자 정의 인증)</FONT></P>
			<P><FONT face="굴림">사용자이름 :
					<asp:TextBox id="txtUserName" runat="server" Width="144px"></asp:TextBox><BR>
				</FONT><FONT face="굴림">비 밀 번 호 :
					<asp:TextBox id="txtPassword" runat="server" TextMode="Password"></asp:TextBox></FONT></P>
			<P><FONT face="굴림">
					<asp:Button id="btnLogin" runat="server" Text="로그인"></asp:Button></FONT></P>
			<P><FONT face="굴림">
					<asp:Label id="lblMessage" runat="server" ForeColor="Red"></asp:Label></P>
			</FONT>
		</form>
	</body>
</HTML>
