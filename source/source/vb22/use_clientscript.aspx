<%@ Page Language="vb" AutoEventWireup="false" Codebehind="use_clientscript.aspx.vb" Inherits="tiptech_vb.use_clientscript"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>use_clientscript</title>
		<script language="javascript">
function Test()
{
 if (confirm("ó���ұ��?"))
  return true;
 else
  return false;
}
		</script>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="����">Ŭ���̾�Ʈ ��ũ��Ʈ ����ϱ�</FONT></P>
			<P>
				<asp:TextBox id="TextBox1" runat="server"></asp:TextBox>
				<asp:Button id="Button1" runat="server" Text="Button"></asp:Button></P>
			<P>
				<asp:Label id="Label1" runat="server">Label</asp:Label></P>
		</form>
	</body>
</HTML>
