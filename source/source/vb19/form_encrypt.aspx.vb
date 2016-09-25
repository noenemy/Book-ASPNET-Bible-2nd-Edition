Imports System.Web.Security

Public Class form_encrypt
    Inherits System.Web.UI.Page
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnEncrypt As System.Web.UI.WebControls.Button
    Protected WithEvents lblSHA1 As System.Web.UI.WebControls.Label
    Protected WithEvents lblMD5 As System.Web.UI.WebControls.Label

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

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click

        ' 입력받은 비밀번호를 SHA1, MD5로 암호화하기
        Dim Password As String = txtPassword.Text
        lblSHA1.Text = FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "SHA1")
        lblMD5.Text = FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "MD5")

    End Sub
End Class
