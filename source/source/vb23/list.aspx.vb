
Imports System.Data.SqlClient

Public Class list
    Inherits System.Web.UI.Page
    Protected WithEvents lblTitle As System.Web.UI.WebControls.Label
    Protected WithEvents lnkWrite As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lnkPrev As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lnkNext As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lstGuestbook As System.Web.UI.WebControls.DataList
    Protected WithEvents lblPager As System.Web.UI.WebControls.Label

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

    Public CurPage As Integer ' 현재 페이지 번호

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

        ' 현재 페이지값 얻기 or 초기화
        If Request.QueryString("page") = "" Then
            CurPage = 1
        Else
            CurPage = CType(Request.QueryString("page"), Integer)
        End If

        ' 방명록 보여주기
        ShowGuestbookList()

    End Sub

    Private Function GetRecordCount() As Integer

        ' 방명록의 총 레코드 수를 리턴한다.
        Dim conn As New SqlConnection(ConfigurationSettings.AppSettings("DSN"))
        Dim comm As New SqlCommand("SELECT COUNT(*) FROM guestbook", conn)
        Dim RecordCount As Integer

        conn.Open()
        RecordCount = comm.ExecuteScalar()
        conn.Close()

        Return RecordCount

    End Function


    Private Sub ShowGuestbookList()

        ' RecordCount - 총 게시물수
        ' PageSize - 한 페이지에 보여줄 게시물 수
        ' PageCount - 총 페이지수
        Dim RecordCount As Integer = GetRecordCount()
        Dim PageSize As Integer = ConfigurationSettings.AppSettings("PageSize")
        Dim PageCount, TopCount As Integer
        PageCount = Int((RecordCount - 1) / PageSize) + 1

        ' CurPage, PageCount, RecordCount 표시
        lblTitle.Text = "Page [" & CurPage & "/" & PageCount & "] Total : " & RecordCount

        ' 가져올 게시물 수
        TopCount = CurPage * PageSize

        ' 쿼리문 구성
        Dim strSQL As String
        strSQL = "SELECT TOP " & TopCount.ToString() & " * FROM guestbook ORDER BY id DESC"

        ' 방명록 게시물 가져오기
        Dim conn As New SqlConnection(ConfigurationSettings.AppSettings("DSN"))
        Dim comm As New SqlCommand(strSQL, conn)
        conn.Open()
        Dim dr As SqlDataReader = comm.ExecuteReader()

        ' 페이지번호에 맞게 레코드 위치 이동
        Dim i As Integer
        For i = 1 To (CurPage - 1) * PageSize
            dr.Read()
        Next

        ' DataList 컨트롤 데이터바인딩
        lstGuestbook.DataSource = dr
        lstGuestbook.DataBind()

        ' ADO.NET 객체 닫기
        dr.Close()
        conn.Close()

        ' 페이지 네비게이션 출력하기
        ShowPager(RecordCount, CurPage, PageCount, PageSize)

    End Sub


    Public Function DisplayContent(ByVal Content As String) As String

        ' 본문 내용중에 행바꿈문자를 <br> 태그로 변환
        Content = Replace(Content, Chr(13) & Chr(10), "<br>")
        Return Content

    End Function

    Private Sub ShowPager(ByVal RecordCount As Integer, _
                        ByVal CurPage As Integer, _
                        ByVal PageCount As Integer, _
                        ByVal PageSize As Integer)

        ' 링크 문자열
        Dim Path As String = Request.ServerVariables("PATH_INFO") & "?page="

        ' FromPage - 페이지 네비게이션의 시작 페이지번호
        ' CurPage - 페이지 네비게이션의 마지막 페이지번호
        Dim FromPage, ToPage As Integer
        FromPage = Int((CurPage - 1) / 10) * 10 + 1
        If PageCount > FromPage + 9 Then
            ToPage = FromPage + 9
        Else
            ToPage = PageCount
        End If


        Dim Pager As String
        Dim i As Integer

        Pager = "<font size=2>"

        ' 이전 10개 표시
        If Int((CurPage - 1) / 10) > 0 Then
            Pager = Pager & "<a href='" & Path & (FromPage - 1).ToString & "'>{prev}</a>..."
        End If

        ' 페이지 네비게이션 표시
        For i = FromPage To ToPage
            If i = CurPage Then
                Pager &= "<b>[" & i.ToString() & "]</b>"
            Else
                Pager = Pager & "<a href='" & Path & i.ToString & "'>" & _
                        "[" & i.ToString() & "]</a> "
            End If
        Next

        ' 다음 10개 표시
        If ToPage < PageCount Then
            Pager = Pager & "...<a href='" & Path & (ToPage + 1).ToString & "'>{next>}</a>"
        End If

        Pager = Pager & "</font>"

        ' 페이지 네비게이션 출력하기
        lblPager.Text = Pager

        ' Prev, Next 버튼의 링크 구성하기 
        If CurPage > 1 Then
            lnkPrev.NavigateUrl = Path & (CurPage - 1).ToString()
        End If

        If CurPage < ToPage Then
            lnkNext.NavigateUrl = Path & (CurPage + 1).ToString()
        End If

        lnkWrite.NavigateUrl = "write.aspx?page=" & CurPage.ToString()

    End Sub

End Class
