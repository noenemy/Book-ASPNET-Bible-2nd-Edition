<%@ Page Language="vb" AutoEventWireup="false" Codebehind="custom.aspx.vb" Inherits="validation_control.custom" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<script language="javascript">
function ClientValidate(source,args)
{
	var intInput = args.Value;
	// �Է��� ���� Ȧ������ �˻�
	if (intInput % 2 == 1)
		args.IsValid = true;
	else
		args.IsValid = false;	

}
		</script>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<FONT face="����">Ȧ���� �Է��ϼ���.
					<BR>
					<asp:TextBox id="txtInput" runat="server"></asp:TextBox>
					<BR>
				</FONT><FONT face="����">
					<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button>
			</P>
			</FONT>
			<P>
				<FONT face="����">
					<asp:CustomValidator id="CustomValidator1" runat="server" ErrorMessage="Ȧ���� �ƴմϴ�." ControlToValidate="txtInput" ClientValidationFunction="ClientValidate" OnServerValidate="ServerValidate"></asp:CustomValidator>
			</P>
			</FONT>
		</form>
	</body>
</HTML>
