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
using System.IO;

namespace webdisk_cs
{
	/// <summary>
	/// Summary description for openfile.
	/// </summary>
	public class openfile : System.Web.UI.Page
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			
			string Root = System.Configuration.ConfigurationSettings.AppSettings["root"];

			// �ٿ�ε� ��ų ������ ���
			string FilePath = Request.QueryString["path"];

			// ������ ��� �̿��� ���Ͽ�û �ź�
			if (FilePath.CompareTo(Root) > 0 )
			{

				// ���ϸ� ���
				string FileName = Path.GetFileName(FilePath);

				// ����� �����̸� �����ϱ�
				Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
				Response.ContentType = "multipart/form-data";
				// ���� �ٿ�ε� ��Ű��
				Response.WriteFile(FilePath);
			}
			else
				Response.Write("�߸��� ��û�Դϴ�.");

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
