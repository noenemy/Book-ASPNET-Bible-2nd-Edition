<%@ Page language="c#" Codebehind="checkboxlist.aspx.cs" AutoEventWireup="false" Inherits="list1_cs.checkboxlist" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="checkboxlist" method="post" runat="server">
			<P>
				<FONT face="굴림">관심품목을 모두 선택하세요.</FONT>
			</P>
			<P>
				<asp:CheckBoxList id="chkCategories" runat="server" DataSource="<%# dsCategories1 %>" DataTextField="CategoryName" DataValueField="CategoryID" RepeatColumns="3">
				</asp:CheckBoxList>
			</P>
			<P>
				<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button>
			</P>
		</form>
	</body>
</HTML>
