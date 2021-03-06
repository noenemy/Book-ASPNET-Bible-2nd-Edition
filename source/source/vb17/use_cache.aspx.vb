Public Class use_cache
    Inherits System.Web.UI.Page
    Protected WithEvents lblResult As System.Web.UI.WebControls.Label
    Protected WithEvents btnPlus As System.Web.UI.WebControls.Button
    Protected WithEvents btnMinus As System.Web.UI.WebControls.Button

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
            ' 캐시 변수값 초기화
            Cache.Insert("Result", 0)
            ShowResult()
        End If
    End Sub

    Private Sub ShowResult()
        ' 캐시 값 출력하기
        lblResult.Text = Cache("Result")
    End Sub

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        ' 캐시변수 값 + 1
        Cache.Insert("Result", CType(Cache("Result"), Integer) + 1)
        ShowResult()
    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        ' 캐시변수 값 - 1
        Cache.Insert("Result", CType(Cache("Result"), Integer) - 1)
        ShowResult()
    End Sub

End Class
