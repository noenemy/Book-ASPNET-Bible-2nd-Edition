<%@ Page Language="vb" AutoEventWireup="false" Codebehind="delete.aspx.vb" Inherits="guestbook_vb.delete"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>delete</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림"><STRONG>ASP.NET 방명록 - 삭제</STRONG></FONT></P>
			<table>
				<tr>
					<td colSpan="2"><font size="2"><asp:label id="lblId" runat="server">Label</asp:label>번 
							게시물을 삭제합니다. 비밀번호를 입력하세요.</font>
					</td>
				</tr>
				<tr>
					<td>비밀번호 :
						<asp:textbox id="txtPassword" runat="server" TextMode="Password"></asp:textbox><FONT face="굴림"></FONT></td>
				</tr>
			</table>
			<FONT face="굴림">
				<BR>
			</FONT>
			<asp:button id="btnDelete" runat="server" Width="63px" Text="삭제"></asp:button><asp:button id="btnCancel" runat="server" Width="61px" Text="취소"></asp:button>
			<P><FONT face="굴림"></FONT></P>
			</FONT></form>
	</body>
</HTML>
