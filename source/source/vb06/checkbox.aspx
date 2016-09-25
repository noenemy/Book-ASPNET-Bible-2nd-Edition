<%@ Page Language="vb" AutoEventWireup="false" Codebehind="checkbox.aspx.vb" Inherits="intrinsic_control.checkbox" %>
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
				<FONT face="굴림">당신의 관심분야를 선택하세요.
					<BR>
					<asp:CheckBox id="CheckBox1" runat="server" Text="웹프로그래밍"></asp:CheckBox>
					<BR>
					<asp:CheckBox id="CheckBox2" runat="server" Text="데이터베이스"></asp:CheckBox>
					<BR>
					<asp:CheckBox id="CheckBox3" runat="server" Text="시스템프로그래밍"></asp:CheckBox>
					<BR>
					<asp:CheckBox id="CheckBox4" runat="server" Text="운영체제"></asp:CheckBox>
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
