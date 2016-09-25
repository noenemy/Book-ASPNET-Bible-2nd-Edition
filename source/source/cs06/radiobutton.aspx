<%@ Page language="c#" Codebehind="radiobutton.aspx.cs" AutoEventWireup="false" Inherits="intrinsic_cs1.radiobutton" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="radiobutton" method="post" runat="server">
			<P>
				<FONT face="굴림">당신의 성별은?
					<BR>
					<asp:RadioButton id="RadioButton1" runat="server" Text="남"></asp:RadioButton>
					<asp:RadioButton id="RadioButton2" runat="server" Text="여"></asp:RadioButton>
				</FONT>
			</P>
			<P>
				<FONT face="굴림">당신의 직업은?
					<BR>
					<asp:RadioButton id="RadioButton3" runat="server" Text="학생" GroupName="job"></asp:RadioButton>
					<asp:RadioButton id="RadioButton4" runat="server" Text="직장인" GroupName="job"></asp:RadioButton>
					<asp:RadioButton id="RadioButton5" runat="server" Text="기타" GroupName="job"></asp:RadioButton>
				</FONT>
			</P>
			<P>
				<FONT face="굴림">
					<asp:Button id="Button1" runat="server" Text="Button"></asp:Button>
			</P>
			</FONT>
		</form>
	</body>
</HTML>
