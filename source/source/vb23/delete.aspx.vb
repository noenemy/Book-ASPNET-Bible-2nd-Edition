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

            ' Id, CurPage 값 ViewState에 저장
            Dim Id As Integer = Request.QueryString("id")
            Dim CurPage As Integer = Request.QueryString("page")

            lblId.Text = Id.ToString()

            VIewState("Id") = Id
            ViewState("CurPage") = CurPage

        End If

    End Sub

    Private Function IsPasswordCorrect() As Boolean

        ' 비밀번호가 맞는지 확인해서 True/False를 리턴
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

        ' 비밀번호가 맞는지 확인
        If IsPasswordCorrect() = True Then

            Dim Id As Integer = ViewState("Id")
            Dim CurPage As Integer = ViewState("CurPage")

            ' ADO.NET 객체 생성 및 SQL 쿼리문 구성
            Dim conn As New SqlConnection(ConfigurationSettings.AppSettings("DSN"))
            Dim comm As New SqlCommand("DELETE FROM guestbook WHERE id=@Id", conn)
            comm.Parameters.Add(New SqlParameter("@Id", Id))

            ' Delete 실행
            conn.Open()
            comm.ExecuteNonQuery()
            conn.Close()

            ' list.aspx로 이동
            Dim goURL As String = "list.aspx?page=" & CurPage
            Response.Redirect(goURL)

        Else
            ' 비밀번호가 틀린 경우 메시지 출력
            Response.Write("비밀번호가 일치하지 않습니다.<hr>")

        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        ' list.aspx로 이동
        Dim CurPage As Integer = ViewState("CurPage")
        Dim goURL As String = "list.aspx?page=" & CurPage.ToString()
        Response.Redirect(goURL)
    End Sub
End Class
