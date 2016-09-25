Public Class method
    Inherits System.Web.UI.Page
    Protected WithEvents txtYear As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnOK As System.Web.UI.WebControls.Button
    Protected WithEvents lblAge As System.Web.UI.WebControls.Label

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
        Page.DataBind()
    End Sub


    Public Function CaculateAge(ByVal BirthYear As String) As Integer
        ' 태어난 해를 인수로 받아서 올해 나이를 계산해서 리턴한다.
        Dim Age As Integer
        Age = Now.Year - CType(BirthYear, Integer) + 1
        Return Age

    End Function
End Class
