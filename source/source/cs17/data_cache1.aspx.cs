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

namespace statemanage_cs
{
	/// <summary>
	/// Summary description for data_cache1.
	/// </summary>
	public class data_cache1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			if (Cache["customers"] == null)
			{
				// 캐시된 데이터가 없으면 데이터 캐시하기

				// ADO.NET 객체 생성
				SqlConnection conn = new SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;");
				SqlCommand comm = new SqlCommand("SELECT * FROM customers", conn);
				SqlDataAdapter adapter = new SqlDataAdapter(comm);
				DataSet ds = new DataSet();

				// 데이터 가져오기
				adapter.Fill(ds, "customers");

				// 캐시에 데이터 넣기
				Cache["customers"] = ds;
				Cache["cached_time"] = DateTime.Now.ToString();

			}
										   
			// 데이터 캐시를 이용한 데이터바인딩
			DataGrid1.DataSource = Cache["customers"];
			DataGrid1.DataMember = "customers";
			DataGrid1.DataBind();
			Label1.Text = "데이터 캐시된 시각 : " + Cache["cached_time"];
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
