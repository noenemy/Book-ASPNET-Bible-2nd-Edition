<%@ OutputCache Duration="60" VaryByParam="country" %>
<%@ Page language="c#" Codebehind="output_cache4.aspx.cs" AutoEventWireup="false" Inherits="statemanage_cs.output_cache4" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>output_cache4</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="output_cache4" method="post" runat="server">
			<P><FONT face="����">Output Cache ���� 4 - VaryByParm �̿��ϱ�</FONT></P>
			<P>
				<asp:HyperLink id="HyperLink1" runat="server" NavigateUrl="output_cache4.aspx?country=UK">UK</asp:HyperLink><FONT face="����">&nbsp;</FONT>
				<asp:HyperLink id="HyperLink2" runat="server" NavigateUrl="output_cache4.aspx?country=USA">USA</asp:HyperLink><FONT face="����">&nbsp;</FONT>
				<asp:HyperLink id="HyperLink3" runat="server" NavigateUrl="output_cache4.aspx?country=Germany">Germany</asp:HyperLink></P>
			<P><FONT face="����">Country : </FONT>
				<asp:Label id="lblCountry" runat="server">Label</asp:Label><FONT face="����">&nbsp;&nbsp; 
					ĳ�ÿ� ����� �ð� :
					<asp:Label id="lblCachedTime" runat="server">Label</asp:Label></FONT></P>
			<P>
				<asp:DataGrid id="DataGrid1" runat="server"></asp:DataGrid></P>
		</form>
	</body>
</HTML>
