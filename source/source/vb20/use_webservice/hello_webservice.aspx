<%@ Page Language="vb" AutoEventWireup="false" Codebehind="hello_webservice.aspx.vb" Inherits="use_webservice.hello_webservice"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>hello_webservice</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">Web Service 사용하기 </FONT>
			</P>
			<P>
				<asp:TextBox id="TextBox1" runat="server"></asp:TextBox>
				<asp:Button id="btnInvoke" runat="server" Text="웹 서비스 호출"></asp:Button></P>
		</form>
	</body>
</HTML>
