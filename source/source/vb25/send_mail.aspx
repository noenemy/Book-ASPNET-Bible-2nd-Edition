<%@ Page Language="vb" AutoEventWireup="false" Codebehind="send_mail.aspx.vb" Inherits="webmail.send_mail"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>send_mail</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">메일보내기 예제 1</FONT></P>
			<P><FONT face="굴림">보내는사람 : </FONT>
				<asp:textbox id="txtFrom" runat="server"></asp:textbox><BR>
				<FONT face="굴림">받 는 사 람 : </FONT>
				<asp:textbox id="txtTo" runat="server"></asp:textbox><FONT face="굴림"><BR>
					제&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 목 :
					<asp:textbox id="txtSubject" runat="server" Width="389px"></asp:textbox><BR>
					내&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 용 :
					<asp:textbox id="txtContent" runat="server" Width="390px" Height="138px" TextMode="MultiLine" Rows="10"></asp:textbox></FONT></P>
			<P><FONT face="굴림"><asp:button id="btnSend" runat="server" Text="메일보내기"></asp:button></P>
			</FONT></form>
	</body>
</HTML>
