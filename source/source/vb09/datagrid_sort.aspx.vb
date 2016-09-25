Public Class datagrid_sort
    Inherits System.Web.UI.Page
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents DataView1 As System.Data.DataView
    Protected WithEvents DsCategories1 As list_control2.dsCategories

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsCategories1 = New list_control2.dsCategories()
        Me.DataView1 = New System.Data.DataView()
        CType(Me.DsCategories1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "data source=(local);initial catalog=Northwind;password="""";persist security info=Tr" & _
        "ue;user id=sa;packet size=4096"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Categories(CategoryName, Description, Picture) VALUES (@CategoryName," & _
        " @Description, @Picture); SELECT CategoryID, CategoryName, Description, Picture " & _
        "FROM Categories WHERE (CategoryID = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 16, "Description"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 16, "Picture"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Categories SET CategoryName = @CategoryName, Description = @Description, P" & _
        "icture = @Picture WHERE (CategoryID = @Original_CategoryID) AND (CategoryName = " & _
        "@Original_CategoryName); SELECT CategoryID, CategoryName, Description, Picture F" & _
        "ROM Categories WHERE (CategoryID = @CategoryID)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 16, "Description"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 16, "Picture"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CategoryID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CategoryName", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Categories WHERE (CategoryID = @Original_CategoryID) AND (CategoryNam" & _
        "e = @Original_CategoryName)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CategoryID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CategoryName", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Picture", "Picture")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DsCategories1
        '
        Me.DsCategories1.DataSetName = "dsCategories"
        Me.DsCategories1.Locale = New System.Globalization.CultureInfo("ko-KR")
        Me.DsCategories1.Namespace = "http://www.tempuri.org/dsCategories.xsd"
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsCategories1.Categories
        CType(Me.DsCategories1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        SqlDataAdapter1.Fill(DsCategories1)
        DataGrid1.DataBind()
    End Sub

    Private Sub DataGrid1_SortCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles DataGrid1.SortCommand

        ' 정렬 규칙 정하기
        Dim strOrder As String
        strOrder = "ASC"

        ' 현재 정렬상태가 해당 필드이고 오름차순(ASC)이면 내림차순(DESC)로 설정
        If DataGrid1.Attributes("field") = e.SortExpression And DataGrid1.Attributes("order") = "ASC" Then
            strOrder = "DESC"
        End If

        ' 정렬규칙을 DataGrid의 Attributes에 저장
        DataGrid1.Attributes("field") = e.SortExpression
        DataGrid1.Attributes("order") = strOrder

        Response.Write("정렬규칙 : " & e.SortExpression & "," & strOrder)
        ' DataView를 이용하여 정렬하여 바인딩하기

        SqlDataAdapter1.Fill(DsCategories1)
        DataView1.Sort = e.SortExpression & " " & strOrder
        DataGrid1.DataBind()
    End Sub
End Class
