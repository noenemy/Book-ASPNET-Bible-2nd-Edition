Public Class table
    Inherits System.Web.UI.Page
    Protected WithEvents Table1 As System.Web.UI.WebControls.Table
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' TableRow, TableCell ��ü ����
        Dim Row As New TableRow()
        Dim Cell1 As New TableCell()
        Dim Cell2 As New TableCell()
        Dim Cell3 As New TableCell()

        ' TableCell �÷����� TableRow ��ü�� �߰��ϱ�
        Cell1.Text = "ȫ�浿"
        Row.Cells.Add(Cell1)
        Cell2.Text = "hongkildong@dotnetxpert.com"
        Row.Cells.Add(Cell2)
        Cell3.Text = "065-101-1100"
        Row.Cells.Add(Cell3)

        ' TableRow �÷����� Table ��ü�� �߰��ϱ�
        Table1.Rows.Add(Row)

    End Sub
End Class
