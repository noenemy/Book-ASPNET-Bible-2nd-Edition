Imports System.Web.Mail

Public Class send_attachfile
    Inherits System.Web.UI.Page
    Protected WithEvents txtFrom As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSubject As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtContent As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSend As System.Web.UI.WebControls.Button
    Protected WithEvents File1 As System.Web.UI.HtmlControls.HtmlInputFile

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
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click


        ' MailMessage 객체 생성
        Dim mail As New MailMessage()
        mail.From = txtFrom.Text
        mail.To = txtTo.Text
        mail.Subject = txtSubject.Text
        mail.Body = txtContent.Text

        ' 첨부된 파일이 있으면
        Response.Write(File1.PostedFile.FileName)
        Dim FileName As String = File1.PostedFile.FileName
        If FileName <> "" Then
            FileName = Mid(FileName, InStrRev(FileName, "\") + 1)
            File1.PostedFile.SaveAs("c:\" & FileName)

            ' 메일에 파일 첨부하기
            Dim attach As New MailAttachment("c:\" & FileName)
            mail.Attachments.Add(attach)
        End If

        Try
            ' SmtpMail.Send로 메일 발송하기
            System.Web.Mail.SmtpMail.Send(mail)

        Catch ex As Exception
            Response.Write("예외발생 : " & ex.Message.ToString())
        End Try
    End Sub
End Class
