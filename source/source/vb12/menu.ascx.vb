Imports System.Data.SqlClient

Public MustInherit Class menu
    Inherits System.Web.UI.UserControl
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList

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

    ' RegionName ������Ƽ
    Private m_RegionName As String = ""
    Public Property RegionName() As String
        Get
            Return m_RegionName
        End Get
        Set(ByVal Value As String)
            m_RegionName = Value
        End Set
    End Property


    Event SelectionChanged As EventHandler  ' �̺�Ʈ ��ü ����

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If Not Page.IsPostBack Then
            ' customers ���̺��� region ���� ��������
            Dim conn As New SqlConnection("Server=(local);database=Northwind;uid=sa;pwd=")
            conn.Open()
            Dim comm As New SqlCommand("SELECT DISTINCT region FROM customers", conn)
            ' DataReader�� ������ �����ϱ�
            Dim reader As SqlDataReader
            reader = comm.ExecuteReader()
            ' DataList ��Ʈ�� ���ε��ϱ�
            DataList1.DataSource = reader
            DataList1.DataBind()
            ' DataReader, Connection ��ü �ݱ�
            reader.Close()
            conn.Close()
        End If
    End Sub

    Private Sub DataList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataList1.SelectedIndexChanged
        ' RegionName ������Ƽ ����
        RegionName = CType(DataList1.SelectedItem.FindControl("LinkButton1"), LinkButton).Text
        ' SelectionChanged �̺�Ʈ �߻�
        RaiseEvent SelectionChanged(Me, Nothing)
    End Sub
End Class
