<%@ Page language="c#" Codebehind="write.aspx.cs" AutoEventWireup="false" Inherits="guestbook_cs.write" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>write</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="write" method="post" runat="server">
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
			</FONT>
		</form>
	</body>
</HTML>
