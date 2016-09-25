<%@ Page Language="vb" AutoEventWireup="false" Codebehind="schedule.aspx.vb" Inherits="richvb.schedule"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>schedule</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="±º∏≤">Calendar - ¿œ¡§«•</FONT></P>
			<P>
				<asp:Calendar id="Calendar1" runat="server" Width="500px" Font-Size="9px" ShowGridLines="True">
					<DayStyle Height="50px" VerticalAlign="Top"></DayStyle>
					<SelectedDayStyle BackColor="Navy"></SelectedDayStyle>
				</asp:Calendar></P>
		</form>
	</body>
</HTML>
