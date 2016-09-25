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

namespace validation_cs
{
	/// <summary>
	/// Summary description for practice.
	/// </summary>
	public class practice : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtID;
		protected System.Web.UI.WebControls.RequiredFieldValidator ReqID;
		protected System.Web.UI.WebControls.TextBox txtPWD1;
		protected System.Web.UI.WebControls.RequiredFieldValidator ReqPWD1;
		protected System.Web.UI.WebControls.CompareValidator ComPWD;
		protected System.Web.UI.WebControls.TextBox txtPWD2;
		protected System.Web.UI.WebControls.RequiredFieldValidator ReqPWD2;
		protected System.Web.UI.WebControls.TextBox txtJumin;
		protected System.Web.UI.WebControls.RequiredFieldValidator ReqJumin;
		protected System.Web.UI.WebControls.CustomValidator CusJumin;
		protected System.Web.UI.WebControls.TextBox txtMobile;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegMobile;
		protected System.Web.UI.WebControls.ValidationSummary Summary;
		protected System.Web.UI.WebControls.Button btnOK;
	
		public practice()
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
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			Response.Write("가입되었습니다. <hr>");
		}
	}
}
