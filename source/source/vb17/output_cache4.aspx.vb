Imports System.Data.SqlClient

Public Class output_cache4
    Inherits System.Web.UI.Page
    Protected WithEvents HyperLink1 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents HyperLink2 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents HyperLink3 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lblCountry As System.Web.UI.WebControls.Label
    Protected WithEvents lblCachedTime As System.Web.UI.WebControls.Label
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

        ' country 쿼리스트링 가져오기
        Dim country As String = Request.QueryString("country")
        If country = "" Then country = "UK"

        ' SQL 쿼리문 구성
        Dim strSQL As String = "SELECT * FROM customers WHERE country = '" & country & "'"

        ' ADO.NET 객체 생성
        Dim conn As New SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;")
        Dim comm As New SqlCommand(strSQL, conn)
        Dim adapter As New SqlDataAdapter(comm)
        Dim ds As New DataSet()

        ' 데이터 가져오기
        adapter.Fill(ds, "customers")

        ' DataGrid 컨트롤 데이터 바인딩
        DataGrid1.DataSource = ds
        DataGrid1.DataMember = "customers"
        DataGrid1.DataBind()

        ' 현재 국가, 캐시된 시각 출력
        lblCountry.Text = country
        lblCachedTime.Text = DateTime.Now.ToString()



    End Sub

End Class
