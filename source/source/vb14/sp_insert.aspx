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
				<FONT face="굴림">ADO.NET&nbsp;저장프로시저 사용하기&nbsp;-&nbsp;INSERT
					<BR>
					(output parameter 사용하기)</FONT>&nbsp;
			</P>
			<P>
				<FONT face="굴림">회사명 :</FONT>&nbsp; <FONT face="굴림"></FONT>
				<asp:TextBox id="txtCompany" runat="server"></asp:TextBox>
				<BR>
				<FONT face="굴림">전화번호 : </FONT>
				<asp:TextBox id="txtPhone" runat="server"></asp:TextBox>
				<FONT face="굴림">&nbsp;
					<asp:Button id="Button1" runat="server" Text="Insert"></asp:Button>
					<BR>
				</FONT>
			</P>
		</form>
	</body>
</HTML>
