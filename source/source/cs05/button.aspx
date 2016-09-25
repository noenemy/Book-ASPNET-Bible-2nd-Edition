<%@ Page language="c#" Codebehind="button.aspx.cs" AutoEventWireup="false" Inherits="html_cs.button" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
	<head>
		<title>button</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</head>
	<body MS_POSITIONING="GridLayout">
		<form id="button" method="post" runat="server">
			<P>
				텍스트버튼 : <button runat="server" id="button1" type="button">버튼입니다. </button>
			</P>
			<P>
				이미지버튼 : <button runat="server" id="button2" type="button"><img src="images/write.gif">
				</button>
			</P>		
		</form>
	</body>
</html>
