<%@ Page Language="vb" AutoEventWireup="false" Codebehind="test.aspx.vb" Inherits="validation_control.test" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<script language="javascript">
function ClientValidate(source,args)
{
	var intInput = args.Value;
	if (intInput % 2 == 1)
		args.IsValid = true;
	else
		args.IsValid = false;	

}

	</script>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<FONT face="±¼¸²">È¦¼ö¸¦ ÀÔ·ÂÇÏ¼¼¿°.</FONT>
			</P>
			<P>
				<FONT face="±¼¸²">Å¬¶óÀÌ¾ðÆ® : </FONT>
				<asp:TextBox id="TextBox1" runat="server"></asp:TextBox>
			</P>
			<P>
				<FONT face="±¼¸²">¼­¹ö : </FONT>
				<asp:TextBox id="TextBox2" runat="server"></asp:TextBox>
			</P>
			<P>
				<asp:Button id="Button1" runat="server" Text="Button"></asp:Button>
			</P>
			<P>
				<asp:CustomValidator id="CustomValidator2" runat="server" ErrorMessage="Å¬¶óÀÌ¾ðÆ® : È¦¼ö¾Æ´Ô" ControlToValidate="TextBox1" ClientValidationFunction="ClientValidate"></asp:CustomValidator>
				<asp:CustomValidator id="CustomValidator1" runat="server" ErrorMessage="¼­¹ö : È¦¼ö ¾Æ´Ô" ControlToValidate="TextBox2" OnServerValidate="ServerValidate"></asp:CustomValidator>
			</P>
		</form>
	</body>
</HTML>
