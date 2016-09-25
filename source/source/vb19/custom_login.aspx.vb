Public Class custom_login1
    Inherits System.Web.UI.Page
    Protected WithEvents txtUserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnLogin As System.Web.UI.WebControls.Button
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label

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

            ' 로그인 처리후 리턴할 페이지 정보 ViewState에 저장
            ViewState("ReturnURL") = Request.QueryString("ret_url")
            ViewState("Param") = Request.QueryString("param")
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        If txtUserName.Text.Length > 0 Then

            ' web.config의 credential 정보로 인증하기
            If txtUserName.Text = "noenemy" And txtPassword.Text = "1234" Then
                ' 인증된 경우 세션변수 저장하기
                Session("UserID") = txtUserName.Text

                ' 이전 페이지로 이동
                Dim goURL As String = ViewState("ReturnURL") & "?" & ViewState("Param")
                Response.Redirect(goURL)

            End If
        End If

        ' 인증실패시 메시지 출력하기
        lblMessage.Text = "로그인 실패! 다시 입력하세요"
    End Sub
End Class
