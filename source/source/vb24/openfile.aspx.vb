Imports System.IO

Public Class openfile
    Inherits System.Web.UI.Page

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
        Dim Root As String = ConfigurationSettings.AppSettings("root")

        ' �ٿ�ε� ��ų ������ ���
        Dim FilePath As String = Request.QueryString("path")

        ' ������ ��� �̿��� ���Ͽ�û �ź�
        If InStr(FilePath, Root) > 0 Then

            ' ���ϸ� ���
            Dim FileName As String = Path.GetFileName(FilePath)

            ' ����� �����̸� �����ϱ�
            Response.AddHeader("Content-Disposition", "attachment;filename=" & FileName)
            Response.ContentType = "multipart/form-data"
            ' ���� �ٿ�ε� ��Ű��
            Response.WriteFile(FilePath)
        Else
            Response.Write("�߸��� ��û�Դϴ�.")
        End If


    End Sub

End Class
