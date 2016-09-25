<%@ Page language="c#" Codebehind="Textarea.aspx.cs" AutoEventWireup="false" Inherits="html_cs.Textarea" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Textarea</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Textarea" method="post" runat="server">
			<P>
				soft : <TEXTAREA id="TEXTAREA1" name="TEXTAREA1" rows="2" cols="20" runat="server" wrap="soft">
				</TEXTAREA>
			</P>
			<P>
				hard : <TEXTAREA id="TEXTAREA2" name="TEXTAREA2" rows="2" wrap="hard" cols="20" runat="server">
				</TEXTAREA>
			</P>
			<P>
				off :<TEXTAREA id="TEXTAREA3" name="TEXTAREA3" rows="2" wrap="off" cols="20" runat="server"></TEXTAREA>
			</P>
			<P>
				<asp:Button id="Button1" runat="server" Text="Button"></asp:Button>
			</P>
			<P>
			</P>
			soft :
			<br>
			<pre><%=Request.Form("TEXTAREA1")%></pre>
			<hr>
			hard :
			<br>
			<pre><%=Request.Form("TEXTAREA2")%></pre>
			<hr>
			off :
			<br>
			<pre><%=Request.Form("TEXTAREA3")%></pre>		
		</form>
	</body>
</HTML>
