<%@ Page Language="vb" AutoEventWireup="false" Codebehind="sp_select.aspx.vb" Inherits="adonet.sp_select" %>
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
				<FONT face="����">ADO.NET&nbsp;�������ν��� ����ϱ�&nbsp;- SELECT</FONT>
			</P>
			<P>
				&nbsp;
				<asp:TextBox id="txtID" runat="server" Width="54px" Height="24px"></asp:TextBox>
				<FONT face="����">�� ��ǰ
					<asp:Button id="btnSelect" runat="server" Text="Select"></asp:Button>
					&nbsp;(��: ���� '3' �Է�)</FONT>
			</P>
			<P>
				<asp:DataGrid id="DataGrid1" runat="server"></asp:DataGrid>
			</P>
			<P>
				<FONT face="����"></FONT>&nbsp;
			</P>
		</form>
	</body>
</HTML>
