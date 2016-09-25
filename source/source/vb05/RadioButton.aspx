<%@ Page Language="vb" AutoEventWireup="false" Codebehind="RadioButton.aspx.vb" Inherits="html_control.RadioButton" %>
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
				<FONT face="굴림">다음중 ASP.NET의 특징이 아닌것은?</FONT>
			</P>
			<P>
				<INPUT id="Radio1" type="radio" CHECKED value="Radio1" name="RadioGroup" runat="server"><FONT face="굴림">&nbsp;호출시마다 
					매번 컴파일된다.
					<BR>
				</FONT><INPUT id="Radio2" type="radio" value="Radio2" name="RadioGroup" runat="server"><FONT face="굴림">&nbsp;웹 
					팜 환경에서 Session 변수를 공유할 수 있다.
					<BR>
				</FONT><INPUT id="Radio3" type="radio" value="Radio3" name="RadioGroup" runat="server"><FONT face="굴림">&nbsp;.NET 
					플랫폼을 지원한다.
					<BR>
				</FONT><INPUT id="Radio4" type="radio" value="Radio4" name="RadioGroup" runat="server"><FONT face="굴림">&nbsp;OOP를 
					지원한다.</FONT>
			</P>
			<P>
				<INPUT id="Submit1" type="submit" value="Submit" name="Submit1" runat="server">
			</P>
		</form>
	</body>
</HTML>
