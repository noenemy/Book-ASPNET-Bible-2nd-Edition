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
	/// Summary description for radiobutton.
	/// </summary>
	public class radiobutton : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.RadioButton RadioButton5;
		protected System.Web.UI.WebControls.RadioButton RadioButton4;
		protected System.Web.UI.WebControls.RadioButton RadioButton3;
		protected System.Web.UI.WebControls.RadioButton RadioButton2;
		protected System.Web.UI.WebControls.RadioButton RadioButton1;
	
		public radiobutton()
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

			if (RadioButton1.Checked == true) strChecked += RadioButton1.Text + ",";
			if (RadioButton2.Checked == true) strChecked += RadioButton2.Text + ",";

			if (RadioButton3.Checked == true) strChecked += RadioButton3.Text;
			if (RadioButton4.Checked == true) strChecked += RadioButton4.Text;
			if (RadioButton5.Checked == true) strChecked += RadioButton5.Text;

			Response.Write(strChecked + "<hr>");

		}
	}
}
