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
	/// Summary description for list.
	/// </summary>
	public class ListForm : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblBoardTitle;
		protected System.Web.UI.WebControls.Label lblStatus;
		protected System.Web.UI.WebControls.DataList DataList1;
		protected System.Web.UI.WebControls.Label lblPager;
		protected System.Web.UI.WebControls.HyperLink lnkWrite;
		protected System.Web.UI.WebControls.HyperLink lnkPrev;
		protected System.Web.UI.WebControls.HyperLink lnkNext;
		protected System.Web.UI.WebControls.DropDownList comSearchOption;
		protected System.Web.UI.HtmlControls.HtmlInputHidden hidBId;
		protected System.Web.UI.HtmlControls.HtmlInputText txtSearchKey;
		protected System.Web.UI.HtmlControls.HtmlInputButton btnFind;
		protected System.Web.UI.HtmlControls.HtmlInputButton btnSearchCancel;

		public int CurPage, PageSize;		
		public string b_id;
		public string SearchOption = "";
		public string SearchKey = "";
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			
			// 현재 페이지값 얻기 or 초기화
			if (Request.QueryString["page"] == null)
				CurPage = 1;
			else
				CurPage = int.Parse(Request.QueryString["page"]);

			// 게시판 Id 얻기 or 초기화
			if (Request.QueryString["b_id"] == null)
				b_id = "test";
			else
				b_id = Request.QueryString["b_id"].ToString();

			// Hidden 컨트롤에 게시판 ID(b_id) 값 셋팅
			hidBId.Value = b_id;

			// 검색 조건 얻기
			if (Request.QueryString["search_option"] != null)
			{
				SearchOption = Request.QueryString["search_option"].ToString();
				switch (SearchOption)
				{
					case "subject":
						comSearchOption.SelectedIndex = 0;
						break;
					case "content":
						comSearchOption.SelectedIndex = 1;
						break;
					case "writer":
						comSearchOption.SelectedIndex = 2;
						break;
				}
			}
			else
				comSearchOption.SelectedIndex = 0; // 제목

			btnSearchCancel.Disabled = true; // 검색취소 버튼 비활성화
			if (Request.QueryString["search_key"] != null)
			{
				SearchKey = Request.QueryString["search_key"].ToString();
				if (SearchKey != "")
					btnSearchCancel.Disabled = false;	// 검색취소버튼 활성화
			}

			txtSearchKey.Value = SearchKey;

			// 게시판 목록 보여주기
			ShowBoardList();
		}


		private void ShowBoardList()
		{

			// 게시물 수 얻기
			BizBoard.nTx objnTx = new BizBoard.nTx();
			int RecordCount = objnTx.GetBoardRecordCount(b_id, SearchOption, SearchKey);

			// 게시판 정보 얻기 - pagesize, title
			BizBoard.dsBoard dsBoardInfo = objnTx.GetBoardInfo(b_id);
			PageSize = int.Parse(dsBoardInfo.boardmaster[0].pagesize.ToString());
			lblBoardTitle.Text = dsBoardInfo.boardmaster[0].title.ToString();

			// 총 페이지 수 개산
			int PageCount;
			PageCount = (int)((RecordCount - 1) / PageSize) + 1;

			// CurPage, PageCount, RecordCount 표시
			lblStatus.Text = "Page [" + CurPage.ToString() + "/" + 
				PageCount.ToString() + "] Total : " + RecordCount.ToString();

			// 게시물 목록 출력하기
			DataList1.DataSource = objnTx.GetBoardList(b_id, SearchOption, SearchKey, PageSize, CurPage);
			DataList1.DataMember = "boardlist";
			DataList1.DataBind();

			// 페이지 네비게이션 출력하기
			ShowPager(RecordCount, CurPage, PageCount, PageSize);
		}


		private void ShowPager(int RecordCount, int CurPage, int PageCount, int PageSize)
		{

			// 링크 문자열
			string Path = Request.ServerVariables["PATH_INFO"].ToString() + "?b_id" + b_id + 
						  "&search_option=" + SearchOption +
						  "&search_key=" + SearchKey + "&page=";

				// FromPage - 페이지 네비게이션의 시작 페이지번호
				// CurPage - 페이지 네비게이션의 마지막 페이지번호
				int FromPage, ToPage;
			FromPage = (int)((CurPage - 1) / 10) * 10 + 1;
			if (PageCount > FromPage + 9)
				ToPage = FromPage + 9;
			else
				ToPage = PageCount;

			string Pager = "";
			int i;

			// 이전 10개 표시
			if ((int)((CurPage - 1) / 10) > 0)
				Pager = Pager + "<a href='" + Path + (FromPage - 1).ToString() + "'>{prev}</a>...";

			// 페이지 네비게이션 표시
			for (i = FromPage; i<=ToPage; i++)
			{
				if (i == CurPage)
					Pager += "<b>[" + i.ToString() + "]</b>";
				else
					Pager = Pager + "<a href='" + Path + i.ToString() + "'>" +
						"[" + i.ToString() + "]</a>";
			}

			// 다음 10개 표시
			if (ToPage < PageCount)
				Pager = Pager + "...<a href='" + Path + (ToPage + 1).ToString() + "'>{next>}</a>";


			// 페이지 네비게이션 출력하기
			lblPager.Text = Pager;

			// Prev, Next 버튼의 링크 구성하기 
			if (CurPage > 1)
				lnkPrev.NavigateUrl = Path + (CurPage - 1).ToString();

			if (CurPage < ToPage)
				lnkNext.NavigateUrl = Path + (CurPage + 1).ToString();

			lnkWrite.NavigateUrl = "write.aspx?b_id="+ b_id + "&page=" + CurPage.ToString();
		}


		public string ShowDepth(int c_depth)
		{

			// 답변글일 경우 reply 이미지를 출력하고
			// 답변 레벨에 따라 글 제목을 밀어넣기
			if (c_depth == 0)
				return "";
			else
			{
				int i;
				string strDepth = "";
				for (i = 0; i < c_depth; i ++)
				{
					strDepth = strDepth + "&nbsp;&nbsp;";
				}
				return strDepth + "<img src='images/re.gif' border=0> ";

			}
		}


		public string ShowNumber(int c_id, int c_step)
		{

			// 게시물의 번호 출력 - c_id
			if (c_step > 1)
				return "";
			else
				return c_id.ToString();
		}


		public string ShowFileImage(string filename)
		{

			// 첨부된 파일의 종류에 따라 이미지를 출력한다

			string ext = "";
			ext = System.IO.Path.GetExtension(filename).Replace(".","");

			string fileicon = "";
			if (ext.Length > 0)
			{
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
			}
			else
				fileicon = "txt.gif";

			// 이미지 파일의 경로 리턴
			return "images/pds/" + fileicon;
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
			this.ID = "ListForm";
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
