<%@ Page language="c#" Codebehind="WebForm1.aspx.cs" AutoEventWireup="false" Inherits="guestbook_cs.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="굴림"><STRONG>ASP.NET 방명록</STRONG></FONT></P>
			<P><font color="navy" size="2"><asp:label id="lblTitle" runat="server">Label</asp:label></font></FONT></P>
			<P><asp:datalist id="lstGuestbook" runat="server">
					<ItemTemplate>
						<TABLE width="600">
							<TR bgColor="#66ff99">
								<TD width="30"><FONT size="2">
										<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Id") %>'>
										</asp:Label></FONT></TD>
								<TD><FONT size="2">
										<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Writer") %>' NavigateUrl='<%# "mailto:" + DataBinder.Eval(Container, "DataItem.Email") %>'>
										</asp:HyperLink>님이
										<asp:Label id=Label3 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Reg_Date") %>'>
										</asp:Label>에 남기신 글입니다. </FONT>
								</TD>
								<TD align="middle" width="100">
									<asp:HyperLink id=lnkEdit runat="server" NavigateUrl='<%# "edit.aspx?page=" + CurPage.ToString() + "&amp;id=" + DataBinder.Eval(Container, "DataItem.Id").ToString() %>' Font-Size="X-Small">수정</asp:HyperLink><FONT face="굴림">&nbsp;</FONT>
									<asp:HyperLink id=lnkDelete runat="server" NavigateUrl='<%# "delete.aspx?page=" + CurPage.ToString() + "&amp;id=" + DataBinder.Eval(Container, "DataItem.Id").ToString() %>' Font-Size="X-Small">삭제</asp:HyperLink></TD>
							</TR>
							<TR bgColor="#ccffcc">
								<TD colSpan="3"><FONT size="2">
										<asp:Label id=Label2 runat="server" Text='<%# DisplayContent(DataBinder.Eval(Container, "DataItem.Content").ToString()) %>'>
										</asp:Label></FONT></TD>
							</TR>
						</TABLE>
						<BR>
					</ItemTemplate>
				</asp:datalist></P>
			<table width="600">
				<tr>
					<td width="300"><asp:label id="lblPager" runat="server">Label</asp:label></td>
					<td align="right"><asp:hyperlink id="lnkWrite" runat="server" ImageUrl="images/write.gif">HyperLink</asp:hyperlink><asp:hyperlink id="lnkPrev" runat="server" ImageUrl="images/previous.gif">HyperLink</asp:hyperlink><asp:hyperlink id="lnkNext" runat="server" ImageUrl="images/next.gif">HyperLink</asp:hyperlink></td>
				</tr>
			</table>
			<P></P>
			<P><FONT face="굴림"></FONT>&nbsp;</P>
		</form>
	</body>
</HTML>
