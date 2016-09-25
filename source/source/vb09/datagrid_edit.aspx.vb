Public Class datagrid_edit
    Inherits System.Web.UI.Page
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
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
        CType(Me.DsCategories1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "data source=(local);initial catalog=Northwind;password=a#292503;persist security " & _
        "info=True;user id=sa;packet size=4096"
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
        CType(Me.DsCategories1, System.ComponentModel.ISupportInitialize).EndInit()

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
            SqlDataAdapter1.Fill(DsCategories1)
            DataGrid1.DataBind()
        End If
    End Sub



    Private Sub DataGrid1_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid1.EditCommand

        ' SelectedIndex 초기화
        DataGrid1.SelectedIndex = -1

        ' EditItemIndex 설정
        SqlDataAdapter1.Fill(DsCategories1)
        DataGrid1.EditItemIndex = e.Item.ItemIndex
        DataGrid1.DataBind()
    End Sub

    Private Sub DataGrid1_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid1.CancelCommand
        ' EditItemIndex 초기화
        SqlDataAdapter1.Fill(DsCategories1)
        DataGrid1.EditItemIndex = -1
        DataGrid1.DataBind()
    End Sub

    Private Sub DataGrid1_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid1.DeleteCommand
        ' SelectedIndex, EditItemIndex 초기화
        DataGrid1.SelectedIndex = -1
        DataGrid1.EditItemIndex = -1
        SqlDataAdapter1.Fill(DsCategories1)

        ' 현재 선택된 행의 CategoryID 값 얻기
        Dim DeleteItemID As String
        DeleteItemID = DataGrid1.DataKeys.Item(e.Item.ItemIndex)

        ' 해당행 삭제
        Dim Row() As DataRow
        Row = DsCategories1.Categories.Select("CategoryID = " & DeleteItemID)
        Row(0).Delete()

        ' DataAdapter를 이용해서 DB 업데이트
        SqlDataAdapter1.Update(DsCategories1)
        DataGrid1.DataBind()
    End Sub

    Private Sub DataGrid1_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid1.UpdateCommand
        ' SelectedIndex, EditItemIndex 초기화
        DataGrid1.SelectedIndex = -1
        DataGrid1.EditItemIndex = -1
        SqlDataAdapter1.Fill(DsCategories1)

        ' 업데이트할 행의 CategoryID 값 얻기
        Dim UpdateItemID As String
        UpdateItemID = DataGrid1.DataKeys.Item(e.Item.ItemIndex)

        ' 해당행 필드값 수정
        Dim Row() As DataRow
        Row = DsCategories1.Categories.Select("CategoryID = " & UpdateItemID)
        Row(0)("CategoryName") = CType(e.Item.Cells(0).Controls(0), TextBox).Text()
        Row(0)("Description") = CType(e.Item.Cells(1).Controls(0), TextBox).Text()

        ' DataAdapter를 이용해서 DB 업데이트
        SqlDataAdapter1.Update(DsCategories1)
        DataGrid1.DataBind()
    End Sub
End Class
