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

namespace list2_cs
{
	/// <summary>
	/// Summary description for datagrid_custompaging.
	/// </summary>
	public class datagrid_custompaging : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if  (!Page.IsPostBack)
			{
				// 총 레코드 개수 얻기
				SqlConnection conn = new SqlConnection("Server=(local);Database=Northwind;uid=sa;pwd=;");
				conn.Open();
				SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM customers", conn);
				int RecordCount = (int)comm.ExecuteScalar();
				conn.Close();

				// VirtualItemCount 프로퍼티 설정
				DataGrid1.VirtualItemCount = RecordCount;

				DataGridBind();
			}
		}

		private void DataGridBind()
		{
			// 현재 페이지 번호와 총 페이지 개수 구하기
			int PageNo, PageCount;
			PageNo = DataGrid1.CurrentPageIndex + 1;
			PageCount = (int)(DataGrid1.VirtualItemCount / DataGrid1.PageSize) + 1;

			Response.Write("Page : " + PageNo.ToString() + "/" + PageCount.ToString());

			// 가져올 레코드 개수
			int TopCount = PageNo * DataGrid1.PageSize;

			// 데이터 가져오기	
			string strSQL;
			strSQL = "SELECT TOP " + TopCount.ToString() + " * FROM customers";
			Response.Write(" Query : " + strSQL)	;
			SqlConnection conn = new SqlConnection("Server=(local);Database=Northwind;uid=sa;pwd=;");
			SqlDataAdapter adapter = new SqlDataAdapter(strSQL, conn);
			DataSet ds = new DataSet();

			// 화면에 출력할 레코드의 시작위치
			int StartRecord = DataGrid1.CurrentPageIndex * DataGrid1.PageSize;

			// DataSet 채우기
			adapter.Fill(ds, StartRecord, DataGrid1.PageSize, "customers");

			// DataGrid 데이터바인딩
			DataGrid1.DataSource = ds;
			DataGrid1.DataMember = "customers";
			DataGrid1.DataBind();
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
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			DataGrid1.CurrentPageIndex = e.NewPageIndex;
			DataGridBind();
		}

	}
}
