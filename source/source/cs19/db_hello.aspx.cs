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
using System.Web.Security;

namespace security_cs
{
	/// <summary>
	/// Summary description for db_hello.
	/// </summary>
	public class db_hello : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblUserName;
		protected System.Web.UI.WebControls.Button btnLogOut;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			// 인증된 사용자 이름 출력하기
			lblUserName.Text = User.Identity.Name;
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
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnLogOut_Click(object sender, System.EventArgs e)
		{
			// 로그아웃하기
			FormsAuthentication.SignOut();
			Response.Redirect("db_hello.aspx");
		}
	}
}
