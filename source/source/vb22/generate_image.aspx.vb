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

        ' GDI+ 객체 초기화
        Dim objBitmap As New System.Drawing.Bitmap(Server.MapPath("snowman.jpg"))
        Dim objGraphic As Graphics = Graphics.FromImage(objBitmap)

        Dim objBrush As New SolidBrush(Color.Navy)

        ' 이미지에 문자열 그리기
        Dim strMessage As String = "여러분 새해에는 모두 부~~자 되세요."
        objGraphic.DrawString(strMessage, New Font("dotum", 12, FontStyle.Bold), objBrush, 90, 290)

        strMessage = DateTime.Now.ToShortDateString & " by Noenemy"
        objGraphic.DrawString(strMessage, New Font("gulim", 8, FontStyle.Italic), objBrush, 250, 310)

        ' 메모리 이미지를 스트림으로 전송
        Response.ContentType = "image/jpeg"
        objBitmap.Save(Response.OutputStream, ImageFormat.Jpeg)

        ' 
        objGraphic.Dispose()
        objBitmap.Dispose()

    End Sub

End Class
