Public Class custom_login1
    Inherits System.Web.UI.Page
    Protected WithEvents txtUserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnLogin As System.Web.UI.WebControls.Button
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label

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
        If Not Page.IsPostBack Then

            ' �α��� ó���� ������ ������ ���� ViewState�� ����
            ViewState("ReturnURL") = Request.QueryString("ret_url")
            ViewState("Param") = Request.QueryString("param")
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        If txtUserName.Text.Length > 0 Then

            ' web.config�� credential ������ �����ϱ�
            If txtUserName.Text = "noenemy" And txtPassword.Text = "1234" Then
                ' ������ ��� ���Ǻ��� �����ϱ�
                Session("UserID") = txtUserName.Text

                ' ���� �������� �̵�
                Dim goURL As String = ViewState("ReturnURL") & "?" & ViewState("Param")
                Response.Redirect(goURL)

            End If
        End If

        ' �������н� �޽��� ����ϱ�
        lblMessage.Text = "�α��� ����! �ٽ� �Է��ϼ���"
    End Sub
End Class
