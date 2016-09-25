using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

namespace tiptech_cs
{
	/// <summary>
	/// Summary description for upload_to_db.
	/// </summary>
	public class upload_to_db : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button btnUpload;
		protected System.Web.UI.WebControls.DataList DataList1;
		protected System.Web.UI.HtmlControls.HtmlInputFile File1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected tiptech_cs.dsUploadTest dsUploadTest1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			// 파일목록 보여주기
			ShowFileList();
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.dsUploadTest1 = new tiptech_cs.dsUploadTest();
			((System.ComponentModel.ISupportInitialize)(this.dsUploadTest1)).BeginInit();
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT Id, filename, file_size, content_type, content FROM upload_test";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO upload_test(filename, file_size, content_type, content) VALUES (@file" +
				"name, @file_size, @content_type, @content); SELECT Id, filename, file_size, cont" +
				"ent_type, content FROM upload_test WHERE (Id = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@filename", System.Data.SqlDbType.NVarChar, 50, "filename"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@file_size", System.Data.SqlDbType.Int, 4, "file_size"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@content_type", System.Data.SqlDbType.NVarChar, 50, "content_type"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@content", System.Data.SqlDbType.VarBinary, 16, "content"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE upload_test SET filename = @filename, file_size = @file_size, content_type = @content_type, content = @content WHERE (Id = @Original_Id) AND (content_type = @Original_content_type) AND (file_size = @Original_file_size) AND (filename = @Original_filename); SELECT Id, filename, file_size, content_type, content FROM upload_test WHERE (Id = @Id)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@filename", System.Data.SqlDbType.NVarChar, 50, "filename"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@file_size", System.Data.SqlDbType.Int, 4, "file_size"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@content_type", System.Data.SqlDbType.NVarChar, 50, "content_type"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@content", System.Data.SqlDbType.VarBinary, 16, "content"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_content_type", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "content_type", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_file_size", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "file_size", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_filename", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "filename", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM upload_test WHERE (Id = @Original_Id) AND (content_type = @Original_c" +
				"ontent_type) AND (file_size = @Original_file_size) AND (filename = @Original_fil" +
				"ename)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_content_type", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "content_type", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_file_size", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "file_size", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_filename", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "filename", System.Data.DataRowVersion.Original, null));
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "data source=NENOTE;initial catalog=ASPNETBible;persist security info=True;user id" +
				"=sa;workstation id=NENOTE;packet size=4096";
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "upload_test", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("Id", "Id"),
																																																					 new System.Data.Common.DataColumnMapping("filename", "filename"),
																																																					 new System.Data.Common.DataColumnMapping("file_size", "file_size"),
																																																					 new System.Data.Common.DataColumnMapping("content_type", "content_type"),
																																																					 new System.Data.Common.DataColumnMapping("content", "content")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// dsUploadTest1
			// 
			this.dsUploadTest1.DataSetName = "dsUploadTest";
			this.dsUploadTest1.Locale = new System.Globalization.CultureInfo("ko-KR");
			this.dsUploadTest1.Namespace = "http://www.tempuri.org/dsUploadTest.xsd";
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsUploadTest1)).EndInit();

		}
		#endregion

		private void ShowFileList()
		{

			// DB 정보를 이용해서 파일리스트 보여주기
			sqlDataAdapter1.Fill(dsUploadTest1);
			DataList1.DataBind();
		}

		private void btnUpload_Click(object sender, System.EventArgs e)
		{
			// 업로드할 파일의 정보 얻기
			int FileSize = (int)File1.PostedFile.InputStream.Length;
			string ContentType = File1.PostedFile.ContentType;
			string FileName = System.IO.Path.GetFileName(File1.PostedFile.FileName);
			byte [] Content = new byte[FileSize];

			// 스트림으로 파일 업로드
			File1.PostedFile.InputStream.Read(Content, 0, FileSize);

			// ADO.NET 객체 생성
			string strSQL;
			strSQL = "INSERT INTO upload_test(filename, file_size, content_type, content) " +
                    " VALUES(@FileName,@FileSize, @ContentType, @Content)";
			SqlConnection conn = new SqlConnection("server=(local);database=ASPNETBible;uid=sa;pwd=;");
			SqlCommand comm = new SqlCommand(strSQL, conn);

			// 파라미터 구성하기
			SqlParameter Param1 = new SqlParameter("@FileName", SqlDbType.VarChar);
			Param1.Value = FileName;
			comm.Parameters.Add(Param1);

			SqlParameter Param2 = new SqlParameter("@FileSize", SqlDbType.Int);
			Param2.Value = FileSize;
			comm.Parameters.Add(Param2);

			SqlParameter Param3 = new SqlParameter("@ContentType", SqlDbType.VarChar);
			Param3.Value = ContentType;
			comm.Parameters.Add(Param3);

			SqlParameter Param4 = new SqlParameter("@Content", SqlDbType.Image);
			Param4.Value = Content;
			comm.Parameters.Add(Param4);

			// DB에 입력하기
			conn.Open();
			comm.ExecuteNonQuery();
			conn.Close();

			// 파일리스트 보여주기
			ShowFileList();
		}
	}
}
