<%@ Page Language="vb" AutoEventWireup="false" Codebehind="range.aspx.vb" Inherits="validation_control.range" %>
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
				<FONT face="����">����� �¾ ��(��)�� �����Դϱ�?</FONT>
			</P>
			<P>
				<asp:TextBox id="txtMonth" runat="server" Width="50px"></asp:TextBox>
				<FONT face="����">��</FONT>
			</P>
			<P>
				<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button>
			</P>
			<P>
				<asp:RangeValidator id="RangeValidator1" runat="server" ErrorMessage="1-12������ ���ڸ� �Է��ϼ���." ControlToValidate="txtMonth" MaximumValue="12" MinimumValue="1" Type="Integer"></asp:RangeValidator>
			</P>
		</form>
	</body>
</HTML>
