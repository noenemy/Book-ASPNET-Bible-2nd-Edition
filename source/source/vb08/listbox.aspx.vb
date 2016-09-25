Public Class listbox
    Inherits System.Web.UI.Page
    Protected WithEvents txtItem As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
    Protected WithEvents lstSong As System.Web.UI.WebControls.ListBox
    Protected WithEvents btnOK As System.Web.UI.WebControls.Button
    Protected WithEvents lblSelection As System.Web.UI.WebControls.Label

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

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' ListItem ��ü ����
        Dim Item As New ListItem()
        Item.Value = txtItem.Text
        Item.Text = txtItem.Text
        ' ������ �÷��ǿ� �߰�
        lstSong.Items.Add(Item)
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If lstSong.SelectedIndex > -1 Then ' ������ ���� ������(���߼���)
            lblSelection.Text = "������ �� : "
            Dim Item As ListItem

            For Each Item In lstSong.Items ' ������ ����ŭ �ݺ�
                If Item.Selected = True Then
                    lblSelection.Text &= Item.Text & ","
                End If
            Next

        End If

    End Sub
End Class
