<%@ Page Language="vb" AutoEventWireup="false" Codebehind="cmd_update.aspx.vb" Inherits="adonet.cmd_update" %>
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
				<FONT face="����">ADO.NET �Ϲ� -&nbsp;UPDATE��
					<BR>
					(Command ��ü�� ExecuteNonQuery �̿�)</FONT>
			</P>
			<P>
				<FONT face="����">
					<BR>
					ID :
					<asp:TextBox id="txtID" runat="server"></asp:TextBox>
					&nbsp;
					<BR>
					Description :
					<asp:TextBox id="txtDesc" runat="server"></asp:TextBox>
				</FONT>
			</P>
			<P>
				<FONT face="����">
					<asp:Button id="btnUpdate" runat="server" Text="Update"></asp:Button>
				</FONT>
			</P>
		</form>
	</body>
</HTML>
