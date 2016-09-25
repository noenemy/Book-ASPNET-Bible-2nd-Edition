<%@ Page language="c#" Codebehind="radiobuttonlist.aspx.cs" AutoEventWireup="false" Inherits="list1_cs.radiobuttonlist" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="radiobuttonlist" method="post" runat="server">
			<P>
				<FONT face="굴림">관심품목을 선택하세요.</FONT>
			</P>
			<P>
				<asp:radiobuttonlist id="optCategories" runat="server" DataSource="<%# dsCategories1 %>" DataTextField="CategoryName" DataValueField="CategoryID" RepeatColumns="3" RepeatLayout="Flow"></asp:radiobuttonlist>
			</P>
			<P>
				<asp:button id="btnOK" runat="server" Text="Button"></asp:button>
			</P>
		</form>
	</body>
</HTML>
