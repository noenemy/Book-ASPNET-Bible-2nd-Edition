Public Class output_cache2
    Inherits System.Web.UI.Page
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label

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
        '현재 페이지의 캐시 설정 - 만료시간 : 5초
        Response.Cache.SetExpires(DateTime.Now.AddSeconds(5))
        Response.Cache.SetCacheability(HttpCacheability.Public)
        Label1.Text = "페이지가 캐시에 저장된 시각 : " & DateTime.Now.ToString()
    End Sub


End Class
