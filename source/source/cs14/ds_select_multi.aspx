<%@ Page language="c#" Codebehind="ds_select_multi.aspx.cs" AutoEventWireup="false" Inherits="adonet_cs.ds_select_multi" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="ds_select_multi" method="post" runat="server">
			<P>
				<FONT face="굴림">ADO.NET 일반 - SELECT (DataSet에 여러 테이블 담기)</FONT>
			</P>
			<P>
				<asp:DataGrid id="DataGrid1" runat="server"></asp:DataGrid>
			</P>
			<P>
				<asp:DataGrid id="DataGrid2" runat="server"></asp:DataGrid>
			</P>
			<P>
				<FONT face="굴림">
					<asp:Button id="btnBind" runat="server" Text="Button"></asp:Button>
				</FONT>
			</P>
		</form>
	</body>
</HTML>
