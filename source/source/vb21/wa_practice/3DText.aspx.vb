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

            ' �� ���� ��ü ����
            Dim ws As New com.xara.ws.RenderServer3D()

            ' ����ü, �̹�������, ���ø� ������ ���
            comFonts.DataSource = ws.GetFonts()
            comTypes.DataSource = ws.GetExportTypes()
            comTemplates.DataSource = ws.GetTemplates()

            ' ������ ���ε�
            Page.DataBind()
        End If

    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        ' ���� ����
        Dim Template, Text, TextColor, BGColor, Font, FontSize, ExportType As String
        Dim Width, Height As Long
        Dim ImageURL As String

        ' �̹��� ������ ���� ������ ����
        Template = comTemplates.SelectedItem.Text
        Text = txtText.Text
        Font = comFonts.SelectedItem.Text
        ExportType = comTypes.SelectedItem.Text
        TextColor = ""  ' �⺻�� ���
        BGColor = ""    ' �⺻�� ���
        FontSize = ""   ' �⺻�� ���

        ' ������ ��ü ���� 
        Dim ws As New com.xara.ws.RenderServer3D()

        ' RenderURL �� �޼ҵ� ȣ�� �� �̹��� URL ���
        ImageURL = ws.RenderURL(Template, Text, TextColor, BGColor, Font, FontSize, ExportType, Width, Height)

        ' ������ �̹��� �������� ǥ���ϱ� 
        img3D.ImageUrl = ImageURL

    End Sub
End Class
