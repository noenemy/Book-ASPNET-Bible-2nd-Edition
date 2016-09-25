<%@ Page Language="vb" AutoEventWireup="false" Codebehind="summary.aspx.vb" Inherits="validation_control.summary" %>
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
				<FONT face="굴림">Email&nbsp;:
					<asp:textbox id="txtEmail" runat="server"></asp:textbox>
					<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" Display="Dynamic" ErrorMessage="Email 주소를 입력하세요." ControlToValidate="txtEmail">*</asp:requiredfieldvalidator>
				</FONT>
			</P>
			<P>
				<FONT face="굴림">취미&nbsp;:
					<asp:dropdownlist id="comHobby" runat="server">
						<asp:ListItem Value="-- 선택 --" Selected="True">-- 선택 --</asp:ListItem>
						<asp:ListItem Value="영화감상">영화감상</asp:ListItem>
						<asp:ListItem Value="음악감상">음악감상</asp:ListItem>
						<asp:ListItem Value="춤추기">춤추기</asp:ListItem>
					</asp:dropdownlist>
					<asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" ErrorMessage="취미를 선택하세요." ControlToValidate="comHobby" InitialValue="-- 선택 --">*</asp:requiredfieldvalidator>
				</FONT>
			</P>
			<FONT face="굴림">
				<P>
					<asp:ValidationSummary id="ValidationSummary1" runat="server" HeaderText="다음과 같은 입력 오류가 있습니다." ShowMessageBox="True"></asp:ValidationSummary>
				</P>
				<P>
					<asp:button id="btnOK" runat="server" Text="Button"></asp:button>
				</P>
			</FONT>
		</form>
	</body>
</HTML>
