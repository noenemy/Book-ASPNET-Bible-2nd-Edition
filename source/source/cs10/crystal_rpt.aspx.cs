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

namespace richcs
{
	/// <summary>
	/// crystal_rpt�� ���� ��� �����Դϴ�.
	/// </summary>
	public class crystal_rpt : System.Web.UI.Page
	{
		protected CrystalDecisions.Web.CrystalReportViewer CrystalReportViewer1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// ���⿡ ����� �ڵ带 ��ġ�Ͽ� �������� �ʱ�ȭ�մϴ�.

			// �����ͺ��̽� ���� ����
			SqlConnection conn = new SqlConnection("Server=(local);Database=Northwind;uid=sa;pwd=;");
			SqlCommand comm = new SqlCommand("SELECT * FROM categories", conn);	
			SqlDataAdapter adapter = new SqlDataAdapter(comm);
			dsCategories ds = new dsCategories();
			
			// DataSet ä��� (report ������ ����� ���̺� �̸��� �����ؾ��Ѵ�.)
			adapter.Fill(ds, "categories");	
			// Report ��ü ����
			rptCategory rpt = new rptCategory();
			
			// ����Ʈ ����ϱ�	
			rpt.SetDataSource(ds);
			CrystalReportViewer1.ReportSource = rpt;
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �� ȣ���� ASP.NET Web Form �����̳ʿ� �ʿ��մϴ�.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
