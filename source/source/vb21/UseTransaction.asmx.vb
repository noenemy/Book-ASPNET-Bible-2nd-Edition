Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.EnterpriseServices

<WebService(Namespace := "http://tempuri.org/")> _
Public Class UseTransaction
    Inherits System.Web.Services.WebService

#Region " Web Services Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Web Services Designer.
        InitializeComponent()

        'Add your own initialization code after the InitializeComponent() call

    End Sub

    'Required by the Web Services Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Web Services Designer
    'It can be modified using the Web Services Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'CODEGEN: This procedure is required by the Web Services Designer
        'Do not modify it using the code editor.
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#End Region

    ' WEB SERVICE EXAMPLE
    ' The HelloWorld() example service returns the string Hello World.
    ' To build, uncomment the following lines then save and build the project.
    ' To test this web service, ensure that the .asmx file is the start page
    ' and press F5.
    '
    '<WebMethod()> Public Function HelloWorld() As String
    '	HelloWorld = "Hello World"
    ' End Function

    <WebMethod(TransactionOption:=TransactionOption.RequiresNew)> _
     Public Function TransactionTest() As String

        ' 정상적으로 실행될 SQL문
        Dim strSQL1 As String = "INSERT INTO region(regionid,regiondescription) VALUES(5,'서초구')"
        ' 예외를 발생시킬 SQL문
        Dim strSQL2 As String = "DELETE FROM unknown_table"

        Dim conn As New SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;")
        conn.Open()

        Dim comm1 As New SqlCommand(strSQL1, conn)
        Dim comm2 As New SqlCommand(strSQL2, conn)


        Try

            ' comm1은 정상적으로 실행된다.
            comm1.ExecuteNonQuery()

            ' comm2는 unknown_table을 찾을 수 없다는 에러가 발생할 것이다.
            ' 이 웹 메소드는 트랜잭션에 참여하고 있으므로
            ' comm1에서 실행된 결과는 자동으로 rollback 될 것이다.
            comm2.ExecuteNonQuery()

            ContextUtil.SetComplete()

            Return "Transaction Committed!"

        Catch ex As Exception

            ContextUtil.SetAbort()

            Return "Transaction Rollbacked! : " & ex.Message

        Finally
            conn.Close()
        End Try

    End Function



End Class
