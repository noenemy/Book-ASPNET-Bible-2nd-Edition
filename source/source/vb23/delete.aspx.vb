Imports System.Data.SqlClient

Public Class delete
    Inherits System.Web.UI.Page
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnDelete As System.Web.UI.WebControls.Button
    Protected WithEvents lblId As System.Web.UI.WebControls.Label
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button

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

            ' Id, CurPage �� ViewState�� ����
            Dim Id As Integer = Request.QueryString("id")
            Dim CurPage As Integer = Request.QueryString("page")

            lblId.Text = Id.ToString()

            VIewState("Id") = Id
            ViewState("CurPage") = CurPage

        End If

    End Sub

    Private Function IsPasswordCorrect() As Boolean

        ' ��й�ȣ�� �´��� Ȯ���ؼ� True/False�� ����
        Dim Id As Integer = ViewState("Id")
        Dim conn As New SqlConnection(ConfigurationSettings.AppSettings("DSN"))
        Dim comm As New SqlCommand("SELECT COUNT(*) FROM guestbook WHERE id=@Id AND password=@Password", conn)
        comm.Parameters.Add(New SqlParameter("@Id", Id))
        comm.Parameters.Add(New SqlParameter("@Password", txtPassword.Text))
        conn.Open()
        If comm.ExecuteScalar() > 0 Then
            IsPasswordCorrect = True
        Else
            IsPasswordCorrect = False
        End If
        conn.Close()

    End Function


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        ' ��й�ȣ�� �´��� Ȯ��
        If IsPasswordCorrect() = True Then

            Dim Id As Integer = ViewState("Id")
            Dim CurPage As Integer = ViewState("CurPage")

            ' ADO.NET ��ü ���� �� SQL ������ ����
            Dim conn As New SqlConnection(ConfigurationSettings.AppSettings("DSN"))
            Dim comm As New SqlCommand("DELETE FROM guestbook WHERE id=@Id", conn)
            comm.Parameters.Add(New SqlParameter("@Id", Id))

            ' Delete ����
            conn.Open()
            comm.ExecuteNonQuery()
            conn.Close()

            ' list.aspx�� �̵�
            Dim goURL As String = "list.aspx?page=" & CurPage
            Response.Redirect(goURL)

        Else
            ' ��й�ȣ�� Ʋ�� ��� �޽��� ���
            Response.Write("��й�ȣ�� ��ġ���� �ʽ��ϴ�.<hr>")

        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        ' list.aspx�� �̵�
        Dim CurPage As Integer = ViewState("CurPage")
        Dim goURL As String = "list.aspx?page=" & CurPage.ToString()
        Response.Redirect(goURL)
    End Sub
End Class
