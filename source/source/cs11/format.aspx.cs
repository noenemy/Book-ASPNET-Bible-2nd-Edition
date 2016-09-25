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

namespace databinding_cs
{
	/// <summary>
	/// Summary description for format.
	/// </summary>
	public class format : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataList DataList1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected databinding_cs.dsOrders dsOrders1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!Page.IsPostBack)
			{
				sqlDataAdapter1.Fill(dsOrders1);
				DataList1.DataBind();
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
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.dsOrders1 = new databinding_cs.dsOrders();
			((System.ComponentModel.ISupportInitialize)(this.dsOrders1)).BeginInit();
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Orders", new System.Data.Common.DataColumnMapping[] {
																																																				new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
																																																				new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
																																																				new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
																																																				new System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"),
																																																				new System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"),
																																																				new System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"),
																																																				new System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"),
																																																				new System.Data.Common.DataColumnMapping("Freight", "Freight"),
																																																				new System.Data.Common.DataColumnMapping("ShipName", "ShipName"),
																																																				new System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"),
																																																				new System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"),
																																																				new System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"),
																																																				new System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"),
																																																				new System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, Shi" +
				"pVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, Ship" +
				"Country FROM Orders";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO Orders(CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry) VALUES (@CustomerID, @EmployeeID, @OrderDate, @RequiredDate, @ShippedDate, @ShipVia, @Freight, @ShipName, @ShipAddress, @ShipCity, @ShipRegion, @ShipPostalCode, @ShipCountry); SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders WHERE (OrderID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE Orders SET CustomerID = @CustomerID, EmployeeID = @EmployeeID, OrderDate =" +
				" @OrderDate, RequiredDate = @RequiredDate, ShippedDate = @ShippedDate, ShipVia =" +
				" @ShipVia, Freight = @Freight, ShipName = @ShipName, ShipAddress = @ShipAddress," +
				" ShipCity = @ShipCity, ShipRegion = @ShipRegion, ShipPostalCode = @ShipPostalCod" +
				"e, ShipCountry = @ShipCountry WHERE (OrderID = @Original_OrderID) AND (CustomerI" +
				"D = @Original_CustomerID OR @Original_CustomerID IS NULL AND CustomerID IS NULL)" +
				" AND (EmployeeID = @Original_EmployeeID OR @Original_EmployeeID IS NULL AND Empl" +
				"oyeeID IS NULL) AND (Freight = @Original_Freight OR @Original_Freight IS NULL AN" +
				"D Freight IS NULL) AND (OrderDate = @Original_OrderDate OR @Original_OrderDate I" +
				"S NULL AND OrderDate IS NULL) AND (RequiredDate = @Original_RequiredDate OR @Ori" +
				"ginal_RequiredDate IS NULL AND RequiredDate IS NULL) AND (ShipAddress = @Origina" +
				"l_ShipAddress OR @Original_ShipAddress IS NULL AND ShipAddress IS NULL) AND (Shi" +
				"pCity = @Original_ShipCity OR @Original_ShipCity IS NULL AND ShipCity IS NULL) A" +
				"ND (ShipCountry = @Original_ShipCountry OR @Original_ShipCountry IS NULL AND Shi" +
				"pCountry IS NULL) AND (ShipName = @Original_ShipName OR @Original_ShipName IS NU" +
				"LL AND ShipName IS NULL) AND (ShipPostalCode = @Original_ShipPostalCode OR @Orig" +
				"inal_ShipPostalCode IS NULL AND ShipPostalCode IS NULL) AND (ShipRegion = @Origi" +
				"nal_ShipRegion OR @Original_ShipRegion IS NULL AND ShipRegion IS NULL) AND (Ship" +
				"Via = @Original_ShipVia OR @Original_ShipVia IS NULL AND ShipVia IS NULL) AND (S" +
				"hippedDate = @Original_ShippedDate OR @Original_ShippedDate IS NULL AND ShippedD" +
				"ate IS NULL); SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, S" +
				"hippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipP" +
				"ostalCode, ShipCountry FROM Orders WHERE (OrderID = @OrderID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Freight", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM Orders WHERE (OrderID = @Original_OrderID) AND (CustomerID = @Original_CustomerID OR @Original_CustomerID IS NULL AND CustomerID IS NULL) AND (EmployeeID = @Original_EmployeeID OR @Original_EmployeeID IS NULL AND EmployeeID IS NULL) AND (Freight = @Original_Freight OR @Original_Freight IS NULL AND Freight IS NULL) AND (OrderDate = @Original_OrderDate OR @Original_OrderDate IS NULL AND OrderDate IS NULL) AND (RequiredDate = @Original_RequiredDate OR @Original_RequiredDate IS NULL AND RequiredDate IS NULL) AND (ShipAddress = @Original_ShipAddress OR @Original_ShipAddress IS NULL AND ShipAddress IS NULL) AND (ShipCity = @Original_ShipCity OR @Original_ShipCity IS NULL AND ShipCity IS NULL) AND (ShipCountry = @Original_ShipCountry OR @Original_ShipCountry IS NULL AND ShipCountry IS NULL) AND (ShipName = @Original_ShipName OR @Original_ShipName IS NULL AND ShipName IS NULL) AND (ShipPostalCode = @Original_ShipPostalCode OR @Original_ShipPostalCode IS NULL AND ShipPostalCode IS NULL) AND (ShipRegion = @Original_ShipRegion OR @Original_ShipRegion IS NULL AND ShipRegion IS NULL) AND (ShipVia = @Original_ShipVia OR @Original_ShipVia IS NULL AND ShipVia IS NULL) AND (ShippedDate = @Original_ShippedDate OR @Original_ShippedDate IS NULL AND ShippedDate IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Freight", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null));
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "data source=NENOTE;initial catalog=Northwind;password=\"\";persist security info=Tr" +
				"ue;user id=sa;workstation id=NENOTE;packet size=4096";
			// 
			// dsOrders1
			// 
			this.dsOrders1.DataSetName = "dsOrders";
			this.dsOrders1.Locale = new System.Globalization.CultureInfo("ko-KR");
			this.dsOrders1.Namespace = "http://www.tempuri.org/dsOrders.xsd";
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsOrders1)).EndInit();

		}
		#endregion
	}
}
