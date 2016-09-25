<%@ Page language="c#" Codebehind="panel.aspx.cs" AutoEventWireup="false" Inherits="intrinsic_cs1.panel" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="panel" method="post" runat="server">
			<P>
				<asp:Panel id="Panel1" runat="server" HorizontalAlign="Center" BackColor="#FFFFC0" Height="138px" Width="228px">
					<FONT face="±¼¸²">
						<BR>
					</FONT>
					<asp:TextBox id="TextBox1" runat="server"></asp:TextBox>
					<FONT face="±¼¸²">
						<BR>
					</FONT>
					<asp:TextBox id="TextBox2" runat="server"></asp:TextBox>
				</asp:Panel>
			</P>
			<P>
				<asp:Button id="btnShow" runat="server" Text="º¸ÀÌ±â"></asp:Button>
				<asp:Button id="btnHide" runat="server" Text="¼û±â±â"></asp:Button>
				<asp:Button id="btnAdd" runat="server" Text="ÄÁÆ®·ÑÃß°¡"></asp:Button>
			</P>
		</form>
	</body>
</HTML>
