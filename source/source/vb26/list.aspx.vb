'Imports System.Data.SqlClient
'Imports System.IO.Path

Public Class list
    Inherits System.Web.UI.Page
    Protected WithEvents lblPager As System.Web.UI.WebControls.Label
    Protected WithEvents lnkWrite As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lnkPrev As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lnkNext As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents lblBoardTitle As System.Web.UI.WebControls.Label
    Protected WithEvents comSearchOption As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnFind As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents btnSearchCancel As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents txtSearchKey As System.Web.UI.HtmlControls.HtmlInputText
    Protected WithEvents hidBId As System.Web.UI.HtmlControls.HtmlInputHidden
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Public CurPage, PageSize As Integer
    Public b_id As String
    Public SearchOption As String = ""
    Public SearchKey As String = ""

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

        ' ���� �������� ��� or �ʱ�ȭ
        If Request.QueryString("page") = "" Then
            CurPage = 1
        Else
            CurPage = CType(Request.QueryString("page"), Integer)
        End If

        ' �Խ��� Id ��� or �ʱ�ȭ
        If Request.QueryString("b_id") = "" Then
            b_id = "test"
        Else
            b_id = CType(Request.QueryString("b_id"), String)
        End If

        ' Hidden ��Ʈ�ѿ� �Խ��� ID(b_id) �� ����
        hidBId.Value = b_id

        ' �˻� ���� ���
        If Request.QueryString("search_option") <> "" Then
            SearchOption = CType(Request.QueryString("search_option"), String)
            Select Case SearchOption
                Case "subject"
                    comSearchOption.SelectedIndex = 0
                Case "content"
                    comSearchOption.SelectedIndex = 1
                Case "writer"
                    comSearchOption.SelectedIndex = 2
            End Select
        Else
            comSearchOption.SelectedIndex = 0 ' ����
        End If

        btnSearchCancel.Disabled = True ' �˻���� ��ư ��Ȱ��ȭ
        If Request.QueryString("search_key") <> "" Then
            SearchKey = CType(Request.QueryString("search_key"), String)
            btnSearchCancel.Disabled = False ' �˻���� ��ư Ȱ��ȭ
        End If
        txtSearchKey.Value = SearchKey


        ' �Խ��� ��� �����ֱ�
        ShowBoardList()

    End Sub


    Private Function ShowBoardList()

        ' �Խù� �� ���
        Dim objnTx As New BizBoard.nTx()
        Dim RecordCount As Integer = objnTx.GetBoardRecordCount(b_id, SearchOption, SearchKey)

        ' �Խ��� ���� ��� - pagesize, title
        Dim dsBoardInfo As BizBoard.dsBoard = objnTx.GetBoardInfo(b_id)
        PageSize = CType(dsBoardInfo.boardmaster(0).pagesize.ToString(), Integer)
        lblBoardTitle.Text = dsBoardInfo.boardmaster(0).title.ToString()

        ' �� ������ �� ����
        Dim PageCount, TopCount As Integer
        PageCount = Int((RecordCount - 1) / PageSize) + 1

        ' CurPage, PageCount, RecordCount ǥ��
        lblStatus.Text = "Page [" & CurPage & "/" & PageCount & "] Total : " & RecordCount

        ' �Խù� ��� ����ϱ�
        DataList1.DataSource = objnTx.GetBoardList(b_id, SearchOption, SearchKey, PageSize, CurPage)
        DataList1.DataMember = "boardlist"
        DataList1.DataBind()

        ' ������ �׺���̼� ����ϱ�
        ShowPager(RecordCount, CurPage, PageCount, PageSize)

    End Function



    Private Sub ShowPager(ByVal RecordCount As Integer, _
                        ByVal CurPage As Integer, _
                        ByVal PageCount As Integer, _
                        ByVal PageSize As Integer)

        ' ��ũ ���ڿ�
        Dim Path As String = Request.ServerVariables("PATH_INFO") & "?b_id=" & b_id & _
                             "&search_option=" & SearchOption & _
                             "&search_key=" & SearchKey & "&page="

        ' FromPage - ������ �׺���̼��� ���� ��������ȣ
        ' CurPage - ������ �׺���̼��� ������ ��������ȣ
        Dim FromPage, ToPage As Integer
        FromPage = Int((CurPage - 1) / 10) * 10 + 1
        If PageCount > FromPage + 9 Then
            ToPage = FromPage + 9
        Else
            ToPage = PageCount
        End If


        Dim Pager As String
        Dim i As Integer

        'Pager = "<font size=1>"

        ' ���� 10�� ǥ��
        If Int((CurPage - 1) / 10) > 0 Then
            Pager = Pager & "<a href='" & Path & (FromPage - 1).ToString & "'>{prev}</a>..."
        End If

        ' ������ �׺���̼� ǥ��
        For i = FromPage To ToPage
            If i = CurPage Then
                Pager &= "<b>[" & i.ToString() & "]</b>"
            Else
                Pager = Pager & "<a href='" & Path & i.ToString & "'>" & _
                        "[" & i.ToString() & "]</a>"
            End If
        Next

        ' ���� 10�� ǥ��
        If ToPage < PageCount Then
            Pager = Pager & "...<a href='" & Path & (ToPage + 1).ToString & "'>{next>}</a>"
        End If

        'Pager = Pager & "</font>"

        ' ������ �׺���̼� ����ϱ�
        lblPager.Text = Pager

        ' Prev, Next ��ư�� ��ũ �����ϱ� 
        If CurPage > 1 Then
            lnkPrev.NavigateUrl = Path & (CurPage - 1).ToString()
        End If

        If CurPage < ToPage Then
            lnkNext.NavigateUrl = Path & (CurPage + 1).ToString()
        End If

        lnkWrite.NavigateUrl = "write.aspx?b_id=" & b_id & "&page=" & CurPage.ToString()

    End Sub


    Public Function ShowDepth(ByVal c_depth As Integer) As String

        ' �亯���� ��� reply �̹����� ����ϰ�
        ' �亯 ������ ���� �� ������ �о�ֱ�
        If c_depth = 0 Then
            Return ""
        Else
            Dim i As Integer
            Dim strDepth As String = ""
            For i = 0 To c_depth - 1
                strDepth = strDepth & "&nbsp;&nbsp;"
            Next
            Return strDepth & "<img src='images/re.gif' border=0> "
        End If

    End Function


    Public Function ShowNumber(ByVal c_id As Integer, ByVal c_step As Integer) As String

        ' �Խù��� ��ȣ ��� - c_id
        If c_step > 1 Then
            Return ""
        Else
            Return CType(c_id, String)
        End If

    End Function



    Public Function ShowFileImage(ByVal filename As String) As String

        ' ÷�ε� ������ ������ ���� �̹����� ����Ѵ�

        Dim ext As String = UCase(Mid(filename, InStrRev(filename, ".") + 1))

        Dim fileicon As String
        If ext.Length > 0 Then

            Select Case ext  'Ȯ���ڿ� ���� �̹��� ����
                Case "HWP", "COM", "EXE", "TXT", "WAV", "XLS", "DOC", "ZIP", "RAR", "GIF", "BMP", "MP3"
                    fileicon = ext & ".gif"
                Case "RA", "RAM", "RM"
                    fileicon = "ra.gif"
                Case "HTM", "HTML"
                    fileicon = "htm.gif"
                Case "JPG", "JPEG"
                    fileicon = "jpg.gif"
                Case "MPG", "MPEG", "AVI"
                    fileicon = "mpg.gif"
                Case Else
                    fileicon = "etc.gif"
            End Select
        Else
            fileicon = "txt.gif"
        End If

        ' �̹��� ������ ��� ����
        Return "images/pds/" & fileicon


    End Function

End Class
