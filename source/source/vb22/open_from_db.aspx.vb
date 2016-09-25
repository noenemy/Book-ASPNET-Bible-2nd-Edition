Imports System.Data.SqlClient

Public Class open_from_db
    Inherits System.Web.UI.Page

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

        ' 파일의 Id 값 얻기
        Dim Id As Integer = CInt(Request.QueryString("id"))

        ' ADO.NET 객체 생성
        Dim conn As New SqlConnection("server=(local);database=ASPNETBible;uid=sa;pwd=;")
        Dim comm As New SqlCommand("SELECT * FROM upload_test WHERE id = @Id", conn)

        ' 파라미터 구성
        Dim Param1 As New SqlParameter("@Id", SqlDbType.Int)
        Param1.Value = Id
        comm.Parameters.Add(Param1)

        ' DataReader로 읽기
        conn.Open()
        Dim dr As SqlDataReader
        dr = comm.ExecuteReader()
        dr.Read()

        ' OutputStream으로 파일 출력하기
        Response.ContentType = dr("content_type")
        Response.OutputStream.Write(dr("content"), 0, dr("file_size"))
        Response.End()

        conn.Close()

    End Sub

End Class
