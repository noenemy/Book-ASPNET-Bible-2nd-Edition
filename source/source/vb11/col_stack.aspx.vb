Public Class col_stack
    Inherits System.Web.UI.Page
    Protected WithEvents lstStack As System.Web.UI.WebControls.ListBox

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
            ' Stack 아이템 구성
            Dim st As New Stack()
            st.Push("John Petrucci")
            st.Push("Eric Johnson")
            st.Push("Pat Mathney")
            st.Push("Steve Vai")

            ' ListBox 컨트롤 데이터바인딩
            lstStack.DataSource = st
            lstStack.DataBind()
        End If
    End Sub

End Class
