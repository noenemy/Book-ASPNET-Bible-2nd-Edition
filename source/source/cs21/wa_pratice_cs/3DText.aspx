<%@ Page language="c#" Codebehind="3DText.aspx.cs" AutoEventWireup="false" Inherits="wa_pratice_cs.Form1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>3DText</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="����">�� ���� Ȱ�� - Xara3DGraphicsGenerator </FONT>
			</P>
			<P><FONT face="����"> ����ü&nbsp;:
					<asp:DropDownList id="comFonts" runat="server"></asp:DropDownList>&nbsp;�̹������� :
					<asp:DropDownList id="comTypes" runat="server"></asp:DropDownList>&nbsp;���ø� :
					<asp:DropDownList id="comTemplates" runat="server"></asp:DropDownList><BR>
					���ڿ� :
					<asp:TextBox id="txtText" runat="server" Width="316px"></asp:TextBox>
					<asp:Button id="btnGenerate" runat="server" Text="Generate!!"></asp:Button></FONT></P>
			<P><FONT face="����">
					<asp:Image id="img3D" runat="server"></asp:Image></P>
			</FONT><FONT face="����"></FONT>
		</form>
	</body>
</HTML>
