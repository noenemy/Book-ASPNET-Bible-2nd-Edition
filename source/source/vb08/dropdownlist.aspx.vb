Public Class dropdownlist
    Inherits System.Web.UI.Page
    Protected WithEvents comMovie As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnOK As System.Web.UI.WebControls.Button

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

        If comMovie.SelectedItem.Value <> 0 Then
            If comMovie.SelectedItem.Value = 3 Then
                Response.Write("정답입니다. <hr>")
            Else
                Response.Write("틀렸습니다. <hr>")
            End If
        End If

    End Sub
End Class
