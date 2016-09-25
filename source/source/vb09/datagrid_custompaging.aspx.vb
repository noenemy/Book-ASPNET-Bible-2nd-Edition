Imports System.Data.SqlClient

Public Class datagrid_custompaging
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

            ' 총 레코드 개수 얻기
            Dim conn As New SqlConnection("Server=(local);Database=Northwind;uid=sa;pwd=;")
            conn.Open()
            Dim comm As New SqlCommand("SELECT COUNT(*) FROM customers", conn)
            Dim RecordCount As Integer = comm.ExecuteScalar()
            conn.Close()

            ' VirtualItemCount 프로퍼티 설정
            DataGrid1.VirtualItemCount = RecordCount

            DataGridBind()
        End If
    End Sub

    Private Sub DataGridBind()

        ' 현재 페이지 번호와 총 페이지 개수 구하기
        Dim PageNo, PageCount As Integer
        PageNo = DataGrid1.CurrentPageIndex + 1
        PageCount = Int(DataGrid1.VirtualItemCount / DataGrid1.PageSize) + 1

        Response.Write("Page : " & PageNo & "/" & PageCount)

        ' 가져올 레코드 개수
        Dim TopCount As Integer = PageNo * DataGrid1.PageSize

        ' 데이터 가져오기
        Dim strSQL As String
        strSQL = "SELECT TOP " & TopCount & " * FROM customers"
        Response.Write(" Query : " & strSQL)
        Dim conn As New SqlConnection("Server=(local);Database=Northwind;uid=sa;pwd=;")
        Dim adapter As New SqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet()

        ' 화면에 출력할 레코드의 시작위치
        Dim StartRecord As Integer
        StartRecord = DataGrid1.CurrentPageIndex * DataGrid1.PageSize

        ' DataSet 채우기
        adapter.Fill(ds, StartRecord, DataGrid1.PageSize, "customers")

        ' DataGrid 데이터바인딩
        DataGrid1.DataSource = ds
        DataGrid1.DataMember = "customers"
        DataGrid1.DataBind()

    End Sub

    Private Sub DataGrid1_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGrid1.PageIndexChanged
        DataGrid1.CurrentPageIndex = e.NewPageIndex
        DataGridBind()
    End Sub
End Class
