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
	/// Summary description for write.
	/// </summary>
	public class write : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblBoardTitle;
		protected System.Web.UI.WebControls.TextBox txtName;
		protected System.Web.UI.WebControls.TextBox txtEmail;
		protected System.Web.UI.WebControls.TextBox txtSubject;
		protected System.Web.UI.WebControls.TextBox txtContent;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.Button btnWrite;
		protected System.Web.UI.HtmlControls.HtmlInputFile File1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here


			if (!Page.IsPostBack)
			{

				// 게시판 제목 출력하기
				string b_id = Request.QueryString["b_id"];
				BizBoard.nTx objnTx = new BizBoard.nTx();
				BizBoard.dsBoard dsBoardInfo = new BizBoard.dsBoard();
				dsBoardInfo = objnTx.GetBoardInfo(b_id);
				lblBoardTitle.Text = dsBoardInfo.boardmaster[0].title.ToString();
			}
		}


		private void btnWrite_Click(object sender, System.EventArgs e)
		{
			// 입력할 게시물 정보
			string filesize, b_id, subject, writer, email, filename, password, content;
			b_id = Request.QueryString["b_id"];
			writer = txtName.Text;
			email = txtEmail.Text;
			password = txtPassword.Text;
			content = txtContent.Text;
			subject = txtSubject.Text;
			filename = "";
			filesize = "";

			// 첨부된 파일이 있으면
			if (File1.PostedFile.ContentLength > 0)
			{

				string UpPath;
				string UpDir = ConfigurationSettings.AppSettings["UpDir"];
				filesize = GetFileSize(File1.PostedFile.ContentLength);
				filename = System.IO.Path.GetFileName(File1.PostedFile.FileName);

				// 업로드 경로가 없으면 디렉토리 생성
				UpDir = UpDir + "\\" + b_id;
				if (Directory.Exists(UpDir) == false)
					Directory.CreateDirectory(UpDir);		

				// 업로드할 경로
				UpPath = UpDir + "\\" + filename;

				// 파일명 중복 방지
				int i = 0;
				string filename2 = "";
				while (File.Exists(UpPath))
				{
					i = i + 1;
					filename2 = System.IO.Path.GetFileNameWithoutExtension(filename) +
						"(" + i.ToString() + ")" + Path.GetExtension(filename);
					UpPath = UpDir + "\\" + filename2;
				}

				if (filename2.Length > filename.Length)
					filename = filename2;

				// 파일 업로드하기
				File1.PostedFile.SaveAs(UpPath);

			}

			// 게시물 등록하기
			BizBoard.Root objRoot = new BizBoard.Root();
			bool result;
			result = objRoot.WriteArticle(b_id, subject, writer, email, filename, filesize, content, password);

			if (result == false)
				lblMessage.Text = "관리자만 입력할 수 있습니다.";
			else
			{

				// list.aspx로 이동
				int CurPage = int.Parse(Request.QueryString["page"]);
				string goURL = "list.aspx?b_id=" + b_id + "&page=" + CurPage.ToString() ;
				Response.Redirect(goURL);
			}
		}

		private string GetFileSize(int Size)
		{

			// 파일크기를 KByte 형식으로 변환해서 리턴
			string result;
			if (Size > 1024) //1024byte(1Kbyte)보다 크면	
				result = ((int)(Size / 1024)).ToString() + "K";
			else
				result = Size.ToString();

			return result;
	   }



		private void btnCancel_Click(object sender, System.EventArgs e)
		{
		
			// list.aspx로 이동
			int CurPage = int.Parse(Request.QueryString["page"]);
			string b_id = Request.QueryString["b_id"];
			string goURL = "list.aspx?b_id=" + b_id + "&page=" + CurPage.ToString();
			Response.Redirect(goURL);
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
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion



	}
}
