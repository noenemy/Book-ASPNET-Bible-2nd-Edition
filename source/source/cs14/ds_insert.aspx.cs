using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace adonet_cs
{
	/// <summary>
	/// Summary description for ds_insert.
	/// </summary>
	public class ds_insert : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtID;
		protected System.Web.UI.WebControls.TextBox txtDesc;
		protected System.Web.UI.WebControls.Button btnInsert;
	
		public ds_insert()
		{
			Page.Init += new System.EventHandler(Page_Init);
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
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
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnInsert_Click(object sender, System.EventArgs e)
		{
			// Connection ��ü �����ؼ� ����
			SqlConnection conn = new SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;");        
	
			// Command ��ü�� Parameter ��ü ����
			SqlCommand cmdSelect = new SqlCommand("SELECT * FROM region",conn);
			SqlCommand cmdInsert = new SqlCommand("INSERT INTO region(regionid,regiondescription) VALUES(@id,@desc)",conn);
			cmdInsert.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, "regionid"));
			cmdInsert.Parameters.Add(new SqlParameter("@desc", SqlDbType.Char, 50, "regiondescription"));

			// DataAdapter ��ü ���� �� Command ����    
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmdSelect;
			adapter.InsertCommand = cmdInsert;

			// Untyped DataSet ��ü �����ϰ� ������ ä���
			DataSet dataset = new DataSet();
			adapter.Fill(dataset, "region");        

			// DataTable�� DataRow �߰��ϱ�
			DataTable table = dataset.Tables["region"];
			DataRow row = table.NewRow();
	        row["regionid"] = txtID.Text.ToString();
			row["regiondescription"] = txtDesc.Text.ToString();
			table.Rows.Add(row);

			// ����� DataSet���� Update�ϱ�
			Response.Write("DataAdpater�� Update ��ɼ���<hr>");
			adapter.Update(dataset, "region");
		}
	}
}
