<%@ Page language="c#" Codebehind="delete.aspx.cs" AutoEventWireup="false" Inherits="board_cs.delete" %>

<!--
* NEBOARD.net COM+ 버전 1.0
*
* 작성일 : 2003.10.02 
*          by noenemy
-->

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>delete</title>
		<LINK href="styles.css" rel="stylesheet">
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="delete" method="post" runat="server">
			<center>
				<img src="images/title.gif" height="20" width="20" align="absMiddle"> &nbsp;&nbsp;<font size="3"><b><asp:Label id="lblBoardTitle" runat="server"></asp:Label></b></font>&nbsp;&nbsp;
				<br>
				<p><font color="darkslategray">게시판에 등록된 <b>
							<asp:Label id="lblId" runat="server">Label</asp:Label>번</b> 게시물을 삭제합니다.</font></p>
				<table border="0" align="center" width="355" bgcolor="#66cc66" cellpadding="2" cellspacing="2">
					<tr valign="center">
						<td>
							<table border="0" align="center" width="350" bgcolor="#f8f8f1" cellpadding="2" cellspacing="0">
								<tr>
									<td align="middle">
										<br>
										게시물 등록시에 사용한 비밀번호를 입력해 주세요.
										<br>
										<br>
										비밀번호 :
										<asp:TextBox id="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
										<br>
										<asp:Label id="lblMessage" runat="server" ForeColor="Red"></asp:Label><br>
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
				<br>
				<asp:Button id="btnDelete" runat="server" Text="삭제하기"></asp:Button>&nbsp; <INPUT type="button" id="btnCancel" name="btnCancel" Value="취소" onclick="javascript:history.back();" style="WIDTH:60px">
			</center>
		</form>
	</body>
</HTML>
