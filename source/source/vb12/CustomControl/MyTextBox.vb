Imports System.Web.UI
Imports System.Web.UI.WebControls


Public Class MyTextBox
    Inherits WebControl
    Implements IPostBackDataHandler

    ' ������ --------
    Public Sub New()
        MyBase.New("input") ' <input> �±׷� �������ϵ��� ����
    End Sub

    ' Text ������Ƽ ------
    'Private m_Text As String = ""
    'Public Property Text() As String
    '    Get
    '        Return m_Text
    '    End Get
    '    Set(ByVal Value As String)
    '        m_Text = Value
    '    End Set
    'End Property


    Public Property Text() As String
        Get
            If ViewState("Text") Is Nothing Then
                Return ""
            Else
                Return CType(ViewState("Text"), String)
            End If
        End Get
        Set(ByVal Value As String)
            ViewState("Text") = Value
        End Set
    End Property


    Event TextChanged As EventHandler ' �̺�Ʈ ��ü ����


    Protected Overrides Sub AddAttributesToRender(ByVal writer As System.Web.UI.HtmlTextWriter)
        MyBase.AddAttributesToRender(writer)
        ' �������� �� Name, Type, Value �Ӽ� �߰��ϱ�
        writer.AddAttribute(HtmlTextWriterAttribute.Name, UniqueID)
        writer.AddAttribute(HtmlTextWriterAttribute.Type, "input")
        writer.AddAttribute(HtmlTextWriterAttribute.Value, Text)
    End Sub

    Public Function LoadPostData(ByVal postDataKey As String, ByVal postCollection As System.Collections.Specialized.NameValueCollection) As Boolean Implements System.Web.UI.IPostBackDataHandler.LoadPostData
        Dim EventFlag As Boolean = False
        If Text <> postCollection(postDataKey) Then
            EventFlag = True
        End If
        Text = postCollection(postDataKey) ' POST ������ ��������
        Return EventFlag ' ���� ����Ǿ����� True ����
    End Function

    Public Sub RaisePostDataChangedEvent() Implements System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent
        RaiseEvent TextChanged(Me, EventArgs.Empty)
    End Sub
End Class
