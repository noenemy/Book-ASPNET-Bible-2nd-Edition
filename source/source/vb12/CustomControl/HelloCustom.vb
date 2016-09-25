Imports System.Web.UI

Public Class HelloCustom
    Inherits Control

    ' Text 프로퍼티 
    Private m_Text As String = "Hello, Custom Control!"
    Public Property Text() As String
        Get
            Return m_Text
        End Get
        Set(ByVal Value As String)
            m_Text = Value
        End Set
    End Property


    Protected Overrides Sub Render(ByVal writer As System.Web.UI.HtmlTextWriter)
        writer.Write(m_Text)
    End Sub

End Class