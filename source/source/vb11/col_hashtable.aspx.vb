Public Class col_hashtable
    Inherits System.Web.UI.Page
    Protected WithEvents optHash As System.Web.UI.WebControls.RadioButtonList

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
            ' HashTable ������ ����
            Dim htSong As New Hashtable()
            htSong.Add("������", "��Ʈ����̾�")
            htSong.Add("����Ŭ�轼", "Invincible")
            htSong.Add("CBMASS", "���Ķ�")

            ' RadioButtonList ��Ʈ�� �����͹��ε�
            optHash.DataSource = htSong
            optHash.DataTextField = "Value"
            optHash.DataValueField = "Key"
            optHash.DataBind()

        End If
    End Sub

End Class
