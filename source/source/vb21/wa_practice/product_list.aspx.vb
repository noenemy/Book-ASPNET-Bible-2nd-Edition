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
            ' ProductService �� ���� ��ü ����
            Dim ws As New localhost.ProductService()
            ' GetCategories �� �޼ҵ� ȣ���ؼ� Categories ������ ���
            comCategories.DataSource = ws.GetCategories()
            comCategories.DataTextField = "CategoryName"
            comCategories.DataValueField = "CategoryID"
            ' DropDownList �����͹��ε�
            comCategories.DataBind()
            ' �ʱ� CategoryID �� ����
            comCategories.SelectedIndex = 0
            ShowProductsList(CType(comCategories.SelectedItem.Value, Integer))
        End If
    End Sub

    Private Sub ShowProductsList(ByVal CategoryID As Integer)
        ' ���ڷ� ���� CategoriID ������
        ' GetProductsByCategoryID �� �޼ҵ� ȣ���ؼ� 
        ' DataGrid ��Ʈ�� ������ ���ε�
        Dim ws As New localhost.ProductService()
        grdProducts.DataSource = ws.GetProductsByCategoryID(CategoryID)
        grdProducts.DataBind()

    End Sub


    Private Sub comCategories_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comCategories.SelectedIndexChanged
        ' ����ڰ� ������ CategoryID ���� �ٲ��
        ' �ش� CategoryID�� �ش��ϴ� Products ����Ʈ�� ����
        Dim CategoryID As Integer = CType(comCategories.SelectedItem.Value, Integer)
        ShowProductsList(CategoryID)
    End Sub
End Class
