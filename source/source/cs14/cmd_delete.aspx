<%@ Page language="c#" Codebehind="cmd_delete.aspx.cs" AutoEventWireup="false" Inherits="adonet_cs.cmd_delete" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="cmd_delete" method="post" runat="server">
			<P>
				<FONT face="����">ADO.NET �Ϲ� -&nbsp;DELETE��
					<BR>
					(Command ��ü�� ExecuteNonQuery �̿�)</FONT>
			</P>
			<P>
				<FONT face="����">
					<BR>
					ID :
					<asp:TextBox id="txtID" runat="server"></asp:TextBox>
					&nbsp; </FONT>
			</P>
			<P>
				<FONT face="����">
					<asp:Button id="btnDelete" runat="server" Text="Delete"></asp:Button>
				</FONT>
			</P>
		</form>
	</body>
</HTML>
