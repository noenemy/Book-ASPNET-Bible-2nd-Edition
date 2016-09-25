<%@ Page language="c#" Codebehind="send_mail.aspx.cs" AutoEventWireup="false" Inherits="webmail_cs.send_mail" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>send_mail</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="send_mail" method="post" runat="server">
			<P><FONT face="굴림">메일보내기 예제 1</FONT></P>
			<P><FONT face="굴림">보내는사람 : </FONT>
				<asp:TextBox id="txtFrom" runat="server"></asp:TextBox><BR>
				<FONT face="굴림">받 는 사 람 : </FONT>
				<asp:TextBox id="txtTo" runat="server"></asp:TextBox><FONT face="굴림"><BR>
					제&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 목 :
					<asp:TextBox id="txtSubject" runat="server" Width="389px"></asp:TextBox><BR>
					내&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 용 :
					<asp:TextBox id="txtContent" runat="server" Height="138px" Width="390px" TextMode="MultiLine" Rows="10"></asp:TextBox></FONT></P>
			<P><FONT face="굴림">
					<asp:Button id="btnSend" runat="server" Text="메일보내기"></asp:Button></P>
			</FONT>
		</form>
	</body>
</HTML>
