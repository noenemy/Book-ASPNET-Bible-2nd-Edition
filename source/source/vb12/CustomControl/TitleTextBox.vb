Imports System.Web.UI
Imports System.Web.UI.WebControls

Public Class TitleTextBox
    Inherits Control
    Implements INamingContainer

    ' Text 프로퍼티 
    Private m_Text As String = "Text"
    Public Property Text() As String
        Get
            Return m_Text
        End Get
        Set(ByVal Value As String)
            m_Text = Value
        End Set
    End Property

    ' Title 프로퍼티 
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

        ' Label 컨트롤 추가하기
        Dim Label1 As New Label()
        Label1.Width = WebControls.Unit.Pixel(100)
        Label1.Text = m_Title
        Controls.Add(Label1)

        ' FlatTextBox 컨트롤 추가하기
        Dim FlatTextBox1 As New FlatTextBox()
        FlatTextBox1.Text = m_Text
        Controls.Add(FlatTextBox1)

    End Sub



End Class
