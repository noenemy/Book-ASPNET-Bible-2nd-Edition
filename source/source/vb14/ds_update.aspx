<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ds_update.aspx.vb" Inherits="adonet.ds_update" %>
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
				<FONT face="±¼¸²">ADO.NET ÀÏ¹Ý -&nbsp;UPDATE (DataSet ÀÌ¿ë)</FONT>
			</P>
			<P>
				<FONT face="±¼¸²">
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
				<FONT face="±¼¸²">
					<asp:button id="btnUpdate" runat="server" Text="Update"></asp:button>
				</FONT>
			</P>
		</form>
	</body>
</HTML>
