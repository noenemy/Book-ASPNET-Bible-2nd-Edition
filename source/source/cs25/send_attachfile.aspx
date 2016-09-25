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
			<P><FONT face="굴림">메일보내기 예제 2 - 파일첨부</FONT></P>
			<P><FONT face="굴림">보내는사람 : </FONT>
				<asp:textbox id="txtFrom" runat="server"></asp:textbox><BR>
				<FONT face="굴림">받 는 사 람 : </FONT>
				<asp:textbox id="txtTo" runat="server"></asp:textbox><FONT face="굴림"><BR>
					제&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 목 :
					<asp:textbox id="txtSubject" runat="server" Width="389px"></asp:textbox><BR>
					내&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 용 :
					<asp:textbox id="txtContent" runat="server" Width="390px" Height="138px" TextMode="MultiLine" Rows="10"></asp:textbox><BR>
					첨 부 파 일 : <INPUT type="file" id="File1" name="File1" runat="server"></FONT></P>
			<P><FONT face="굴림"><asp:button id="btnSend" runat="server" Text="메일보내기"></asp:button></P>
			</FONT></form>
		</FORM>
	</body>
</HTML>
