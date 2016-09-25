<%@ Page Language="vb" AutoEventWireup="false" Codebehind="repeater.aspx.vb" Inherits="list_control2.repeater" %>
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
				<FONT face="굴림">Repeater를 이용한 상품목록예제</FONT>
			</P>
			<P>
				<asp:Repeater id="Repeater1" runat="server" DataSource="<%# DsProduct1 %>">
					<HEADERTEMPLATE>
						<TABLE>
					</HEADERTEMPLATE>
					<ITEMTEMPLATE>
						<TBODY>
							<TR>
								<TD>
									<asp:Image id="Image1" runat="server" imageurl='<%# Container.DataItem("image")%>'>
									</asp:Image>
								</TD>
								<TD>
									<FONT size="2">제품명 :
										<%# Container.DataItem("product_name")%>
										<BR>
										제조사 :
										<%# Container.DataItem("vender")%>
										<BR>
										가 격 :
										<%# FormatNumber(Container.DataItem("price"),0)%>
										원
										<BR>
										<%# Container.DataItem("spec")%>
										<BR>
									</FONT>
								</TD>
							</TR>
					</ITEMTEMPLATE>
					<SEPARATORTEMPLATE>
						<TR>
							<TD bgColor="black" colSpan="2" height="2">
							</TD>
						</TR>
					</SEPARATORTEMPLATE>
					<ALTERNATINGITEMTEMPLATE>
						<TR bgColor="#ffcc99">
							<TD>
								<asp:Image id="Image2" runat="server" imageurl='<%# Container.DataItem("image")%>'>
								</asp:Image>
							</TD>
							<TD>
								<FONT size="2">제품명 :
									<%# Container.DataItem("product_name")%>
									<BR>
									제조사 :
									<%# Container.DataItem("vender")%>
									<BR>
									가 격 :
									<%# FormatNumber(Container.DataItem("price"),0)%>
									원
									<BR>
									<%# Container.DataItem("spec")%>
									<BR>
								</FONT>
							</TD>
						</TR>
					</ALTERNATINGITEMTEMPLATE>
					<FOOTERTEMPLATE>
						</TBODY></TABLE>
					</FOOTERTEMPLATE>
				</asp:Repeater>
			</P>
		</form>
	</body>
</HTML>
