<%@ Page Language="vb" AutoEventWireup="false" Codebehind="passport_hello.aspx.vb" Inherits="security_vb.passport_hello"%>
<%@ Register TagPrefix="uc1" TagName="passport_control" Src="passport_control.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>passport_hello</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림">Passport 인증
					<uc1:passport_control id="Passport_control1" runat="server"></uc1:passport_control></FONT></P>
			<P><FONT face="굴림">
					<asp:Panel id="Panel1" runat="server" Width="309px" Height="138px">이름 : 
<asp:TextBox id="txtName" runat="server"></asp:TextBox><BR>email: 
<asp:TextBox id="txtEmail" runat="server"></asp:TextBox><BR>성별 : 
<asp:TextBox id="txtGender" runat="server"></asp:TextBox><BR>국가 : 
<asp:TextBox id="txtCountry" runat="server"></asp:TextBox><BR>지역 : 
<asp:TextBox id="txtRegion" runat="server"></asp:TextBox></asp:Panel></P>
			</FONT>
		</form>
	</body>
</HTML>
