Imports System.Web.UI
Imports System.Web.UI.WebControls

Public Class TitleTextBox
    Inherits Control
    Implements INamingContainer

    ' Text ������Ƽ 
    Private m_Text As String = "Text"
    Public Property Text() As String
        Get
            Return m_Text
        End Get
        Set(ByVal Value As String)
            m_Text = Value
        End Set
    End Property

    ' Title ������Ƽ 
    Private m_Title As String = "Title"
    Public Property Title() As String
        Get
            Return m_Title
        End Get
        Set(ByVal Value As String)
            m_Title = Value
        End Set
    End Property


    Protected Overrides Sub CreateChildControls()

        ' Label ��Ʈ�� �߰��ϱ�
        Dim Label1 As New Label()
        Label1.Width = WebControls.Unit.Pixel(100)
        Label1.Text = m_Title
        Controls.Add(Label1)

        ' FlatTextBox ��Ʈ�� �߰��ϱ�
        Dim FlatTextBox1 As New FlatTextBox()
        FlatTextBox1.Text = m_Text
        Controls.Add(FlatTextBox1)

    End Sub



End Class
