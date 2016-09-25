Public Class WhoAmI
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
        Response.Write("Who Am I?")
        Response.Write("<br>사용자이름 : " & User.Identity.Name)
        Response.Write("<br>인증방법 : " & User.Identity.AuthenticationType)
        Response.Write("<br>HttpHandler 수행 계정 : " & System.Security.Principal.WindowsIdentity.GetCurrent.Name)
    End Sub

End Class
