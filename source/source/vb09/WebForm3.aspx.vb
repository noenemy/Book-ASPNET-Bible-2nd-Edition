Imports System.Data
Imports System.Data.SqlClient

Public Class WebForm3
    Inherits System.Web.UI.Page

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

        Dim conn As New SqlConnection("server=(local);database=northwind;uid=sa;pwd=;")
        conn.Open()
        Dim strSQL As String = "SELECT COUNT(*) FROM categories"
        Dim comm As New SqlCommand(strSQL, conn)
        Dim intCount As Integer = CType(comm.ExecuteScalar(), Integer)
        Response.Write(intCount.ToString)


        conn.Close()

    End Sub

End Class
