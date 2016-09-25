Imports System.Data.SqlClient

Public Class ds_select3
    Inherits System.Web.UI.Page
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnBind As System.Web.UI.WebControls.Button

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

    Private Sub btnBind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBind.Click

        ' Connection ��ü �����ؼ� ����
        Dim conn As New SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;")
        conn.Open()

        ' Command ��ü ����
        Dim strSQL As String = "SELECT * FROM categories WHERE categoryid > @id"
        Dim comm As New SqlCommand(strSQL, conn)

        ' Parameter ��ü ������ Command ��ü�� �߰�
        Dim param As New SqlParameter("@id", SqlDbType.Int)
        param.Value = 3
        comm.Parameters.Add(param)

        ' DataAdapter ��ü �����ϱ�    
        Dim adapter As New SqlDataAdapter(comm)

        ' Untyped DataSet ��ü �����ϰ� ������ ä���
        Dim dataset As New DataSet()
        adapter.Fill(dataset, "categories")

        ' DataSet�� �̿��ؼ� DataGrid ��Ʈ�� ���ε�
        DataGrid1.DataSource = dataset
        DataGrid1.DataBind()
    End Sub
End Class
