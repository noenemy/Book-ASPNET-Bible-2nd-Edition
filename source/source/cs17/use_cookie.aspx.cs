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

namespace statemanage_cs
{
	/// <summary>
	/// Summary description for use_cookie.
	/// </summary>
	public class use_cookie : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblResult;
		protected System.Web.UI.WebControls.Button btnPlus;
		protected System.Web.UI.WebControls.Button btnMinus;

		private int Result;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!Page.IsPostBack)
				Result = 0;
			else
				Result = int.Parse(Request.Cookies["Result"].Value.ToString());

			ShowResult();
		}

		private void ShowResult()
		{
			// 값 출력하고, 쿠키 저장하기
			lblResult.Text = Result.ToString();
			Response.Cookies["Result"].Value = Result.ToString();
		}

		
		private void btnPlus_Click(object sender, System.EventArgs e)
		{
			// 변수 값 + 1
			Result = Result + 1;
			ShowResult();		
		}

		private void btnMinus_Click(object sender, System.EventArgs e)
		{
			// 변수 값 - 1
			Result = Result - 1;
			ShowResult();
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
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
