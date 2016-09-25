Imports System.Data.SqlClient

Public Class write
    Inherits System.Web.UI.Page
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtContent As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnWrite As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox

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
        ViewState("CurPage") = Request.QueryString("page")

    End Sub

    Private Sub btnWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWrite.Click

        ' SQL 쿼리문 만들기
        Dim strSQL As String
        strSQL = "INSERT INTO guestbook(writer,email,password,content) " & _
                 "VALUES(@Writer,@Email,@Password,@Content)"

        ' ADO.NET 객체 생성
        Dim conn As New SqlConnection(ConfigurationSettings.AppSettings("DSN"))
        Dim comm As New SqlCommand(strSQL, conn)

        ' 파라미터 구성
        comm.Parameters.Add(New SqlParameter("@writer", txtName.Text))
        comm.Parameters.Add(New SqlParameter("@Email", txtEmail.Text))
        comm.Parameters.Add(New SqlParameter("@Password", txtPassword.Text))
        comm.Parameters.Add(New SqlParameter("@Content", txtContent.Text))

        ' 게시물 쓰기
        conn.Open()
        comm.ExecuteNonQuery()
        conn.Close()

        ' list.aspx로 이동
        Response.Redirect("list.aspx")

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        ' list.aspx로 이동
        Dim CurPage As Integer = ViewState("CurPage")
        Dim goURL As String = "list.aspx?page=" & CurPage.ToString()
        Response.Redirect(goURL)
    End Sub
End Class
