Public Class adrotator
    Inherits System.Web.UI.Page
    Protected WithEvents comKeyword As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnReload As System.Web.UI.WebControls.Button
    Protected WithEvents AdRotator1 As System.Web.UI.WebControls.AdRotator

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
    End Sub

    Private Sub comKeyword_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comKeyword.SelectedIndexChanged
        ' ���͸� Ű���� ����
        AdRotator1.KeywordFilter = comKeyword.SelectedItem.Text
    End Sub
End Class