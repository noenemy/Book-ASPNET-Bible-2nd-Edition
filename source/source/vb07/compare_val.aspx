<%@ Page Language="vb" AutoEventWireup="false" Codebehind="compare_val.aspx.vb" Inherits="validation_control.compare_val" %>
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
				<FONT face="����">��&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ȣ :&nbsp;
					<asp:TextBox id="txtPWD1" runat="server" TextMode="Password"></asp:TextBox>
					<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="txtPWD1" ErrorMessage="��ȣ�� �Է��ϼ���."></asp:RequiredFieldValidator>
					<BR>
				</FONT><FONT face="����">��ȣȮ�� :
					<asp:TextBox id="txtPWD2" runat="server" TextMode="Password"></asp:TextBox>
					<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="txtPWD2" ErrorMessage="��ȣȮ���� �Է��ϼ���."></asp:RequiredFieldValidator>
				</FONT>
			</P>
			<P>
				<FONT face="����">
					<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button>
			</P>
			</FONT>
			<P>
				<FONT face="����">
					<asp:CompareValidator id="CompareValidator1" runat="server" ErrorMessage="��ȣ�� ��ġ���� �ʽ��ϴ�." ControlToCompare="txtPWD1" ControlToValidate="txtPWD2"></asp:CompareValidator>
			</P>
			</FONT>
		</form>
	</body>
</HTML>
