<%@ Page language="c#" Codebehind="listbox.aspx.cs" AutoEventWireup="false" Inherits="list1_cs.listbox" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="listbox" method="post" runat="server">
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
