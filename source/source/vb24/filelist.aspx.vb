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
            ' 웹 디스크 루트 디렉토리 경로 얻기
            txtPath.Text = ConfigurationSettings.AppSettings("root")

            ' 서브디렉토리 목록, 파일목록 출력하기
            ShowDirList()
            ShowFileList()
        End If

    End Sub

    Private Sub ShowDirList()

        ' 현재 디렉토리의 상위 디렉토리 경로 얻기
        Dim ParentDir As String = Left(txtPath.Text, InStrRev(txtPath.Text, "\") - 1)

        ' [상위폴더로 이동] 버튼의 CommandArgument 설정
        btnGoParentDir.CommandArgument = ParentDir

        ' 현재 디렉토리가 루트 디렉토리라면 [상위폴더로 이동] 버튼을 비활성화시킴
        ' 루트 디렉토리 이상의 디렉토리에 접근을 막음
        Dim RootPath As String = ConfigurationSettings.AppSettings("root")
        If txtPath.Text = RootPath Then
            btnGoParentDir.Enabled = False
        Else
            btnGoParentDir.Enabled = True
        End If

        ' 현재 디렉토리의 하위디렉토리 목록 가져와서 바인딩시키기
        Dim dir As New System.IO.DirectoryInfo(txtPath.Text)
        lstDir.DataSource = dir.GetDirectories()
        lstDir.DataBind()

    End Sub

    Private Sub ShowFileList()
        ' 현재 디렉토리내의 파일 목록 가져와서 바인딩하기
        Dim dir As New DirectoryInfo(txtPath.Text)
        lstFile.DataSource = dir.GetFiles()
        lstFile.DataBind()
    End Sub




    Private Sub btnCD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCD.Click

        ' 생성할 디렉토리 경로 
        Dim NewDir As String = txtPath.Text & "\" & NewDirName.Text
        Dim dir As New DirectoryInfo(NewDir)

        ' 디렉토리 생성하기
        dir.Create()

        ' 디렉토리 목록 재바인딩하기
        ShowDirList()

    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click

        ' 첨부된 파일이 있으면
        If File1.PostedFile.ContentLength > 0 Then

            ' 현재 디렉토리에 파일 업로드하기
            Dim Path As String
            Path = txtPath.Text & "\" & System.IO.Path.GetFileName(File1.PostedFile.FileName)
            File1.PostedFile.SaveAs(Path)

            ' 파일목록 재바인딩하기
            ShowFileList()
        End If

    End Sub


    Private Sub lstDir_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstDir.DeleteCommand

        ' 삭제할 디렉토리의 경로 얻기
        Dim DelDir As String = e.CommandArgument
        Dim dir As New DirectoryInfo(DelDir)

        ' 디렉토리 삭제
        dir.Delete(True)

        ' 디렉토리 목록 재바인딩하기
        ShowDirList()

    End Sub

    Private Sub lstDir_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstDir.CancelCommand
        ' 디렉토리 목록 DataList 컨트롤의 Edit 모드 해제
        lstDir.EditItemIndex = -1
        ShowDirList()
    End Sub

    Private Sub lstDir_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstDir.ItemCommand

        ' 디렉토리 목록에서 디렉토리명을 선택하면 해당 디렉토리로 이동
        If e.CommandName = "GoDir" Then
            txtPath.Text = e.CommandArgument
            ShowDirList()
            ShowFileList()
        End If

    End Sub

    Private Sub btnGoParentDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoParentDir.Click

        ' [상위 디렉토리로 이동] 버튼을 클릭했을 때 
        ' 현재 디렉토리의 상위 디렉토리로 이동
        txtPath.Text = btnGoParentDir.CommandArgument
        ShowDirList()
        ShowFileList()

    End Sub

    Private Sub lstDir_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstDir.UpdateCommand

        ' 원래의 디렉토리명
        Dim CurDir As String = e.CommandArgument

        ' 바꿀 디렉토리명
        Dim RenameDir As String
        RenameDir = txtPath.Text & "\" & CType(e.Item.Controls(1), TextBox).Text

        ' 디렉토리 이름 바꾸기
        Dim dir As New DirectoryInfo(CurDir)
        dir.MoveTo(RenameDir)

        ' Edit 모드 해제 및 디렉토리 목록 재바인딩
        lstDir.EditItemIndex = -1
        ShowDirList()

    End Sub


    Private Sub lstDir_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstDir.EditCommand

        ' 디렉토리의 [Rename] 버튼을 클릭한 경우 Edit 모드로 변경
        lstDir.EditItemIndex = e.Item.ItemIndex
        ShowDirList()

    End Sub

    Private Sub lstFile_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstFile.DeleteCommand

        ' 삭제할 파일의 경로 얻기
        Dim DelFile As String = e.CommandArgument
        Dim file As New FileInfo(DelFile)

        ' 파일 삭제
        file.Delete()

        ' 파일목록 재바인딩하기
        ShowFileList()

    End Sub

    Private Sub lstFile_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstFile.EditCommand

        ' 파일목록에서 [Rename] 버튼을 클릭한 경우 Edit 모드로 변환
        lstFile.EditItemIndex = e.Item.ItemIndex
        ShowFileList()

    End Sub

    Private Sub lstFile_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstFile.CancelCommand

        ' 파일목록의 Edit 모드 해제
        lstFile.EditItemIndex = -1
        ShowFileList()

    End Sub

    Private Sub lstFile_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles lstFile.UpdateCommand

        ' 원래의 파일명 얻기
        Dim CurFile As String = e.CommandArgument

        ' 이름을 바꿀 파일명
        Dim RenameFile As String
        RenameFile = txtPath.Text & "\" & CType(e.Item.Controls(1), TextBox).Text

        ' 파일명 바꾸기
        Dim File As New FileInfo(CurFile)
        File.MoveTo(RenameFile)

        ' Edit모드 해제 및 파일목록 재바인딩하기
        lstFile.EditItemIndex = -1
        ShowFileList()

    End Sub


End Class
