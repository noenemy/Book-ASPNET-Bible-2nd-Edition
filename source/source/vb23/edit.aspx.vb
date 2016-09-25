
Imports System.Data.SqlClient

Public Class edit
    Inherits System.Web.UI.Page
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtContent As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnUpdate As System.Web.UI.WebControls.Button
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

            VIewState("Id") = Id
            ViewState("CurPage") = CurPage

            ' 현재 게시물의 내용 가져오기
            Dim conn As New SqlConnection(ConfigurationSettings.AppSettings("DSN"))
            Dim comm As New SqlCommand("SELECT * FROM guestbook WHERE id=@Id", conn)
            comm.Parameters.Add(New SqlParameter("@Id", Id))
            conn.Open()

            ' 컨트롤에 게시물 내용 출력
            Dim dr As SqlDataReader = comm.ExecuteReader()
            If dr.Read() = True Then
                txtName.Text = dr.Item("writer")
                txtEmail.Text = dr.Item("email")
                txtContent.Text = dr.Item("content")
            Else
                Response.Write("잘못된 요청입니다. 데이터가 없습니다.")
            End If

            dr.Close()
            conn.Close()

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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        ' 비밀번호가 맞는지 확인
        If IsPasswordCorrect() = True Then


            Dim Id As Integer = ViewState("Id")
            Dim CurPage As Integer = ViewState("CurPage")

            ' SQL 쿼리문 작성
            Dim strSQL As String
            strSQL = "UPDATE guestbook SET writer=@Writer, email=@Email, content=@Content " & _
                     "WHERE id=@Id"

            ' ADO.NET 객체 생성
            Dim conn As New SqlConnection(ConfigurationSettings.AppSettings("DSN"))
            Dim comm As New SqlCommand(strSQL, conn)

            ' 파라미터 구성
            comm.Parameters.Add(New SqlParameter("@Id", Id))
            comm.Parameters.Add(New SqlParameter("@Writer", txtName.Text))
            comm.Parameters.Add(New SqlParameter("@Email", txtEmail.Text))
            comm.Parameters.Add(New SqlParameter("@content", txtContent.Text))

            ' Update 실행
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
