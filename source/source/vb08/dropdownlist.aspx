<%@ Page Language="vb" AutoEventWireup="false" Codebehind="dropdownlist.aspx.vb" Inherits="list_control1.dropdownlist" %>
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
			<FONT face="����">
				<P>
					�������� �ֿ��� ��ȭ�� �����ϼ���.
				</P>
				<P>
					<asp:DropDownList id="comMovie" runat="server">
						<asp:ListItem Value="0" Selected="True">�����ϼ���.</asp:ListItem>
						<asp:ListItem Value="1">����������</asp:ListItem>
						<asp:ListItem Value="2">����������</asp:ListItem>
						<asp:ListItem Value="3">�������α׳�</asp:ListItem>
						<asp:ListItem Value="4">ų�����Ǽ���</asp:ListItem>
					</asp:DropDownList>
				</P>
				<P>
					<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button>
				</P>
			</FONT>
		</form>
	</body>
</HTML>
