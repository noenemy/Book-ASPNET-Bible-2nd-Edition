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
	/// Summary description for output_cache4.
	/// </summary>
	public class output_cache4 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.HyperLink HyperLink1;
		protected System.Web.UI.WebControls.HyperLink HyperLink2;
		protected System.Web.UI.WebControls.HyperLink HyperLink3;
		protected System.Web.UI.WebControls.Label lblCountry;
		protected System.Web.UI.WebControls.Label lblCachedTime;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			// country 쿼리스트링 가져오기
			string country = Request.QueryString["country"];
			if (country == null)
				country = "UK";

			// SQL 쿼리문 구성
			string strSQL = "SELECT * FROM customers WHERE country = '" + country + "'";

			// ADO.NET 객체 생성
			SqlConnection conn = new  SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;");
			SqlCommand comm = new SqlCommand(strSQL, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(comm);
			DataSet ds = new DataSet();

			// 데이터 가져오기
			adapter.Fill(ds, "customers");

			// DataGrid 컨트롤 데이터 바인딩
			DataGrid1.DataSource = ds;
			DataGrid1.DataMember = "customers";
			DataGrid1.DataBind();

			// 현재 국가, 캐시된 시각 출력
			lblCountry.Text = country;
			lblCachedTime.Text = DateTime.Now.ToString();
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
