<%@ Page language="c#" Codebehind="cmd_update.aspx.cs" AutoEventWireup="false" Inherits="adonet_cs.cmd_update" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="cmd_update" method="post" runat="server">
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
