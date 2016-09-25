Imports System.Data.SqlClient

Public MustInherit Class pagelet3
    Inherits System.Web.UI.UserControl
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label

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

    Public _Region As String = ""

    Public Property Region() As String
        Get
            Return _Region
        End Get
        Set(ByVal Value As String)
            _Region = Value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If Not Page.IsPostBack Then
            ShowCustomers()
        End If
    End Sub

    Public Sub ShowCustomers()
        ' Region 표시
        Label1.Text = _Region

        ' 해당 Region에 속하는 고객정보 가져오기
        Dim conn As New SqlConnection("Server=(local);Database=Northwind;uid=sa;pwd=;")
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM customers WHERE region=@region", conn)
        comm.Parameters.Add(New SqlParameter("@region", _Region))
        Dim reader As SqlDataReader = comm.ExecuteReader()

        ' DataGrid 컨트롤에 DataReader 객체 바인딩
        DataGrid1.DataSource = reader
        DataGrid1.DataBind()
        reader.Close()
        conn.Close()
    End Sub

End Class
