Imports System.IO
Imports System.IO.Path

Public Class edit
    Inherits System.Web.UI.Page
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSubject As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtContent As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents hidOldFile As System.Web.UI.HtmlControls.HtmlInputHidden
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblBoardTitle As System.Web.UI.WebControls.Label
    Protected WithEvents File1 As System.Web.UI.HtmlControls.HtmlInputFile

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

            Dim b_id As String = Request.QueryString("b_id")
            Dim c_id As Integer = Request.QueryString("c_id")
            Dim c_step As Integer = Request.QueryString("c_step")

            ' �Խ��� ���� ����ϱ�
            Dim objnTx As New BizBoard.nTx()
            Dim dsBoardInfo As New BizBoard.dsBoard()
            dsBoardInfo = objnTx.GetBoardInfo(b_id)
            lblBoardTitle.Text = dsBoardInfo.boardmaster(0).title.ToString()

            ' �Խù� ���� ��������
            Dim dsBoard As New BizBoard.dsBoard()
            dsBoard = objnTx.GetArticle(b_id, c_id, c_step)

            ' �Է� ��Ʈ�ѿ� ���� �� ���
            txtName.Text = dsBoard.GetArticle(0).writer.ToString()
            txtEmail.Text = dsBoard.GetArticle(0).email.ToString()
            txtSubject.Text = dsBoard.GetArticle(0).subject.ToString()
            txtContent.Text = dsBoard.GetArticle(0).content.ToString()

            ' ������ ÷�ε� ���� �̸�
            hidOldFile.Value = dsBoard.GetArticle(0).filename.ToString()


        End If

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        ' ������ ����
        Dim filesize, b_id, subject, writer, email, filename, password, content, old_file As String
        Dim SearchOption, SearchKey As String
        Dim c_id, c_step As Integer
        b_id = Request.QueryString("b_id")
        c_id = Request.QueryString("c_id")
        c_step = Request.QueryString("c_step")
        SearchOption = Request.QueryString("search_option")
        SearchKey = Request.QueryString("search_key")
        writer = txtName.Text
        email = txtEmail.Text
        password = txtPassword.Text
        content = txtContent.Text
        subject = txtSubject.Text
        old_file = hidOldFile.Value
        filename = ""
        filesize = ""

        ' ���Ͼ��ε��ϱ�
        If File1.PostedFile.ContentLength > 0 Then

            Dim UpPath As String
            Dim UpDir As String = ConfigurationSettings.AppSettings("UpDir")
            filesize = GetFileSize(File1.PostedFile.ContentLength)
            filename = GetFileName(File1.PostedFile.FileName)
            UpDir = UpDir & "\" & b_id

            ' ���ε��� ���丮�� ������ ����
            If Directory.Exists(UpDir) = False Then
                Directory.CreateDirectory(UpDir)
            End If

            ' ���ε��� ���
            UpPath = UpDir & "\" & filename

            ' ���� �̸��� ���� �ߺ� ����
            Dim i As Integer = 0
            Dim filename2 As String = ""
            Do While (File.Exists(UpPath))
                i = i + 1
                filename2 = GetFileNameWithoutExtension(filename) & _
                        "(" & i.ToString() & ")" & Path.GetExtension(filename)
                UpPath = UpDir & "\" & filename2
            Loop
            If filename2.Length > filename.Length Then
                filename = filename2
            End If

            ' ���� ���ε��ϱ�
            File1.PostedFile.SaveAs(UpPath)

            ' ������ ���ε�� ���� �����ϱ�
            If old_file.Length > 0 Then
                Dim DelPath As String
                DelPath = ConfigurationSettings.AppSettings("UpDir") & "\" & b_id & "\" & old_file
                File.Delete(DelPath)
            End If

        End If


        ' �Խù� ���� �����ϱ�
        Dim objRoot As New BizBoard.Root()
        Dim result As Boolean
        result = objRoot.EditArticle(b_id, c_id, c_step, subject, writer, email, filename, filesize, content, password)

        If result = False Then
            lblMessage.Text = "��й�ȣ�� ��ġ���� �ʽ��ϴ�."
        Else

            ' list.aspx�� �̵�
            Dim CurPage As Integer = Request.QueryString("page")
            Dim goURL As String = "list.aspx?b_id=" & b_id & "&search_option=" & SearchOption & _
                                  "&search_key=" & Server.UrlEncode(SearchKey) & "&page=" & CurPage.ToString()
            Response.Redirect(goURL)
        End If

    End Sub

    Private Function GetFileSize(ByVal Size As Integer) As String

        ' ����ũ�⸦ KByte �������� ��ȯ�ؼ� ����
        Dim result As String
        If Size > 1024 Then '1024byte(1Kbyte)���� ũ��	
            result = (CInt(Size / 1024)).ToString() & "K"
        Else
            result = Size.ToString()
        End If
        Return result

    End Function


End Class
