Imports System.Web.Security
Imports System.Data.SqlClient

Public Class db_login
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
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        If txtUserName.Text.Length > 0 Then

            ' �����ͺ��̽��� ȸ�� ������ �����ϱ�
            Dim strSQL As String
            strSQL = "SELECT COUNT(*) FROM login_test " & _
                     "WHERE userid='" & Trim(txtUserName.Text) & "' AND " & _
                     "password = '" & Trim(txtPassword.Text) & "'"

            Dim conn As New SqlConnection("server=(local);database=ASPNETBible;uid=sa;pwd=;")
            Dim comm As New SqlCommand(strSQL, conn)
            Dim count As Integer

            conn.Open()
            count = comm.ExecuteScalar()
            conn.Close()

            If count > 0 Then
                ' ������ ��� ������Ű �����ϰ�, ���� �������� �̵�
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, False)
            End If

        End If

        ' �������н� �޽��� ����ϱ�
        lblMessage.Text = "�α��� ����! �ٽ� �Է��ϼ���"
    End Sub
End Class
