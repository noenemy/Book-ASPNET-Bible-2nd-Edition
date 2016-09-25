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
				// �� ��ũ ��Ʈ ���丮 ��� ���
				
				txtPath.Text = System.Configuration.ConfigurationSettings.AppSettings["root"];

				// ������丮 ���, ���ϸ�� ����ϱ�
				ShowDirList();
				ShowFileList();
			}
		}



		private void ShowDirList()
		{

			// ���� ���丮�� ���� ���丮 ��� ���
			int intEnd;
			string ParentDir = txtPath.Text;
			intEnd = ParentDir.LastIndexOf("\\");
			ParentDir = ParentDir.Substring(0, intEnd);

			// [���������� �̵�] ��ư�� CommandArgument ����
			btnGoParentDir.CommandArgument = ParentDir;

			// ���� ���丮�� ��Ʈ ���丮��� [���������� �̵�] ��ư�� ��Ȱ��ȭ��Ŵ
			// ��Ʈ ���丮 �̻��� ���丮�� ������ ����
			string RootPath = System.Configuration.ConfigurationSettings.AppSettings["root"];
			if (txtPath.Text == RootPath)
				btnGoParentDir.Enabled = false;
			else
				btnGoParentDir.Enabled = true;
			
			// ���� ���丮�� �������丮 ��� �����ͼ� ���ε���Ű��
			DirectoryInfo dir = new DirectoryInfo(txtPath.Text);
			lstDir.DataSource = dir.GetDirectories();
			lstDir.DataBind();
		}


		private void ShowFileList()
		{
			// ���� ���丮���� ���� ��� �����ͼ� ���ε��ϱ�
			DirectoryInfo dir = new DirectoryInfo(txtPath.Text);
			lstFile.DataSource = dir.GetFiles();
			lstFile.DataBind();
		}

		private void btnCD_Click(object sender, System.EventArgs e)
		{
			// ������ ���丮 ��� 
			string NewDir = txtPath.Text + "\\" + NewDirName.Text;
				DirectoryInfo dir = new DirectoryInfo(NewDir);

			// ���丮 �����ϱ�
			dir.Create();

			// ���丮 ��� ����ε��ϱ�
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
			
			// ÷�ε� ������ ������
			if (File1.PostedFile.ContentLength > 0)
			{

				// ���� ���丮�� ���� ���ε��ϱ�
				string Path;
				Path = txtPath.Text + "\\" + System.IO.Path.GetFileName(File1.PostedFile.FileName);
				File1.PostedFile.SaveAs(Path);

				// ���ϸ�� ����ε��ϱ�
				ShowFileList();
			}
		}

		private void lstDir_DeleteCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// ������ ���丮�� ��� ���
			string DelDir = e.CommandArgument.ToString();
			DirectoryInfo dir = new DirectoryInfo(DelDir);

			// ���丮 ����
			dir.Delete(true);

			// ���丮 ��� ����ε��ϱ�
			ShowDirList();
		}

		private void lstDir_CancelCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// ���丮 ��� DataList ��Ʈ���� Edit ��� ����
			lstDir.EditItemIndex = -1;
			ShowDirList();
		}

		private void lstDir_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// ���丮 ��Ͽ��� ���丮���� �����ϸ� �ش� ���丮�� �̵�
			if (e.CommandName == "GoDir")
			{
				txtPath.Text = e.CommandArgument.ToString();
				ShowDirList();
				ShowFileList();
			}
		}

		private void btnGoParentDir_Click(object sender, System.EventArgs e)
		{
			// [���� ���丮�� �̵�] ��ư�� Ŭ������ �� 
			// ���� ���丮�� ���� ���丮�� �̵�
			txtPath.Text = btnGoParentDir.CommandArgument;
			ShowDirList();
			ShowFileList();
		}

		
		private void lstDir_UpdateCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// ������ ���丮��
			string CurDir = e.CommandArgument.ToString();

			// �ٲ� ���丮��
			string RenameDir;
			RenameDir = txtPath.Text + "\\" + ((TextBox)(e.Item.Controls[1])).Text;

			// ���丮 �̸� �ٲٱ�
			DirectoryInfo dir = new DirectoryInfo(CurDir);
			dir.MoveTo(RenameDir);

			// Edit ��� ���� �� ���丮 ��� ����ε�
			lstDir.EditItemIndex = -1;
			ShowDirList();
		}

		private void lstDir_EditCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// ���丮�� [Rename] ��ư�� Ŭ���� ��� Edit ���� ����
			lstDir.EditItemIndex = e.Item.ItemIndex;
			ShowDirList();
		}

		private void lstFile_DeleteCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// ������ ������ ��� ���
			string DelFile = e.CommandArgument.ToString();
			FileInfo file = new FileInfo(DelFile);

			// ���� ����
			file.Delete();

			// ���ϸ�� ����ε��ϱ�
			ShowFileList();

		}


		private void lstFile_EditCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// ���ϸ�Ͽ��� [Rename] ��ư�� Ŭ���� ��� Edit ���� ��ȯ
			lstFile.EditItemIndex = e.Item.ItemIndex;
			ShowFileList();
		}

		private void lstFile_CancelCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			// ���ϸ���� Edit ��� ����
			lstFile.EditItemIndex = -1;
			ShowFileList();
		}


		private void lstFile_UpdateCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{

			// ������ ���ϸ� ���
			string CurFile = e.CommandArgument.ToString();

			// �̸��� �ٲ� ���ϸ�
			string RenameFile;
			RenameFile = txtPath.Text + "\\" + ((TextBox)(e.Item.Controls[1])).Text;

			// ���ϸ� �ٲٱ�
			FileInfo File = new FileInfo(CurFile);
			File.MoveTo(RenameFile);

			// Edit��� ���� �� ���ϸ�� ����ε��ϱ�
			lstFile.EditItemIndex = -1;
			ShowFileList();
		}


	}
}
