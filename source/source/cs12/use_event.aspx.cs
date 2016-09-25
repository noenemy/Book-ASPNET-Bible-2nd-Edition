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
	/// Summary description for use_event.
	/// </summary>
	public class use_event : System.Web.UI.Page
	{
		protected menu Menu1;
		protected pagelet3 Pagelet31;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		private void Menu1_SelectionChanged(object sender, System.EventArgs e)
		{
			Pagelet31.Region = Menu1.RegionName;
			Pagelet31.ShowCustomers();
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
			this.Load += new System.EventHandler(this.Page_Load);
			this.Menu1.SelectionChanged += new System.EventHandler(this.Menu1_SelectionChanged);

		}
		#endregion
	}
}
