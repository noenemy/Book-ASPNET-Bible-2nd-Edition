Public Class col_arraylist
    Inherits System.Web.UI.Page
    Protected WithEvents comArray As System.Web.UI.WebControls.DropDownList

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
        If Not Page.IsPostBack Then

            ' ArrayList ������ ����
            Dim arr As New ArrayList()
            arr.Add("�հ浿")
            arr.Add("�ѵ���")
            arr.Add("������")
            arr.Add("������")

            ' Dropdownlist ��Ʈ�� �����͹��ε�
            comArray.DataSource = arr
            comArray.DataBind()
        End If
    End Sub

End Class
