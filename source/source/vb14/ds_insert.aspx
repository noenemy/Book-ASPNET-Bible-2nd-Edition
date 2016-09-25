<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ds_insert.aspx.vb" Inherits="adonet.ds_insert" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<FONT face="±¼¸²">ADO.NET ÀÏ¹Ý -&nbsp;INSERT (DataSet ÀÌ¿ë)</FONT>
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
					<asp:button id="btnInsert" runat="server" Text="Insert"></asp:button>
				</FONT>
			</P>
		</form>
	</body>
</HTML>
