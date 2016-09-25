<%@ Page Language="vb" AutoEventWireup="false" Codebehind="delete.aspx.vb" Inherits="board_vb.delete"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>delete</title> 
		<!--
* NEBOARD.net COM+ 버전 1.0
*
* 작성일 : 2003.10.02 
*          by noenemy
-->
		<LINK href="styles.css" rel="stylesheet">
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<center><IMG height="20" src="images/title.gif" width="20" align="absMiddle"> &nbsp;&nbsp;<font size="3"><b><asp:label id="lblBoardTitle" runat="server"></asp:label></b></font>&nbsp;&nbsp;
				<br>
				<p><font color="darkslategray">게시판에 등록된 <b>
							<asp:label id="lblId" runat="server">Label</asp:label>번</b> 게시물을 삭제합니다.</font></p>
				<table cellSpacing="2" cellPadding="2" width="355" align="center" bgColor="#66cc66" border="0">
					<tr vAlign="center">
						<td>
							<table cellSpacing="0" cellPadding="2" width="350" align="center" bgColor="#f8f8f1" border="0">
								<tr>
									<td align="middle"><br>
										게시물 등록시에 사용한 비밀번호를 입력해 주세요.
										<br>
										<br>
										비밀번호 :
										<asp:textbox id="txtPassword" runat="server" TextMode="Password"></asp:textbox><br>
										<asp:label id="lblMessage" runat="server" ForeColor="Red"></asp:label><br>
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
				<br>
				<asp:button id="btnDelete" runat="server" Width="60px" Text="삭제하기"></asp:button>&nbsp;
				<INPUT id="btnCancel" style="WIDTH: 60px" onclick="javascript:history.back();" type="button" value="취소" name="btnCancel">
			</center>
		</form>
	</body>
</HTML>
