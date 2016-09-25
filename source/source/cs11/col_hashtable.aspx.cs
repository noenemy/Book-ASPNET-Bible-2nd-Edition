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

namespace databinding_cs
{
	/// <summary>
	/// Summary description for col_hashtable.
	/// </summary>
	public class col_hashtable : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.RadioButtonList optHash;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!Page.IsPostBack)
			{
				// HashTable 아이템 구성
				Hashtable htSong = new Hashtable();
                htSong.Add("서태지", "울트라맨이야");
				htSong.Add("마이클잭슨", "Invincible");
				htSong.Add("CBMASS", "휘파람");

				// RadioButtonList 컨트롤 데이터바인딩
				optHash.DataSource = htSong;
				optHash.DataTextField = "Value";
				optHash.DataValueField = "Key";
				optHash.DataBind();
			}

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
