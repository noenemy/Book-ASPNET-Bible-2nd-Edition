<%@ Page Language="vb" AutoEventWireup="false" Codebehind="use_event.aspx.vb" Inherits="control.use_event"%>
<%@ Register TagPrefix="uc1" TagName="menu" Src="menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="pagelet3" Src="pagelet3.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>use_event</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">페이지릿 예제 - 이벤트 사용하기</FONT></P>
			<P>
				<table>
					<tr>
						<td valign="top" width="180"><uc1:menu id="Menu1" runat="server"></uc1:menu></td>
						<td valign="top"><uc1:pagelet3 id="Pagelet31" runat="server"></uc1:pagelet3></td>
					</tr>
				</table>
		</form>
		</P>
	</body>
</HTML>
