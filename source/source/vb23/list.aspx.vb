
Imports System.Data.SqlClient

Public Class list
    Inherits System.Web.UI.Page
    Protected WithEvents lblTitle As System.Web.UI.WebControls.Label
    Protected WithEvents lnkWrite As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lnkPrev As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lnkNext As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lstGuestbook As System.Web.UI.WebControls.DataList
    Protected WithEvents lblPager As System.Web.UI.WebControls.Label

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

    Public CurPage As Integer ' ���� ������ ��ȣ

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

        ' ���� �������� ��� or �ʱ�ȭ
        If Request.QueryString("page") = "" Then
            CurPage = 1
        Else
            CurPage = CType(Request.QueryString("page"), Integer)
        End If

        ' ���� �����ֱ�
        ShowGuestbookList()

    End Sub

    Private Function GetRecordCount() As Integer

        ' ������ �� ���ڵ� ���� �����Ѵ�.
        Dim conn As New SqlConnection(ConfigurationSettings.AppSettings("DSN"))
        Dim comm As New SqlCommand("SELECT COUNT(*) FROM guestbook", conn)
        Dim RecordCount As Integer

        conn.Open()
        RecordCount = comm.ExecuteScalar()
        conn.Close()

        Return RecordCount

    End Function


    Private Sub ShowGuestbookList()

        ' RecordCount - �� �Խù���
        ' PageSize - �� �������� ������ �Խù� ��
        ' PageCount - �� ��������
        Dim RecordCount As Integer = GetRecordCount()
        Dim PageSize As Integer = ConfigurationSettings.AppSettings("PageSize")
        Dim PageCount, TopCount As Integer
        PageCount = Int((RecordCount - 1) / PageSize) + 1

        ' CurPage, PageCount, RecordCount ǥ��
        lblTitle.Text = "Page [" & CurPage & "/" & PageCount & "] Total : " & RecordCount

        ' ������ �Խù� ��
        TopCount = CurPage * PageSize

        ' ������ ����
        Dim strSQL As String
        strSQL = "SELECT TOP " & TopCount.ToString() & " * FROM guestbook ORDER BY id DESC"

        ' ���� �Խù� ��������
        Dim conn As New SqlConnection(ConfigurationSettings.AppSettings("DSN"))
        Dim comm As New SqlCommand(strSQL, conn)
        conn.Open()
        Dim dr As SqlDataReader = comm.ExecuteReader()

        ' ��������ȣ�� �°� ���ڵ� ��ġ �̵�
        Dim i As Integer
        For i = 1 To (CurPage - 1) * PageSize
            dr.Read()
        Next

        ' DataList ��Ʈ�� �����͹��ε�
        lstGuestbook.DataSource = dr
        lstGuestbook.DataBind()

        ' ADO.NET ��ü �ݱ�
        dr.Close()
        conn.Close()

        ' ������ �׺���̼� ����ϱ�
        ShowPager(RecordCount, CurPage, PageCount, PageSize)

    End Sub


    Public Function DisplayContent(ByVal Content As String) As String

        ' ���� �����߿� ��ٲ޹��ڸ� <br> �±׷� ��ȯ
        Content = Replace(Content, Chr(13) & Chr(10), "<br>")
        Return Content

    End Function

    Private Sub ShowPager(ByVal RecordCount As Integer, _
                        ByVal CurPage As Integer, _
                        ByVal PageCount As Integer, _
                        ByVal PageSize As Integer)

        ' ��ũ ���ڿ�
        Dim Path As String = Request.ServerVariables("PATH_INFO") & "?page="

        ' FromPage - ������ �׺���̼��� ���� ��������ȣ
        ' CurPage - ������ �׺���̼��� ������ ��������ȣ
        Dim FromPage, ToPage As Integer
        FromPage = Int((CurPage - 1) / 10) * 10 + 1
        If PageCount > FromPage + 9 Then
            ToPage = FromPage + 9
        Else
            ToPage = PageCount
        End If


        Dim Pager As String
        Dim i As Integer

        Pager = "<font size=2>"

        ' ���� 10�� ǥ��
        If Int((CurPage - 1) / 10) > 0 Then
            Pager = Pager & "<a href='" & Path & (FromPage - 1).ToString & "'>{prev}</a>..."
        End If

        ' ������ �׺���̼� ǥ��
        For i = FromPage To ToPage
            If i = CurPage Then
                Pager &= "<b>[" & i.ToString() & "]</b>"
            Else
                Pager = Pager & "<a href='" & Path & i.ToString & "'>" & _
                        "[" & i.ToString() & "]</a> "
            End If
        Next

        ' ���� 10�� ǥ��
        If ToPage < PageCount Then
            Pager = Pager & "...<a href='" & Path & (ToPage + 1).ToString & "'>{next>}</a>"
        End If

        Pager = Pager & "</font>"

        ' ������ �׺���̼� ����ϱ�
        lblPager.Text = Pager

        ' Prev, Next ��ư�� ��ũ �����ϱ� 
        If CurPage > 1 Then
            lnkPrev.NavigateUrl = Path & (CurPage - 1).ToString()
        End If

        If CurPage < ToPage Then
            lnkNext.NavigateUrl = Path & (CurPage + 1).ToString()
        End If

        lnkWrite.NavigateUrl = "write.aspx?page=" & CurPage.ToString()

    End Sub

End Class
