<%@ Page language="c#" Codebehind="form_encrypt.aspx.cs" AutoEventWireup="false" Inherits="security_cs.form_encrypt" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>form_encrypt</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="form_encrypt" method="post" runat="server">
			<P><FONT face="����">��й�ȣ ��ȣȭ(Encryption)</FONT></P>
			<P><FONT face="����">��й�ȣ :
					<asp:TextBox id="txtPassword" runat="server"></asp:TextBox>
					<asp:Button id="btnEncrypt" runat="server" Text="��ȣȭ�ϱ�"></asp:Button></FONT></P>
			<P><FONT face="����">SHA1 :
					<asp:Label id="lblSHA1" runat="server">Label</asp:Label><BR>
					MD5&nbsp;&nbsp;:
					<asp:Label id="lblMD5" runat="server">Label</asp:Label><BR>
			</P>
			</FONT>
		</form>
	</body>
</HTML>
