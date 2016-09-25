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
	/// Summary description for filelist.
	/// </summary>
	public class filelist : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtPath;
		protected System.Web.UI.WebControls.Button btnGoParentDir;
		protected System.Web.UI.WebControls.Button btnUpload;
		protected System.Web.UI.WebControls.TextBox NewDirName;
		protected System.Web.UI.WebControls.Button btnCD;
		protected System.Web.UI.WebControls.DataList lstDir;
		protected System.Web.UI.WebControls.DataList lstFile;
		protected System.Web.UI.HtmlControls.HtmlInputFile File1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			if (!Page.IsPostBack)
			{
				// 웹 디스크 루트 디렉토리 경로 얻기
				
				txtPath.Text = System.Configuration.ConfigurationSettings.AppSettings["root"];

				// 서브디렉토리 목록, 파일목록 출력하기
				ShowDirList();
				ShowFileList();
			}
		}



		private void ShowDirList()
		{

			// 현재 디렉토리의 상위 디렉토리 경로 얻기
			int intEnd;
			string ParentDir = txtPath.Text;
			intEnd = ParentDir.LastIndexOf("\\");
			ParentDir = ParentDir.Substring(0, intEnd);

			// [상위폴더로 이동] 버튼의 CommandArgument 설정
			btnGoParentDir.CommandArgument = ParentDir;

			// 현재 디렉토리가 루트 디렉토리라면 [상위폴더로 이동] 버튼을 비활성화시킴
			// 루트 디렉토리 이상의 디렉토리에 접근을 막음
			string RootPath = System.Configuration.ConfigurationSettings.AppSettings["root"];
			if (txtPath.Text == RootPath)
				btnGoParentDir.Enabled = false;
			else
				btnGoParentDir.Enabled = true;
			
			// 현재 디렉토리의 하위디렉토리 목록 가져와서 바인딩시키기
			DirectoryInfo dir = new DirectoryInfo(txtPath.Text);
			lstDir.DataSource = dir.GetDirectories();
			lstDir.DataBind();
		}


		private void ShowFileList()
		{
			// 현재 디렉토리내의 파일 목록 가져와서 바인딩하기
			DirectoryInfo dir = new DirectoryInfo(txtPath.Text);
			lstFile.DataSource = dir.GetFiles();
			lstFile.DataBind();
		}

		private void btnCD_Click(object sender, System.EventArgs e)
		{
			// 생성할 디렉토리 경로 
			string NewDir = txtPath.Text + "\\" + NewDirName.Text;
				DirectoryInfo dir = new DirectoryInfo(NewDir);

			// 디렉토리 생성하기
			dir.Create();

			// 디렉토리 목록 재바인딩하기
			ShowDirList();
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
			this.btnGoParentDir.Click += new System.EventHandler(this.btnGoParentDir_Click);
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			this.btnCD.Click += new System.EventHandler(this.btnCD_Click);
			this.lstDir.ItemCommand += new System.Web.UI.WebControls.DataListCommandEventHandler(this.lstDir_ItemCommand);
			this.lstDir.CancelCommand += new System.Web.UI.WebControls.DataListCommandEventHandler(this.lstDir_CancelCommand);
			this.lstDir.EditCommand += new System.Web.UI.WebControls.DataListCommandEventHandler(this.lstDir_EditCommand);
			this.lstDir.UpdateCommand += new System.Web.UI.WebControls.DataListCommandEventHandler(this.lstDir_UpdateCommand);
			this.lstDir.DeleteCommand += new System.Web.UI.WebControls.DataListCommandEventHandler(this.lstDir_DeleteCommand);
			this.lstFile.CancelCommand += new System.Web.UI.WebControls.DataListCommandEventHandler(this.lstFile_CancelCommand);
			this.lstFile.EditCommand += new System.Web.UI.WebControls.DataListCommandEventHandler(this.lstFile_EditCommand);
			this.lstFile.UpdateCommand += new System.Web.UI.WebControls.DataListCommandEventHandler(this.lstFile_UpdateCommand);
			this.lstFile.DeleteCommand += new System.Web.UI.WebControls.DataListCommandEventHandler(this.lstFile_DeleteCommand);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion



		private void btnUpload_Click(object sender, System.EventArgs e)
		{
			
			// 첨부된 파일이 있으면
			if (File1.PostedFile.ContentLength > 0)
			{

				// 현재 디렉토리에 파일 업로드하기
				string Path;
				Path = txtPath.Text + "\\" + System.IO.Path.GetFileName(File1.PostedFile.FileName);
				File1.PostedFile.SaveAs(Path);

				// 파일목록 재바인딩하기
				ShowFileList();
			}
		}

		private void lstDir_DeleteCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// 삭제할 디렉토리의 경로 얻기
			string DelDir = e.CommandArgument.ToString();
			DirectoryInfo dir = new DirectoryInfo(DelDir);

			// 디렉토리 삭제
			dir.Delete(true);

			// 디렉토리 목록 재바인딩하기
			ShowDirList();
		}

		private void lstDir_CancelCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// 디렉토리 목록 DataList 컨트롤의 Edit 모드 해제
			lstDir.EditItemIndex = -1;
			ShowDirList();
		}

		private void lstDir_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// 디렉토리 목록에서 디렉토리명을 선택하면 해당 디렉토리로 이동
			if (e.CommandName == "GoDir")
			{
				txtPath.Text = e.CommandArgument.ToString();
				ShowDirList();
				ShowFileList();
			}
		}

		private void btnGoParentDir_Click(object sender, System.EventArgs e)
		{
			// [상위 디렉토리로 이동] 버튼을 클릭했을 때 
			// 현재 디렉토리의 상위 디렉토리로 이동
			txtPath.Text = btnGoParentDir.CommandArgument;
			ShowDirList();
			ShowFileList();
		}

		
		private void lstDir_UpdateCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// 원래의 디렉토리명
			string CurDir = e.CommandArgument.ToString();

			// 바꿀 디렉토리명
			string RenameDir;
			RenameDir = txtPath.Text + "\\" + ((TextBox)(e.Item.Controls[1])).Text;

			// 디렉토리 이름 바꾸기
			DirectoryInfo dir = new DirectoryInfo(CurDir);
			dir.MoveTo(RenameDir);

			// Edit 모드 해제 및 디렉토리 목록 재바인딩
			lstDir.EditItemIndex = -1;
			ShowDirList();
		}

		private void lstDir_EditCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// 디렉토리의 [Rename] 버튼을 클릭한 경우 Edit 모드로 변경
			lstDir.EditItemIndex = e.Item.ItemIndex;
			ShowDirList();
		}

		private void lstFile_DeleteCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// 삭제할 파일의 경로 얻기
			string DelFile = e.CommandArgument.ToString();
			FileInfo file = new FileInfo(DelFile);

			// 파일 삭제
			file.Delete();

			// 파일목록 재바인딩하기
			ShowFileList();

		}


		private void lstFile_EditCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// 파일목록에서 [Rename] 버튼을 클릭한 경우 Edit 모드로 변환
			lstFile.EditItemIndex = e.Item.ItemIndex;
			ShowFileList();
		}

		private void lstFile_CancelCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// 파일목록의 Edit 모드 해제
			lstFile.EditItemIndex = -1;
			ShowFileList();
		}


		private void lstFile_UpdateCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{

			// 원래의 파일명 얻기
			string CurFile = e.CommandArgument.ToString();

			// 이름을 바꿀 파일명
			string RenameFile;
			RenameFile = txtPath.Text + "\\" + ((TextBox)(e.Item.Controls[1])).Text;

			// 파일명 바꾸기
			FileInfo File = new FileInfo(CurFile);
			File.MoveTo(RenameFile);

			// Edit모드 해제 및 파일목록 재바인딩하기
			lstFile.EditItemIndex = -1;
			ShowFileList();
		}


	}
}
