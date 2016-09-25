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

namespace configuration_cs
{
	/// <summary>
	/// Summary description for use_appsetting.
	/// </summary>
	public class use_appsetting : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!Page.IsPostBack)
			{
				// �����ͺ��̽� ���� ���ڿ� ��������
				string strDSN = System.Configuration.ConfigurationSettings.AppSettings["DSN"];
				Response.Write(strDSN);

				// Connection, Command, DataReader ��ü ����
				SqlConnection conn = new SqlConnection(strDSN);
				conn.Open();
				SqlCommand comm = new SqlCommand("SELECT * FROM categories", conn);
				SqlDataReader ds;

				// ������ ��������
				ds = comm.ExecuteReader();

				// DataGrid �����͹��ε�
				DataGrid1.DataSource = ds;
				DataGrid1.DataBind();

				// DataReader, Connection ��ü �ݱ�
				ds.Close();
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
