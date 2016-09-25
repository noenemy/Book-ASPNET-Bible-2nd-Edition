using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace adonet_cs
{
	/// <summary>
	/// Summary description for dr_select1.
	/// </summary>
	public class dr_select1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.Button btnBind;
	
		public dr_select1()
		{
			Page.Init += new System.EventHandler(Page_Init);
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		private void Page_Init(object sender, EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
		}

		#region Web Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnBind.Click += new System.EventHandler(this.btnBind_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnBind_Click(object sender, System.EventArgs e)
		{
			// Connection 객체 생성해서 열기
			SqlConnection conn = new SqlConnection("server=(local);database=Northwind;uid=sa;pwd=");
			conn.Open();

			// Command 객체 생성
			string strSQL = "SELECT * FROM categories";
			SqlCommand comm = new SqlCommand(strSQL, conn);
			
			// DataReader 생성하기
			SqlDataReader reader = comm.ExecuteReader();

			// DataReader를 이용해서 DataGrid 컨트롤 바인딩
			DataGrid1.DataSource = reader;
			DataGrid1.DataBind();

			// DataReader와 Connection 닫기
			reader.Close();
			conn.Close();

		}
	}
}
