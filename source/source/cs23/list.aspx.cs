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
using System.Data.SqlClient;
using System.Configuration;

namespace guestbook_cs
{
	/// <summary>
	/// Summary description for list.
	/// </summary>
	public class list : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblTitle;
		protected System.Web.UI.WebControls.DataList lstGuestbook;
		protected System.Web.UI.WebControls.Label lblPager;
		protected System.Web.UI.WebControls.HyperLink lnkWrite;
		protected System.Web.UI.WebControls.HyperLink lnkPrev;
		protected System.Web.UI.WebControls.HyperLink lnkNext;
	
		public int CurPage; // 현재 페이지번호

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			// 현재 페이지값 얻기 or 초기화
			if (Request.QueryString["page"] == null)
				CurPage = 1;
			else
				CurPage = int.Parse(Request.QueryString["page"]);
			
			// 방명록 보여주기
			ShowGuestbookList();
		}

		private int GetRecordCount()
		{

			// 방명록의 총 레코드 수를 리턴한다.
			SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["DSN"]);
			SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM guestbook", conn);
			int RecordCount;

			conn.Open();
			RecordCount = (int)(comm.ExecuteScalar());
			conn.Close();

			return RecordCount;
		}


		private void ShowGuestbookList()
		{

			// RecordCount - 총 게시물수
			// PageSize - 한 페이지에 보여줄 게시물 수
			// PageCount - 총 페이지수
			int RecordCount = GetRecordCount();
			int PageSize = int.Parse(ConfigurationSettings.AppSettings["PageSize"]);
			int PageCount, TopCount;
			PageCount = (int)((RecordCount - 1) / PageSize) + 1;

			// CurPage, PageCount, RecordCount 표시
			lblTitle.Text = "Page [" + CurPage.ToString() + "/" + PageCount.ToString() + 
				"] Total : " + RecordCount.ToString();

			// 가져올 게시물 수
			TopCount = CurPage * PageSize;

			// 쿼리문 구성
			string strSQL;
			strSQL = "SELECT TOP " + TopCount.ToString() + " * FROM guestbook ORDER BY id DESC";

				// 방명록 게시물 가져오기
				SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["DSN"]);
			SqlCommand comm = new SqlCommand(strSQL, conn);
			conn.Open();
			SqlDataReader dr = comm.ExecuteReader();

			// 페이지번호에 맞게 레코드 위치 이동
			for (int i=0; i< (CurPage -1)*PageSize;i++)
			{
				dr.Read();
			}

			// DataList 컨트롤 데이터바인딩
			lstGuestbook.DataSource = dr;
			lstGuestbook.DataBind();

			// ADO.NET 객체 닫기
			dr.Close();
			conn.Close();

			// 페이지 네비게이션 출력하기
			ShowPager(RecordCount, CurPage, PageCount, PageSize);
		}

		public string DisplayContent(string Content)
		{

			// 본문 내용중에 행바꿈문자를 <br> 태그로 변환
			Content = Content.Replace("\r\n", "<br>");
			return Content;
		}
    
		private void ShowPager(int RecordCount, int CurPage, int PageCount, int PageSize)
		{

			// 링크 문자열
			string Path = Request.ServerVariables["PATH_INFO"] + "?page=";

			// FromPage - 페이지 네비게이션의 시작 페이지번호
			// CurPage - 페이지 네비게이션의 마지막 페이지번호
			int FromPage, ToPage;
			FromPage = (int)((CurPage - 1) / 10) * 10 + 1;
			if (PageCount > FromPage + 9)
				ToPage = FromPage + 9;
			else
				ToPage = PageCount;

			string Pager;

			Pager = "<font size=2>";

			// 이전 10개 표시
			if ((int)((CurPage - 1) / 10) > 0)
				Pager = Pager + "<a href='" + Path + (FromPage - 1).ToString() + "'>{prev}</a>...";

			// 페이지 네비게이션 표시
			for (int i=FromPage;i<=ToPage;i++)
			{
				if (i == CurPage)
					Pager += "<b>[" + i.ToString() + "]</b>";
				else
					Pager = Pager + "<a href='" + Path + i.ToString() + "'>" +
						"[" + i.ToString() + "]</a> ";
					}


			// 다음 10개 표시
			if (ToPage < PageCount)
				Pager = Pager + "...<a href='" + Path + (ToPage + 1).ToString() + "'>{next>}</a>";

			Pager = Pager + "</font>";

			// 페이지 네비게이션 출력하기
			lblPager.Text = Pager;

			// Prev, Next 버튼의 링크 구성하기 
			if (CurPage > 1)
				lnkPrev.NavigateUrl = Path + (CurPage - 1).ToString();

			if (CurPage < ToPage)
				lnkNext.NavigateUrl = Path + (CurPage + 1).ToString();
			
			lnkWrite.NavigateUrl = "write.aspx?page=" + CurPage.ToString();

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
