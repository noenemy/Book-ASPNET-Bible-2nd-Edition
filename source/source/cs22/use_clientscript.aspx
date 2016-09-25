<%@ Page language="c#" Codebehind="use_clientscript.aspx.cs" AutoEventWireup="false" Inherits="tiptech_cs.use_clientscript" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>use_clientscript</title>
		<script language="javascript">
function Test()
{
 if (confirm("처리할까요?"))
  return true;
 else
  return false;
}
		</script>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="use_clientscript" method="post" runat="server">
			<P><FONT face="굴림">클라이언트 스크립트 사용하기</FONT></P>
			<P>
				<asp:TextBox id="TextBox1" runat="server"></asp:TextBox>
				<asp:Button id="Button1" runat="server" Text="Button"></asp:Button></P>
			<P>
				<asp:Label id="Label1" runat="server">Label</asp:Label></P>
		</form>
	</body>
</HTML>
