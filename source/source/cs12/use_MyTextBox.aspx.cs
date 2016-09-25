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

namespace control_cs
{
	/// <summary>
	/// Summary description for use_MyTextBox.
	/// </summary>
	public class use_MyTextBox : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button1;
		protected CustomControl.MyTextBox MyTextBox1;
	
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
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);
			this.MyTextBox1.TextChanged += new System.EventHandler(this.MyTextBox1_TextChanged);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			Response.Write(MyTextBox1.Text);
		}
		
		private void MyTextBox1_TextChanged(object sender, System.EventArgs e)
		{
			Response.Write("TextChanged 이벤트발생.");
		}

	}
}
