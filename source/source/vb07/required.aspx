<%@ Page Language="vb" AutoEventWireup="false" Codebehind="required.aspx.vb" Inherits="validation_control.required" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">Email&nbsp;:
					<asp:textbox id="txtEmail" runat="server"></asp:textbox>[<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" Display="Dynamic" ErrorMessage="Email 주소를 입력하세요." ControlToValidate="txtEmail"></asp:requiredfieldvalidator>]</FONT>
			</P>
			<P><FONT face="굴림">취미&nbsp;:
					<asp:dropdownlist id="comHobby" runat="server">
						<asp:ListItem Selected="True" Value="-- 선택 --">-- 선택 --</asp:ListItem>
						<asp:ListItem Value="영화감상">영화감상</asp:ListItem>
						<asp:ListItem Value="음악감상">음악감상</asp:ListItem>
						<asp:ListItem Value="춤추기">춤추기</asp:ListItem>
					</asp:dropdownlist><asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" ErrorMessage="취미를 선택하세요." ControlToValidate="comHobby" InitialValue="-- 선택 --"></asp:requiredfieldvalidator></FONT></P>
			<P><FONT face="굴림"><asp:button id="btnOK" runat="server" Text="Button"></asp:button></P>
			</FONT></form>
	</body>
</HTML>
