<%@ Page Language="vb" AutoEventWireup="false" Codebehind="custom_login.aspx.vb" Inherits="security_vb.custom_login1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>custom_login</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="����">Login ������(����� ���� ����)</FONT></P>
			<P><FONT face="����">������̸� :
					<asp:TextBox id="txtUserName" runat="server" Width="144px"></asp:TextBox><BR>
				</FONT><FONT face="����">�� �� �� ȣ :
					<asp:TextBox id="txtPassword" runat="server" TextMode="Password"></asp:TextBox></FONT></P>
			<P><FONT face="����">
					<asp:Button id="btnLogin" runat="server" Text="�α���"></asp:Button></FONT></P>
			<P><FONT face="����">
					<asp:Label id="lblMessage" runat="server" ForeColor="Red"></asp:Label></P>
			</FONT>
		</form>
	</body>
</HTML>
