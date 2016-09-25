Imports System.IO
Imports System.IO.Path

Public Class delete
    Inherits System.Web.UI.Page
    Protected WithEvents btnDelete As System.Web.UI.WebControls.Button
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblId As System.Web.UI.WebControls.Label
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

            ' 삭제할 게시물 정보 얻기
            Dim b_id As String = Request.QueryString("b_id")
            Dim c_id As Integer = Request.QueryString("c_id")
            Dim c_step As Integer = Request.QueryString("c_step")
            lblId.Text = "<b>" & c_id.ToString() & "-" & c_step.ToString() & "</b>"

            ' 게시판 제목 출력
            Dim objnTx As New BizBoard.nTx()
            Dim dsBoardInfo As New BizBoard.dsBoard()
            dsBoardInfo = objnTx.GetBoardInfo(b_id)
            lblBoardTitle.Text = dsBoardInfo.boardmaster(0).title.ToString()

        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim filename, b_id, password, SearchOption, SearchKey As String
        Dim c_id, c_step As Integer
        b_id = Request.QueryString("b_id")
        c_id = Request.QueryString("c_id")
        c_step = Request.QueryString("c_step")
        SearchOption = Request.QueryString("search_option")
        SearchKey = Request.QueryString("search_key")
        password = txtPassword.Text

        ' 기존에 첨부된 파일 정보 얻기
        Dim objnTx As New BizBoard.nTx()
        Dim dsArticle As BizBoard.dsBoard = objnTx.GetArticle(b_id, c_id, c_step)
        filename = dsArticle.GetArticle(0).filename.ToString()

        ' 게시물 삭제하기
        Dim objRoot As New BizBoard.Root()
        Dim result As Boolean
        result = objRoot.DeleteArticle(b_id, c_id, c_step, password)

        If result = False Then
            lblMessage.Text = "비밀번호가 일치하지 않습니다."
        Else

            ' 첨부된 파일이 있었으면 파일 삭제
            If filename.Length > 0 Then
                Dim DelPath As String
                DelPath = ConfigurationSettings.AppSettings("UpDir") & "\" & b_id & "\" & filename
                File.Delete(DelPath)
            End If

            ' list.aspx로 이동
            Dim CurPage As Integer = Request.QueryString("page")
            Dim goURL As String = "list.aspx?b_id=" & b_id & "&search_option=" & SearchOption & _
                                  "&search_key=" & Server.UrlEncode(SearchKey) & "&page=" & CurPage.ToString()
            Response.Redirect(goURL)

        End If

    End Sub

End Class
