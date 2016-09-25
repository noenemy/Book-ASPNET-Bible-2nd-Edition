<%@ Page language="c#" Codebehind="textbox.aspx.cs" AutoEventWireup="false" Inherits="intrinsic_cs1.textbox" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="textbox" method="post" runat="server">
			<P>
				<FONT face="굴림">사용자ID : </FONT>
				<asp:TextBox id="UserID" tabIndex="1" runat="server" MaxLength="10"></asp:TextBox>
				<BR>
				<FONT face="굴림">비밀번호 : </FONT>
				<asp:TextBox id="Password" tabIndex="3" runat="server" TextMode="Password" MaxLength="10"></asp:TextBox>
				<BR>
				<FONT face="굴림">자기소개 : </FONT>
				<asp:TextBox id="Introduction" tabIndex="2" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
			</P>
			<P>
				<asp:Button id="Button1" runat="server" Text="Button"></asp:Button>
			</P>
		</form>
	</body>
</HTML>
