<%@ Page Language="vb" AutoEventWireup="false" Codebehind="datagrid_edit.aspx.vb" Inherits="list_control2.datagrid_edit"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>datagrid_edit</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="����">DataGrid - select,edit,delete ���</FONT></P>
			<P>
				<asp:DataGrid id=DataGrid1 runat="server" DataSource="<%# DsCategories1 %>" DataMember="Categories" DataKeyField="CategoryID" AutoGenerateColumns="False">
					<SelectedItemStyle Font-Bold="True" BackColor="Yellow"></SelectedItemStyle>
					<EditItemStyle BackColor="Teal"></EditItemStyle>
					<Columns>
						<asp:BoundColumn DataField="CategoryName" SortExpression="CategoryName" HeaderText="CategoryName"></asp:BoundColumn>
						<asp:BoundColumn DataField="Description" SortExpression="Description" HeaderText="Description"></asp:BoundColumn>
						<asp:ButtonColumn Text="����" HeaderText="����" CommandName="Select"></asp:ButtonColumn>
						<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" HeaderText="����" CancelText="Cancel" EditText="����"></asp:EditCommandColumn>
						<asp:ButtonColumn Text="����" HeaderText="����" CommandName="Delete"></asp:ButtonColumn>
					</Columns>
				</asp:DataGrid></P>
		</form>
	</body>
</HTML>
