<%@ Page Language="vb" AutoEventWireup="false" Codebehind="listbox.aspx.vb" Inherits="list_control1.listbox" %>
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
			<P>
				<asp:TextBox id="txtItem" runat="server"></asp:TextBox>
				<asp:Button id="btnAdd" runat="server" Text="�������߰�"></asp:Button>
				<BR>
				<asp:ListBox id="lstSong" runat="server" Rows="6" SelectionMode="Multiple">
					<asp:ListItem Value="�����̵���">�����̵���</asp:ListItem>
					<asp:ListItem Value="�ʽ�">�ʽ�</asp:ListItem>
					<asp:ListItem Value="TakeFive">TakeFive</asp:ListItem>
					<asp:ListItem Value="���˾ƿ�">���˾ƿ�</asp:ListItem>
				</asp:ListBox>
			</P>
			<P>
				<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button>
			</P>
			<P>
				<asp:Label id="lblSelection" runat="server">Label</asp:Label>
			</P>
		</form>
	</body>
</HTML>
