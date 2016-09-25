<%@ Page Language="vb" AutoEventWireup="false" Codebehind="calendar.aspx.vb" Inherits="richvb.calendar" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<FONT face="±¼¸²">Calendar ¿¹Á¦</FONT>
			</P>
			<P>
				<FONT face="±¼¸²">SelectionMode
					<asp:DropDownList id="comSelectionMode" runat="server" AutoPostBack="True">
						<asp:ListItem Value="None">None</asp:ListItem>
						<asp:ListItem Value="Day">Day</asp:ListItem>
						<asp:ListItem Value="DayWeek">DayWeek</asp:ListItem>
						<asp:ListItem Value="DayWeekMonth">DayWeekMonth</asp:ListItem>
					</asp:DropDownList>
				</FONT>
			</P>
			<P>
				<asp:Calendar id="Calendar1" runat="server"></asp:Calendar>
			</P>
		</form>
	</body>
</HTML>
