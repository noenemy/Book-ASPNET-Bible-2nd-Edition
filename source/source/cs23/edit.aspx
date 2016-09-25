<%@ Page language="c#" Codebehind="edit.aspx.cs" AutoEventWireup="false" Inherits="guestbook_cs.edit" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>edit</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="edit" method="post" runat="server">
			<P><FONT face="굴림"><STRONG>ASP.NET 방명록 - 수정</STRONG></FONT></P>
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
					<td><asp:textbox id="txtContent" runat="server" Width="418px" TextMode="MultiLine" Height="170px"></asp:textbox></td>
				</tr>
				<tr>
					<td>비밀번호</td>
					<td><asp:textbox id="txtPassword" runat="server" TextMode="Password"></asp:textbox><FONT face="굴림">(작성시 
							입력한 비밀번호 입력)</FONT></td>
				</tr>
			</table>
			<FONT face="굴림">
				<BR>
			</FONT>
			<asp:button id="btnUpdate" runat="server" Width="63px" Text="수정"></asp:button><asp:button id="btnCancel" runat="server" Width="61px" Text="취소"></asp:button>
			<P><FONT face="굴림"></FONT></P>
			</FONT>
		</form>
	</body>
</HTML>
