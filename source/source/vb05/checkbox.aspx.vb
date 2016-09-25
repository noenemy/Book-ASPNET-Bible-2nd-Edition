Public Class checkbox
    Inherits System.Web.UI.Page
    Protected WithEvents Checkbox1 As System.Web.UI.HtmlControls.HtmlInputCheckBox
    Protected WithEvents Checkbox2 As System.Web.UI.HtmlControls.HtmlInputCheckBox
    Protected WithEvents Submit1 As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents Checkbox3 As System.Web.UI.HtmlControls.HtmlInputCheckBox

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

        Dim strMsg As String = "선택한 연예인 : "
        If Checkbox1.Checked = True Then strMsg += " 전지현 "
        If Checkbox2.Checked = True Then strMsg += " 이영애 "
        If Checkbox3.Checked = True Then strMsg += " 김현주 "

        Response.Write(strMsg & "<hr>")

    End Sub
End Class
