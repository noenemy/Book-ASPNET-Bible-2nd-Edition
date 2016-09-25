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
	/// Summary description for sp_select.
	/// </summary>
	public class sp_select : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtID;
		protected System.Web.UI.WebControls.Button btnSelect;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
	
		public sp_select()
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
			SqlCommand comm = new SqlCommand();
			comm.CommandText = "sp_products";
			comm.CommandType = CommandType.StoredProcedure;
			comm.Connection = conn;

			// Parameter 객체 생성해서 추가하기
			SqlParameter param = new SqlParameter("@productid", SqlDbType.Int);
			param.Direction = ParameterDirection.Input;
			param.Value = int.Parse(txtID.Text.ToString());
			comm.Parameters.Add(param);

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
