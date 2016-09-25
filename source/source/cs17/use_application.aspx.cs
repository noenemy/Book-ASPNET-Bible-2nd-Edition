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
	/// Summary description for use_application.
	/// </summary>
	public class use_application : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblResult;
		protected System.Web.UI.WebControls.Button btnPlus;
		protected System.Web.UI.WebControls.Button btnMinus;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!Page.IsPostBack)
			{
				// 어플리케이션 변수값 초기화
				Application["Result"] = 0;
				ShowResult();
			}
		}

		private void ShowResult()
		{
			// 어플리케이션 값 출력하기
			lblResult.Text = Application["Result"].ToString();
		}

		
		private void btnPlus_Click(object sender, System.EventArgs e)
		{
			// 어플리케이션변수 값 + 1
			Application["Result"] = (int)Application["Result"] + 1;
			ShowResult();		
		}

		private void btnMinus_Click(object sender, System.EventArgs e)
		{
			// 어플리케이션변수 값 - 1
			Application["Result"] = (int)Application["Result"] - 1;
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
