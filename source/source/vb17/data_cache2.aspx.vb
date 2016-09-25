Imports System.Data.SqlClient

Public Class data_cache2
    Inherits System.Web.UI.Page
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid

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

        If Cache("customers") Is Nothing Then
            ' ĳ�õ� �����Ͱ� ������ ������ ĳ���ϱ�

            ' ADO.NET ��ü ����
            Dim conn As New SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;")
            Dim comm As New SqlCommand("SELECT * FROM customers", conn)
            Dim adapter As New SqlDataAdapter(comm)
            Dim ds As New DataSet()

            ' ������ ��������
            adapter.Fill(ds, "customers")

            ' ĳ�ÿ� ������ �ֱ�
            Cache.Insert("customers", ds, Nothing, DateTime.Now.AddSeconds(10), TimeSpan.Zero)
            Cache("cached_time") = DateTime.Now.ToString()

        End If

        ' ������ ĳ�ø� �̿��� �����͹��ε�
        DataGrid1.DataSource = Cache("customers")
        DataGrid1.DataMember = "customers"
        DataGrid1.DataBind()
        Label1.Text = "������ ĳ�õ� �ð� : " & Cache("cached_time")

    End Sub

End Class
