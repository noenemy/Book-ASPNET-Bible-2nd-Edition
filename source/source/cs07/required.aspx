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
				<FONT face="굴림">Email&nbsp;:
					<asp:TextBox id="txtEmail" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email 주소를 입력하세요."></asp:RequiredFieldValidator>
				</FONT>
			</P>
			<P>
				<FONT face="굴림">취미&nbsp;:
					<asp:DropDownList id="comHobby" runat="server">
						<asp:ListItem Selected="True" Value="-- 선택 --">-- 선택 
--</asp:ListItem>
						<asp:ListItem Value="영화감상">영화감상</asp:ListItem>
						<asp:ListItem Value="음악감상">음악감상</asp:ListItem>
						<asp:ListItem Value="춤추기">춤추기</asp:ListItem>
					</asp:DropDownList>
					<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="comHobby" ErrorMessage="취미를 선택하세요." InitialValue="-- 선택 --"></asp:RequiredFieldValidator>
				</FONT>
			</P>
			<P>
				<FONT face="굴림">
					<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button>
			</P>
			</FONT>
		</form>
	</body>
</HTML>
