Imports System.Web
Imports System.Web.SessionState

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


    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' 카운터를 위한 Application 변수 초기화
        Application("TotalCount") = 0   ' 총 접속자수  
        Application("NowCount") = 0     ' 현재 접속자수
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' 카운터 증가시키기
        Application.Lock()
        Application("TotalCount") += 1
        Application("NowCount") += 1
        Application.UnLock()
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' 현재 접속자수 - 1
        Application.Lock()
        Application("NowCount") -= 1
        Application.UnLock()
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

    ' 이벤트 순서를 확인하기 위한 설정 ----------------------------
    Sub Application_BeginRequest(ByVal Sender As Object, ByVal e As EventArgs)
        Response.Write("Application_BeginRequest<br>")
    End Sub

    Sub Application_EndRequest(ByVal Sender As Object, ByVal e As EventArgs)
        Response.Write("Application_EndRequest<br>")
    End Sub

    Sub Application_AuthenticateRequest(ByVal Sender As Object, ByVal e As EventArgs)
        Response.Write("Application_AuthenticateRequest<br>")
    End Sub

    Sub Application_AuthoriseRequest(ByVal Sender As Object, ByVal e As EventArgs)
        Response.Write("Application_AuthoriseRequest<br>")
    End Sub

    Sub Application_ResolveRequestCache(ByVal Sender As Object, ByVal e As EventArgs)
        Response.Write("Application_ResolveRequestCache<br>")
    End Sub

    Sub Application_AcquireRequestState(ByVal Sender As Object, ByVal e As EventArgs)
        Response.Write("Application_AcquireRequestState<br>")
    End Sub

    Sub Application_PreRequestHandlerExecute(ByVal Sender As Object, ByVal e As EventArgs)
        Response.Write("Application_PreRequestHandlerExecute<br>")
    End Sub

    Sub Application_PostRequestHandlerExecute(ByVal Sender As Object, ByVal e As EventArgs)
        Response.Write("Application_PostRequestHandlerExecute<br>")
    End Sub

    Sub Application_ReleaseRequestState(ByVal Sender As Object, ByVal e As EventArgs)
        Response.Write("Application_ReleaseRequestState<br>")
    End Sub

    Sub Application_UpdateRequestCache(ByVal Sender As Object, ByVal e As EventArgs)
        Response.Write("Application_UpdateRequestCache<br>")
    End Sub
End Class
