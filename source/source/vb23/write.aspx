<%@ Page Language="vb" AutoEventWireup="false" Codebehind="write.aspx.vb" Inherits="guestbook_vb.write"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>write</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림"><STRONG>ASP.NET 방명록 - 쓰기</STRONG></FONT></P>
			<table>
				<tr>
					<td>이름</td>
					<td><asp:textbox id="txtName" runat="server" Width="95px"></asp:textbox></td>
				</tr>
				<tr>
					<td>Email</td>
					<td><asp:textbox id="txtEmail" runat="server" Width="301px"></asp:textbox></td>
				</tr>
				<tr>
					<td>내용</td>
					<td><asp:textbox id="txtContent" runat="server" Width="418px" Height="170px" TextMode="MultiLine"></asp:textbox></td>
				</tr>
				<tr>
					<td>비밀번호</td>
					<td><asp:textbox id="txtPassword" runat="server" TextMode="Password"></asp:textbox></td>
				</tr>
			</table>
			<FONT face="굴림">
				<BR>
			</FONT>
			<asp:button id="btnWrite" runat="server" Text="쓰기" Width="63px"></asp:button><asp:button id="btnCancel" runat="server" Text="취소" Width="61px"></asp:button>
			<P><FONT face="굴림"></FONT></P>
			</FONT></form>
	</body>
</HTML>
