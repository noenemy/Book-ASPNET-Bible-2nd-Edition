Public Class checkbox
    Inherits System.Web.UI.Page
    Protected WithEvents CheckBox1 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents CheckBox2 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents CheckBox3 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents CheckBox4 As System.Web.UI.WebControls.CheckBox
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

        If CheckBox1.Checked = True Then strChecked &= CheckBox1.Text & ","
        If CheckBox2.Checked = True Then strChecked &= CheckBox2.Text & ","
        If CheckBox3.Checked = True Then strChecked &= CheckBox3.Text & ","
        If CheckBox4.Checked = True Then strChecked &= CheckBox4.Text

        Response.Write(strChecked & "<hr>")

    End Sub
End Class
