<%@ Page language="c#" Codebehind="edit.aspx.cs" AutoEventWireup="false" Inherits="board_cs.edit" %>

<!--
* NEBOARD.net COM+ 버전 1.0
*
* 작성일 : 2003.10.02 
*          by noenemy
-->

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>edit</title>
		<LINK href="styles.css" rel="stylesheet">
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="edit" method="post" runat="server" enctype="multipart/form-data">
			<center><IMG height="20" src="images/title.gif" width="20" align="absMiddle"> &nbsp;&nbsp;<font size="3"><b><asp:label id="lblBoardTitle" runat="server"></asp:label></b></font>&nbsp;&nbsp;
				<br>
				<br>
				<table>
					<TBODY>
						<tr>
							<td bgColor="#ffcc99">이름</td>
							<td><asp:textbox id="txtName" runat="server" Width="95px"></asp:textbox><INPUT id="hidOldFile" type="hidden" name="Hidden1" runat="server"></td>
						</tr>
						<tr>
							<td bgColor="#ffcc99">Email</td>
							<td><asp:textbox id="txtEmail" runat="server" Width="301px"></asp:textbox></td>
						</tr>
						<tr>
							<td bgColor="#ffcc99">제목</td>
							<td><asp:textbox id="txtSubject" runat="server" Width="418px"></asp:textbox></td>
						</tr>
						<tr>
							<td bgColor="#ffcc99">내용</td>
							<td><asp:textbox id="txtContent" runat="server" Width="418px" Height="170px" TextMode="MultiLine"></asp:textbox></td>
						</tr>
						<tr>
							<td bgColor="#ffcc99">파일첨부</td>
							<td><INPUT id="File1" style="WIDTH: 367px; HEIGHT: 22px" type="file" size="42" name="File1" runat="server"></td>
						</tr>
						<tr>
							<td bgColor="#ffcc99">비밀번호</td>
							<td><asp:textbox id="txtPassword" runat="server" TextMode="Password"></asp:textbox><FONT face="굴림">(작성시 
									입력했던 비밀번호)
									<asp:label id="lblMessage" runat="server" ForeColor="Red"></asp:label></FONT></td>
						</tr>
						<tr>
							<td align="middle" colSpan="2"><br>
								<asp:button id="btnEdit" runat="server" Width="60px" Text="수정하기"></asp:button>
								<INPUT type="button" id="btnCancel" name="btnCancel" Value="취소" onclick="javascript:history.back();" style="WIDTH:60px">
							</td>
						</tr>
					</TBODY>
				</table>
				<BR>
				<P></P>
				</FONT></center>
		</form>
		</TR></TBODY></TABLE>
		<CENTER></CENTER>
		</FORM>
	</body>
</HTML>
