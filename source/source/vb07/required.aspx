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
			<P><FONT face="����">Email&nbsp;:
					<asp:textbox id="txtEmail" runat="server"></asp:textbox>[<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" Display="Dynamic" ErrorMessage="Email �ּҸ� �Է��ϼ���." ControlToValidate="txtEmail"></asp:requiredfieldvalidator>]</FONT>
			</P>
			<P><FONT face="����">���&nbsp;:
					<asp:dropdownlist id="comHobby" runat="server">
						<asp:ListItem Selected="True" Value="-- ���� --">-- ���� --</asp:ListItem>
						<asp:ListItem Value="��ȭ����">��ȭ����</asp:ListItem>
						<asp:ListItem Value="���ǰ���">���ǰ���</asp:ListItem>
						<asp:ListItem Value="���߱�">���߱�</asp:ListItem>
					</asp:dropdownlist><asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" ErrorMessage="��̸� �����ϼ���." ControlToValidate="comHobby" InitialValue="-- ���� --"></asp:requiredfieldvalidator></FONT></P>
			<P><FONT face="����"><asp:button id="btnOK" runat="server" Text="Button"></asp:button></P>
			</FONT></form>
	</body>
</HTML>
