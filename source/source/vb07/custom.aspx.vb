Public Class custom
    Inherits System.Web.UI.Page
    Protected WithEvents txtInput As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnOK As System.Web.UI.WebControls.Button
            Protected WithEvents CustomValidator1 As System.Web.UI.WebControls.CustomValidator
        
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
            Response.Write("홀수가 맞습니다. <hr>")
        End If
    End Sub

    Sub ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)

        Try
            Dim intInput As Integer = args.Value
            If intInput Mod 2 = 1 Then
                args.IsValid = True
            Else
                args.IsValid = False
            End If

        Catch objError As Exception
            args.IsValid = False
        End Try

    End Sub

End Class
