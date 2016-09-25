Imports System.IO.Path
Imports System.IO

Public Class write
    Inherits System.Web.UI.Page
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtContent As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnWrite As System.Web.UI.WebControls.Button
    Protected WithEvents txtSubject As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblBoardTitle As System.Web.UI.WebControls.Label
    Protected WithEvents File1 As System.Web.UI.HtmlControls.HtmlInputFile

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

            ' 게시판 제목 출력하기
            Dim b_id As String = Request.QueryString("b_id")
            Dim objnTx As New BizBoard.nTx()
            Dim dsBoardInfo As New BizBoard.dsBoard()
            dsBoardInfo = objnTx.GetBoardInfo(b_id)
            lblBoardTitle.Text = dsBoardInfo.boardmaster(0).title.ToString()

        End If
    End Sub


    Private Sub btnWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWrite.Click

        ' 입력할 게시물 정보
        Dim filesize, b_id, subject, writer, email, filename, password, content As String
        b_id = Request.QueryString("b_id")
        writer = txtName.Text
        email = txtEmail.Text
        password = txtPassword.Text
        content = txtContent.Text
        subject = txtSubject.Text
        filename = ""
        filesize = ""

        ' 첨부된 파일이 있으면
        If File1.PostedFile.ContentLength > 0 Then

            Dim UpPath As String
            Dim UpDir As String = ConfigurationSettings.AppSettings("UpDir")
            filesize = GetFileSize(File1.PostedFile.ContentLength)
            filename = GetFileName(File1.PostedFile.FileName)

            ' 업로드 경로가 없으면 디렉토리 생성
            UpDir = UpDir & "\" & b_id
            If Directory.Exists(UpDir) = False Then
                Directory.CreateDirectory(UpDir)
            End If

            ' 업로드할 경로
            UpPath = UpDir & "\" & filename

            ' 파일명 중복 방지
            Dim i As Integer = 0
            Dim filename2 As String = ""
            Do While (File.Exists(UpPath))
                i = i + 1
                filename2 = GetFileNameWithoutExtension(filename) & _
                        "(" & i.ToString() & ")" & Path.GetExtension(filename)
                UpPath = UpDir & "\" & filename2
            Loop
            If filename2.Length > filename.Length Then
                filename = filename2
            End If

            ' 파일 업로드하기
            File1.PostedFile.SaveAs(UpPath)

        End If

        ' 게시물 등록하기
        Dim objRoot As New BizBoard.Root()
        Dim result As Boolean
        result = objRoot.WriteArticle(b_id, subject, writer, email, filename, filesize, content, password)

        If result = False Then
            lblMessage.Text = "관리자만 입력할 수 있습니다."
        Else

            ' list.aspx로 이동
            Dim CurPage As Integer = Request.QueryString("page")
            Dim goURL As String = "list.aspx?b_id=" & b_id & "&page = " & Request.QueryString("page").ToString()
            Response.Redirect(goURL)

        End If

    End Sub

    Private Function GetFileSize(ByVal Size As Integer) As String

        ' 파일크기를 KByte 형식으로 변환해서 리턴
        Dim result As String
        If Size > 1024 Then '1024byte(1Kbyte)보다 크면	
            result = (CInt(Size / 1024)).ToString() & "K"
        Else
            result = Size.ToString()
        End If
        Return result

    End Function

End Class
