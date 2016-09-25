<%@ Page Language="vb" AutoEventWireup="false" Codebehind="adrotator.aspx.vb" Inherits="richvb.adrotator" %>
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
				<FONT face="굴림">AdRotator 컨트롤 예제</FONT>
			</P>
			<FONT face="굴림">
				<P>
					키워드 :
					<asp:DropDownList id="comKeyword" runat="server">
						<asp:ListItem Selected="True">선택안함</asp:ListItem>
						<asp:ListItem Value="ASP">ASP</asp:ListItem>
						<asp:ListItem Value="ASP.NET">ASP.NET</asp:ListItem>
						<asp:ListItem Value="SQL">SQL</asp:ListItem>
					</asp:DropDownList>
					<asp:Button id="btnReload" runat="server" Text="Reload"></asp:Button>
				</P>
				<P>
					<asp:AdRotator id="AdRotator1" runat="server" AdvertisementFile="ads.xml"></asp:AdRotator>
				</P>
			</FONT>
		</form>
	</body>
</HTML>
