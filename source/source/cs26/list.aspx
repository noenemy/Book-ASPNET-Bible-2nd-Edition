<%@ Page language="c#" Codebehind="list.aspx.cs" AutoEventWireup="false" Inherits="board_cs.ListForm" %>

<!--
* NEBOARD.net COM+ 버전 1.0
*
* 작성일 : 2003.10.02 
*          by noenemy
-->

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>list</title>
		<LINK href="styles.css" rel="stylesheet">
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript">
// 검색키 입력창에서 엔터키를 누르면 검색을 실행한다.		
function OnSearchKeyDown()
{
	if (event.keyCode == 13)
		document.all.btnFind.focus();
}

// 검색버튼 클릭해 입력된 정보를 이용해서 검색페이지로 이동한다.
function OnSearch()
{
	// 검색 조건 정보 가져오기, 검색키 값은 URL 인코딩이 필요하므로 escape 함수 사용
	var b_id = document.ListForm.hidBId.value;
	var search_option = document.ListForm.comSearchOption.value;
	var search_key = escape(document.ListForm.txtSearchKey.value);
	
	// 검색키가 입력되었는지 확인
	if (search_key != "") 
	{
		// 검색 결과 페이지로 이동
		var page = "list.aspx?b_id=" + b_id + "&search_option=" + search_option + "&search_key=" + search_key;
		window.location.href = page;
	}
	else
	{
		// 검색키가 입력되지 않았으면 메시지 출력
		alert("검색어를 입력해 주세요!");
		document.ListForm.txtSearchKey.focus();	
	}
}

// 검색취소 버튼을 클릭하면 검색조건을 초기화하고 게시판 페이지로 이동한다.
function OnSearchCancel()
{
	var b_id = document.ListForm.hidBId.value;
	window.location.href = "list.aspx?b_id=" + b_id + "&search_option=&search_key=";
}
		</script>
	</HEAD>
	<body>
		<form id="ListForm" method="post" runat="server">
			<center><IMG height="20" src="images/title.gif" width="20" align="absMiddle"> &nbsp;&nbsp;<font size="3"><b><asp:label id="lblBoardTitle" runat="server"></asp:label></b></font>&nbsp;&nbsp;
				<br>
				<table width="600">
					<tr>
						<br>
						<td><asp:label id="lblStatus" runat="server">Label</asp:label></td>
						<td align="right"><INPUT id="hidBId" type="hidden" name="hidBId" runat="server">
							<asp:dropdownlist id="comSearchOption" runat="server">
								<asp:ListItem Value="subject">제목</asp:ListItem>
								<asp:ListItem Value="content">본문</asp:ListItem>
								<asp:ListItem Value="writer">글쓴이</asp:ListItem>
							</asp:dropdownlist><INPUT id="txtSearchKey" onkeydown="javascript:return OnSearchKeyDown();" maxLength="15" name="txtSearchKey" runat="server">
							<INPUT id="btnFind" onclick="javascript:OnSearch();" type="button" value="검색" name="btnFind" runat="server">
							<INPUT id="btnSearchCancel" onclick="javascript:OnSearchCancel();" type="button" value="검색취소" name="btnSearchCancel" runat="server">
						</td>
					</tr>
				</table>
				<asp:datalist id="DataList1" runat="server">
					<HeaderTemplate>
						<table border="0" cellpadding="2" cellspacing="0" width="600">
							<tr bgcolor="black" height="2">
								<td colspan="7"></td>
							</tr>
							<tr bgcolor="#99ff66" align="right" height="20">
								<td align="middle" width="25">&nbsp;</td>
								<td align="left" width="30">&nbsp;</td>
								<td align="center">제&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;목</td>
								<td align="center" width="70">글 쓴 이</td>
								<td align="center" width="75">등 록 일</td>
								<td align="center" width="30">조회</td>
								<td align="center" width="30">받음</td>
							</tr>
							<tr bgcolor="black" height="2">
								<td colspan="7"></td>
							</tr>
					</HeaderTemplate>
					<FooterTemplate>
						<tr bgcolor="black" height="2">
							<td colspan="7"></td>
						</tr>
					</FooterTemplate>
					<ItemTemplate>
						<TR bgcolor="#ccffff">
							<TD align="right">
								<asp:Label id="lblCId1" runat="server" Text='<%# ShowNumber((int)DataBinder.Eval(Container, "DataItem.c_id"),(int)DataBinder.Eval(Container, "DataItem.c_step")) %>'>
								</asp:Label></TD>
							<TD>
								<asp:Image id="imgFile1" runat="server" ImageUrl='<%# ShowFileImage(DataBinder.Eval(Container, "DataItem.filename").ToString()) %>'>
								</asp:Image>
							</TD>
							<TD>
								<asp:Label id="lblDepth1" runat="server" Text='<%# ShowDepth((int)DataBinder.Eval(Container, "DataItem.c_depth")) %>'>Label</asp:Label>
								<asp:HyperLink id=lnkSubject1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.subject") %>' NavigateUrl='<%# "show.aspx?b_id=" + DataBinder.Eval(Container, "DataItem.b_id").ToString() + "&amp;c_id=" + DataBinder.Eval(Container, "DataItem.c_id").ToString() + "&amp;c_step=" + DataBinder.Eval(Container, "DataItem.c_step").ToString() + "&amp;page=" + CurPage.ToString() + "&search_option=" + SearchOption + "&search_key=" + Server.UrlEncode(SearchKey)%>'>
								</asp:HyperLink></TD>
							<TD align="center">
								<asp:HyperLink id=lnkMail1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.writer") %>' NavigateUrl='<%# "mailto:" + DataBinder.Eval(Container, "DataItem.email").ToString() %>'>
								</asp:HyperLink>
								</asp:Label></TD>
							<TD align="center">
								<asp:Label id=lblRegDate1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.regdate") %>'>
								</asp:Label></TD>
							<TD align="center">
								<asp:Label id=lblReadCount1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.readcount") %>'>
								</asp:Label></TD>
							<TD align="center">
								<asp:Label id=lblDownCount1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.downcount") %>'>
								</asp:Label></TD>
						</TR>
					</ItemTemplate>
					<AlternatingItemTemplate>
						<TR>
							<TD align="right">
								<asp:Label id="lblCId2" runat="server" Text='<%# ShowNumber((int)DataBinder.Eval(Container, "DataItem.c_id"),(int)DataBinder.Eval(Container, "DataItem.c_step")) %>'>
								</asp:Label></TD>
							<TD>
								<asp:Image id="imgFile2" runat="server" ImageUrl='<%# ShowFileImage(DataBinder.Eval(Container, "DataItem.filename").ToString()) %>'>
								</asp:Image>
							</TD>
							<TD>
								<asp:Label id="lblDepth2" runat="server" Text='<%# ShowDepth((int)DataBinder.Eval(Container, "DataItem.c_depth")) %>'>Label</asp:Label>
								<asp:HyperLink id="lnkSubject2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.subject") %>' NavigateUrl='<%# "show.aspx?b_id=" + DataBinder.Eval(Container, "DataItem.b_id").ToString() + "&amp;c_id=" + DataBinder.Eval(Container, "DataItem.c_id").ToString() + "&amp;c_step=" + DataBinder.Eval(Container, "DataItem.c_step").ToString()  + "&amp;page=" + CurPage.ToString() + "&search_option=" + SearchOption + "&search_key=" + Server.UrlEncode(SearchKey) %>'>
								</asp:HyperLink></TD>
							<TD align="center">
								<asp:HyperLink id="lnkMail2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.writer") %>' NavigateUrl='<%# "mailto:" + DataBinder.Eval(Container, "DataItem.email").ToString() %>'>
								</asp:HyperLink>
								</asp:Label></TD>
							<TD align="center">
								<asp:Label id="lblRegDate2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.regdate") %>'>
								</asp:Label></TD>
							<TD align="center">
								<asp:Label id="lblReadCount2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.readcount") %>'>
								</asp:Label></TD>
							<TD align="center">
								<asp:Label id="lblDownCount2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.downcount") %>'>
								</asp:Label></TD>
						</TR>
					</AlternatingItemTemplate>
				</asp:datalist>
				<table width="600">
					<tr>
						<td><asp:label id="lblPager" runat="server">Label</asp:label></td>
					</tr>
					<tr>
						<td align="middle"><asp:hyperlink id="lnkWrite" runat="server" ImageUrl="images/write.gif">HyperLink</asp:hyperlink><asp:hyperlink id="lnkPrev" runat="server" ImageUrl="images/previous.gif">HyperLink</asp:hyperlink><asp:hyperlink id="lnkNext" runat="server" ImageUrl="images/next.gif">HyperLink</asp:hyperlink></td>
					</tr>
				</table>
			</center>
		</form>
	</body>
</HTML>
