Imports System.Web.Security

Public Class form_login
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
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        If txtUserName.Text.Length > 0 Then

            ' web.config의 credential 정보로 인증하기
            If FormsAuthentication.Authenticate(txtUserName.Text, txtPassword.Text) Then
                ' 인증된 경우 인증쿠키 저장하고, 이전 페이지로 이동
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, False)
            End If
        End If

        ' 인증실패시 메시지 출력하기
        lblMessage.Text = "로그인 실패! 다시 입력하세요"

    End Sub
End Class
