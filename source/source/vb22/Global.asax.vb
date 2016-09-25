Imports System.Web
Imports System.Web.SessionState
Imports System.Diagnostics

Public Class Global
    Inherits System.Web.HttpApplication

#Region " Component Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    Dim LogName As String = "MyLog"

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started

        ' 이벤트 로그 항목이 없으면 생성하기
        If (Not EventLog.SourceExists(LogName)) Then
            EventLog.CreateEventSource(LogName, LogName)
        End If

    End Sub

    Sub Application_Error(ByVal Sender As Object, ByVal E As EventArgs)

        ' 에러발생시 이벤트 로그에 저장하기
        Dim Message As String = "Url " & Request.Path & " Error: " & Server.GetLastError.ToString
        Dim Log As New EventLog()
        Log.Source = LogName
        Log.WriteEntry(Message, EventLogEntryType.Error)

    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

End Class
