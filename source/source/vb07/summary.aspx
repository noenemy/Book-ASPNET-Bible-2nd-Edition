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
				<FONT face="����">Email&nbsp;:
					<asp:textbox id="txtEmail" runat="server"></asp:textbox>
					<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" Display="Dynamic" ErrorMessage="Email �ּҸ� �Է��ϼ���." ControlToValidate="txtEmail">*</asp:requiredfieldvalidator>
				</FONT>
			</P>
			<P>
				<FONT face="����">���&nbsp;:
					<asp:dropdownlist id="comHobby" runat="server">
						<asp:ListItem Value="-- ���� --" Selected="True">-- ���� --</asp:ListItem>
						<asp:ListItem Value="��ȭ����">��ȭ����</asp:ListItem>
						<asp:ListItem Value="���ǰ���">���ǰ���</asp:ListItem>
						<asp:ListItem Value="���߱�">���߱�</asp:ListItem>
					</asp:dropdownlist>
					<asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" ErrorMessage="��̸� �����ϼ���." ControlToValidate="comHobby" InitialValue="-- ���� --">*</asp:requiredfieldvalidator>
				</FONT>
			</P>
			<FONT face="����">
				<P>
					<asp:ValidationSummary id="ValidationSummary1" runat="server" HeaderText="������ ���� �Է� ������ �ֽ��ϴ�." ShowMessageBox="True"></asp:ValidationSummary>
				</P>
				<P>
					<asp:button id="btnOK" runat="server" Text="Button"></asp:button>
				</P>
			</FONT>
		</form>
	</body>
</HTML>
