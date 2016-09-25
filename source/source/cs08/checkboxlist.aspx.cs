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

namespace list1_cs
{
	/// <summary>
	/// Summary description for checkboxlist.
	/// </summary>
	public class checkboxlist : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.CheckBoxList chkCategories;
		protected System.Web.UI.WebControls.Button btnOK;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected list1_cs.dsCategories dsCategories1;
	
		public checkboxlist()
		{
			Page.Init += new System.EventHandler(Page_Init);
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!Page.IsPostBack)
			{
				// 데이터셋 채운뒤 Checkboxlist 컨트롤 데이터바인딩
				sqlDataAdapter1.Fill(dsCategories1);
				chkCategories.DataBind();
			}
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
			this.dsCategories1 = new list1_cs.dsCategories();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			((System.ComponentModel.ISupportInitialize)(this.dsCategories1)).BeginInit();
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// dsCategories1
			// 
			this.dsCategories1.DataSetName = "dsCategories";
			this.dsCategories1.Locale = new System.Globalization.CultureInfo("ko-KR");
			this.dsCategories1.Namespace = "http://www.tempuri.org/dsCategories.xsd";
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Categories", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
																																																					new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT CategoryID, CategoryName FROM Categories";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO Categories(CategoryName) VALUES (@CategoryName); SELECT CategoryID, C" +
				"ategoryName FROM Categories WHERE (CategoryID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryName", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE Categories SET CategoryName = @CategoryName WHERE (CategoryID = @Original_" +
				"CategoryID) AND (CategoryName = @Original_CategoryName); SELECT CategoryID, Cate" +
				"goryName FROM Categories WHERE (CategoryID = @Select_CategoryID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryName", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Select_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Current, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM Categories WHERE (CategoryID = @CategoryID) AND (CategoryName = @Cate" +
				"goryName)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, null));
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "data source=(local);initial catalog=Northwind;persist security info=False;user id" +
				"=sa;packet size=4096";
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsCategories1)).EndInit();

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{

			// 사용자가 체크한 값이 있으면
			if (chkCategories.SelectedIndex > -1)
			{
				// 아이템 개수만큼 반복
				foreach (ListItem Item in chkCategories.Items)
				{
					// 현재 아이템이 체크되었으면 출력
					if (Item.Selected == true)
						Response.Write(Item.Text + ",");
				}
				Response.Write("<hr>");
			}
		}
	}
}
