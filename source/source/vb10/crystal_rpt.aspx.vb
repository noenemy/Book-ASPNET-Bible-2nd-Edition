Imports System.Data.SqlClient

Public Class crystal_rpt
    Inherits System.Web.UI.Page
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer

#Region " Web Form �����̳ʿ��� ������ �ڵ� "

    '�� ȣ���� Web Form �����̳ʿ� �ʿ��մϴ�.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: �� �޼��� ȣ���� Web Form �����̳ʿ� �ʿ��մϴ�.
        '�ڵ� �����⸦ ����Ͽ� �������� ���ʽÿ�.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '���⿡ ����� �ڵ带 ��ġ�Ͽ� �������� �ʱ�ȭ�մϴ�.

        ' �����ͺ��̽� ���� ����
        Dim conn As New SqlConnection("Server=(local);Database=Northwind;uid=sa;pwd=;")
        Dim comm As New SqlCommand("SELECT * FROM categories", conn)
        Dim adapter As New SqlDataAdapter(comm)
        Dim ds As New dsCategories()

        ' DataSet ä��� (report ������ ����� ���̺� �̸��� �����ؾ��Ѵ�.)
        adapter.Fill(ds, "categories")
        ' Report ��ü ���� 
        Dim rpt As New rptCategory()
        ' ����Ʈ ����ϱ�        rpt.SetDataSource(ds) 
        CrystalReportViewer1.ReportSource = rpt
    End Sub

End Class
