<%@ Page Language="vb" AutoEventWireup="false" Codebehind="3DText.aspx.vb" Inherits="wa_practice._3DText"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>_3DText</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">웹 서비스 활용 - Xara3DGraphicsGenerator </FONT>
			</P>
			<P><FONT face="굴림"> 글자체&nbsp;:
					<asp:DropDownList id="comFonts" runat="server"></asp:DropDownList>&nbsp;이미지포맷 :
					<asp:DropDownList id="comTypes" runat="server"></asp:DropDownList>&nbsp;템플릿 :
					<asp:DropDownList id="comTemplates" runat="server"></asp:DropDownList><BR>
					문자열 :
					<asp:TextBox id="txtText" runat="server" Width="316px"></asp:TextBox>
					<asp:Button id="btnGenerate" runat="server" Text="Generate!!"></asp:Button></FONT></P>
			<P><FONT face="굴림">
					<asp:Image id="img3D" runat="server"></asp:Image></P>
			</FONT><FONT face="굴림"></FONT>
		</form>
	</body>
</HTML>
