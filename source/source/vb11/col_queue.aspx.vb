Public Class col_queue
    Inherits System.Web.UI.Page
    Protected WithEvents chkQueue As System.Web.UI.WebControls.CheckBoxList

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
            ' Queue 아이템 구성
            Dim q As New Queue()
            q.Enqueue("HDD")
            q.Enqueue("CPU")
            q.Enqueue("VGA")
            q.Enqueue("RAM")

            ' CheckBoxList 컨트롤 데이터바인딩
            chkQueue.DataSource = q
            chkQueue.DataBind()
        End If
    End Sub

End Class
