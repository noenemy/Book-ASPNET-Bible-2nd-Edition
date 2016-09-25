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
	/// Summary description for ds_delete.
	/// </summary>
	public class ds_delete : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtID;
		protected System.Web.UI.WebControls.Button btnDelete;
	
		public ds_delete()
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
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			// Connection 객체 생성해서 열기
			SqlConnection conn = new SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;");
			
			// Command 객체와 Parameter 객체 생성
			SqlCommand cmdSelect = new SqlCommand("SELECT * FROM region", conn);
			SqlCommand cmdDelete = new SqlCommand("DELETE FROM region WHERE regionid = @id", conn); 
			cmdDelete.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, "regionid"));

			// DataAdapter 객체 생성 및 Command 설정    
			SqlDataAdapter adapter = new SqlDataAdapter();
	        adapter.SelectCommand = cmdSelect;
			adapter.DeleteCommand = cmdDelete;

			// Untyped DataSet 객체 생성하고 데이터 채우기
			DataSet dataset = new DataSet();
			adapter.Fill(dataset, "region");

			// 해당하는 DataRow를 찾기
			DataTable table = dataset.Tables["region"];
			DataRow[] row = table.Select("regionid = " + txtID.Text.ToString());

			if (row.Length > 0) // 해당하는 행이 있으면 삭제
			{
				row[0].Delete();
				Response.Write("DataAdpater의 Update 명령수행<hr>");
				adapter.Update(dataset, "region");
			}
			else
			{
				Response.Write("해당하는 데이터가 없습니다.<hr>");
			}
		}
	}
}
