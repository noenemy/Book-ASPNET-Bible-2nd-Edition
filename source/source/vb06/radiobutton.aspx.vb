Public Class radiobutton
    Inherits System.Web.UI.Page
    Protected WithEvents RadioButton1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RadioButton2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RadioButton3 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RadioButton4 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RadioButton5 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strChecked As String
        strChecked = "선택된 값 : "

        If RadioButton1.Checked = True Then strChecked &= RadioButton1.Text & ","
        If RadioButton2.Checked = True Then strChecked &= RadioButton2.Text & ","

        If RadioButton3.Checked = True Then strChecked &= RadioButton3.Text
        If RadioButton4.Checked = True Then strChecked &= RadioButton4.Text
        If RadioButton5.Checked = True Then strChecked &= RadioButton5.Text

        Response.Write(strChecked & "<hr>")
    End Sub
End Class
