<%@ Page Language="vb" AutoEventWireup="false" Codebehind="upload_to_db.aspx.vb" Inherits="tiptech_vb.upload_to_db"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>upload_to_db</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server" enctype="multipart/form-data">
			<P><FONT face="����">DB�� ���� ���ε��ϱ�</FONT></P>
			<P>
				<INPUT id="File1" style="WIDTH: 329px; HEIGHT: 22px" type="file" size="35" name="File1" runat="server"><FONT face="����">&nbsp;</FONT>
				<asp:Button id="btnUpload" runat="server" Text="���ε��ϱ�"></asp:Button></P>
			<P><FONT face="����"></FONT></P>
			<P>
				<asp:DataList id=DataList1 runat="server" DataSource="<%# DsUploadTest1 %>">
					<ItemTemplate>
						<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Id") %>'>
						</asp:Label>
						<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.filename") %>' NavigateUrl='<%# "open_from_db.aspx?id=" + DataBinder.Eval(Container, "DataItem.Id").ToString() %>'>
						</asp:HyperLink><FONT face="����">(</FONT>
						<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.file_size") %>'>
						</asp:Label><FONT face="����">&nbsp;bytes)
							<asp:Label id=Label3 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.content_type") %>'>
							</asp:Label></FONT>
					</ItemTemplate>
				</asp:DataList></P>
		</form>
	</body>
</HTML>
