Imports System.Data.SqlClient

Public Class ds_delete
    Inherits System.Web.UI.Page
    Protected WithEvents txtID As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnDelete As System.Web.UI.WebControls.Button

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

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        ' Connection 객체 생성해서 열기
        Dim conn As New SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;")

        ' Command 객체와 Parameter 객체 생성
        Dim cmdSelect As New SqlCommand("SELECT * FROM region", conn)
        Dim cmdDelete As New SqlCommand("DELETE FROM region WHERE regionid = @id", conn)
        cmdDelete.Parameters.Add(New SqlParameter("@id", SqlDbType.Int, 4, "regionid"))

        ' DataAdapter 객체 생성 및 Command 설정    
        Dim adapter As New SqlDataAdapter()
        adapter.SelectCommand = cmdSelect
        adapter.DeleteCommand = cmdDelete

        ' Untyped DataSet 객체 생성하고 데이터 채우기
        Dim dataset As New DataSet()
        adapter.Fill(dataset, "region")

        ' 해당하는 DataRow를 찾기
        Dim table As DataTable = dataset.Tables("region")
        Dim row() As DataRow = table.Select("regionid = " & txtID.Text.ToString)

        If row.Length > 0 Then ' 해당하는 행이 있으면 삭제
            row(0).Delete()
            Response.Write("DataAdpater의 Update 명령수행<hr>")
            adapter.Update(dataset, "region")
        Else
            Response.Write("해당하는 데이터가 없습니다.<hr>")
        End If
    End Sub
End Class
