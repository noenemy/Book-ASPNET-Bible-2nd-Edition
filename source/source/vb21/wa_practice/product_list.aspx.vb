Public Class product_list
    Inherits System.Web.UI.Page
    Protected WithEvents comCategories As System.Web.UI.WebControls.DropDownList
    Protected WithEvents grdProducts As System.Web.UI.WebControls.DataGrid

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
            ' ProductService 웹 서비스 객체 생성
            Dim ws As New localhost.ProductService()
            ' GetCategories 웹 메소드 호출해서 Categories 데이터 얻기
            comCategories.DataSource = ws.GetCategories()
            comCategories.DataTextField = "CategoryName"
            comCategories.DataValueField = "CategoryID"
            ' DropDownList 데이터바인딩
            comCategories.DataBind()
            ' 초기 CategoryID 값 설정
            comCategories.SelectedIndex = 0
            ShowProductsList(CType(comCategories.SelectedItem.Value, Integer))
        End If
    End Sub

    Private Sub ShowProductsList(ByVal CategoryID As Integer)
        ' 인자로 받은 CategoriID 값으로
        ' GetProductsByCategoryID 웹 메소드 호출해서 
        ' DataGrid 컨트롤 데이터 바인딩
        Dim ws As New localhost.ProductService()
        grdProducts.DataSource = ws.GetProductsByCategoryID(CategoryID)
        grdProducts.DataBind()

    End Sub


    Private Sub comCategories_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comCategories.SelectedIndexChanged
        ' 사용자가 선택한 CategoryID 값이 바뀌면
        ' 해당 CategoryID에 해당하는 Products 리스트로 갱신
        Dim CategoryID As Integer = CType(comCategories.SelectedItem.Value, Integer)
        ShowProductsList(CategoryID)
    End Sub
End Class
