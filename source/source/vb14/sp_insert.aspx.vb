Imports System.Data.SqlClient
Public Class sp_insert
    Inherits System.Web.UI.Page
    Protected WithEvents txtCompany As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPhone As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Connection 객체 생성해서 열기
        Dim conn As New SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;")
        conn.Open()

        ' Command, Parameter 객체 생성
        Dim comm As New SqlCommand()
        comm.CommandText = "sp_InsertShipper"
        comm.CommandType = CommandType.StoredProcedure
        comm.Connection = conn

        Dim param As New SqlParameter()

        ' @id, @desc Parameter 설정
        param = comm.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40)
        param.Direction = ParameterDirection.Input
        param.Value = txtCompany.Text.ToString

        param = comm.Parameters.Add("@Phone", SqlDbType.NVarChar, 24)
        param.Direction = ParameterDirection.Input
        param.Value = txtPhone.Text.ToString

        param = comm.Parameters.Add("@ShipperID", SqlDbType.Int, 4)
        param.Direction = ParameterDirection.Output

        ' sp_InsertShipper 실행
        Dim intAffected As Integer
        intAffected = comm.ExecuteNonQuery()

        ' 결과출력하고 Connection 닫기
        Response.Write(intAffected.ToString & " rows Inserted.<hr>")
        conn.Close()

        ' Ouput Parameter 값 얻기
        Dim ShipperID As String = comm.Parameters.Item("@ShipperID").Value
        Response.Write("부여받은 ID는 " & ShipperID & "입니다.<hr>")
    End Sub
End Class
