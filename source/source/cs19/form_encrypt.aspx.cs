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
	/// Summary description for form_encrypt.
	/// </summary>
	public class form_encrypt : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.Button btnEncrypt;
		protected System.Web.UI.WebControls.Label lblSHA1;
		protected System.Web.UI.WebControls.Label lblMD5;
	
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
			this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnEncrypt_Click(object sender, System.EventArgs e)
		{
			// 입력받은 비밀번호를 SHA1, MD5로 암호화하기
			string Password  = txtPassword.Text;
			lblSHA1.Text = FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "SHA1");
			lblMD5.Text = FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "MD5");
		}
	}
}
