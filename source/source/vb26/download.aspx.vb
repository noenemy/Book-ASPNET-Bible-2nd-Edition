Imports System.IO


Public Class download
    Inherits System.Web.UI.Page

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

        Dim b_id As String = Request.QueryString("b_id")
        Dim c_id As Integer = Request.QueryString("c_id")
        Dim c_step As Integer = Request.QueryString("c_step")

        Dim filename, downpath As String

        ' 파일의 다운로드수 증가
        Dim objRoot As New BizBoard.Root()
        objRoot.IncreaseDownCount(b_id, c_id, c_step)

        ' 첨부파일 정보 얻기
        Dim objnTx As New BizBoard.nTx()
        Dim dsArticle As New BizBoard.dsBoard()
        dsArticle = objnTx.GetArticle(b_id, c_id, c_step)
        filename = dsArticle.GetArticle(0).filename.ToString()

        ' 다운로드할 파일의 경로
        Dim UpDir As String = ConfigurationSettings.AppSettings("UpDir")
        downpath = UpDir & "\" & b_id & "\" & filename

        If File.Exists(downpath) Then ' 파일이 있으면

            ' 헤더에 파일이름 지정하기
            Response.AddHeader("Content-Disposition", "attachment;filename=" & Server.UrlEncode(filename))
            Response.ContentType = "multipart/form-data"
            ' 파일 다운로드 시키기
            Response.WriteFile(downpath)

        Else
            Response.Write("파일이 존재하지 않습니다.")
        End If


    End Sub

End Class
