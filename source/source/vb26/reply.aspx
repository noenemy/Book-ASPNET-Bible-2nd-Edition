<%@ Page Language="vb" AutoEventWireup="false" Codebehind="reply.aspx.vb" Inherits="board_vb.reply"%>

<!--
* NEBOARD.net COM+ 버전 1.0
*
* 작성일 : 2003.10.02 
*          by noenemy
-->

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>reply</title>
		<LINK href="styles.css" rel="stylesheet">
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" encType="multipart/form-data" runat="server">
			<center><IMG height="20" src="images/title.gif" width="20" align="absMiddle"> &nbsp;&nbsp;<font size="3"><b><asp:label id="lblBoardTitle" runat="server"></asp:label></b></font>&nbsp;&nbsp;
				<br>
				<br>
				<table>
					<tr>
						<td bgcolor="#ffcc99">이름</td>
						<td><asp:textbox id="txtName" runat="server" Width="95px"></asp:textbox>
							<INPUT id="hid_depth" type="hidden" name="Hidden2" runat="server"></td>
					</tr>
					<tr>
						<td bgcolor="#ffcc99">Email</td>
						<td><asp:textbox id="txtEmail" runat="server" Width="301px"></asp:textbox></td>
					</tr>
					<tr>
						<td bgcolor="#ffcc99">제목</td>
						<td><asp:textbox id="txtSubject" runat="server" Width="418px"></asp:textbox></td>
					</tr>
					<tr>
						<td bgcolor="#ffcc99">내용</td>
						<td><asp:textbox id="txtContent" runat="server" Width="418px" Height="170px" TextMode="MultiLine"></asp:textbox></td>
					</tr>
					<tr>
						<td bgcolor="#ffcc99">파일첨부</td>
						<td><INPUT id="File1" style="WIDTH: 367px; HEIGHT: 22px" type="file" size="42" name="File1" runat="server"></td>
					</tr>
					<tr>
						<td bgcolor="#ffcc99">비밀번호</td>
						<td><asp:textbox id="txtPassword" runat="server" TextMode="Password"></asp:textbox><asp:label id="lblMessage" runat="server" ForeColor="Red"></asp:label></td>
					</tr>
				</table>
				<FONT face="굴림">
					<BR>
				</FONT>
				<asp:button id="btnReply" runat="server" Width="60px" Text="답변하기"></asp:button>
				<INPUT type="button" id="btnCancel" name="btnCancel" Value="취소" onclick="javascript:history.back();" style="WIDTH:60px">
				<P><FONT face="굴림"></FONT></P>
				</FONT></center>
		</form>
	</body>
</HTML>
