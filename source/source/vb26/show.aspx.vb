Public Class show
    Inherits System.Web.UI.Page
    Protected WithEvents lnkWriter As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lblRegDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblSubject As System.Web.UI.WebControls.Label
    Protected WithEvents lnkReply As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lnkList As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lnkEdit As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lnkDelete As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lblContent As System.Web.UI.WebControls.Label
    Protected WithEvents lblFile As System.Web.UI.WebControls.Label
    Protected WithEvents lblBoardTitle As System.Web.UI.WebControls.Label

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


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

        If Not Page.IsPostBack Then

            Dim CurPage As Integer = Request.QueryString("page")
            Dim b_id As String = Request.QueryString("b_id")
            Dim c_id As Integer = Request.QueryString("c_id")
            Dim c_step As Integer = Request.QueryString("c_step")
            Dim SearchOption As String = Request.QueryString("search_option")
            Dim SearchKey As String = Server.UrlEncode(Request.QueryString("search_key"))

            ' 게시물 조회수 증가
            Dim objRoot As New BizBoard.Root()
            objRoot.IncreaseReadCount(b_id, c_id, c_step)

            ' 게시판 제목 출력
            Dim objnTx As New BizBoard.nTx()
            Dim dsBoardInfo As New BizBoard.dsBoard()
            dsBoardInfo = objnTx.GetBoardInfo(b_id)
            lblBoardTitle.Text = dsBoardInfo.boardmaster(0).title.ToString()

            ' 게시물 가져오기
            Dim dsBoard As New BizBoard.dsBoard()
            dsBoard = objnTx.GetArticle(b_id, c_id, c_step)

            ' 게시물 내용 출력하기
            lnkWriter.Text = dsBoard.GetArticle(0).writer.ToString()
            lnkWriter.NavigateUrl = "mailto:" & dsBoard.GetArticle(0).email.ToString()
            lblRegDate.Text = dsBoard.GetArticle(0).regdate.ToString()
            lblSubject.Text = dsBoard.GetArticle(0).subject.ToString()
            lblContent.Text = DisplayContent(dsBoard.GetArticle(0).content.ToString())

            ' 첨부된 파일의 정보 출력하기
            lblFile.Text = ShowAttachedFileInfo(dsBoard.GetArticle(0).filename.ToString(), dsBoard.GetArticle(0).filesize.ToString())

            ' 링크버튼의 하이퍼링크 설정
            lnkReply.NavigateUrl = "reply.aspx?b_id=" & b_id & "&page=" & CurPage.ToString() & _
                                    "&c_id=" & c_id.ToString & "&c_step=" & c_step.ToString() & _
                                    "&search_option=" & SearchOption & "&search_key=" & SearchKey
            lnkList.NavigateUrl = "list.aspx?b_id=" & b_id & "&page=" & CurPage.ToString() & _
                                    "&search_option=" & SearchOption & "&search_key=" & SearchKey
            lnkEdit.NavigateUrl = "edit.aspx?b_id=" & b_id & "&page=" & CurPage.ToString() & _
                                    "&c_id=" & c_id.ToString & "&c_step=" & c_step.ToString() & _
                                    "&search_option=" & SearchOption & "&search_key=" & SearchKey
            lnkDelete.NavigateUrl = "delete.aspx?b_id=" & b_id & "&page=" & CurPage.ToString() & _
                                    "&c_id=" & c_id.ToString & "&c_step=" & c_step.ToString() & _
                                    "&search_option=" & SearchOption & "&search_key=" & SearchKey

        End If

    End Sub

    Public Function ShowAttachedFileInfo(ByVal filename As String, ByVal filesize As String) As String

        Dim b_id As String = Request.QueryString("b_id")
        Dim c_id As Integer = Request.QueryString("c_id")
        Dim c_step As Integer = Request.QueryString("c_step")

        ' 첨부파일에 대한 정보 및 링크 구성해서 리턴
        Dim FileLink As String
        If filename.Length > 0 Then
            FileLink = "<b>첨부파일</b> : " & _
                    "<img src='" & GetFileImagePath(filename) & "' border=0 align=absmiddle> "
        Else
            Return ""
        End If

        FileLink = FileLink & "<a href='download.aspx?b_id=" & b_id & _
                "&c_id=" & c_id.ToString() & "&c_step=" & c_step.ToString() & "'>" & _
                filename & " (" & filesize & "bytes)</a>" & _
                "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br>"
        Return FileLink

    End Function


    Public Function GetFileImagePath(ByVal filename As String) As String

        ' 첨부된 파일 확장자에 맞는 이미지 파일 경로 리턴
        Dim ext As String = UCase(Mid(filename, InStrRev(filename, ".") + 1))

        Dim fileicon As String

        Select Case ext  '확장자에 따른 이미지 선택
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

        Return "images/pds/" & fileicon

    End Function



    Public Function DisplayContent(ByVal Content As String) As String

        ' 본문 내용중에 행바꿈문자를 <br> 태그로 변환
        Content = Replace(Content, Chr(13) & Chr(10), "<br>")
        Return Content

    End Function

End Class
