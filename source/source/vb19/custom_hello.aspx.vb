Public Class custom_hello
    Inherits System.Web.UI.Page
    Protected WithEvents lblUserName As System.Web.UI.WebControls.Label
    Protected WithEvents btnLogOut As System.Web.UI.WebControls.Button

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

        ' ����� �̸� ����ϱ�
        lblUserName.Text = Session("UserID")
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        ' �α׾ƿ��ϱ�
        Session.Abandon()
        Response.Redirect("custom_hello.aspx")
    End Sub
End Class
