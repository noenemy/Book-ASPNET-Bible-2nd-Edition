<%@ Page language="c#" Codebehind="edit.aspx.cs" AutoEventWireup="false" Inherits="guestbook_cs.edit" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>edit</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="edit" method="post" runat="server">
			<P><FONT face="����"><STRONG>ASP.NET ���� - ����</STRONG></FONT></P>
			<table>
				<tr>
					<td>�̸�</td>
					<td><asp:textbox id="txtName" runat="server" Width="95px"></asp:textbox></td>
				</tr>
				<tr>
					<td>Email</td>
					<td><asp:textbox id="txtEmail" runat="server" Width="301px"></asp:textbox></td>
				</tr>
				<tr>
					<td>����</td>
					<td><asp:textbox id="txtContent" runat="server" Width="418px" TextMode="MultiLine" Height="170px"></asp:textbox></td>
				</tr>
				<tr>
					<td>��й�ȣ</td>
					<td><asp:textbox id="txtPassword" runat="server" TextMode="Password"></asp:textbox><FONT face="����">(�ۼ��� 
							�Է��� ��й�ȣ �Է�)</FONT></td>
				</tr>
			</table>
			<FONT face="����">
				<BR>
			</FONT>
			<asp:button id="btnUpdate" runat="server" Width="63px" Text="����"></asp:button><asp:button id="btnCancel" runat="server" Width="61px" Text="���"></asp:button>
			<P><FONT face="����"></FONT></P>
			</FONT>
		</form>
	</body>
</HTML>
