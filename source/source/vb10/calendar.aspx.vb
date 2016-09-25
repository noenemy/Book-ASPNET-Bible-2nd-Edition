Public Class calendar
    Inherits System.Web.UI.Page
    Protected WithEvents comSelectionMode As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar

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

    Private Sub comSelectionMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comSelectionMode.SelectedIndexChanged
        ' Calendar 컨트롤의 SelectionMode 설정
        Calendar1.SelectionMode = comSelectionMode.SelectedIndex
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged

        If Calendar1.SelectedDates.Count > 0 Then ' 선택된 날이 있으면
            Dim Day As DateTime
            ' 선택된 날 만큼 반복
            For Each Day In Calendar1.SelectedDates
                Response.Write(Day.ToShortDateString & "<br>")
            Next
            Response.Write("<hr>")
        End If
    End Sub
End Class
