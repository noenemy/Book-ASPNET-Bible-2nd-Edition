<%@ Page language="c#" Codebehind="schedule.aspx.cs" AutoEventWireup="false" Inherits="richcs.schedule" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>schedule</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="schedule" method="post" runat="server">
			<P><FONT face="±º∏≤">Calendar - ¿œ¡§«•</FONT></P>
			<P>
				<asp:Calendar id="Calendar1" runat="server" Width="500px" Font-Size="9px" ShowGridLines="True">
					<DayStyle Height="50px" VerticalAlign="Top"></DayStyle>
					<SelectedDayStyle BackColor="Navy"></SelectedDayStyle>
				</asp:Calendar></P>
		</form>
	</body>
</HTML>
