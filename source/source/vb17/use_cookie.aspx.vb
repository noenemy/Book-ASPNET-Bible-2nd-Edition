Public Class use_cookie
    Inherits System.Web.UI.Page
    Protected WithEvents lblResult As System.Web.UI.WebControls.Label
    Protected WithEvents btnPlus As System.Web.UI.WebControls.Button
    Protected WithEvents btnMinus As System.Web.UI.WebControls.Button

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

    Private Result As Integer

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If Not Page.IsPostBack Then
            Result = 0
        Else
            Result = Request.Cookies("Result").Value
        End If
        ShowResult()
    End Sub

    Private Sub ShowResult()
        ' �� ����ϰ�, ��Ű �����ϱ�
        lblResult.Text = Result.ToString
        Response.Cookies("Result").Value = Result
    End Sub

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        ' ���� �� + 1
        Result = Result + 1
        ShowResult()
    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        ' ���� �� - 1
        Result = Result - 1
        ShowResult()
    End Sub
End Class
