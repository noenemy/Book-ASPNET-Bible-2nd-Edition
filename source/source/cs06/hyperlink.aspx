<%@ Page language="c#" Codebehind="hyperlink.aspx.cs" AutoEventWireup="false" Inherits="intrinsic_cs1.hyperlink" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="hyperlink" method="post" runat="server">
			<P>
				<FONT face="굴림">텍스트 링크 :
					<asp:HyperLink id="HyperLink1" runat="server" NavigateUrl="http://www.noenemy.pe.kr" Target="_blank">Noenemy's 
ASP.NET</asp:HyperLink>
				</FONT>
			</P>
			<P>
				<FONT face="굴림">이미지 링크 :
					<asp:HyperLink id="HyperLink2" runat="server" NavigateUrl="http://www.noenemy.pe.kr" Target="_blank" ImageUrl="images/top_banner.gif">HyperLink</asp:HyperLink>
				</FONT>
			</P>
		</form>
	</body>
</HTML>
