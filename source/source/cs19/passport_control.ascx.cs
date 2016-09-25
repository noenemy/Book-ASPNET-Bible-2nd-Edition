namespace security_cs
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.Web.Security;

	/// <summary>
	///		Summary description for passport_control.
	/// </summary>
	public abstract class passport_control : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.Label Label1;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			PassportIdentity id = (PassportIdentity)Page.User.Identity;
			Label1.Text = id.LogoTag();
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
