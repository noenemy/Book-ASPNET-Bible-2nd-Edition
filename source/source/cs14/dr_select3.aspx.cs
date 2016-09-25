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
	/// Summary description for dr_select3.
	/// </summary>
	public class dr_select3 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button btnSelect;
	
		public dr_select3()
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
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnSelect_Click(object sender, System.EventArgs e)
		{
			// Connection 객체 생성해서 열기
			SqlConnection conn = new SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;");
			conn.Open();

			// Command 객체 생성
			string strSQL = "SELECT COUNT(*) FROM categories";
			SqlCommand comm = new SqlCommand(strSQL, conn);

			// ExecuteScalar를 통해 값 얻기 
			int intCount = int.Parse(comm.ExecuteScalar().ToString());

			// Connection 닫기
			conn.Close();

			Response.Write("현재 카테고리 개수는 " + intCount.ToString() + "개 입니다.<hr>");


		}
	}
}
