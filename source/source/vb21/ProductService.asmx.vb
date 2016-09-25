Imports System.Data.SqlClient
Imports System.Web.Services

<WebService(Namespace := "http://tempuri.org/")> _
Public Class ProductService
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

    ' ------------------------------------------------------------
    ' GetConnectionString - DB ���Ṯ�ڿ��� �����ϴ� �Լ�
    ' return type : String
    ' ------------------------------------------------------------
    Private Function GetConnectionString() As String
        Return "server=(local);database=Northwind;uid=sa;pwd=;"
    End Function

    ' ------------------------------------------------------------
    ' GetCategories - Categories ���̺��� ���ڵ带 �����ϴ� �Լ�
    ' return type : dsCategories
    ' ------------------------------------------------------------
    <WebMethod(Description:="Northwind�� Categories ���̺��� ��� ���ڵ带 �����մϴ�.")> _
    Public Function GetCategories() As dsCategories
        Dim conn As New SqlConnection(GetConnectionString())
        Dim comm As New SqlCommand("SELECT * FROM categories", conn)
        Dim adapter As New SqlDataAdapter(comm)
        Dim ds As New dsCategories()
        adapter.Fill(ds, "categories")
        Return ds
    End Function

    ' ------------------------------------------------------------
    ' GetCategories - CategoryID�� �ش��ϴ�
    '                 Products ���̺��� ���ڵ带 �����ϴ� �Լ�
    ' parameters : CategoryID(integer)
    ' return type : dsProducts
    ' ------------------------------------------------------------
    <WebMethod()> _
    Public Function GetProductsByCategoryID(ByVal CategoryID As Integer) As dsProducts
        Dim conn As New SqlConnection(GetConnectionString())
        Dim comm As New SqlCommand("SELECT * FROM products WHERE categoryid=@CategoryID", conn)
        comm.Parameters.Add(New SqlParameter("@CategoryID", CategoryID))
        Dim adapter As New SqlDataAdapter(comm)
        Dim ds As New dsProducts()
        adapter.Fill(ds, "products")
        Return ds
    End Function


End Class
