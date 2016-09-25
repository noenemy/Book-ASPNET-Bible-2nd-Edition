<%@ Page Language="vb" AutoEventWireup="false" Codebehind="select_format.aspx.vb" Inherits="webmail.select_format"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>select_format</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">메일보내기 예제 3 - 형식선택하기</FONT></P>
			<P><FONT face="굴림">보내는사람 : </FONT>
				<asp:textbox id="txtFrom" runat="server"></asp:textbox><BR>
				<FONT face="굴림">받 는 사 람 : </FONT>
				<asp:textbox id="txtTo" runat="server"></asp:textbox><FONT face="굴림"><BR>
					제&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 목 :
					<asp:textbox id="txtSubject" runat="server" Width="389px"></asp:textbox><BR>
					내&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 용 :
					<asp:textbox id="txtContent" runat="server" Width="390px" Height="138px" TextMode="MultiLine" Rows="10"></asp:textbox><BR>
					메 일 형 식 :
					<asp:RadioButton id="optText" runat="server" Text="TEXT 형식" GroupName="format" Checked="True"></asp:RadioButton>
					<asp:RadioButton id="optHtml" runat="server" Text="HTML 형식" GroupName="format"></asp:RadioButton></FONT></P>
			<P><FONT face="굴림"><asp:button id="btnSend" runat="server" Text="메일보내기"></asp:button></P>
			</FONT></form>
		</FORM>
	</body>
</HTML>
