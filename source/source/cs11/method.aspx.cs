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

namespace databinding_cs
{
	/// <summary>
	/// Summary description for method.
	/// </summary>
	public class method : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtYear;
		protected System.Web.UI.WebControls.Button btnOK;
		protected System.Web.UI.WebControls.Label lblAge;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
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
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			Page.DataBind();
		}

		public int CaculateAge(string BirthYear)
		{
			// 태어난 해를 인수로 받아서 올해 나이를 계산해서 리턴한다.
			int Age;
			Age = DateTime.Now.Year - int.Parse(BirthYear) + 1;
			return Age;
		}

	}
}
