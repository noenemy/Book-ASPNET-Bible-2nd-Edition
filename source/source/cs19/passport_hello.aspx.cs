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
using System.Web.Security;

namespace security_cs
{
	/// <summary>
	/// Summary description for passport_hello.
	/// </summary>
	public class passport_hello : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtName;
		protected System.Web.UI.WebControls.TextBox txtEmail;
		protected System.Web.UI.WebControls.TextBox txtGender;
		protected System.Web.UI.WebControls.TextBox txtCountry;
		protected System.Web.UI.WebControls.TextBox txtRegion;
		protected System.Web.UI.WebControls.Panel Panel1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here


			// PassportIdentity 객체 생성
			PassportIdentity PUser = (PassportIdentity)Context.User.Identity;

			// 인증된 사용자의 Passport 프로필 출력하기
			if (PUser.IsAuthenticated == true)
			{
				Panel1.Visible = true;
				txtName.Text = PUser["MemberName"];
				txtEmail.Text = PUser["PreferredEmail"];
				txtCountry.Text = PUser["Country"];
				txtGender.Text = PUser["Gender"];
				txtRegion.Text = PUser["Region"];
			}
			else
			{

				Panel1.Visible = false;
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
