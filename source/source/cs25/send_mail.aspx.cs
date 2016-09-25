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

namespace webmail_cs
{
	/// <summary>
	/// Summary description for send_mail.
	/// </summary>
	public class send_mail : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtFrom;
		protected System.Web.UI.WebControls.TextBox txtTo;
		protected System.Web.UI.WebControls.TextBox txtSubject;
		protected System.Web.UI.WebControls.TextBox txtContent;
		protected System.Web.UI.WebControls.Button btnSend;
	
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
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnSend_Click(object sender, System.EventArgs e)
		{
			
			// MailMessage ��ü ����
			System.Web.Mail.MailMessage mail = new System.Web.Mail.MailMessage();
	        mail.From = txtFrom.Text;
			mail.To = txtTo.Text;
			mail.Subject = txtSubject.Text;
			mail.Body = txtContent.Text;

			try
			{
				// SmtpMail.Send�� ���� �߼��ϱ�
				System.Web.Mail.SmtpMail.Send(mail);
			}
			catch (System.Exception ex)
			{
				Response.Write("���ܹ߻� : " + ex.Message.ToString());
			}        
		}
	}
}
