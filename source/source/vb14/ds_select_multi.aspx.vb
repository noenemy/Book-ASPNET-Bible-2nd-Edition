Imports System.Data.SqlClient

Public Class ds_select_multi
    Inherits System.Web.UI.Page
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnBind As System.Web.UI.WebControls.Button
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid

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

        ' DataAdapter, Command, DataSet ��ü ����   
        Dim adapter As New SqlDataAdapter()
        Dim dataset As New DataSet()
        Dim comm As New SqlCommand()

        comm.Connection = conn

        ' categories ���̺� ��������
        comm.CommandText = "SELECT * FROM categories"
        adapter.SelectCommand = comm
        adapter.Fill(dataset, "categories")

        ' region ���̺� ��������
        comm.CommandText = "SELECT * FROM region"
        adapter.SelectCommand = comm
        adapter.Fill(dataset, "region")

        ' DataSet�� �̿��ؼ� DataGrid ��Ʈ�� ���ε�
        DataGrid1.DataSource = dataset.Tables(0)
        DataGrid1.DataBind()
        DataGrid2.DataSource = dataset.Tables(1)
        DataGrid2.DataBind()


    End Sub
End Class
