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
	/// Summary description for checkbox.
	/// </summary>
	public class checkbox : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.CheckBox CheckBox4;
		protected System.Web.UI.WebControls.CheckBox CheckBox3;
		protected System.Web.UI.WebControls.CheckBox CheckBox2;
		protected System.Web.UI.WebControls.CheckBox CheckBox1;
	
		public checkbox()
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
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			string strChecked;
			strChecked = "선택된 값 : ";

			if (CheckBox1.Checked == true) strChecked += CheckBox1.Text + ",";
			if (CheckBox2.Checked == true) strChecked += CheckBox2.Text + ",";
			if (CheckBox3.Checked == true) strChecked += CheckBox3.Text + ",";
			if (CheckBox4.Checked == true) strChecked += CheckBox4.Text + ",";

			Response.Write(strChecked + "<hr>");
		}
	}
}
