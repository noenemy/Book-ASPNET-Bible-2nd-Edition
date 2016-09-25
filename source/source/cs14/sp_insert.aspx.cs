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
	/// Summary description for sp_insert.
	/// </summary>
	public class sp_insert : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtCompany;
		protected System.Web.UI.WebControls.TextBox txtPhone;
		protected System.Web.UI.WebControls.Button Button1;
	
		public sp_insert()
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
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			// Connection 객체 생성해서 열기
			SqlConnection conn = new SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;");
			conn.Open();
        
			// Command, Parameter 객체 생성
			SqlCommand comm = new SqlCommand();
			comm.CommandText = "sp_InsertShipper";
			comm.CommandType = CommandType.StoredProcedure;
			comm.Connection = conn;
			
			SqlParameter param = new SqlParameter();
        
			// @id, @desc Parameter 설정
			param = comm.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40);
			param.Direction = ParameterDirection.Input;
			param.Value = txtCompany.Text.ToString();

			param = comm.Parameters.Add("@Phone", SqlDbType.NVarChar, 24);
			param.Direction = ParameterDirection.Input;
			param.Value = txtPhone.Text.ToString();

			param = comm.Parameters.Add("@ShipperID", SqlDbType.Int, 4);
			param.Direction = ParameterDirection.Output;

			// sp_InsertShipper 실행
			int intAffected;
			intAffected = comm.ExecuteNonQuery();
	
			// 결과출력하고 Connection 닫기
			Response.Write(intAffected.ToString() + " rows Inserted.<hr>");
			conn.Close();

			// Ouput Parameter 값 얻기 (이 부분 안됨..)
			string ShipperID = comm.Parameters["@ShipperID"].Value.ToString();
            Response.Write("부여받은 ID는 " + ShipperID + "입니다.<hr>");
		}
	}
}
