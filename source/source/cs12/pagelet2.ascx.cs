namespace control_cs
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Summary description for pagelet2.
	/// </summary>
	public abstract class pagelet2 : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.Button Button1;

		public string Message
		{
			get
			{
				return TextBox1.Text;
			}
			set 
			{
				TextBox1.Text = value;
			}
		}

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
		
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			TextBox1.Text = "������Ƽ2";
		}
	}
}