<%@ Page Language="vb" AutoEventWireup="false" Codebehind="custom_hello.aspx.vb" Inherits="security_vb.custom_hello"%>
<%@ Register TagPrefix="uc1" TagName="custom_login_check" Src="custom_login_check.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>custom_hello</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="����">�ȳ��ϼ���.
					<asp:Label id="lblUserName" runat="server">Label</asp:Label>��<BR>
					<BR>
					����� ����&nbsp;����������� �����Ǿ����ϴ�.</FONT>
			</P>
			<P>
				<asp:Button id="btnLogOut" runat="server" Text="�α׾ƿ�"></asp:Button><FONT face="����"><BR>
				</FONT><FONT face="����">
					<BR>
				</FONT>
				<uc1:custom_login_check id="Custom_login_check1" runat="server"></uc1:custom_login_check></P>
		</form>
	</body>
</HTML>
