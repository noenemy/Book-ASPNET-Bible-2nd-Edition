<%@ Page language="c#" Codebehind="regular.aspx.cs" AutoEventWireup="false" Inherits="validation_cs.regular" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="regular" method="post" runat="server">
			<P>
				<FONT face="����">������ȣ�� �Է��ϼ���.</FONT>
			</P>
			<P>
				<asp:TextBox id="txtZipCode" runat="server" Width="100px"></asp:TextBox>
				<FONT face="����">&nbsp;��:123-456</FONT>
			</P>
			<P>
				<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button>
			</P>
			<P>
				<asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" ValidationExpression="\d{3}-\d{3}" ControlToValidate="txtZipCode" ErrorMessage="������ȣ ������ �ƴմϴ�."></asp:RegularExpressionValidator>
			</P>
		</form>
	</body>
</HTML>