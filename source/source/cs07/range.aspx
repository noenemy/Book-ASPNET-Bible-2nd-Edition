<%@ Page language="c#" Codebehind="range.aspx.cs" AutoEventWireup="false" Inherits="validation_cs.range" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="range" method="post" runat="server">
			<P>
				<FONT face="����">����� �¾ ��(��)�� �����Դϱ�?</FONT>
			</P>
			<P>
				<asp:TextBox id="txtMonth" runat="server" Width="50px"></asp:TextBox>
				<FONT face="����">��</FONT>
			</P>
			<P>
				<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button>
			</P>
			<P>
				<asp:RangeValidator id="RangeValidator1" runat="server" Type="Integer" MinimumValue="1" MaximumValue="12" ControlToValidate="txtMonth" ErrorMessage="1-12������ ���ڸ� �Է��ϼ���."></asp:RangeValidator>
			</P>
		</form>
	</body>
</HTML>
