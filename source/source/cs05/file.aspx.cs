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
	/// file�� ���� ��� �����Դϴ�.
	/// </summary>
	public class file : System.Web.UI.Page
	{
		protected System.Web.UI.HtmlControls.HtmlInputFile File1;
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
			File1.PostedFile.SaveAs("c:\test.jpg");

			Response.Write("���ε� �߽��ϴ�.<hr>");
		}
	}
}
