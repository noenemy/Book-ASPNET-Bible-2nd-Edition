' ----------------------------------------
' NEBOARD.net COM+ 버전 1.0
' Class 명 : Root
' TrasactionOption : Required
'
' 작성일 : 2003.10.02 
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
    ' 지정한 게시물의 읽기수 증가
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
    ' 게시물 첨부파일의 다운로드수 증가
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
    ' 게시물 삭제하기
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function DeleteArticle(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer, _
                        ByVal password As String) As Boolean

        Dim objnTx As New BizBoard.nTx()

        Try
            ' 삭제 권한이 있는지 체크
            If objnTx.HasEditPermission(b_id, c_id, c_step, password) Then

                ' 게시물 삭제
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
    ' 게시물 수정하기
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
            ' 수정 권한이 있는지 체크
            If objnTx.HasEditPermission(b_id, c_id, c_step, password) Then

                ' 게시물 삭제
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
    ' 새로운 게시물 등록하기
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

            ' 쓰기 권한이 있는지 체크
            If objnTx.HasWritePermission(b_id, password) = False Then
                Return False
            Else

                ' 새 게시물 번호 구하기
                Dim c_id As Integer = objnTx.GetNewArticleID(b_id)

                ' 게시물 입력
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
    ' 게시물 답변하기
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

            ' 답변 권한이 있는지 체크
            If objnTx.HasWritePermission(b_id, password) = False Then
                Return False
            Else

                Dim p_Step As Integer ' 답변글이 입력될 위치 - step 값
                p_Step = objnTx.GetReplyArticleStep(b_id, c_id, c_step, c_depth)

                Dim objTx As New BizBoard.Tx()
                ' 입력될 Step 값 이후의 글 밀어내기
                objTx.ReorderBoardList(b_id, c_id, p_Step)
                objTx.ReorderBoardContent(b_id, c_id, p_Step)

                ' 답변글 등록하기
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
