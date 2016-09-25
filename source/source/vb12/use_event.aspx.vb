Public Class use_event
    Inherits System.Web.UI.Page

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

    Protected WithEvents menu1 As menu
    Protected pagelet31 As pagelet3

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub menu1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles menu1.SelectionChanged
        ' 메뉴에서 선택된 지역이름을 가져와서 바인딩하기
        pagelet31.Region = menu1.RegionName
        pagelet31.ShowCustomers()
    End Sub
End Class
