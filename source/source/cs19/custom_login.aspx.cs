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

namespace security_cs
{
	/// <summary>
	/// Summary description for custom_login.
	/// </summary>
	public class custom_login : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtUserName;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.Button btnLogin;
		protected System.Web.UI.WebControls.Label lblMessage;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			if (!Page.IsPostBack)
			{
				// 로그인 처리후 리턴할 페이지 정보 ViewState에 저장
				ViewState["ReturnURL"] = Request.QueryString["ret_url"];
				ViewState["Param"] = Request.QueryString["param"];
			}
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
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnLogin_Click(object sender, System.EventArgs e)
		{
			if (txtUserName.Text.Length > 0)
			{

				// web.config의 credential 정보로 인증하기
				if ((txtUserName.Text == "noenemy") && (txtPassword.Text == "1234"))
				{
					// 인증된 경우 세션변수 저장하기
					Session["UserID"] = txtUserName.Text;

					// 이전 페이지로 이동
					string goURL = ViewState["ReturnURL"] + "?" + ViewState["Param"];
					Response.Redirect(goURL);
				}
			}

			// 인증실패시 메시지 출력하기
			lblMessage.Text = "로그인 실패! 다시 입력하세요";
		}
	}
}
