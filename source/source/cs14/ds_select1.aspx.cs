using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace adonet_cs
{
	/// <summary>
	/// Summary description for ds_select1.
	/// </summary>
	public class ds_select1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.Button btnBind;
	
		public ds_select1()
		{
			Page.Init += new System.EventHandler(Page_Init);
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		private void Page_Init(object sender, EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
		}

		#region Web Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnBind.Click += new System.EventHandler(this.btnBind_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnBind_Click(object sender, System.EventArgs e)
		{
			// Connection ��ü �����ϱ�
			SqlConnection conn = new SqlConnection("server=(local);database=Northwind;uid=sa;pwd=");
			
			// Command ��ü ����
			string strSQL = "SELECT * FROM categories";
			SqlCommand comm = new SqlCommand(strSQL,conn);

			// DataAdapter ��ü �����ϱ�
			SqlDataAdapter adapter = new SqlDataAdapter(comm);

			// Untyped DataSet ��ü �����ϰ� ������ ä���
			DataSet dataset = new DataSet();
			adapter.Fill(dataset);

			// DataSet�� �̿��ؼ� DataGrid ��Ʈ�� ���ε�
			DataGrid1.DataSource = dataset;
			DataGrid1.DataBind();
		}
	}
}
