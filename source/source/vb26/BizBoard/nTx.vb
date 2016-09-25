' ----------------------------------------
' NEBOARD.net COM+ 버전 1.0
' Class 명 : nTx
' TrasactionOption : NotSupported
'
' 작성일 : 2003.10.02 
'                       by noenemy
' ----------------------------------------


Imports System.EnterpriseServices
Imports System.Data.SqlClient


<Transaction(TransactionOption.NotSupported)> _
Public Class nTx
    Inherits ServicedComponent

    ' ---------------------------------------------------------
    ' GetConnectionString
    ' Input Parameter : 
    ' Return Type : String
    '
    ' DB 연결 문자열을 web.config에서 가져와서 리턴
    '----------------------------------------------------------
    Private Function GetConnString() As String
        Return System.Configuration.ConfigurationSettings.AppSettings("DSN")
    End Function

    ' ---------------------------------------------------------
    ' GetArticle
    ' Input Parameter : b_id, c_id, c_step
    ' Return Type : dsBoard
    '
    ' 지정한 게시물 내용 리턴
    '----------------------------------------------------------
    Public Function GetArticle(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer) As dsBoard

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("GetArticle", conn)
        comm.CommandType = CommandType.StoredProcedure

        Dim adapter As New SqlDataAdapter(comm)

        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@c_id", c_id)
        comm.Parameters.Add("@c_step", c_step)

        Dim ds As New dsBoard()
        Try
            adapter.Fill(ds, "GetArticle")

            Return ds

        Catch e As Exception
            Throw e
        End Try

    End Function

    ' ---------------------------------------------------------
    ' GetBoardInfo
    ' Input Parameter : b_id
    ' Return Type : dsBoard
    '
    ' 게시판 정보 리턴
    '----------------------------------------------------------
    Public Function GetBoardInfo(ByVal b_id As String) As dsBoard

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("GetBoardInfo", conn)
        comm.CommandType = CommandType.StoredProcedure

        Dim adapter As New SqlDataAdapter(comm)

        comm.Parameters.Add("@b_id", b_id)

        Dim ds As New dsBoard()
        Try
            adapter.Fill(ds, "boardmaster")
            Return ds

        Catch e As Exception
            Throw e
        End Try

    End Function

    ' ---------------------------------------------------------
    ' GetBoardList
    ' Input Parameter : b_id, search_option, search_key,
    '                   pagesize, curpage
    ' Return Type : dsBoard
    '
    ' 게시물 목록을 리턴
    '----------------------------------------------------------
    Public Function GetBoardList(ByVal b_id As String, _
                        ByVal search_option As String, _
                        ByVal search_key As String, _
                        ByVal pagesize As Integer, _
                        ByVal curpage As Integer) As dsBoard

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("GetBoardList", conn)
        comm.CommandType = CommandType.StoredProcedure

        ' 가져올 게시물 수
        Dim TopCount As Integer = curpage * pagesize
        Dim adapter As New SqlDataAdapter(comm)

        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@search_option", search_option)
        comm.Parameters.Add("@search_key", search_key)
        comm.Parameters.Add("@topcount", TopCount.ToString())

        ' 페이지번호에 따른 레코드 시작위치
        Dim start_record As Integer = (curpage - 1) * pagesize

        Dim ds As New dsBoard()
        Try
            adapter.Fill(ds, start_record, pagesize, "boardlist")

            Return ds

        Catch e As Exception
            Throw e
        End Try

    End Function

    ' ---------------------------------------------------------
    ' GetBoardRecordCount
    ' Input Parameter : b_id, search_option, search_key
    ' Return Type : Integer
    '
    ' 지정한 게시판의 게시물 수를 리턴
    '----------------------------------------------------------
    Public Function GetBoardRecordCount(ByVal b_id As String, _
                                        ByVal search_option As String, _
                                        ByVal search_key As String) As Integer

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("GetBoardRecordCount", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@search_option", search_option)
        comm.Parameters.Add("@search_key", search_key)

        Dim result As Integer
        Try
            conn.Open()
            result = comm.ExecuteScalar()
            conn.Close()

            Return result

        Catch e As Exception
            Throw e
        End Try

    End Function

    ' ---------------------------------------------------------
    ' GetNewArticleID
    ' Input Parameter : b_id
    ' Return Type : Integer
    '
    ' 지정한 게시판의 새글쓰기에 사용되는 c_id 값 리턴
    '----------------------------------------------------------
    Public Function GetNewArticleID(ByVal b_id As String) As Integer

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("GetNewArticleID", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.Parameters.Add("@b_id", b_id)

        Dim result As Object
        Try
            conn.Open()
            Dim objTemp As Object
            objTemp = comm.ExecuteScalar()
            If objTemp.GetType().ToString() = "System.DBNull" Then
                result = 1
            Else
                result = CType(objTemp, Integer)
            End If
            conn.Close()

            Return result

        Catch e As Exception
            Throw e
        End Try

    End Function



    ' ---------------------------------------------------------
    ' GetReplyArticleStep
    ' Input Parameter : b_id, c_id, c_step, c_depth
    ' Return Type : Integer
    '
    ' 답변글이 입력될 c_step 값 리턴
    '----------------------------------------------------------
    Public Function GetReplyArticleStep(ByVal b_id As String, _
                                ByVal c_id As Integer, _
                                ByVal c_step As Integer, _
                                ByVal c_depth As Integer) As Integer

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("GetReplyArticleStep", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@c_id", c_id)
        comm.Parameters.Add("@c_step", c_step)
        comm.Parameters.Add("@c_depth", c_depth)

        Dim result As Integer
        Try
            conn.Open()
            result = comm.ExecuteScalar()

            Return result

        Catch e As Exception
            Throw e

        End Try

    End Function

    ' ---------------------------------------------------------
    ' HasEditPermission
    ' Input Parameter : b_id, c_id, c_step, password
    ' Return Type : boolean
    '
    ' 게시물을 수정/삭제할 권한이 있는지 판단해서 리턴
    '----------------------------------------------------------
    Public Function HasEditPermission(ByVal b_id As String, _
                    ByVal c_id As Integer, _
                    ByVal c_step As Integer, _
                    ByVal password As String) As Boolean

        ' 삭제 및 수정 권한 체크

        Dim dsBoardInfo As dsBoard = GetBoardInfo(b_id)
        Dim AdminPW, WriterPW As String

        Try
            AdminPW = dsBoardInfo.boardmaster(0).adminpw.ToString()

            Dim dsArticleInfo As dsBoard = GetArticle(b_id, c_id, c_step)

            WriterPW = dsArticleInfo.GetArticle(0).password.ToString()

            If password = AdminPW Or password = WriterPW Then
                Return True
            Else
                Return False
            End If

        Catch e As Exception
            Throw e

        End Try


    End Function

    ' ---------------------------------------------------------
    ' HasWritePermission
    ' Input Parameter : b_id,password
    ' Return Type : boolean
    '
    ' 게시물을 쓰기/답변할 권한이 있는지 판단해서 리턴
    '----------------------------------------------------------
    Public Function HasWritePermission(ByVal b_id As String, _
                        ByVal password As String) As Boolean

        ' 쓰기 및 답변글쓰기 권한체크

        Dim dsBoardInfo As dsBoard = GetBoardInfo(b_id)
        Dim AdminPW, AdminOnly As String

        Try
            AdminPW = dsBoardInfo.boardmaster(0).adminpw.ToString()
            AdminOnly = dsBoardInfo.boardmaster(0)._readonly.ToString()

            If AdminOnly = "T" And password <> AdminPW Then
                Return False
            Else
                Return True
            End If

        Catch e As Exception
            Throw e

        End Try


    End Function


End Class
