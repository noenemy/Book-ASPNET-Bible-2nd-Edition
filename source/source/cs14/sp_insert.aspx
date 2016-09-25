<%@ Page language="c#" Codebehind="sp_insert.aspx.cs" AutoEventWireup="false" Inherits="adonet_cs.sp_insert" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="sp_insert" method="post" runat="server">
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
