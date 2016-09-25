' ----------------------------------------
' NEBOARD.net COM+ ���� 1.0
' Class �� : nTx
' TrasactionOption : NotSupported
'
' �ۼ��� : 2003.10.02 
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
    ' DB ���� ���ڿ��� web.config���� �����ͼ� ����
    '----------------------------------------------------------
    Private Function GetConnString() As String
        Return System.Configuration.ConfigurationSettings.AppSettings("DSN")
    End Function

    ' ---------------------------------------------------------
    ' GetArticle
    ' Input Parameter : b_id, c_id, c_step
    ' Return Type : dsBoard
    '
    ' ������ �Խù� ���� ����
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
    ' �Խ��� ���� ����
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
    ' �Խù� ����� ����
    '----------------------------------------------------------
    Public Function GetBoardList(ByVal b_id As String, _
                        ByVal search_option As String, _
                        ByVal search_key As String, _
                        ByVal pagesize As Integer, _
                        ByVal curpage As Integer) As dsBoard

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("GetBoardList", conn)
        comm.CommandType = CommandType.StoredProcedure

        ' ������ �Խù� ��
        Dim TopCount As Integer = curpage * pagesize
        Dim adapter As New SqlDataAdapter(comm)

        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@search_option", search_option)
        comm.Parameters.Add("@search_key", search_key)
        comm.Parameters.Add("@topcount", TopCount.ToString())

        ' ��������ȣ�� ���� ���ڵ� ������ġ
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
    ' ������ �Խ����� �Խù� ���� ����
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
    ' ������ �Խ����� ���۾��⿡ ���Ǵ� c_id �� ����
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
    ' �亯���� �Էµ� c_step �� ����
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
    ' �Խù��� ����/������ ������ �ִ��� �Ǵ��ؼ� ����
    '----------------------------------------------------------
    Public Function HasEditPermission(ByVal b_id As String, _
                    ByVal c_id As Integer, _
                    ByVal c_step As Integer, _
                    ByVal password As String) As Boolean

        ' ���� �� ���� ���� üũ

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
    ' �Խù��� ����/�亯�� ������ �ִ��� �Ǵ��ؼ� ����
    '----------------------------------------------------------
    Public Function HasWritePermission(ByVal b_id As String, _
                        ByVal password As String) As Boolean

        ' ���� �� �亯�۾��� ����üũ

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
