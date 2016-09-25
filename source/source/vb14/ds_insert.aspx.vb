Imports System.Data.SqlClient

Public Class ds_insert
    Inherits System.Web.UI.Page
    Protected WithEvents txtID As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDesc As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnInsert As System.Web.UI.WebControls.Button

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

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        ' Connection ��ü �����ؼ� ����
        Dim conn As New SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;")

        ' Command ��ü�� Parameter ��ü ����
        Dim cmdSelect As New SqlCommand("SELECT * FROM region", conn)
        Dim cmdInsert As New SqlCommand("INSERT INTO region(regionid,regiondescription) VALUES(@id,@desc)", conn)
        cmdInsert.Parameters.Add(New SqlParameter("@id", SqlDbType.Int, 4, "regionid"))
        cmdInsert.Parameters.Add(New SqlParameter("@desc", SqlDbType.Char, 50, "regiondescription"))

        ' DataAdapter ��ü ���� �� Command ����    
        Dim adapter As New SqlDataAdapter()
        adapter.SelectCommand = cmdSelect
        adapter.InsertCommand = cmdInsert


        ' Untyped DataSet ��ü �����ϰ� ������ ä���
        Dim dataset As New DataSet()
        adapter.Fill(dataset, "region")

        ' DataTable�� DataRow �߰��ϱ�
        Dim table As DataTable = dataset.Tables("region")
        Dim row As DataRow = table.NewRow()
        row.Item("regionid") = txtID.Text.ToString
        row.Item("regiondescription") = txtDesc.Text.ToString
        table.Rows.Add(row)

        ' ����� DataSet���� Update�ϱ�
        Response.Write("DataAdpater�� Update ��ɼ���<hr>")
        adapter.Update(dataset, "region")


    End Sub
End Class
