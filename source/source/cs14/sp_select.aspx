<%@ Page language="c#" Codebehind="sp_select.aspx.cs" AutoEventWireup="false" Inherits="adonet_cs.sp_select" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="sp_select" method="post" runat="server">
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
				<FONT face="����"></FONT>
			</P>
		</form>
	</body>
</HTML>
