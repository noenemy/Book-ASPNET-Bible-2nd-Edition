Public Class var_practice
    Inherits System.Web.UI.Page
    Protected WithEvents txtID As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPWD1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnOK As System.Web.UI.WebControls.Button
    Protected WithEvents txtJumin As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtMobile As System.Web.UI.WebControls.TextBox
    Protected WithEvents ReqID As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents ReqPWD1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents ReqPWD2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents ComPWD As System.Web.UI.WebControls.CompareValidator
    Protected WithEvents Summary As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents CusJumin As System.Web.UI.WebControls.CustomValidator
    Protected WithEvents ReqJumin As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RegMobile As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents txtPWD2 As System.Web.UI.WebControls.TextBox

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

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJumin.TextChanged

    End Sub
End Class
