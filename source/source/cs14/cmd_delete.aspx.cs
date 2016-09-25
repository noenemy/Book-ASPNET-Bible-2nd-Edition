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
	/// Summary description for cmd_delete.
	/// </summary>
	public class cmd_delete : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtID;
		protected System.Web.UI.WebControls.Button btnDelete;
	
		public cmd_delete()
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
			conn.Open();

			// Command, Parameter 객체 생성
			string strSQL = "DELETE FROM region WHERE regionid = @id";
			SqlCommand comm = new SqlCommand(strSQL,conn);
			SqlParameter param = new SqlParameter();

			// @id Parameter 설정
			param = comm.Parameters.Add("@id", SqlDbType.Int);
			param.Direction = ParameterDirection.Input;
			param.Value = int.Parse(txtID.Text.ToString());

			// DELETE문 실행
			int intAffected;
	        intAffected = comm.ExecuteNonQuery();

			// 결과출력하고 Connection 닫기
			Response.Write(intAffected.ToString() + " rows deleted.<hr>");
			conn.Close();
		}
	}
}
