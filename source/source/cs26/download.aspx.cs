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
using System.Configuration;

namespace board_cs
{
	/// <summary>
	/// Summary description for download.
	/// </summary>
	public class download : System.Web.UI.Page
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			string b_id = Request.QueryString["b_id"];
			int c_id = int.Parse(Request.QueryString["c_id"]);
			int c_step = int.Parse(Request.QueryString["c_step"]);

			string filename, downpath;

			// 파일의 다운로드수 증가
			BizBoard.Root objRoot = new BizBoard.Root();
			objRoot.IncreaseDownCount(b_id, c_id, c_step);

			// 첨부파일 정보 얻기
			BizBoard.nTx objnTx = new BizBoard.nTx();
			BizBoard.dsBoard dsArticle = new BizBoard.dsBoard();
			dsArticle = objnTx.GetArticle(b_id, c_id, c_step);
			filename = dsArticle.GetArticle[0].filename.ToString();

			// 다운로드할 파일의 경로
			string UpDir = ConfigurationSettings.AppSettings["UpDir"];
			downpath = UpDir + "\\" + b_id + "\\" + filename;

			if (File.Exists(downpath))	// 파일이 있으면
			{
				// 헤더에 파일이름 지정하기
				Response.AddHeader("Content-Disposition", "attachment;filename=" + Server.UrlEncode(filename));
				Response.ContentType = "multipart/form-data";
				// 파일 다운로드 시키기
				Response.WriteFile(downpath);
			}
			else
				Response.Write("파일이 존재하지 않습니다.");
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
