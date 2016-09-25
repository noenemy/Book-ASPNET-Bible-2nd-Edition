<%@ Page language="c#" Codebehind="expression.aspx.cs" AutoEventWireup="false" Inherits="databinding_cs.expression" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>expression</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="expression" method="post" runat="server">
			<P><FONT face="굴림">Expression 데이터바인딩</FONT></P>
			<P><FONT face="굴림"> 텍스트1&nbsp;:
					<asp:TextBox id="TextBox1" runat="server"></asp:TextBox><BR>
					텍스트2&nbsp;:
					<asp:TextBox id="TextBox2" runat="server"></asp:TextBox></FONT></P>
			<P>
				<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button></P>
			<P>
				<asp:Label id=lblMessage runat="server" Text="<%# TextBox1.Text + TextBox2.Text %>">
				</asp:Label></P>
		</form>
	</body>
</HTML>
