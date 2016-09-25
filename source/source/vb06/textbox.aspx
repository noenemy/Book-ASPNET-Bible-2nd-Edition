<%@ Page Language="vb" AutoEventWireup="false" Codebehind="textbox.aspx.vb" Inherits="intrinsic_control.textbox" %>
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
				<FONT face="굴림">사용자ID : </FONT>
				<asp:TextBox id="UserID" tabIndex="1" runat="server" MaxLength="10"></asp:TextBox>
				<FONT face="굴림">
					<BR>
					비밀번호 :
					<asp:TextBox id="Password" tabIndex="3" runat="server" MaxLength="10" TextMode="Password"></asp:TextBox>
					<BR>
					나의소개 :
					<asp:TextBox id="Introduction" tabIndex="2" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox>
				</FONT>
			</P>
			<P>
				<FONT face="굴림">
					<asp:Button id="Button1" runat="server" Text="Button"></asp:Button>
			</P>
			</FONT>
		</form>
	</body>
</HTML>
