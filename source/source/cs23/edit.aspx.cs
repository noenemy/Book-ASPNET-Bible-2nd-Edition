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
	/// Summary description for edit.
	/// </summary>
	public class edit : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtName;
		protected System.Web.UI.WebControls.TextBox txtEmail;
		protected System.Web.UI.WebControls.TextBox txtContent;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.Button btnUpdate;
		protected System.Web.UI.WebControls.Button btnCancel;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!Page.IsPostBack)
			{

				// Id, CurPage �� ViewState�� ����
				int Id = int.Parse(Request.QueryString["id"].ToString());
				int CurPage = int.Parse(Request.QueryString["page"].ToString());

				ViewState["Id"] = Id;
				ViewState["CurPage"] = CurPage;

				// ���� �Խù��� ���� ��������
				SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["DSN"]);
				SqlCommand comm = new SqlCommand("SELECT * FROM guestbook WHERE id=@Id", conn);
				comm.Parameters.Add(new SqlParameter("@Id", Id));
				conn.Open();

				// ��Ʈ�ѿ� �Խù� ���� ���
				SqlDataReader dr = comm.ExecuteReader();
				if (dr.Read() == true)
				{
					txtName.Text = dr["writer"].ToString();
					txtEmail.Text = dr["email"].ToString();
					txtContent.Text = dr["content"].ToString();
				}
				else
					Response.Write("�߸��� ��û�Դϴ�. �����Ͱ� �����ϴ�.");

				dr.Close();
				conn.Close();
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
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private bool IsPasswordCorrect()
		{

			// ��й�ȣ�� �´��� Ȯ���ؼ� True/False�� ����

			int Id = int.Parse(ViewState["Id"].ToString());
			SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["DSN"]);
			SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM guestbook WHERE id=@Id AND password=@Password", conn);
			comm.Parameters.Add(new SqlParameter("@Id", Id));
			comm.Parameters.Add(new SqlParameter("@Password", txtPassword.Text));
			conn.Open();
			
			bool Result;
			if ((int)comm.ExecuteScalar() > 0)
				Result = true;
			else
				Result = false;
			conn.Close();

			return Result;
		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			// ��й�ȣ�� �´��� Ȯ��
			if (IsPasswordCorrect() == true)
			{
				int Id  = int.Parse(ViewState["Id"].ToString());
				int CurPage = int.Parse(ViewState["CurPage"].ToString());

				// SQL ������ �ۼ�
				string strSQL;
				strSQL = "UPDATE guestbook SET writer=@Writer, email=@Email, content=@Content " +
					"WHERE id=@Id";

				// ADO.NET ��ü ����
				SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["DSN"]);
				SqlCommand comm = new SqlCommand(strSQL, conn);

				// �Ķ���� ����
				comm.Parameters.Add(new SqlParameter("@Id", Id));
				comm.Parameters.Add(new SqlParameter("@Writer", txtName.Text));
				comm.Parameters.Add(new SqlParameter("@Email", txtEmail.Text));
				comm.Parameters.Add(new SqlParameter("@content", txtContent.Text));

				// Update ����
				conn.Open();
				comm.ExecuteNonQuery();
				conn.Close();

				// list.aspx�� �̵�
				string goURL = "list.aspx?page=" + CurPage.ToString();
				Response.Redirect(goURL);
			}
			else
			{
				// ��й�ȣ�� Ʋ�� ��� �޽��� ���
				Response.Write("��й�ȣ�� ��ġ���� �ʽ��ϴ�.<hr>");
			}

		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			// list.aspx�� �̵�
			int CurPage = int.Parse(ViewState["CurPage"].ToString());
			string goURL = "list.aspx?page=" + CurPage.ToString();
			Response.Redirect(goURL);
		}
	}
}
