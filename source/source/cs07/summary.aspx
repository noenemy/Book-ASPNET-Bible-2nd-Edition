<%@ Page language="c#" Codebehind="summary.aspx.cs" AutoEventWireup="false" Inherits="validation_cs.summary" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="summary" method="post" runat="server">
			<P>
				<FONT face="굴림">Email&nbsp;:
					<asp:textbox id="txtEmail" runat="server"></asp:textbox>
					<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email 주소를 입력하세요." Display="Dynamic">*</asp:requiredfieldvalidator>
				</FONT>
			</P>
			<P>
				<FONT face="굴림">취미&nbsp;:
					<asp:dropdownlist id="comHobby" runat="server">
						<asp:ListItem Selected="True" Value="-- 선택 --">-- 선택 
--</asp:ListItem>
						<asp:ListItem Value="영화감상">영화감상</asp:ListItem>
						<asp:ListItem Value="음악감상">음악감상</asp:ListItem>
						<asp:ListItem Value="춤추기">춤추기</asp:ListItem>
					</asp:dropdownlist>
					<asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" ControlToValidate="comHobby" ErrorMessage="취미를 선택하세요." InitialValue="-- 선택 --">*</asp:requiredfieldvalidator>
				</FONT>
			</P>
			<FONT face="굴림">
				<P>
					<asp:ValidationSummary id="ValidationSummary1" runat="server" ShowMessageBox="True" HeaderText="다음과 같은 입력 오류가 있습니다."></asp:ValidationSummary>
				</P>
				<P>
					<asp:button id="btnOK" runat="server" Text="Button"></asp:button>
				</P>
			</FONT>
		</form>
	</body>
</HTML>
