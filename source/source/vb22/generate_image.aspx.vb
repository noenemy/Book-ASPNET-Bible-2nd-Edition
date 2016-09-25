Imports System.Drawing
Imports System.Drawing.Imaging

Public Class generate_image
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

        ' GDI+ ��ü �ʱ�ȭ
        Dim objBitmap As New System.Drawing.Bitmap(Server.MapPath("snowman.jpg"))
        Dim objGraphic As Graphics = Graphics.FromImage(objBitmap)

        Dim objBrush As New SolidBrush(Color.Navy)

        ' �̹����� ���ڿ� �׸���
        Dim strMessage As String = "������ ���ؿ��� ��� ��~~�� �Ǽ���."
        objGraphic.DrawString(strMessage, New Font("dotum", 12, FontStyle.Bold), objBrush, 90, 290)

        strMessage = DateTime.Now.ToShortDateString & " by Noenemy"
        objGraphic.DrawString(strMessage, New Font("gulim", 8, FontStyle.Italic), objBrush, 250, 310)

        ' �޸� �̹����� ��Ʈ������ ����
        Response.ContentType = "image/jpeg"
        objBitmap.Save(Response.OutputStream, ImageFormat.Jpeg)

        ' 
        objGraphic.Dispose()
        objBitmap.Dispose()

    End Sub

End Class
