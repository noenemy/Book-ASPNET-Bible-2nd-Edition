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

			// 다운로드 시킬 파일의 경로
			string FilePath = Request.QueryString["path"];

			// 지정된 경로 이외의 파일요청 거부
			if (FilePath.CompareTo(Root) > 0 )
			{

				// 파일명 얻기
				string FileName = Path.GetFileName(FilePath);

				// 헤더에 파일이름 지정하기
				Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
				Response.ContentType = "multipart/form-data";
				// 파일 다운로드 시키기
				Response.WriteFile(FilePath);
			}
			else
				Response.Write("잘못된 요청입니다.");

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
