<%@ Page language="c#" Codebehind="use_event.aspx.cs" AutoEventWireup="false" Inherits="control_cs.use_event" %>
<%@ Register TagPrefix="uc1" TagName="menu" Src="menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="pagelet3" Src="pagelet3.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>use_event</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="use_event" method="post" runat="server">
			<P><FONT face="굴림">페이지릿 예제 - 이벤트 사용하기</FONT></P>
			<P>
				<table id="Table1">
					<tr>
						<td vAlign="top" width="180"><uc1:menu id="Menu1" runat="server"></uc1:menu></td>
						<td vAlign="top"><uc1:pagelet3 id="Pagelet31" runat="server"></uc1:pagelet3></td>
					</tr>
				</table>
		</form>
		</P>
	</body>
</HTML>
