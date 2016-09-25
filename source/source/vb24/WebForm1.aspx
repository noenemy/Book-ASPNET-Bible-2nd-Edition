<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="webdisk_vb.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form2" method="post" encType="multipart/form-data" runat="server">
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
				</asp:datalist><FONT face="굴림"><BR>
				</FONT>
				<asp:datalist id="lstFile" runat="server">
				</asp:datalist></P>
		</form>

		</form>
	</body>
</HTML>
