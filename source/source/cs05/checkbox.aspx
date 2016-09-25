<%@ Page language="c#" Codebehind="checkbox.aspx.cs" AutoEventWireup="false" Inherits="html_cs.checkbox" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>checkbox</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="checkbox" method="post" runat="server">
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
