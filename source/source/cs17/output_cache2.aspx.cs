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

namespace statemanage_cs
{
	/// <summary>
	/// Summary description for output_cache2.
	/// </summary>
	public class output_cache2 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			// 현재 페이지의 캐시 설정 - 만료시간 : 5초
			Response.Cache.SetExpires(DateTime.Now.AddSeconds(5));
			Response.Cache.SetCacheability(HttpCacheability.Public);
			Label1.Text = "페이지가 캐시에 저장된 시각 : " + DateTime.Now.ToString();
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

		}
		#endregion
	}
}
