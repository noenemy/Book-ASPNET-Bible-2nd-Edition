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

namespace intrinsic_cs1
{
	/// <summary>
	/// Summary description for panel.
	/// </summary>
	public class panel : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button btnAdd;
		protected System.Web.UI.WebControls.Button btnHide;
		protected System.Web.UI.WebControls.Button btnShow;
		protected System.Web.UI.WebControls.TextBox TextBox2;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.Panel Panel1;
	
		public panel()
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
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnShow_Click(object sender, System.EventArgs e)
		{
			Panel1.Visible = true;
		}

		private void btnHide_Click(object sender, System.EventArgs e)
		{
			Panel1.Visible = false;
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			// TextBox 按眉 积己
			TextBox txtNew = new System.Web.UI.WebControls.TextBox();
			txtNew.Text = "眠啊等 TextBox";
			
			// Panel 牧飘费俊 TextBox 悼利 积己
			Panel1.Controls.Add(txtNew);
		}
	}
}
