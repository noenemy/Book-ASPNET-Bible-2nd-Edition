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
	/// Summary description for open_from_db.
	/// </summary>
	public class open_from_db : System.Web.UI.Page
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			// 파일의 Id 값 얻기
			int Id = int.Parse(Request.QueryString["id"].ToString());

			// ADO.NET 객체 생성
			SqlConnection conn = new SqlConnection("server=(local);database=ASPNETBible;uid=sa;pwd=;");
			SqlCommand comm = new SqlCommand("SELECT * FROM upload_test WHERE id = @Id", conn);

			// 파라미터 구성
			SqlParameter Param1 = new SqlParameter("@Id", SqlDbType.Int);
			Param1.Value = Id;
			comm.Parameters.Add(Param1);

			// DataReader로 읽기
			conn.Open();
			SqlDataReader dr;
			dr = comm.ExecuteReader();
			dr.Read();

			// OutputStream으로 파일 출력하기
			Response.ContentType = dr["content_type"].ToString();
			Response.OutputStream.Write((byte[])dr["content"], 0, (int)dr["file_size"]);
			Response.End();

			conn.Close();
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
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion
	}
}
