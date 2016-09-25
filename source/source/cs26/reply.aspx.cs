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
	/// Summary description for reply.
	/// </summary>
	public class reply : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblBoardTitle;
		protected System.Web.UI.WebControls.TextBox txtName;
		protected System.Web.UI.WebControls.TextBox txtEmail;
		protected System.Web.UI.WebControls.TextBox txtSubject;
		protected System.Web.UI.WebControls.TextBox txtContent;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.Button btnReply;
		protected System.Web.UI.HtmlControls.HtmlInputHidden hid_depth;
		protected System.Web.UI.HtmlControls.HtmlInputFile File1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!Page.IsPostBack)
			{
				string b_id = Request.QueryString["b_id"];
				int c_id = int.Parse(Request.QueryString["c_id"]);
				int c_step = int.Parse(Request.QueryString["c_step"]);

				// �Խ��� ���� ���
				BizBoard.nTx objnTx = new BizBoard.nTx();
				BizBoard.dsBoard  dsBoardInfo = new BizBoard.dsBoard();
				dsBoardInfo = objnTx.GetBoardInfo(b_id);
				lblBoardTitle.Text = dsBoardInfo.boardmaster[0].title.ToString();

				// �θ���� ���� ��������
				BizBoard.dsBoard dsBoard = new BizBoard.dsBoard();
				dsBoard = objnTx.GetArticle(b_id, c_id, c_step);

				// �θ���� ���� ��Ʈ�ѿ� ���
				string Content;
				Content = "> " + dsBoard.GetArticle[0].writer.ToString() + "���� " +
					dsBoard.GetArticle[0].regdate.ToString() + "�� �ۼ��� ���Դϴ�." + "\r\n" +
					dsBoard.GetArticle[0].content.ToString().Replace("\r\n", "\r\n> ") + "\r\n\r\n";							
				txtContent.Text = Content;
				txtSubject.Text = dsBoard.GetArticle[0].subject.ToString();
				hid_depth.Value = dsBoard.GetArticle[0].c_depth.ToString();
			}

		}


		private void btnReply_Click(object sender, System.EventArgs e)
		{

			// �亯���� ����
			string filesize, b_id, subject, writer, email, filename, password, content;
			int c_id, c_step, c_depth;
			b_id = Request.QueryString["b_id"];
			c_id = int.Parse(Request.QueryString["c_id"]);
			c_step = int.Parse(Request.QueryString["c_step"]);
			c_depth = int.Parse(hid_depth.Value);
			string SearchOption = "";
			string SearchKey = "";
			if (Request.QueryString["search_option"] != null)
				SearchOption = Request.QueryString["search_option"].ToString();
			if (Request.QueryString["search_key"] != null)
				SearchKey = Server.UrlEncode(Request.QueryString["search_key"].ToString());
			writer = txtName.Text;
			email = txtEmail.Text;
			password = txtPassword.Text;
			content = txtContent.Text;
			subject = txtSubject.Text;
			filename = "";
			filesize = "";

			// ÷���� ������ ������ ���ε��ϱ�
			if (File1.PostedFile.ContentLength > 0)
			{

				string UpPath;
				string UpDir = ConfigurationSettings.AppSettings["UpDir"];
				filesize = GetFileSize(File1.PostedFile.ContentLength);
				filename = System.IO.Path.GetFileName(File1.PostedFile.FileName);

				// ���ε��� ���丮�� ������ �����
				UpDir = UpDir + "\\" + b_id;
				if (Directory.Exists(UpDir) == false)
					Directory.CreateDirectory(UpDir);

				// ���ε��� ���
				UpPath = UpDir + "\\" + filename;

				// ���ϸ� �ߺ� ����
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

				// ���� ���ε��ϱ�
				File1.PostedFile.SaveAs(UpPath);

			}

			// �Խù� �亯 ����ϱ�
			BizBoard.Root objRoot = new BizBoard.Root();
			bool result;
			result = objRoot.ReplyArticle(b_id, c_id, c_step, c_depth, subject, writer, 
								email, filename, filesize, content, password);

			if (result == false)
				lblMessage.Text = "�����ڸ� �Է��� �� �ֽ��ϴ�.";
			else
			{
				// list.aspx�� �̵�
				int CurPage = int.Parse(Request.QueryString["page"]);
				string goURL = "list.aspx?b_id=" + b_id + "&page=" + CurPage.ToString() +
							   "&search_option=" + SearchOption +
							   "&search_key=" + SearchKey;
				Response.Redirect(goURL);
			}

		}



		private string GetFileSize(int Size)
		{

			// ����ũ�⸦ KByte �������� ��ȯ�ؼ� ����
			string result;
			if (Size > 1024) //1024byte(1Kbyte)���� ũ��	
				result = ((int)(Size / 1024)).ToString() + "K";
			else
				result = Size.ToString();

			return result;
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
			this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion


	}
}
