<%@ Page language="c#" Codebehind="required.aspx.cs" AutoEventWireup="false" Inherits="validation_cs.required" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="required" method="post" runat="server">
			<P>
				<FONT face="����">Email&nbsp;:
					<asp:TextBox id="txtEmail" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email �ּҸ� �Է��ϼ���."></asp:RequiredFieldValidator>
				</FONT>
			</P>
			<P>
				<FONT face="����">���&nbsp;:
					<asp:DropDownList id="comHobby" runat="server">
						<asp:ListItem Selected="True" Value="-- ���� --">-- ���� 
--</asp:ListItem>
						<asp:ListItem Value="��ȭ����">��ȭ����</asp:ListItem>
						<asp:ListItem Value="���ǰ���">���ǰ���</asp:ListItem>
						<asp:ListItem Value="���߱�">���߱�</asp:ListItem>
					</asp:DropDownList>
					<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="comHobby" ErrorMessage="��̸� �����ϼ���." InitialValue="-- ���� --"></asp:RequiredFieldValidator>
				</FONT>
			</P>
			<P>
				<FONT face="����">
					<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button>
			</P>
			</FONT>
		</form>
	</body>
</HTML>
