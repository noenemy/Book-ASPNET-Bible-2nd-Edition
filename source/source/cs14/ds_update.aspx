<%@ Page language="c#" Codebehind="ds_update.aspx.cs" AutoEventWireup="false" Inherits="adonet_cs.ds_update" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="ds_update" method="post" runat="server">
			<P>
				<FONT face="����">ADO.NET �Ϲ� -&nbsp;UPDATE (DataSet �̿�)</FONT>
			</P>
			<P>
				<FONT face="����">
					<BR>
					ID :
					<asp:textbox id="txtID" runat="server"></asp:textbox>
					&nbsp;
					<BR>
					Description :
					<asp:textbox id="txtDesc" runat="server"></asp:textbox>
				</FONT>
			</P>
			<P>
				<FONT face="����">
					<asp:button id="btnUpdate" runat="server" Text="Update"></asp:button>
				</FONT>
			</P>
		</form>
	</body>
</HTML>
