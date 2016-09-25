Imports System.Web.Security

Public Class passport_hello
    Inherits System.Web.UI.Page
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCountry As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtGender As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRegion As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel

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

        ' PassportIdentity 객체 생성
        Dim PUser As PassportIdentity = CType(Context.User.Identity, PassportIdentity)

        ' 인증된 사용자의 Passport 프로필 출력하기
        If PUser.IsAuthenticated = True Then
            Panel1.Visible = True
            txtName.Text = PUser("MemberName")
            txtEmail.Text = PUser("PreferredEmail")
            txtCountry.Text = PUser("Country")
            txtGender.Text = PUser("Gender")
            txtRegion.Text = PUser("Region")
        Else
            Panel1.Visible = False
        End If

    End Sub

End Class
