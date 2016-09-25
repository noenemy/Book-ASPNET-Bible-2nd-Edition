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
using System.Configuration;

namespace guestbook_cs
{
	/// <summary>
	/// Summary description for write.
	/// </summary>
	public class write : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtName;
		protected System.Web.UI.WebControls.TextBox txtEmail;
		protected System.Web.UI.WebControls.TextBox txtContent;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.Button btnWrite;
		protected System.Web.UI.WebControls.Button btnCancel;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			ViewState["CurPage"] = Request.QueryString["page"];
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
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnWrite_Click(object sender, System.EventArgs e)
		{
			// SQL 쿼리문 만들기
			string strSQL;
			strSQL = "INSERT INTO guestbook(writer,email,password,content) " +
					 "VALUES(@Writer,@Email,@Password,@Content)";

			// ADO.NET 객체 생성
			SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["DSN"]);
			SqlCommand comm = new SqlCommand(strSQL, conn);

			// 파라미터 구성
			comm.Parameters.Add(new SqlParameter("@writer", txtName.Text));
			comm.Parameters.Add(new SqlParameter("@Email", txtEmail.Text));
			comm.Parameters.Add(new SqlParameter("@Password", txtPassword.Text));
			comm.Parameters.Add(new SqlParameter("@Content", txtContent.Text));

			// 게시물 쓰기
			conn.Open();
			comm.ExecuteNonQuery();
			conn.Close();

			// list.aspx로 이동
			Response.Redirect("list.aspx");
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			// list.aspx로 이동
			int CurPage = int.Parse (ViewState["CurPage"].ToString());
			string goURL = "list.aspx?page=" + CurPage.ToString();
			Response.Redirect(goURL);
		}
	}
}
