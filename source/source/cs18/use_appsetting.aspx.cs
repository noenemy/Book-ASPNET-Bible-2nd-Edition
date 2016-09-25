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

namespace configuration_cs
{
	/// <summary>
	/// Summary description for use_appsetting.
	/// </summary>
	public class use_appsetting : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!Page.IsPostBack)
			{
				// 데이터베이스 연결 문자열 가져오기
				string strDSN = System.Configuration.ConfigurationSettings.AppSettings["DSN"];
				Response.Write(strDSN);

				// Connection, Command, DataReader 객체 생성
				SqlConnection conn = new SqlConnection(strDSN);
				conn.Open();
				SqlCommand comm = new SqlCommand("SELECT * FROM categories", conn);
				SqlDataReader ds;

				// 데이터 가져오기
				ds = comm.ExecuteReader();

				// DataGrid 데이터바인딩
				DataGrid1.DataSource = ds;
				DataGrid1.DataBind();

				// DataReader, Connection 객체 닫기
				ds.Close();
				conn.Close();

			}
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
