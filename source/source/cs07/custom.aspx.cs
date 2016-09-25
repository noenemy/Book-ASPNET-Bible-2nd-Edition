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
	/// Summary description for custom.
	/// </summary>
	public class custom : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.CustomValidator CustomValidator1;
		protected System.Web.UI.WebControls.Button btnOK;
		protected System.Web.UI.WebControls.TextBox txtInput;
	
		public custom()
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
			if (Page.IsValid == true)
			{
				Response.Write("홀수가 맞습니다. <hr>");
			}
		}

		public void ServerValidate(object source, ServerValidateEventArgs args)
		{
			try
			{
				int intInput = int.Parse(args.Value);
			
				if (intInput % 2 == 1)
					args.IsValid = true;
				else 
					args.IsValid = false;
			}
			catch (Exception e)
			{
				args.IsValid = false;
			}

		}
	}
}
