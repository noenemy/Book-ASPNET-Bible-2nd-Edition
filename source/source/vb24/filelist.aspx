<%@ Page Language="vb" AutoEventWireup="false" Codebehind="filelist.aspx.vb" Inherits="webdisk_vb.filelist" smartNavigation="True"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>filelist</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" encType="multipart/form-data" runat="server">
			<P><FONT face="굴림">주소 :
					<asp:textbox id="txtPath" runat="server" Width="373px" ReadOnly="True"></asp:textbox>&nbsp;
					<asp:button id="btnGoParentDir" runat="server" Text="상위폴더로"></asp:button>
					<hr>
					파일업로드 : <INPUT id="File1" style="WIDTH: 326px; HEIGHT: 22px" type="file" size="35" name="File1" runat="server">&nbsp;
					<asp:button id="btnUpload" runat="server" Text="파일업로드"></asp:button><BR>
					디렉토리 생성 :
					<asp:textbox id="NewDirName" runat="server"></asp:textbox><asp:button id="btnCD" runat="server" Text="만들기"></asp:button></FONT>
				<hr>
			<P><asp:datalist id="lstDir" runat="server">
					<ItemStyle Font-Size="X-Small"></ItemStyle>
					<ItemTemplate>
						<TR>
							<TD width="30"><IMG src="cd.gif"></TD>
							<TD width="180">
								<asp:LinkButton id=Linkbutton1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Name") %>' CommandName="GoDir" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.FullName") %>'>
								</asp:LinkButton></TD>
							<TD width="100">
								<asp:LinkButton id="DirRename" runat="server" CommandName="Edit">Rename</asp:LinkButton>
								<asp:LinkButton id=DirDelete runat="server" CommandName="Delete" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.FullName") %>'>Del</asp:LinkButton></TD>
							<TD width="80">
								<asp:Label id=Label1 runat="server" Text='<%# "" %>'>
								</asp:Label></TD>
							<TD width="80">
								<asp:Label id=Label2 runat="server" Text='<%# "디렉토리" %>'>
								</asp:Label></TD>
							<TD width="200">
								<asp:Label id=Label3 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.LastAccessTime") %>'>
								</asp:Label></TD>
						</TR>
					</ItemTemplate>
					<EditItemTemplate>
						<TR>
							<TD width="30"><IMG src="od.gif"></TD>
							<TD width="180">
								<asp:TextBox id=Textbox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Name") %>' Width="150px">
								</asp:TextBox></TD>
							<TD width="100">
								<asp:Button id=Button1 runat="server" Text="수정" CommandName="Update" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.FullName") %>'>
								</asp:Button>
								<asp:Button id="Button2" runat="server" Text="취소" CommandName="Cancel"></asp:Button></TD>
							<TD width="80">
								<asp:Label id=Label4 runat="server" Text='<%# "" %>'>
								</asp:Label></TD>
							<TD width="80">
								<asp:Label id=Label5 runat="server" Text='<%# "디렉토리" %>'>
								</asp:Label></TD>
							<TD width="200">
								<asp:Label id=Label6 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.LastAccessTime") %>'>
								</asp:Label></TD>
						</TR>
					</EditItemTemplate>
				</asp:datalist><FONT face="굴림"><BR>
				</FONT>
				<asp:datalist id="lstFile" runat="server">
					<ItemStyle Font-Size="X-Small"></ItemStyle>
					<ItemTemplate>
						<TR>
							<TD width="30"><IMG src="file.gif"></TD>
							<TD width="180">
								<asp:HyperLink id=FileName runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Name") %>' NavigateUrl='<%# "openfile.aspx?path=" + DataBinder.Eval(Container, "DataItem.FullName") %>'>
								</asp:HyperLink></TD>
							<TD width="100">
								<asp:LinkButton id=FileRename runat="server" CommandName="Edit" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.FullName") %>'>Rename</asp:LinkButton>
								<asp:LinkButton id=FileDelete runat="server" CommandName="Delete" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.FullName") %>'>Del</asp:LinkButton>
							<TD width="80">
								<asp:Label id=FileSize runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Length") %>'>
								</asp:Label></TD>
							<TD width="80">
								<asp:Label id=FileType runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Extension") %>'>
								</asp:Label></TD>
							<TD width="200">
								<asp:Label id=FileLastAccessTime runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.LastAccessTime") %>'>
								</asp:Label></TD>
						</TR>
					</ItemTemplate>
					<EditItemTemplate>
						<TR>
							<TD width="30"><IMG src="file.gif"></TD>
							<TD width="180">
								<asp:TextBox id="TextBox2" runat="server" Width="150px" Text='<%# DataBinder.Eval(Container, "DataItem.Name") %>'>
								</asp:TextBox></TD>
							<TD width="100">
								<asp:Button id="Button3" runat="server" Text="수정" CommandName="Update" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.FullName") %>'>
								</asp:Button>
								<asp:Button id="Button4" runat="server" Text="취소" CommandName="Cancel"></asp:Button></TD>
							<TD width="80">
								<asp:Label id="Label7" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Length") %>'>
								</asp:Label></TD>
							<TD width="80">
								<asp:Label id="Label8" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Extension") %>'>
								</asp:Label></TD>
							<TD width="200">
								<asp:Label id="Label9" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.LastAccessTime") %>'>
								</asp:Label></TD>
						</TR>
					</EditItemTemplate>
				</asp:datalist></P>
		</form>
	</body>
</HTML>
