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
	
		public int CurPage; // ���� ��������ȣ

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			// ���� �������� ��� or �ʱ�ȭ
			if (Request.QueryString["page"] == null)
				CurPage = 1;
			else
				CurPage = int.Parse(Request.QueryString["page"]);
			
			// ���� �����ֱ�
			ShowGuestbookList();
		}

		private int GetRecordCount()
		{

			// ������ �� ���ڵ� ���� �����Ѵ�.
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

			// RecordCount - �� �Խù���
			// PageSize - �� �������� ������ �Խù� ��
			// PageCount - �� ��������
			int RecordCount = GetRecordCount();
			int PageSize = int.Parse(ConfigurationSettings.AppSettings["PageSize"]);
			int PageCount, TopCount;
			PageCount = (int)((RecordCount - 1) / PageSize) + 1;

			// CurPage, PageCount, RecordCount ǥ��
			lblTitle.Text = "Page [" + CurPage.ToString() + "/" + PageCount.ToString() + 
				"] Total : " + RecordCount.ToString();

			// ������ �Խù� ��
			TopCount = CurPage * PageSize;

			// ������ ����
			string strSQL;
			strSQL = "SELECT TOP " + TopCount.ToString() + " * FROM guestbook ORDER BY id DESC";

				// ���� �Խù� ��������
				SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["DSN"]);
			SqlCommand comm = new SqlCommand(strSQL, conn);
			conn.Open();
			SqlDataReader dr = comm.ExecuteReader();

			// ��������ȣ�� �°� ���ڵ� ��ġ �̵�
			for (int i=0; i< (CurPage -1)*PageSize;i++)
			{
				dr.Read();
			}

			// DataList ��Ʈ�� �����͹��ε�
			lstGuestbook.DataSource = dr;
			lstGuestbook.DataBind();

			// ADO.NET ��ü �ݱ�
			dr.Close();
			conn.Close();

			// ������ �׺���̼� ����ϱ�
			ShowPager(RecordCount, CurPage, PageCount, PageSize);
		}

		public string DisplayContent(string Content)
		{

			// ���� �����߿� ��ٲ޹��ڸ� <br> �±׷� ��ȯ
			Content = Content.Replace("\r\n", "<br>");
			return Content;
		}
    
		private void ShowPager(int RecordCount, int CurPage, int PageCount, int PageSize)
		{

			// ��ũ ���ڿ�
			string Path = Request.ServerVariables["PATH_INFO"] + "?page=";

			// FromPage - ������ �׺���̼��� ���� ��������ȣ
			// CurPage - ������ �׺���̼��� ������ ��������ȣ
			int FromPage, ToPage;
			FromPage = (int)((CurPage - 1) / 10) * 10 + 1;
			if (PageCount > FromPage + 9)
				ToPage = FromPage + 9;
			else
				ToPage = PageCount;

			string Pager;

			Pager = "<font size=2>";

			// ���� 10�� ǥ��
			if ((int)((CurPage - 1) / 10) > 0)
				Pager = Pager + "<a href='" + Path + (FromPage - 1).ToString() + "'>{prev}</a>...";

			// ������ �׺���̼� ǥ��
			for (int i=FromPage;i<=ToPage;i++)
			{
				if (i == CurPage)
					Pager += "<b>[" + i.ToString() + "]</b>";
				else
					Pager = Pager + "<a href='" + Path + i.ToString() + "'>" +
						"[" + i.ToString() + "]</a> ";
					}


			// ���� 10�� ǥ��
			if (ToPage < PageCount)
				Pager = Pager + "...<a href='" + Path + (ToPage + 1).ToString() + "'>{next>}</a>";

			Pager = Pager + "</font>";

			// ������ �׺���̼� ����ϱ�
			lblPager.Text = Pager;

			// Prev, Next ��ư�� ��ũ �����ϱ� 
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
