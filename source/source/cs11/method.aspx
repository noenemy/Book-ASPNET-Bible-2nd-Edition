<%@ Page language="c#" Codebehind="method.aspx.cs" AutoEventWireup="false" Inherits="databinding_cs.method" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>method</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="method" method="post" runat="server">
			<P><FONT face="����">Method �����͹��ε�</FONT></P>
			<P><FONT face="����">�¾ �⵵�� �Է��ϼ���.<BR>
					<asp:TextBox id="txtYear" runat="server" Width="77px"></asp:TextBox>��
					<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button></FONT></P>
			<P><FONT face="����">����
					<asp:Label id=lblAge runat="server" Text="<%# CaculateAge(txtYear.Text) %>">
					</asp:Label>�� �Դϴ�.</P>
			</FONT>
		</form>
	</body>
</HTML>
