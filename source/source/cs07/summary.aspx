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
				<FONT face="����">Email&nbsp;:
					<asp:textbox id="txtEmail" runat="server"></asp:textbox>
					<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email �ּҸ� �Է��ϼ���." Display="Dynamic">*</asp:requiredfieldvalidator>
				</FONT>
			</P>
			<P>
				<FONT face="����">���&nbsp;:
					<asp:dropdownlist id="comHobby" runat="server">
						<asp:ListItem Selected="True" Value="-- ���� --">-- ���� 
--</asp:ListItem>
						<asp:ListItem Value="��ȭ����">��ȭ����</asp:ListItem>
						<asp:ListItem Value="���ǰ���">���ǰ���</asp:ListItem>
						<asp:ListItem Value="���߱�">���߱�</asp:ListItem>
					</asp:dropdownlist>
					<asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" ControlToValidate="comHobby" ErrorMessage="��̸� �����ϼ���." InitialValue="-- ���� --">*</asp:requiredfieldvalidator>
				</FONT>
			</P>
			<FONT face="����">
				<P>
					<asp:ValidationSummary id="ValidationSummary1" runat="server" ShowMessageBox="True" HeaderText="������ ���� �Է� ������ �ֽ��ϴ�."></asp:ValidationSummary>
				</P>
				<P>
					<asp:button id="btnOK" runat="server" Text="Button"></asp:button>
				</P>
			</FONT>
		</form>
	</body>
</HTML>
