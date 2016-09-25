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

namespace list2_cs
{
	/// <summary>
	/// datalist에 대한 요약 설명입니다.
	/// </summary>
	public class datalist : System.Web.UI.Page
	{
		protected list2_cs.dsProduct dsProduct1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Web.UI.WebControls.DataList DataList1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 여기에 사용자 코드를 배치하여 페이지를 초기화합니다.
			if (!Page.IsPostBack)
			{
				sqlDataAdapter1.Fill(dsProduct1);
				DataList1.DataBind();
			}
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
			this.dsProduct1 = new list2_cs.dsProduct();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			((System.ComponentModel.ISupportInitialize)(this.dsProduct1)).BeginInit();
			// 
			// dsProduct1
			// 
			this.dsProduct1.DataSetName = "dsProduct";
			this.dsProduct1.Locale = new System.Globalization.CultureInfo("ko-KR");
			this.dsProduct1.Namespace = "http://www.tempuri.org/dsProduct.xsd";
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "product", new System.Data.Common.DataColumnMapping[] {
																																																				 new System.Data.Common.DataColumnMapping("Id", "Id"),
																																																				 new System.Data.Common.DataColumnMapping("product_name", "product_name"),
																																																				 new System.Data.Common.DataColumnMapping("vender", "vender"),
																																																				 new System.Data.Common.DataColumnMapping("description", "description"),
																																																				 new System.Data.Common.DataColumnMapping("spec", "spec"),
																																																				 new System.Data.Common.DataColumnMapping("price", "price"),
																																																				 new System.Data.Common.DataColumnMapping("image", "image")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT Id, product_name, vender, description, spec, price, image FROM product";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO product(Id, product_name, vender, description, spec, price, image) VA" +
				"LUES (@Id, @product_name, @vender, @description, @spec, @price, @image); SELECT " +
				"Id, product_name, vender, description, spec, price, image FROM product WHERE (Id" +
				" = @Id)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@product_name", System.Data.SqlDbType.VarChar, 100, "product_name"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@vender", System.Data.SqlDbType.VarChar, 50, "vender"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@description", System.Data.SqlDbType.VarChar, 500, "description"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@spec", System.Data.SqlDbType.VarChar, 200, "spec"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, "price"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@image", System.Data.SqlDbType.VarChar, 50, "image"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE product SET Id = @Id, product_name = @product_name, vender = @vender, description = @description, spec = @spec, price = @price, image = @image WHERE (Id = @Original_Id) AND (description = @Original_description OR @Original_description IS NULL AND description IS NULL) AND (image = @Original_image OR @Original_image IS NULL AND image IS NULL) AND (price = @Original_price) AND (product_name = @Original_product_name) AND (spec = @Original_spec OR @Original_spec IS NULL AND spec IS NULL) AND (vender = @Original_vender); SELECT Id, product_name, vender, description, spec, price, image FROM product WHERE (Id = @Id)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@product_name", System.Data.SqlDbType.VarChar, 100, "product_name"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@vender", System.Data.SqlDbType.VarChar, 50, "vender"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@description", System.Data.SqlDbType.VarChar, 500, "description"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@spec", System.Data.SqlDbType.VarChar, 200, "spec"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, "price"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@image", System.Data.SqlDbType.VarChar, 50, "image"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_description", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "description", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_image", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "image", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "price", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_product_name", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "product_name", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_spec", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "spec", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_vender", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "vender", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM product WHERE (Id = @Original_Id) AND (description = @Original_description OR @Original_description IS NULL AND description IS NULL) AND (image = @Original_image OR @Original_image IS NULL AND image IS NULL) AND (price = @Original_price) AND (product_name = @Original_product_name) AND (spec = @Original_spec OR @Original_spec IS NULL AND spec IS NULL) AND (vender = @Original_vender)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_description", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "description", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_image", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "image", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "price", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_product_name", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "product_name", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_spec", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "spec", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_vender", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "vender", System.Data.DataRowVersion.Original, null));
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "data source=(local);initial catalog=pdashop;password=\"\";persist security info=True" +
				";user id=sa;packet size=4096";
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsProduct1)).EndInit();

		}
		#endregion
	}
}
