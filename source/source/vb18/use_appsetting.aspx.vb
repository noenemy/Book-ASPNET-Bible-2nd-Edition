Imports System.Data.SqlClient

Public Class use_appsetting
    Inherits System.Web.UI.Page
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid

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

            ' 데이터베이스 연결 문자열 가져오기
            Dim strDSN As String
            strDSN = ConfigurationSettings.AppSettings("DSN")
            Response.Write(strDSN)

            ' Connection, Command, DataReader 객체 생성
            Dim conn As New SqlConnection(strDSN)
            conn.Open()
            Dim comm As New SqlCommand("SELECT * FROM categories", conn)
            Dim ds As SqlDataReader

            ' 데이터 가져오기
            ds = comm.ExecuteReader()

            ' DataGrid 데이터바인딩
            DataGrid1.DataSource = ds
            DataGrid1.DataBind()

            ' DataReader, Connection 객체 닫기
            ds.Close()
            conn.Close()

        End If

    End Sub

End Class
