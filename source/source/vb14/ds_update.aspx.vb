Imports System.Data.SqlClient

Public Class ds_update
    Inherits System.Web.UI.Page
    Protected WithEvents txtID As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDesc As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnUpdate As System.Web.UI.WebControls.Button

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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        ' Connection 객체 생성해서 열기
        Dim conn As New SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;")

        ' Command 객체와 Parameter 객체 생성
        Dim cmdSelect As New SqlCommand("SELECT * FROM region", conn)
        Dim cmdUpdate As New SqlCommand("UPDATE region SET regiondescription = @desc WHERE regionid = @id", conn)
        cmdUpdate.Parameters.Add(New SqlParameter("@id", SqlDbType.Int, 4, "regionid"))
        cmdUpdate.Parameters.Add(New SqlParameter("@desc", SqlDbType.Char, 50, "regiondescription"))

        ' DataAdapter 객체 생성 및 Command 설정    
        Dim adapter As New SqlDataAdapter()
        adapter.SelectCommand = cmdSelect
        adapter.UpdateCommand = cmdUpdate


        ' Untyped DataSet 객체 생성하고 데이터 채우기
        Dim dataset As New DataSet()
        adapter.Fill(dataset, "region")

        ' 해당하는 DataRow를 찾기
        Dim table As DataTable = dataset.Tables("region")
        Dim row() As DataRow = table.Select("regionid = " & txtID.Text.ToString)

        If row.Length > 0 Then ' 해당하는 행이 있으면 값 변경해서 update
            row(0).Item("regiondescription") = txtDesc.Text.ToString
            ' 변경된 DataSet으로 Update하기
            Response.Write("DataAdpater의 Update 명령수행<hr>")
            adapter.Update(dataset, "region")
        Else
            Response.Write("해당하는 데이터가 없습니다.<hr>")
        End If
    End Sub
End Class
