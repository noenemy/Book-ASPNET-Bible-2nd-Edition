Imports System.IO

Public Class openfile
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
        Dim Root As String = ConfigurationSettings.AppSettings("root")

        ' 다운로드 시킬 파일의 경로
        Dim FilePath As String = Request.QueryString("path")

        ' 지정된 경로 이외의 파일요청 거부
        If InStr(FilePath, Root) > 0 Then

            ' 파일명 얻기
            Dim FileName As String = Path.GetFileName(FilePath)

            ' 헤더에 파일이름 지정하기
            Response.AddHeader("Content-Disposition", "attachment;filename=" & FileName)
            Response.ContentType = "multipart/form-data"
            ' 파일 다운로드 시키기
            Response.WriteFile(FilePath)
        Else
            Response.Write("잘못된 요청입니다.")
        End If


    End Sub

End Class
