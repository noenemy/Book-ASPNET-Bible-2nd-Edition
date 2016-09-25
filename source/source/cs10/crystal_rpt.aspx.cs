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
	/// crystal_rpt에 대한 요약 설명입니다.
	/// </summary>
	public class crystal_rpt : System.Web.UI.Page
	{
		protected CrystalDecisions.Web.CrystalReportViewer CrystalReportViewer1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 여기에 사용자 코드를 배치하여 페이지를 초기화합니다.

			// 데이터베이스 연결 설정
			SqlConnection conn = new SqlConnection("Server=(local);Database=Northwind;uid=sa;pwd=;");
			SqlCommand comm = new SqlCommand("SELECT * FROM categories", conn);	
			SqlDataAdapter adapter = new SqlDataAdapter(comm);
			dsCategories ds = new dsCategories();
			
			// DataSet 채우기 (report 생성시 사용한 테이블 이름을 지정해야한다.)
			adapter.Fill(ds, "categories");	
			// Report 객체 생성
			rptCategory rpt = new rptCategory();
			
			// 리포트 출력하기	
			rpt.SetDataSource(ds);
			CrystalReportViewer1.ReportSource = rpt;
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 이 호출은 ASP.NET Web Form 디자이너에 필요합니다.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
