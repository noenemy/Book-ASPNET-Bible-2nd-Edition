<%@ Page Language="vb" AutoEventWireup="false" Codebehind="sp_insert.aspx.vb" Inherits="adonet.sp_insert" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<FONT face="����">ADO.NET&nbsp;�������ν��� ����ϱ�&nbsp;-&nbsp;INSERT
					<BR>
					(output parameter ����ϱ�)</FONT>&nbsp;
			</P>
			<P>
				<FONT face="����">ȸ��� :</FONT>&nbsp; <FONT face="����"></FONT>
				<asp:TextBox id="txtCompany" runat="server"></asp:TextBox>
				<BR>
				<FONT face="����">��ȭ��ȣ : </FONT>
				<asp:TextBox id="txtPhone" runat="server"></asp:TextBox>
				<FONT face="����">&nbsp;
					<asp:Button id="Button1" runat="server" Text="Insert"></asp:Button>
					<BR>
				</FONT>
			</P>
		</form>
	</body>
</HTML>
