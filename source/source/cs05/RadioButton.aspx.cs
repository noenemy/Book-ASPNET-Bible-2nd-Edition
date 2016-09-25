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

namespace html_cs
{
	/// <summary>
	/// RadioButton�� ���� ��� �����Դϴ�.
	/// </summary>
	public class RadioButton : System.Web.UI.Page
	{
		protected System.Web.UI.HtmlControls.HtmlInputRadioButton Radio1;
		protected System.Web.UI.HtmlControls.HtmlInputRadioButton Radio2;
		protected System.Web.UI.HtmlControls.HtmlInputRadioButton Radio3;
		protected System.Web.UI.HtmlControls.HtmlInputRadioButton Radio4;
		protected System.Web.UI.HtmlControls.HtmlInputButton Submit1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// ���⿡ ����� �ڵ带 ��ġ�Ͽ� �������� �ʱ�ȭ�մϴ�.
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �� ȣ���� ASP.NET Web Form �����̳ʿ� �ʿ��մϴ�.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Submit1.ServerClick += new System.EventHandler(this.Submit1_ServerClick);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Submit1_ServerClick(object sender, System.EventArgs e)
		{
			string strMsg;

			if (Radio1.Checked == true)
				strMsg = "�����Դϴ�.<hr>";
			else
				strMsg = "Ʋ�Ƚ��ϴ�. 1����� �ٽ� ������.<hr>";
        
			Response.Write(strMsg);
		}
	}
}
