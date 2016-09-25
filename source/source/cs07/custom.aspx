<%@ Page language="c#" Codebehind="custom.aspx.cs" AutoEventWireup="false" Inherits="validation_cs.custom" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<script language="javascript">
function ClientValidate(source,args)
{
	var intInput = args.Value;
	// 입력한 값이 홀수인지 검사
	if (intInput % 2 == 1)
		args.IsValid = true;
	else
		args.IsValid = false;	

}
		</script>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="custom" method="post" runat="server">
			<P>
				<FONT face="굴림">홀수를 입력하세요.
					<BR>
					<asp:TextBox id="txtInput" runat="server"></asp:TextBox>
					<BR>
				</FONT><FONT face="굴림">
					<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button>
			</P>
			</FONT>
			<P>
				<FONT face="굴림">
					<asp:CustomValidator id="CustomValidator1" runat="server" OnServerValidate="ServerValidate" ClientValidationFunction="ClientValidate" ControlToValidate="txtInput" ErrorMessage="홀수가 아닙니다."></asp:CustomValidator>
			</P>
			</FONT>
		</form>
	</body>
</HTML>
