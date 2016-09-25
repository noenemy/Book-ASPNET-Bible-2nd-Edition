Imports System.Data.SqlClient

Public Class upload_to_db
    Inherits System.Web.UI.Page
    Protected WithEvents File1 As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents btnUpload As System.Web.UI.WebControls.Button
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents DsUploadTest1 As tiptech_vb.dsUploadTest
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsUploadTest1 = New tiptech_vb.dsUploadTest()
        CType(Me.DsUploadTest1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id, filename, file_size, content_type, content FROM upload_test"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "data source=NENOTE;initial catalog=ASPNETBible;persist security info=True;user id" & _
        "=sa;workstation id=NENOTE;packet size=4096"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO upload_test(filename, file_size, content_type, content) VALUES (@file" & _
        "name, @file_size, @content_type, @content); SELECT Id, filename, file_size, cont" & _
        "ent_type, content FROM upload_test WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@filename", System.Data.SqlDbType.NVarChar, 50, "filename"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@file_size", System.Data.SqlDbType.Int, 4, "file_size"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@content_type", System.Data.SqlDbType.NVarChar, 50, "content_type"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@content", System.Data.SqlDbType.VarBinary, 16, "content"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE upload_test SET filename = @filename, file_size = @file_size, content_type" & _
        " = @content_type, content = @content WHERE (Id = @Original_Id) AND (content_type" & _
        " = @Original_content_type) AND (file_size = @Original_file_size) AND (filename =" & _
        " @Original_filename); SELECT Id, filename, file_size, content_type, content FROM" & _
        " upload_test WHERE (Id = @Id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@filename", System.Data.SqlDbType.NVarChar, 50, "filename"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@file_size", System.Data.SqlDbType.Int, 4, "file_size"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@content_type", System.Data.SqlDbType.NVarChar, 50, "content_type"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@content", System.Data.SqlDbType.VarBinary, 16, "content"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_content_type", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "content_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_file_size", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "file_size", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_filename", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "filename", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM upload_test WHERE (Id = @Original_Id) AND (content_type = @Original_c" & _
        "ontent_type) AND (file_size = @Original_file_size) AND (filename = @Original_fil" & _
        "ename)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_content_type", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "content_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_file_size", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "file_size", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_filename", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "filename", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "upload_test", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("filename", "filename"), New System.Data.Common.DataColumnMapping("file_size", "file_size"), New System.Data.Common.DataColumnMapping("content_type", "content_type"), New System.Data.Common.DataColumnMapping("content", "content")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DsUploadTest1
        '
        Me.DsUploadTest1.DataSetName = "dsUploadTest"
        Me.DsUploadTest1.Locale = New System.Globalization.CultureInfo("ko-KR")
        Me.DsUploadTest1.Namespace = "http://www.tempuri.org/dsUploadTest.xsd"
        CType(Me.DsUploadTest1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

        ' 파일목록 보여주기
        ShowFileList()
    End Sub


    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click

        ' 업로드할 파일의 정보 얻기
        Dim FileSize As Integer = File1.PostedFile.InputStream.Length
        Dim ContentType As String = File1.PostedFile.ContentType
        Dim FileName As String = System.IO.Path.GetFileName(File1.PostedFile.FileName)
        Dim Content As Byte()
        ReDim Content(FileSize)

        ' 스트림으로 파일 업로드
        File1.PostedFile.InputStream.Read(Content, 0, FileSize)

        ' ADO.NET 객체 생성
        Dim strSQL As String
        strSQL = "INSERT INTO upload_test(filename, file_size, content_type, content) " & _
                    " VALUES(@FileName,@FileSize, @ContentType, @Content)"
        Dim conn As New SqlConnection("server=(local);database=ASPNETBible;uid=sa;pwd=;")
        Dim comm As New SqlCommand(strSQL, conn)

        ' 파라미터 구성하기
        Dim Param1 As New SqlParameter("@FileName", SqlDbType.VarChar)
        Param1.Value = FileName
        comm.Parameters.Add(Param1)

        Dim Param2 As New SqlParameter("@FileSize", SqlDbType.Int)
        Param2.Value = FileSize
        comm.Parameters.Add(Param2)

        Dim Param3 As New SqlParameter("@ContentType", SqlDbType.VarChar)
        Param3.Value = ContentType
        comm.Parameters.Add(Param3)

        Dim Param4 As New SqlParameter("@Content", SqlDbType.Image)
        Param4.Value = Content
        comm.Parameters.Add(Param4)

        ' DB에 입력하기
        conn.Open()
        comm.ExecuteNonQuery()
        conn.Close()

        ' 파일리스트 보여주기
        ShowFileList()

    End Sub


    Private Sub ShowFileList()

        ' DB 정보를 이용해서 파일리스트 보여주기
        SqlDataAdapter1.Fill(DsUploadTest1)
        DataList1.DataBind()

    End Sub

End Class
