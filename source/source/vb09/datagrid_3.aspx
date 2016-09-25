<%@ Page Language="vb" AutoEventWireup="false" Codebehind="datagrid_3.aspx.vb" Inherits="list_control2.datagrid_3"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>datagrid_3</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="±¼¸²">DataGrid - ¿¹Á¦ 3</FONT></P>
			<P>
				<asp:DataGrid id=DataGrid1 runat="server" DataSource="<%# DsCategories1 %>" AutoGenerateColumns="False">
					<Columns>
						<asp:BoundColumn DataField="CategoryName" SortExpression="CategoryName" HeaderText="CategoryName"></asp:BoundColumn>
						<asp:BoundColumn DataField="Description" SortExpression="Description" HeaderText="Description"></asp:BoundColumn>
						<asp:TemplateColumn HeaderText="ÅÛÇÃ¸´ ÄÃ·³">
							<ItemTemplate>
								<asp:TextBox id=TextBox1 runat="server" Width="247px" Height="89px" Text='<%# DataBinder.Eval(Container, "DataItem.Description") %>'>
								</asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
				</asp:DataGrid></P>
		</form>
	</body>
</HTML>
