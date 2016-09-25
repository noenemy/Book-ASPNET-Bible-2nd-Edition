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

namespace board_cs
{
	/// <summary>
	/// Summary description for show.
	/// </summary>
	public class show : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblBoardTitle;
		protected System.Web.UI.WebControls.HyperLink lnkWriter;
		protected System.Web.UI.WebControls.Label lblRegDate;
		protected System.Web.UI.WebControls.Label lblSubject;
		protected System.Web.UI.WebControls.Label lblContent;
		protected System.Web.UI.WebControls.Label lblFile;
		protected System.Web.UI.WebControls.HyperLink lnkReply;
		protected System.Web.UI.WebControls.HyperLink lnkList;
		protected System.Web.UI.WebControls.HyperLink lnkEdit;
		protected System.Web.UI.WebControls.HyperLink lnkDelete;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			if (!Page.IsPostBack)
			{

				int CurPage = int.Parse(Request.QueryString["page"]);
				string b_id = Request.QueryString["b_id"];
				int c_id = int.Parse(Request.QueryString["c_id"]);
				int c_step = int.Parse(Request.QueryString["c_step"]);
				string SearchOption = "";
				string SearchKey = "";
				if (Request.QueryString["search_option"] != null)
					SearchOption = Request.QueryString["search_option"].ToString();
				if (Request.QueryString["search_key"] != null)
					SearchKey = Server.UrlEncode(Request.QueryString["search_key"].ToString());

				// 게시물 조회수 증가
				BizBoard.Root objRoot = new BizBoard.Root();
				objRoot.IncreaseReadCount(b_id, c_id, c_step);

				// 게시판 제목 출력
				BizBoard.nTx objnTx = new BizBoard.nTx();
				BizBoard.dsBoard dsBoardInfo = new BizBoard.dsBoard();
				dsBoardInfo = objnTx.GetBoardInfo(b_id);
				lblBoardTitle.Text = dsBoardInfo.boardmaster[0].title.ToString();

				// 게시물 가져오기
				BizBoard.dsBoard dsBoard = new BizBoard.dsBoard();
				dsBoard = objnTx.GetArticle(b_id, c_id, c_step);

				// 게시물 내용 출력하기
				lnkWriter.Text = dsBoard.GetArticle[0].writer.ToString();
				lnkWriter.NavigateUrl = "mailto:" + dsBoard.GetArticle[0].email.ToString();
				lblRegDate.Text = dsBoard.GetArticle[0].regdate.ToString();
				lblSubject.Text = dsBoard.GetArticle[0].subject.ToString();
				lblContent.Text = DisplayContent(dsBoard.GetArticle[0].content.ToString());

				// 첨부된 파일의 정보 출력하기
				lblFile.Text = ShowAttachedFileInfo(dsBoard.GetArticle[0].filename.ToString(), dsBoard.GetArticle[0].filesize.ToString());

				// 링크버튼의 하이퍼링크 설정
				lnkReply.NavigateUrl = "reply.aspx?b_id=" + b_id + "&page=" + CurPage.ToString() +
										"&c_id=" + c_id.ToString() + "&c_step=" + c_step.ToString() +
										"&search_option=" + SearchOption + "&search_key=" + SearchKey;
				lnkList.NavigateUrl = "list.aspx?b_id=" + b_id + "&page=" + CurPage.ToString() +
										"&search_option=" + SearchOption + "&search_key=" + SearchKey;
				lnkEdit.NavigateUrl = "edit.aspx?b_id=" + b_id + "&page=" + CurPage.ToString() +
										"&c_id=" + c_id.ToString() + "&c_step=" + c_step.ToString() +
										"&search_option=" + SearchOption + "&search_key=" + SearchKey;
				lnkDelete.NavigateUrl = "delete.aspx?b_id=" + b_id + "&page=" + CurPage.ToString() +
										"&c_id=" + c_id.ToString() + "&c_step=" + c_step.ToString() +
										"&search_option=" + SearchOption + "&search_key=" + SearchKey;

				}
		}

		public string ShowAttachedFileInfo(string filename, string filesize)
		{

			string b_id = Request.QueryString["b_id"];
			int c_id = int.Parse(Request.QueryString["c_id"]);
			int c_step = int.Parse(Request.QueryString["c_step"]);

			// 첨부파일에 대한 정보 및 링크 구성해서 리턴
			string FileLink;
			if (filename.Length > 0)
			{
				FileLink = "<b>첨부파일</b> : " +
					"<img src='" + GetFileImagePath(filename) + "' border=0 align=absmiddle> ";
			}
			else
				return "";
			
			FileLink = FileLink + "<a href='download.aspx?b_id=" + b_id +
					"&c_id=" + c_id.ToString() + "&c_step=" + c_step.ToString() + "'>" +
					filename + " (" + filesize + "bytes)</a>" +
					"&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br>";
			return FileLink;
		}


		
		public string GetFileImagePath(string filename)
		{

			// 첨부된 파일의 종류에 따라 이미지를 출력한다

			string ext = "";
			ext = System.IO.Path.GetExtension(filename).Replace(".","");

			string fileicon = "";
			string [] cases = new string[] { "HWP","COM","EXE","TXT","WAV","XLS",
												"DOC","ZIP","RAR","GIF","BMP","MP3","RA","HTM","JPG","MPG"};
					
			for (int i =0; i<12; i++)
			{
				if (ext == cases[i])
				{
					fileicon = cases[i] + ".gif";
					break;
				}						
			}

			if (fileicon == "")
				fileicon = "etc.gif";


			// 이미지 파일의 경로 리턴
			return "images/pds/" + fileicon;
		}




		public string DisplayContent(string Content)
		{

			// 본문 내용중에 행바꿈문자를 <br> 태그로 변환
			Content = Content.Replace("\r\n","<br>");
			return Content;
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
