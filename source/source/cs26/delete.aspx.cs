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
using System.Configuration;
using System.IO;


namespace board_cs
{
	/// <summary>
	/// Summary description for delete.
	/// </summary>
	public class delete : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblBoardTitle;
		protected System.Web.UI.WebControls.Label lblId;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.Button btnDelete;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here


			if (!Page.IsPostBack)
			{

				// 삭제할 게시물 정보 얻기
				string b_id = Request.QueryString["b_id"];
				int c_id = int.Parse(Request.QueryString["c_id"]);
				int c_step = int.Parse(Request.QueryString["c_step"]);
				lblId.Text = "<b>" + c_id.ToString() + "-" + c_step.ToString() + "</b>";

				// 게시판 제목 출력
				BizBoard.nTx objnTx = new BizBoard.nTx();
				BizBoard.dsBoard dsBoardInfo = new BizBoard.dsBoard();
				dsBoardInfo = objnTx.GetBoardInfo(b_id);
				lblBoardTitle.Text = dsBoardInfo.boardmaster[0].title.ToString();

			}
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
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			string filename, b_id, password;
			int c_id, c_step;
			b_id = Request.QueryString["b_id"];
			c_id = int.Parse(Request.QueryString["c_id"]);
			c_step = int.Parse(Request.QueryString["c_step"]);
			string SearchOption = "";
			string SearchKey = "";
			if (Request.QueryString["search_option"] != null)
				SearchOption = Request.QueryString["search_option"].ToString();
			if (Request.QueryString["search_key"] != null)
				SearchKey = Server.UrlEncode(Request.QueryString["search_key"].ToString());
			password = txtPassword.Text;

			// 기존에 첨부된 파일 정보 얻기
			BizBoard.nTx objnTx = new BizBoard.nTx();
			BizBoard.dsBoard dsArticle = objnTx.GetArticle(b_id, c_id, c_step);
			filename = dsArticle.GetArticle[0].filename.ToString();

			// 게시물 삭제하기
			BizBoard.Root objRoot = new BizBoard.Root();
			bool result;
			result = objRoot.DeleteArticle(b_id, c_id, c_step, password);

			if (result == false)
				lblMessage.Text = "비밀번호가 일치하지 않습니다.";
			else
			{

				// 첨부된 파일이 있었으면 파일 삭제
				if (filename.Length > 0)
				{
					string DelPath;
					DelPath = ConfigurationSettings.AppSettings["UpDir"] + "\\" + b_id + "\\" + filename;
					File.Delete(DelPath);
				}

				// list.aspx로 이동
				int CurPage  = int.Parse(Request.QueryString["page"]);
				string goURL = "list.aspx?b_id=" + b_id + "&page=" + CurPage.ToString() +
							   "&search_option=" + SearchOption + "&search_key=" + SearchKey;
				Response.Redirect(goURL);
			}
	
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			// list.aspx로 이동
			int CurPage = int.Parse(Request.QueryString["page"]);
			string b_id = Request.QueryString["b_id"];
			string goURL = "list.aspx?b_id=" + b_id + "&page=" + CurPage.ToString();
			Response.Redirect(goURL);
		}
	}
}
