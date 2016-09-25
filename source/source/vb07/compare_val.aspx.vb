Public Class compare_val
    Inherits System.Web.UI.Page
    Protected WithEvents txtPWD1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPWD2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnOK As System.Web.UI.WebControls.Button
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents CompareValidator1 As System.Web.UI.WebControls.CompareValidator

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

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Page.IsValid = True Then
            Response.Write("암호를 확인했습니다. <hr>")
        End If
    End Sub
End Class
