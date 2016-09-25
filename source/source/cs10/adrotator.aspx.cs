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

namespace rich_cs
{
	/// <summary>
	/// Summary description for adrotator.
	/// </summary>
	public class adrotator : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList comKeyword;
		protected System.Web.UI.WebControls.Button btnReload;
		protected System.Web.UI.WebControls.AdRotator AdRotator1;
	
		public adrotator()
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
			this.comKeyword.SelectedIndexChanged += new System.EventHandler(this.comKeyword_SelectedIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void comKeyword_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			 // 필터링 키워드 설정
			AdRotator1.KeywordFilter = comKeyword.SelectedItem.Text;
		}
	}
}
