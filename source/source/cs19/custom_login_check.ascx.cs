namespace security_cs
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Summary description for custom_login_check.
	/// </summary>
	public abstract class custom_login_check : System.Web.UI.UserControl
	{

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			
			// 로그인 했는지 확인
			if (Session["UserID"] == null || Session["UserID"].ToString() == "")
			{
				// 로그인 하지 않았으면 로그인 페이지로 이동
				string strURL = Request.ServerVariables["PATH_INFO"];
				string strParam = Request.ServerVariables["QUERY_STRING"];

				string goURL = "custom_login.aspx?ret_url=" + strURL + "&param=" + strParam;
				Response.Redirect(goURL);
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
		
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion
	}
}
