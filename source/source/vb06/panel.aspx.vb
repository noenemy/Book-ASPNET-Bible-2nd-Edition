Public Class panel
    Inherits System.Web.UI.Page
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnShow As System.Web.UI.WebControls.Button
    Protected WithEvents btnHide As System.Web.UI.WebControls.Button
    Protected WithEvents btnAdd As System.Web.UI.WebControls.Button

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

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Panel1.Visible = True
    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        Panel1.Visible = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        ' TextBox ��ü ����
        Dim txtNew As New System.Web.UI.WebControls.textbox()
        txtNew.Text = "�߰��� TextBox"

        ' Panel ��Ʈ�ѿ� TextBox ���� ����
        Panel1.Controls.Add(txtNew)

    End Sub
End Class
