<%@ Page language="c#" Codebehind="send_attachfile.aspx.cs" AutoEventWireup="false" Inherits="webmail_cs.send_attachfile" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>send_attachfile</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server" enctype="multipart/form-data">
			<P><FONT face="����">���Ϻ����� ���� 2 - ����÷��</FONT></P>
			<P><FONT face="����">�����»�� : </FONT>
				<asp:textbox id="txtFrom" runat="server"></asp:textbox><BR>
				<FONT face="����">�� �� �� �� : </FONT>
				<asp:textbox id="txtTo" runat="server"></asp:textbox><FONT face="����"><BR>
					��&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; �� :
					<asp:textbox id="txtSubject" runat="server" Width="389px"></asp:textbox><BR>
					��&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; �� :
					<asp:textbox id="txtContent" runat="server" Width="390px" Height="138px" TextMode="MultiLine" Rows="10"></asp:textbox><BR>
					÷ �� �� �� : <INPUT type="file" id="File1" name="File1" runat="server"></FONT></P>
			<P><FONT face="����"><asp:button id="btnSend" runat="server" Text="���Ϻ�����"></asp:button></P>
			</FONT></form>
		</FORM>
	</body>
</HTML>
