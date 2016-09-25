Public Class _3DText
    Inherits System.Web.UI.Page
    Protected WithEvents comFonts As System.Web.UI.WebControls.DropDownList
    Protected WithEvents comTypes As System.Web.UI.WebControls.DropDownList
    Protected WithEvents comTemplates As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnGenerate As System.Web.UI.WebControls.Button
    Protected WithEvents img3D As System.Web.UI.WebControls.Image
    Protected WithEvents txtText As System.Web.UI.WebControls.TextBox

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

            ' 웹 서비스 객체 생성
            Dim ws As New com.xara.ws.RenderServer3D()

            ' 글자체, 이미지형식, 템플릿 데이터 얻기
            comFonts.DataSource = ws.GetFonts()
            comTypes.DataSource = ws.GetExportTypes()
            comTemplates.DataSource = ws.GetTemplates()

            ' 데이터 바인딩
            Page.DataBind()
        End If

    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        ' 변수 선언
        Dim Template, Text, TextColor, BGColor, Font, FontSize, ExportType As String
        Dim Width, Height As Long
        Dim ImageURL As String

        ' 이미지 생성을 위한 변수값 설정
        Template = comTemplates.SelectedItem.Text
        Text = txtText.Text
        Font = comFonts.SelectedItem.Text
        ExportType = comTypes.SelectedItem.Text
        TextColor = ""  ' 기본값 사용
        BGColor = ""    ' 기본값 사용
        FontSize = ""   ' 기본값 사용

        ' 웹서비스 객체 생성 
        Dim ws As New com.xara.ws.RenderServer3D()

        ' RenderURL 웹 메소드 호출 및 이미지 URL 얻기
        ImageURL = ws.RenderURL(Template, Text, TextColor, BGColor, Font, FontSize, ExportType, Width, Height)

        ' 생성된 이미지 페이지에 표시하기 
        img3D.ImageUrl = ImageURL

    End Sub
End Class
