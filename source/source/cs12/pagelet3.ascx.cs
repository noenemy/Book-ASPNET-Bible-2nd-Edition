namespace control_cs
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.Data.SqlClient;

	/// <summary>
	///		Summary description for pagelet3.
	/// </summary>
	public abstract class pagelet3 : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!Page.IsPostBack)
			{
				ShowCustomers();
			}
		}

		public void ShowCustomers()
		{
			// Region 표시
			Label1.Text = _Region;

			// 해당 Region에 속하는 고객정보 가져오기
			SqlConnection conn = new SqlConnection("Server=(local);Database=Northwind;uid=sa;pwd=;");
			conn.Open();
			SqlCommand comm = new SqlCommand("SELECT * FROM customers WHERE region=@region", conn);
			comm.Parameters.Add(new SqlParameter("@region", _Region));
			SqlDataReader reader = comm.ExecuteReader();

			// DataGrid 컨트롤에 DataReader 객체 바인딩
			DataGrid1.DataSource = reader;
			DataGrid1.DataBind();
			reader.Close();
			conn.Close();
		}

		private string _Region = "";

		public string Region
		{
			get
			{
				return _Region;
			}
			set
			{
				_Region = value;
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
		
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
