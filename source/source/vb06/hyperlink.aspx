<%@ Page Language="vb" AutoEventWireup="false" Codebehind="hyperlink.aspx.vb" Inherits="intrinsic_control.hyperlink" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<FONT face="굴림">텍스트 링크 :
					<asp:HyperLink id="HyperLink1" runat="server" Target="_blank" NavigateUrl="http://www.noenemy.pe.kr">Noenemy's ASP.NET</asp:HyperLink>
				</FONT>
			</P>
			<P>
				<FONT face="굴림">이미지 링크 :
					<asp:HyperLink id="HyperLink2" runat="server" Target="_blank" NavigateUrl="http://www.noenemy.pe.kr" ImageUrl="images/top_banner.gif">HyperLink</asp:HyperLink>
				</FONT>
			</P>
		</form>
	</body>
</HTML>
