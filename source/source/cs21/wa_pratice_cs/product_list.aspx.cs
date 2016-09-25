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

namespace wa_pratice_cs
{
	/// <summary>
	/// Summary description for product_list.
	/// </summary>
	public class product_list : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList comCategories;
		protected System.Web.UI.WebControls.DataGrid grdProducts;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!Page.IsPostBack)
			{
				// ProductService 웹 서비스 객체 생성
				localhost.ProductService ws = new localhost.ProductService();

				// GetCategories 웹 메소드 호출해서 Categories 데이터 얻기
				comCategories.DataSource = ws.GetCategories();
				comCategories.DataTextField = "CategoryName";
				comCategories.DataValueField = "CategoryID";
            
				// DropDownList 데이터바인딩
				comCategories.DataBind();

				// 초기 CategoryID 값 설정
				comCategories.SelectedIndex = 0;
				ShowProductsList(int.Parse(comCategories.SelectedItem.Value.ToString()));

			}
		}

		private void ShowProductsList(int CategoryID)
		{
			// 인자로 받은 CategoriID 값으로
			// GetProductsByCategoryID 웹 메소드 호출해서 
			// DataGrid 컨트롤 데이터 바인딩
			localhost.ProductService ws = new localhost.ProductService();
			grdProducts.DataSource = ws.GetProductsByCategoryID(CategoryID);
			grdProducts.DataBind();
		}

		private void comCategories_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// 해당 CategoryID에 해당하는 Products 리스트로 갱신
			int CategoryID = int.Parse(comCategories.SelectedItem.Value.ToString());
			ShowProductsList(CategoryID);
		
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
			this.comCategories.SelectedIndexChanged += new System.EventHandler(this.comCategories_SelectedIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

	}
}
