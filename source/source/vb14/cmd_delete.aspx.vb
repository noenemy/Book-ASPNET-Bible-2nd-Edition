Imports System.Data.SqlClient

Public Class cmd_delete
    Inherits System.Web.UI.Page
    Protected WithEvents btnDelete As System.Web.UI.WebControls.Button
    Protected WithEvents txtID As System.Web.UI.WebControls.TextBox

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

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ' Connection 객체 생성해서 열기
        Dim conn As New SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;")
        conn.Open()

        ' Command, Parameter 객체 생성
        Dim strSQL As String = "DELETE FROM region WHERE regionid = @id"
        Dim comm As New SqlCommand(strSQL, conn)
        Dim param As New SqlParameter()

        ' @id Parameter 설정
        param = comm.Parameters.Add("@id", SqlDbType.Int)
        param.Direction = ParameterDirection.Input
        param.Value = CType(txtID.Text.ToString, Integer)

        ' DELETE문 실행
        Dim intAffected As Integer
        intAffected = comm.ExecuteNonQuery()

        ' 결과출력하고 Connection 닫기
        Response.Write(intAffected.ToString & " rows deleted.<hr>")
        conn.Close()
    End Sub
End Class
