Imports System.Data.SqlClient

Public Class dr_select1
    Inherits System.Web.UI.Page
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnBind As System.Web.UI.WebControls.Button

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

    Private Sub btnBind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBind.Click

        ' Connection 객체 생성해서 열기
        Dim conn As New SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;")
        conn.Open()

        ' Command 객체 생성
        Dim strSQL As String = "SELECT * FROM categories"
        Dim comm As New SqlCommand(strSQL, conn)

        ' DataReader 생성하기    
        Dim reader As SqlDataReader = comm.ExecuteReader()

        ' DataReader를 이용해서 DataGrid 컨트롤 바인딩
        DataGrid1.DataSource = reader
        DataGrid1.DataBind()

        ' DataReader와 Connection 닫기
        reader.Close()
        conn.Close()

    End Sub
End Class
