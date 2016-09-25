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
            ' HashTable 아이템 구성
            Dim htSong As New Hashtable()
            htSong.Add("서태지", "울트라맨이야")
            htSong.Add("마이클잭슨", "Invincible")
            htSong.Add("CBMASS", "휘파람")

            ' RadioButtonList 컨트롤 데이터바인딩
            optHash.DataSource = htSong
            optHash.DataTextField = "Value"
            optHash.DataValueField = "Key"
            optHash.DataBind()

        End If
    End Sub

End Class
