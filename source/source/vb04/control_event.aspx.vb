Public Class control_event
    Inherits System.Web.UI.Page
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents CheckBox2 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents CheckBox1 As System.Web.UI.WebControls.CheckBox

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
        'Response.Write("Page : Load �̺�Ʈ �߻�<br>")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Response.Write("TextBox1��Ʈ�� : TextChanged �̺�Ʈ �߻�<br>")
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Response.Write("Button1��Ʈ�� : Click �̺�Ʈ �߻�<br>")
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Response.Write("CheckBox1��Ʈ�� : CheckedChanged �̺�Ʈ �߻�<br>")
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Response.Write("CheckBox2��Ʈ�� : CheckedChanged �̺�Ʈ �߻�<br>")
    End Sub
End Class
