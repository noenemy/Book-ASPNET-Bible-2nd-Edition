<%@ Page language="c#" Codebehind="show.aspx.cs" AutoEventWireup="false" Inherits="board_cs.show" %>

<!--
* NEBOARD.net COM+ 버전 1.0
*
* 작성일 : 2003.10.02 
*          by noenemy
-->

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>show</title>
		<LINK href="styles.css" rel="stylesheet">
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="show" method="post" runat="server">
			<center><IMG height="20" src="images/title.gif" width="20" align="absMiddle"> &nbsp;&nbsp;<font size="3"><b><asp:label id="lblBoardTitle" runat="server"></asp:label></b></font>&nbsp;&nbsp;
				<br>
				<table cellSpacing="0" cellPadding="2" width="600" border="0">
					<tr>
						<td><br>
							<b>[작성자:<asp:hyperlink id="lnkWriter" runat="server">HyperLink</asp:hyperlink>]</b>
							<asp:label id="lblRegDate" runat="server">Label</asp:label>에 남기신 글입니다.
						</td>
					</tr>
					<tr bgColor="black" height="2">
						<td colSpan="7"></td>
					</tr>
					<tr>
						<td align="middle" bgColor="#99ff66" height="20"><b><asp:label id="lblSubject" runat="server">Label</asp:label></b></td>
					</tr>
					<tr bgColor="black" height="2">
						<td colSpan="7"></td>
					</tr>
					<tr>
						<td bgColor="#ccffff"><br>
							<asp:label id="lblContent" runat="server">Label</asp:label></td>
					</tr>
					<tr>
						<td align="right" bgColor="#ccffff"><br>
							<asp:label id="lblFile" runat="server">Label</asp:label><br>
						</td>
					</tr>
					<tr>
						<td align="middle"><FONT face="굴림"><BR>
							</FONT>
							<asp:hyperlink id="lnkReply" runat="server" ImageUrl="images/reply.gif">HyperLink</asp:hyperlink><asp:hyperlink id="lnkList" runat="server" ImageUrl="images/list.gif">HyperLink</asp:hyperlink><asp:hyperlink id="lnkEdit" runat="server" ImageUrl="images/edit.gif">HyperLink</asp:hyperlink><asp:hyperlink id="lnkDelete" runat="server" ImageUrl="images/delete.gif">HyperLink</asp:hyperlink></td>
					</tr>
				</table>
			</center>
		</form>
	</body>
</HTML>
