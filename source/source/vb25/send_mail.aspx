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
			<P><FONT face="����">���Ϻ����� ���� 1</FONT></P>
			<P><FONT face="����">�����»�� : </FONT>
				<asp:textbox id="txtFrom" runat="server"></asp:textbox><BR>
				<FONT face="����">�� �� �� �� : </FONT>
				<asp:textbox id="txtTo" runat="server"></asp:textbox><FONT face="����"><BR>
					��&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; �� :
					<asp:textbox id="txtSubject" runat="server" Width="389px"></asp:textbox><BR>
					��&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; �� :
					<asp:textbox id="txtContent" runat="server" Width="390px" Height="138px" TextMode="MultiLine" Rows="10"></asp:textbox></FONT></P>
			<P><FONT face="����"><asp:button id="btnSend" runat="server" Text="���Ϻ�����"></asp:button></P>
			</FONT></form>
	</body>
</HTML>
