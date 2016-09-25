<%@ Page Language="vb" AutoEventWireup="false" Codebehind="regular.aspx.vb" Inherits="validation_control.regular" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<FONT face="굴림">우편번호를 입력하세요.</FONT>
			</P>
			<P>
				<asp:TextBox id="txtZipCode" runat="server" Width="100px"></asp:TextBox>
				<FONT face="굴림">&nbsp;예:123-456</FONT>
			</P>
			<P>
				<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button>
			</P>
			<P>
				<asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" ErrorMessage="우편번호 형식이 아닙니다." ControlToValidate="txtZipCode" ValidationExpression="\d{3}-\d{3}"></asp:RegularExpressionValidator>
			</P>
		</form>
	</body>
</HTML>
