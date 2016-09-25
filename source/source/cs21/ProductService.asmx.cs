using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace ws_practice_cs
{
	/// <summary>
	/// Summary description for ProductService.
	/// </summary>
	public class ProductService : System.Web.Services.WebService
	{
		public ProductService()
		{
			//CODEGEN: This call is required by the ASP.NET Web Services Designer
			InitializeComponent();
		}

		#region Component Designer generated code
		
		//Required by the Web Services Designer 
		private IContainer components = null;
				
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		
		#endregion

		// WEB SERVICE EXAMPLE
		// The HelloWorld() example service returns the string Hello World
		// To build, uncomment the following lines then save and build the project
		// To test this web service, press F5

//		[WebMethod]
//		public string HelloWorld()
//		{
//			return "Hello World";
//		}

		// ------------------------------------------------------------
		// GetConnectionString - DB 연결문자열을 리턴하는 함수
		// return type : String
		// ------------------------------------------------------------
		private string GetConnectionString()
		{
			return "server=(local);database=Northwind;uid=sa;pwd=;";
		}

		// ------------------------------------------------------------
		// GetCategories - Categories 테이블의 레코드를 리턴하는 함수
		// return type : dsCategories
		// ------------------------------------------------------------
		[WebMethod(Description="Northwind의 Categories 테이블의 모든 레코드를 리턴합니다.")]
		public dsCategories GetCategories()
		{
			SqlConnection conn = new SqlConnection(GetConnectionString());
			SqlCommand comm = new SqlCommand("SELECT * FROM categories", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(comm);
			dsCategories ds = new dsCategories();
			adapter.Fill(ds,"categories");
			return ds;							
		}

		// ------------------------------------------------------------
		// GetCategories - CategoryID에 해당하는
		//                 Products 테이블의 레코드를 리턴하는 함수
		// parameters : CategoryID(integer)
		// return type : dsProducts
		// ------------------------------------------------------------
		[WebMethod]
		public dsProducts GetProductsByCategoryID(int CategoryID)
		{
			SqlConnection conn = new SqlConnection(GetConnectionString());
			SqlCommand comm = new SqlCommand("SELECT * FROM products WHERE categoryid=@CategoryID", conn);
			comm.Parameters.Add(new SqlParameter("@CategoryID", CategoryID));
			SqlDataAdapter adapter = new SqlDataAdapter(comm);
			dsProducts ds = new dsProducts();
			adapter.Fill(ds, "products");
			return ds;
		}

	}
}
