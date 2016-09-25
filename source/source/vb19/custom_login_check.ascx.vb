Public MustInherit Class custom_login_check
    Inherits System.Web.UI.UserControl

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

        ' 로그인 했는지 확인
        If Session("UserID") = "" Then

            ' 로그인 하지 않았으면 로그인 페이지로 이동
            Dim strURL As String = Request.ServerVariables("PATH_INFO")
            Dim strParam As String = Request.ServerVariables("QUERY_STRING")

            Dim goURL As String = "custom_login.aspx?ret_url=" & strURL & "&param=" & strParam
            Response.Redirect(goURL)

        End If


    End Sub

End Class
