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
			<P><FONT face="����">���Ϻ����� ���� 1</FONT></P>
			<P><FONT face="����">�����»�� : </FONT>
				<asp:TextBox id="txtFrom" runat="server"></asp:TextBox><BR>
				<FONT face="����">�� �� �� �� : </FONT>
				<asp:TextBox id="txtTo" runat="server"></asp:TextBox><FONT face="����"><BR>
					��&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; �� :
					<asp:TextBox id="txtSubject" runat="server" Width="389px"></asp:TextBox><BR>
					��&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; �� :
					<asp:TextBox id="txtContent" runat="server" Height="138px" Width="390px" TextMode="MultiLine" Rows="10"></asp:TextBox></FONT></P>
			<P><FONT face="����">
					<asp:Button id="btnSend" runat="server" Text="���Ϻ�����"></asp:Button></P>
			</FONT>
		</form>
	</body>
</HTML>
