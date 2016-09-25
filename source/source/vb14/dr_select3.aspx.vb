Imports System.Data.SqlClient

Public Class dr_select3
    Inherits System.Web.UI.Page
    Protected WithEvents btnSelect As System.Web.UI.WebControls.Button

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

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        ' Connection 객체 생성해서 열기
        Dim conn As New SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;")
        conn.Open()

        ' Command 객체 생성
        Dim strSQL As String = "SELECT COUNT(*) FROM categories"
        Dim comm As New SqlCommand(strSQL, conn)

        ' ExecuteScalar를 통해 값 얻기    
        Dim intCount As Integer = CType(comm.ExecuteScalar(), Integer)

        ' Connection 닫기
        conn.Close()

        Response.Write("현재 카테고리 개수는 " & intCount.ToString & "개 입니다.<hr>")

    End Sub
End Class
