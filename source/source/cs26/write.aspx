<%@ Page language="c#" Codebehind="write.aspx.cs" AutoEventWireup="false" Inherits="board_cs.write" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>write</title> 
		<!--
* NEBOARD.net COM+ 버전 1.0
*
* 작성일 : 2003.10.02 
*          by noenemy
-->
		<LINK href="styles.css" rel="stylesheet">
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="write" method="post" runat="server" enctype="multipart/form-data">
			<center>
				<img src="images/title.gif" height="20" width="20" align="absMiddle"> &nbsp;&nbsp;<font size="3"><b><asp:Label id="lblBoardTitle" runat="server"></asp:Label></b></font>&nbsp;&nbsp;
				<br>
				<br>
				<table>
					<tr>
						<td bgcolor="#ffcc99">이름</td>
						<td><asp:textbox id="txtName" runat="server" Width="95px"></asp:textbox></td>
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
						<td><asp:textbox id="txtContent" runat="server" Width="418px" TextMode="MultiLine" Height="170px"></asp:textbox></td>
					</tr>
					<tr>
						<td bgcolor="#ffcc99">파일첨부</td>
						<td><INPUT id="File1" style="WIDTH: 367px; HEIGHT: 22px" type="file" size="42" name="File1" runat="server"></td>
					</tr>
					<tr>
						<td bgcolor="#ffcc99">비밀번호</td>
						<td><asp:textbox id="txtPassword" runat="server" TextMode="Password"></asp:textbox>
							<asp:Label id="lblMessage" runat="server" ForeColor="Red"></asp:Label></td>
					</tr>
				</table>
				<BR>
				<asp:button id="btnWrite" runat="server" Width="63px" Text="쓰기"></asp:button>
				<asp:button id="btnCancel" runat="server" Width="61px" Text="취소"></asp:button>
				<P></P>
				</FONT>
			</center>
		</form>
	</body>
</HTML>
