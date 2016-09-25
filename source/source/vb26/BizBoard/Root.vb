' ----------------------------------------
' NEBOARD.net COM+ ���� 1.0
' Class �� : Root
' TrasactionOption : Required
'
' �ۼ��� : 2003.10.02 
'                       by noenemy
' ----------------------------------------

Imports System.EnterpriseServices
Imports System.Data.SqlClient


<Transaction(TransactionOption.Required)> _
Public Class Root
    Inherits ServicedComponent

    ' ---------------------------------------------------------
    ' IncreaseReadCount
    ' Input Parameter : b_id, c_id, c_step 
    ' Return Type : boolean
    '
    ' ������ �Խù��� �б�� ����
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function IncreaseReadCount(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer) As Boolean

        Dim objTx As New BizBoard.Tx()

        Try
            If objTx.IncreaseReadCount(b_id, c_id, c_step) Then
                Return True
            Else
                Return False
            End If

        Catch e As Exception
            Throw e
        End Try

    End Function

    ' ---------------------------------------------------------
    ' IncreaseDownCount
    ' Input Parameter : b_id, c_id, c_step 
    ' Return Type : boolean
    '
    ' �Խù� ÷�������� �ٿ�ε�� ����
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function IncreaseDownCount(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer) As Boolean

        Dim objTx As New BizBoard.Tx()

        Try
            If objTx.IncreaseDownCount(b_id, c_id, c_step) = True Then
                Return True
            Else
                Return False
            End If

        Catch e As Exception
            Throw e
        End Try

    End Function



    ' ---------------------------------------------------------
    ' DeleteArticle
    ' Input Parameter : b_id, c_id, c_step, password
    ' Return Type : boolean
    '
    ' �Խù� �����ϱ�
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function DeleteArticle(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer, _
                        ByVal password As String) As Boolean

        Dim objnTx As New BizBoard.nTx()

        Try
            ' ���� ������ �ִ��� üũ
            If objnTx.HasEditPermission(b_id, c_id, c_step, password) Then

                ' �Խù� ����
                Dim objTx As New BizBoard.Tx()
                objTx.DeleteBoardList(b_id, c_id, c_step)
                objTx.DeleteBoardContent(b_id, c_id, c_step)

                Return True
            Else
                Return False
            End If

        Catch e As Exception
            Throw e
        End Try

    End Function

    ' ---------------------------------------------------------
    ' EditArticle
    ' Input Parameter : b_id, c_id, c_step, subject, writer, 
    '             email, filename, filesize, content, password
    ' Return Type : boolean
    '
    ' �Խù� �����ϱ�
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function EditArticle(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer, _
                        ByVal subject As String, _
                        ByVal writer As String, _
                        ByVal email As String, _
                        ByVal filename As String, _
                        ByVal filesize As String, _
                        ByVal content As String, _
                        ByVal password As String) As Boolean



        Dim objnTx As New BizBoard.nTx()
        Try
            ' ���� ������ �ִ��� üũ
            If objnTx.HasEditPermission(b_id, c_id, c_step, password) Then

                ' �Խù� ����
                Dim objTx As New BizBoard.Tx()
                objTx.EditBoardList(b_id, c_id, c_step, subject, _
                                    writer, email, filename, filesize)
                objTx.EditBoardContent(b_id, c_id, c_step, content)

                Return True
            Else
                Return False
            End If

        Catch e As Exception
            Throw e
        End Try


    End Function


    ' ---------------------------------------------------------
    ' WriteArticle
    ' Input Parameter : b_id, subject, writer, email, filename,
    '                   filesize, content, password
    ' Return Type : boolean
    '
    ' ���ο� �Խù� ����ϱ�
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function WriteArticle(ByVal b_id As String, _
                        ByVal subject As String, _
                        ByVal writer As String, _
                        ByVal email As String, _
                        ByVal filename As String, _
                        ByVal filesize As String, _
                        ByVal content As String, _
                        ByVal password As String) As Boolean


        Try
            Dim objnTx As New BizBoard.nTx()

            ' ���� ������ �ִ��� üũ
            If objnTx.HasWritePermission(b_id, password) = False Then
                Return False
            Else

                ' �� �Խù� ��ȣ ���ϱ�
                Dim c_id As Integer = objnTx.GetNewArticleID(b_id)

                ' �Խù� �Է�
                Dim objTx As New BizBoard.Tx()
                objTx.WriteBoardList(b_id, c_id, 1, 0, subject, writer, _
                                email, filename, filesize, password)

                objTx.WriteBoardContent(b_id, c_id, 1, content)

                Return True

            End If

        Catch e As Exception
            Throw e

        End Try

    End Function

    ' ---------------------------------------------------------
    ' ReplyArticle
    ' Input Parameter : b_id, c_id, c_step, c_depth, subject,
    '     writer, email, filename, filesize, content, password
    ' Return Type : boolean
    '
    ' �Խù� �亯�ϱ�
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function ReplyArticle(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer, _
                        ByVal c_depth As Integer, _
                        ByVal subject As String, _
                        ByVal writer As String, _
                        ByVal email As String, _
                        ByVal filename As String, _
                        ByVal filesize As String, _
                        ByVal content As String, _
                        ByVal password As String) As Boolean

        Try

            Dim objnTx As New BizBoard.nTx()

            ' �亯 ������ �ִ��� üũ
            If objnTx.HasWritePermission(b_id, password) = False Then
                Return False
            Else

                Dim p_Step As Integer ' �亯���� �Էµ� ��ġ - step ��
                p_Step = objnTx.GetReplyArticleStep(b_id, c_id, c_step, c_depth)

                Dim objTx As New BizBoard.Tx()
                ' �Էµ� Step �� ������ �� �о��
                objTx.ReorderBoardList(b_id, c_id, p_Step)
                objTx.ReorderBoardContent(b_id, c_id, p_Step)

                ' �亯�� ����ϱ�
                objTx.WriteBoardList(b_id, c_id, p_Step, c_depth + 1, _
                    subject, writer, email, filename, filesize, password)
                objTx.WriteBoardContent(b_id, c_id, p_Step, content)

                Return True

            End If

        Catch e As Exception
            Throw e

        End Try

    End Function


End Class
