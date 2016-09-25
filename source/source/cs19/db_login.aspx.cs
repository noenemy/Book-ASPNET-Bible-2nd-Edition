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
using System.Data.SqlClient;

namespace security_cs
{
	/// <summary>
	/// Summary description for db_login.
	/// </summary>
	public class db_login : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtUserName;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.Button btnLogin;
		protected System.Web.UI.WebControls.Label lblMessage;
	
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
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnLogin_Click(object sender, System.EventArgs e)
		{
			if (txtUserName.Text.Length > 0)
			{

				// �����ͺ��̽��� ȸ�� ������ �����ϱ�
				string strSQL;
				strSQL = "SELECT COUNT(*) FROM login_test " +
					"WHERE userid='" + txtUserName.Text.Trim() + "' AND " +
					"password = '" + txtPassword.Text.Trim() + "'";

				SqlConnection conn = new SqlConnection("server=(local);database=ASPNETBible;uid=sa;pwd=;");
				SqlCommand comm = new SqlCommand(strSQL, conn);
				int count;

				conn.Open();
				count = (int)comm.ExecuteScalar();
				conn.Close()	;

				if (count > 0)
				{
					// ������ ��� ������Ű �����ϰ�, ���� �������� �̵�
					FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, false);
				}
			}

			// �������н� �޽��� ����ϱ�
			lblMessage.Text = "�α��� ����! �ٽ� �Է��ϼ���";
		}
	}
}
