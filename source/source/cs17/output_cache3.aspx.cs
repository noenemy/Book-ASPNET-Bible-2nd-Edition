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

namespace statemanage_cs
{
	/// <summary>
	/// Summary description for output_cache3.
	/// </summary>
	public class output_cache3 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			// ADO.NET ��ü ����
			SqlConnection conn = new SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;");
			SqlCommand comm = new SqlCommand("SELECT * FROM customers", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(comm);
			DataSet ds = new DataSet();

			// ������ ��������
			adapter.Fill(ds, "customers");

			// DataGrid ��Ʈ�� ������ ���ε�
			DataGrid1.DataSource = ds;
			DataGrid1.DataMember = "customers";
			DataGrid1.DataBind();

			// ĳ�ÿ� ����� �ð� ���
			Label1.Text = "�������� ĳ�ÿ� ����� �ð� : " + DateTime.Now.ToString();
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