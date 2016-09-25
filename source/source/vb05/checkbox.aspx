<%@ Page Language="vb" AutoEventWireup="false" Codebehind="checkbox.aspx.vb" Inherits="html_control.checkbox" %>
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
				<FONT face="굴림">당신이 좋아하는 여자 연예인은?</FONT>
			</P>
			<P>
				<FONT face="굴림"><INPUT id="Checkbox1" type="checkbox" name="Checkbox1" runat="server" title="" value="on">
					전지현
					<BR>
					<INPUT id="Checkbox2" type="checkbox" name="Checkbox2" runat="server"> 이영애
					<BR>
				</FONT><FONT face="굴림"><INPUT id="Checkbox3" type="checkbox" name="Checkbox3" runat="server"></FONT>
				<FONT face="굴림">김현주</FONT>
			</P>
			<P>
				<INPUT id="Submit1" type="submit" value="Submit" name="Submit1" runat="server">
			</P>
		</form>
	</body>
</HTML>
