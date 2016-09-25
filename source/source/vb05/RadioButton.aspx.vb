Public Class RadioButton
    Inherits System.Web.UI.Page
    Protected WithEvents Radio1 As System.Web.UI.HtmlControls.HtmlInputRadioButton
    Protected WithEvents Radio2 As System.Web.UI.HtmlControls.HtmlInputRadioButton
    Protected WithEvents Radio3 As System.Web.UI.HtmlControls.HtmlInputRadioButton
    Protected WithEvents Radio4 As System.Web.UI.HtmlControls.HtmlInputRadioButton
    Protected WithEvents Submit1 As System.Web.UI.HtmlControls.HtmlInputButton

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

    Private Sub Submit1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit1.ServerClick

        Dim strMsg As String

        If Radio1.Checked = True Then
            strMsg = "정답입니다.<hr>"
        Else
            strMsg = "틀렸습니다. 1장부터 다시 보세요.<hr>"
        End If

        Response.Write(strMsg)
    End Sub
End Class
