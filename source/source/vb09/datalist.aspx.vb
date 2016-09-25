Public Class datalist
    Inherits System.Web.UI.Page
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList
    Protected WithEvents btnImage As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblVender As System.Web.UI.WebControls.Label
    Protected WithEvents lblProductName As System.Web.UI.WebControls.Label
    Protected WithEvents lblSpec As System.Web.UI.WebControls.Label
    Protected WithEvents lblPrice As System.Web.UI.WebControls.Label
    Protected WithEvents DsProduct1 As list_control2.dsProduct

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.DsProduct1 = New list_control2.dsProduct()
        CType(Me.DsProduct1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "product", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("product_name", "product_name"), New System.Data.Common.DataColumnMapping("vender", "vender"), New System.Data.Common.DataColumnMapping("description", "description"), New System.Data.Common.DataColumnMapping("spec", "spec"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("image", "image")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM product WHERE (Id = @Id) AND (description = @description OR @descript" & _
        "ion1 IS NULL AND description IS NULL) AND (image = @image OR @image1 IS NULL AND" & _
        " image IS NULL) AND (price = @price) AND (product_name = @product_name) AND (spe" & _
        "c = @spec OR @spec1 IS NULL AND spec IS NULL) AND (vender = @vender)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@description", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "description", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@description1", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "description", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "image", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "image", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@product_name", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "product_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@spec", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "spec", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@spec1", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "spec", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vender", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vender", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "data source=(local);initial catalog=pdashop;password="""";persist security info=Tru" & _
        "e;user id=sa;packet size=4096"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO product(Id, product_name, vender, description, spec, price, image) VA" & _
        "LUES (@Id, @product_name, @vender, @description, @spec, @price, @image); SELECT " & _
        "Id, product_name, vender, description, spec, price, image FROM product WHERE (Id" & _
        " = @Select_Id)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@product_name", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "product_name", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vender", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vender", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@description", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "description", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@spec", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "spec", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "image", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Select_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id, product_name, vender, description, spec, price, image FROM product"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE product SET Id = @Id, product_name = @product_name, vender = @vender, desc" & _
        "ription = @description, spec = @spec, price = @price, image = @image WHERE (Id =" & _
        " @Original_Id) AND (description = @Original_description OR @Original_description" & _
        "1 IS NULL AND description IS NULL) AND (image = @Original_image OR @Original_ima" & _
        "ge1 IS NULL AND image IS NULL) AND (price = @Original_price) AND (product_name =" & _
        " @Original_product_name) AND (spec = @Original_spec OR @Original_spec1 IS NULL A" & _
        "ND spec IS NULL) AND (vender = @Original_vender); SELECT Id, product_name, vende" & _
        "r, description, spec, price, image FROM product WHERE (Id = @Select_Id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@product_name", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "product_name", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vender", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vender", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@description", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "description", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@spec", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "spec", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "image", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_description", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "description", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_description1", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "description", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_image", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "image", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_image1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "image", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_product_name", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "product_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_spec", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "spec", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_spec1", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, True, CType(0, Byte), CType(0, Byte), "spec", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vender", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vender", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Select_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Current, Nothing))
        '
        'DsProduct1
        '
        Me.DsProduct1.DataSetName = "dsProduct"
        Me.DsProduct1.Locale = New System.Globalization.CultureInfo("ko-KR")
        Me.DsProduct1.Namespace = "http://www.tempuri.org/dsProduct.xsd"
        CType(Me.DsProduct1, System.ComponentModel.ISupportInitialize).EndInit()

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
            SqlDataAdapter1.Fill(DsProduct1)
            DataList1.DataBind()
        End If
    End Sub
End Class
