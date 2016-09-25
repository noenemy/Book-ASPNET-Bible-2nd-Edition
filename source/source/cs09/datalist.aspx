<%@ Page language="c#" Codebehind="datalist.aspx.cs" AutoEventWireup="false" Inherits="list2_cs.datalist" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>datalist</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="datalist" method="post" runat="server">
			<P>
				<FONT face="굴림">DataList를 이용한 상품목록 예제</FONT>
			</P>
			<p>
				<asp:DataList id="DataList1" runat="server" BorderWidth="1px" GridLines="Vertical" CellPadding="3" BackColor="White" BorderStyle="None" BorderColor="#999999" DataSource="<%# dsProduct1 %>" RepeatDirection="Horizontal" RepeatColumns="3">
					<HEADERTEMPLATE>
						<FONT face="굴림">PDA Shop입니다.</FONT>
					</HEADERTEMPLATE>
					<ALTERNATINGITEMSTYLE BackColor="#DCDCDC"></ALTERNATINGITEMSTYLE>
					<FOOTERTEMPLATE>
						<FONT face="굴림">감사합니다.</FONT>
					</FOOTERTEMPLATE>
					<ITEMSTYLE BackColor="#EEEEEE" ForeColor="Black"></ITEMSTYLE>
					<HEADERSTYLE BackColor="#000084" ForeColor="White" Font-Bold="True"></HEADERSTYLE>
					<FOOTERSTYLE BackColor="#CCCCCC" ForeColor="Black"></FOOTERSTYLE>
					<ITEMTEMPLATE>
						<P>
							<TABLE height="110" width="110">
								<TR>
									<TD align="middle">
										<asp:ImageButton id="btnImage" runat="server" ImageUrl='<%# DataBinder.Eval(Container, "DataItem.image") %>'>
										</asp:ImageButton>
										<BR>
									</TD>
								</TR>
							</TABLE>
							<FONT color="navy" size="2"><B>
									<asp:Label id="lblVender" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.vender") %>'>
									</asp:Label>
									<asp:Label id="lblProductName" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.product_name") %>'>
									</asp:Label>
								</B></FONT>
							<BR>
							<FONT color="black" size="2">
								<asp:Label id="lblSpec" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.spec") %>'>
								</asp:Label>
								<BR>
								<asp:Label id="lblPrice" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.price") %>'>
								</asp:Label>
							</FONT>
						</P>
					</ITEMTEMPLATE>
				</asp:DataList>
			<P>
			</P>
			<P>
			</P>
		</form>
	</body>
</HTML>
