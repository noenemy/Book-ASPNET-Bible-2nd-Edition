' ----------------------------------------
' NEBOARD.net COM+ ���� 1.0
' Class �� : Tx
' TrasactionOption : Supported
'
' �ۼ��� : 2003.10.02 
'                       by noenemy
' ----------------------------------------


Imports System.EnterpriseServices
Imports System.Data.SqlClient


<Transaction(TransactionOption.Supported)> _
Public Class Tx
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

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("IncreaseReadCount", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@c_id", c_id)
        comm.Parameters.Add("@c_step", c_step)

        Dim result As Integer
        Try
            conn.Open()
            result = comm.ExecuteNonQuery()
            conn.Close()

            If result > 0 Then
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

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("IncreaseDownCount", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@c_id", c_id)
        comm.Parameters.Add("@c_step", c_step)

        Dim result As Integer
        Try
            conn.Open()
            result = comm.ExecuteNonQuery()
            conn.Close()

            If result > 0 Then
                Return True
            Else
                Return False
            End If

        Catch e As Exception
            Throw e
        End Try

    End Function

    ' ---------------------------------------------------------
    ' WriteBoardList
    ' Input Parameter : b_id, c_id, c_step, c_depth, subject
    '           writer, email, filename, filesize, password
    ' Return Type : boolean
    '
    ' �Խù� ��� ���� ���
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function WriteBoardList(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer, _
                        ByVal c_depth As Integer, _
                        ByVal subject As String, _
                        ByVal writer As String, _
                        ByVal email As String, _
                        ByVal filename As String, _
                        ByVal filesize As String, _
                        ByVal password As String) As Boolean

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("WriteBoardList", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@c_id", c_id)
        comm.Parameters.Add("@c_step", c_step)
        comm.Parameters.Add("@c_depth", c_depth)
        comm.Parameters.Add("@subject", subject)
        comm.Parameters.Add("@writer", writer)
        comm.Parameters.Add("@email", email)
        comm.Parameters.Add("@filename", filename)
        comm.Parameters.Add("@filesize", filesize)
        comm.Parameters.Add("@password", password)

        Dim result As Integer
        Try
            conn.Open()
            result = comm.ExecuteNonQuery()
            conn.Close()

            If result > 0 Then
                Return True
            Else
                Return False
            End If

        Catch e As Exception
            Throw e
        End Try

    End Function


    ' ---------------------------------------------------------
    ' WriteBoardContent
    ' Input Parameter : b_id, c_id, c_step, content
    ' Return Type : boolean
    '
    ' �Խù� ���� ���
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function WriteBoardContent(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer, _
                        ByVal content As String) As Boolean

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("WriteBoardContent", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@c_id", c_id)
        comm.Parameters.Add("@c_step", c_step)
        comm.Parameters.Add("@content", content)

        Dim result As Integer
        Try
            conn.Open()
            result = comm.ExecuteNonQuery()
            conn.Close()

            If result > 0 Then
                Return True
            Else
                Return False
            End If

        Catch e As Exception
            Throw e
        End Try

    End Function



    ' ---------------------------------------------------------
    ' EditBoardList
    ' Input Parameter : b_id, c_id, c_step, subject, writer,
    '                   email, filename, filesize
    ' Return Type : boolean
    '
    ' �Խù� ��� ���� ����
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function EditBoardList(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer, _
                        ByVal subject As String, _
                        ByVal writer As String, _
                        ByVal email As String, _
                        ByVal filename As String, _
                        ByVal filesize As String) As Boolean

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("EditBoardList", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@c_id", c_id)
        comm.Parameters.Add("@c_step", c_step)
        comm.Parameters.Add("@subject", subject)
        comm.Parameters.Add("@writer", writer)
        comm.Parameters.Add("@email", email)
        comm.Parameters.Add("@filename", filename)
        comm.Parameters.Add("@filesize", filesize)

        Dim result As Integer
        Try
            conn.Open()
            result = comm.ExecuteNonQuery()
            conn.Close()

            If result > 0 Then
                Return True
            Else
                Return False
            End If

        Catch e As Exception
            Throw e
        End Try

    End Function


    ' ---------------------------------------------------------
    ' EditBoardContent
    ' Input Parameter : b_id, c_id, c_step, content
    ' Return Type : boolean
    '
    ' �Խù� ���� ����
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function EditBoardContent(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer, _
                        ByVal content As String) As Boolean

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("EditBoardContent", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@c_id", c_id)
        comm.Parameters.Add("@c_step", c_step)
        comm.Parameters.Add("@content", content)

        Dim result As Integer
        Try
            conn.Open()
            result = comm.ExecuteNonQuery()
            conn.Close()

            If result > 0 Then
                Return True
            Else
                Return False
            End If

        Catch e As Exception
            Throw e
        End Try

    End Function


    ' ---------------------------------------------------------
    ' DeleteBoardList
    ' Input Parameter : b_id, c_id, c_step
    ' Return Type : boolean
    '
    ' �Խù� ��� ���� ����
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function DeleteBoardList(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer) As Boolean

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("DeleteBoardList", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@c_id", c_id)
        comm.Parameters.Add("@c_step", c_step)

        Dim result As Integer
        Try
            conn.Open()
            result = comm.ExecuteNonQuery()
            conn.Close()

            If result > 0 Then
                Return True
            Else
                Return False
            End If

        Catch e As Exception
            Throw e
        End Try

    End Function


    ' ---------------------------------------------------------
    ' DeleteBoardContent
    ' Input Parameter : b_id, c_id, c_step
    ' Return Type : boolean
    '
    ' �Խù� ���� ����
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function DeleteBoardContent(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer) As Boolean

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("DeleteBoardContent", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@c_id", c_id)
        comm.Parameters.Add("@c_step", c_step)

        Dim result As Integer
        Try
            conn.Open()
            result = comm.ExecuteNonQuery()
            conn.Close()

            If result > 0 Then
                Return True
            Else
                Return False
            End If

        Catch e As Exception
            Throw e
        End Try

    End Function


    ' ---------------------------------------------------------
    ' ReorderBoardList
    ' Input Parameter : b_id, c_id, c_step
    ' Return Type : boolean
    '
    ' �Խù� ��� ���� c_step �о��(�亯�ÿ� ���)
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function ReorderBoardList(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer) As Boolean

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("ReorderBoardList", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@c_id", c_id)
        comm.Parameters.Add("@c_step", c_step)

        Dim result As Integer
        Try
            conn.Open()
            result = comm.ExecuteNonQuery()
            conn.Close()

            Return result

        Catch e As Exception
            Throw e
        End Try

    End Function


    ' ---------------------------------------------------------
    ' ReorderBoardContent
    ' Input Parameter : b_id, c_id, c_step
    ' Return Type : boolean
    '
    ' �Խù� ���� c_step �о��(�亯�ÿ� ���)
    '----------------------------------------------------------
    <AutoComplete()> _
    Public Function ReorderBoardContent(ByVal b_id As String, _
                        ByVal c_id As Integer, _
                        ByVal c_step As Integer) As Boolean

        Dim conn As New SqlConnection(GetConnString())
        Dim comm As New SqlCommand("ReorderBoardContent", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@b_id", b_id)
        comm.Parameters.Add("@c_id", c_id)
        comm.Parameters.Add("@c_step", c_step)

        Dim result As Integer
        Try
            conn.Open()
            result = comm.ExecuteNonQuery()
            conn.Close()

            Return result

        Catch e As Exception
            Throw e
        End Try

    End Function


End Class
