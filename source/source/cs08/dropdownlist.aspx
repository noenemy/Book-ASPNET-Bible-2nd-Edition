<%@ Page language="c#" Codebehind="dropdownlist.aspx.cs" AutoEventWireup="false" Inherits="list1_cs.dropdownlist" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="dropdownlist" method="post" runat="server">
			<FONT face="����">
				<P>
					�������� �ֿ��� ��ȭ�� �����ϼ���.
				</P>
				<P>
					<asp:DropDownList id="comMovie" runat="server">
						<asp:ListItem Selected="True" Value="0">�����ϼ���.</asp:ListItem>
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
