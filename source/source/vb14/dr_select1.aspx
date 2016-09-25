<%@ Page Language="vb" AutoEventWireup="false" Codebehind="dr_select1.aspx.vb" Inherits="adonet.dr_select1" %>
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
				<FONT face="굴림">ADO.NET 일반 - SELECT (DataReader이용)</FONT>
			</P>
			<P>
				<asp:DataGrid id="DataGrid1" runat="server"></asp:DataGrid>
			</P>
			<P>
				<FONT face="굴림">
					<asp:Button id="btnBind" runat="server" Text="Button"></asp:Button>
				</FONT>
			</P>
		</form>
	</body>
</HTML>
