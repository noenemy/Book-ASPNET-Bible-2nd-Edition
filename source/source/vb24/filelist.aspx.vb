Imports System.IO

Public Class filelist
    Inherits System.Web.UI.Page
    Protected WithEvents lstDir As System.Web.UI.WebControls.DataList
    Protected WithEvents File1 As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents btnUpload As System.Web.UI.WebControls.Button
    Protected WithEvents NewDirName As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnCD As System.Web.UI.WebControls.Button
    Protected WithEvents txtPath As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnGoParentDir As System.Web.UI.WebControls.Button
    Protected WithEvents lstFile As System.Web.UI.WebControls.DataList

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
            ' �� ��ũ ��Ʈ ���丮 ��� ���
            txtPath.Text = ConfigurationSettings.AppSettings("root")

            ' ������丮 ���, ���ϸ�� ����ϱ�
            ShowDirList()
            ShowFileList()
        End If

    End Sub

    Private Sub ShowDirList()

        ' ���� ���丮�� ���� ���丮 ��� ���
        Dim ParentDir As String = Left(txtPath.Text, InStrRev(txtPath.Text, "\") - 1)

        ' [���������� �̵�] ��ư�� CommandArgument ����
        btnGoParentDir.CommandArgument = ParentDir

        ' ���� ���丮�� ��Ʈ ���丮��� [���������� �̵�] ��ư�� ��Ȱ��ȭ��Ŵ
        ' ��Ʈ ���丮 �̻��� ���丮�� ������ ����
        Dim RootPath As String = ConfigurationSettings.AppSettings("root")
        If txtPath.Text = RootPath Then
            btnGoParentDir.Enabled = False
        Else
            btnGoParentDir.Enabled = True
        End If

        ' ���� ���丮�� �������丮 ��� �����ͼ� ���ε���Ű��
        Dim dir As New System.IO.DirectoryInfo(txtPath.Text)
        lstDir.DataSource = dir.GetDirectories()
        lstDir.DataBind()

    End Sub

    Private Sub ShowFileList()
        ' ���� ���丮���� ���� ��� �����ͼ� ���ε��ϱ�
        Dim dir As New DirectoryInfo(txtPath.Text)
        lstFile.DataSource = dir.GetFiles()
        lstFile.DataBind()
    End Sub




    Private Sub btnCD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCD.Click

        ' ������ ���丮 ��� 
        Dim NewDir As String = txtPath.Text & "\" & NewDirName.Text
        Dim dir As New DirectoryInfo(NewDir)

        ' ���丮 �����ϱ�
        dir.Create()

        ' ���丮 ��� ����ε��ϱ�
        ShowDirList()

    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click

        ' ÷�ε� ������ ������
        If File1.PostedFile.ContentLength > 0 Then

            ' ���� ���丮�� ���� ���ε��ϱ�
            Dim Path As String
            Path = txtPath.Text & "\" & System.IO.Path.GetFileName(File1.PostedFile.FileName)
            File1.PostedFile.SaveAs(Path)

            ' ���ϸ�� ����ε��ϱ�
            ShowFileList()
        End If

    End Sub


    Private Sub lstDir_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstDir.DeleteCommand

        ' ������ ���丮�� ��� ���
        Dim DelDir As String = e.CommandArgument
        Dim dir As New DirectoryInfo(DelDir)

        ' ���丮 ����
        dir.Delete(True)

        ' ���丮 ��� ����ε��ϱ�
        ShowDirList()

    End Sub

    Private Sub lstDir_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstDir.CancelCommand
        ' ���丮 ��� DataList ��Ʈ���� Edit ��� ����
        lstDir.EditItemIndex = -1
        ShowDirList()
    End Sub

    Private Sub lstDir_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstDir.ItemCommand

        ' ���丮 ��Ͽ��� ���丮���� �����ϸ� �ش� ���丮�� �̵�
        If e.CommandName = "GoDir" Then
            txtPath.Text = e.CommandArgument
            ShowDirList()
            ShowFileList()
        End If

    End Sub

    Private Sub btnGoParentDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoParentDir.Click

        ' [���� ���丮�� �̵�] ��ư�� Ŭ������ �� 
        ' ���� ���丮�� ���� ���丮�� �̵�
        txtPath.Text = btnGoParentDir.CommandArgument
        ShowDirList()
        ShowFileList()

    End Sub

    Private Sub lstDir_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstDir.UpdateCommand

        ' ������ ���丮��
        Dim CurDir As String = e.CommandArgument

        ' �ٲ� ���丮��
        Dim RenameDir As String
        RenameDir = txtPath.Text & "\" & CType(e.Item.Controls(1), TextBox).Text

        ' ���丮 �̸� �ٲٱ�
        Dim dir As New DirectoryInfo(CurDir)
        dir.MoveTo(RenameDir)

        ' Edit ��� ���� �� ���丮 ��� ����ε�
        lstDir.EditItemIndex = -1
        ShowDirList()

    End Sub


    Private Sub lstDir_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstDir.EditCommand

        ' ���丮�� [Rename] ��ư�� Ŭ���� ��� Edit ���� ����
        lstDir.EditItemIndex = e.Item.ItemIndex
        ShowDirList()

    End Sub

    Private Sub lstFile_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstFile.DeleteCommand

        ' ������ ������ ��� ���
        Dim DelFile As String = e.CommandArgument
        Dim file As New FileInfo(DelFile)

        ' ���� ����
        file.Delete()

        ' ���ϸ�� ����ε��ϱ�
        ShowFileList()

    End Sub

    Private Sub lstFile_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstFile.EditCommand

        ' ���ϸ�Ͽ��� [Rename] ��ư�� Ŭ���� ��� Edit ���� ��ȯ
        lstFile.EditItemIndex = e.Item.ItemIndex
        ShowFileList()

    End Sub

    Private Sub lstFile_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstFile.CancelCommand

        ' ���ϸ���� Edit ��� ����
        lstFile.EditItemIndex = -1
        ShowFileList()

    End Sub

    Private Sub lstFile_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstFile.UpdateCommand

        ' ������ ���ϸ� ���
        Dim CurFile As String = e.CommandArgument

        ' �̸��� �ٲ� ���ϸ�
        Dim RenameFile As String
        RenameFile = txtPath.Text & "\" & CType(e.Item.Controls(1), TextBox).Text

        ' ���ϸ� �ٲٱ�
        Dim File As New FileInfo(CurFile)
        File.MoveTo(RenameFile)

        ' Edit��� ���� �� ���ϸ�� ����ε��ϱ�
        lstFile.EditItemIndex = -1
        ShowFileList()

    End Sub


End Class
