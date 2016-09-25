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
	///		Summary description for menu.
	/// </summary>
	public abstract class menu : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.DataList DataList1;

		// Region ������Ƽ
		private string m_RegionName;
		public string RegionName
		{
			get
			{
				return m_RegionName;
			}
			set
			{
				m_RegionName = value;
			}
		}

		public event EventHandler SelectionChanged;


		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!Page.IsPostBack)
			{
				// customers ���̺��� region ���� ��������
				SqlConnection conn = new SqlConnection("Server=(local);database=Northwind;uid=sa;pwd=");
				conn.Open();
				SqlCommand comm = new SqlCommand("SELECT DISTINCT region FROM customers", conn);
				// DataReader�� ������ �����ϱ�
				SqlDataReader reader;
				reader = comm.ExecuteReader();
				// DataList ��Ʈ�� ���ε��ϱ�
				DataList1.DataSource = reader;
				DataList1.DataBind();
				// DataReader, Connection ��ü �ݱ�
				reader.Close();
				conn.Close();
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
			this.DataList1.SelectedIndexChanged += new System.EventHandler(this.DataList1_SelectedIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void DataList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// RegionName ������Ƽ ����
			RegionName = ((LinkButton)DataList1.SelectedItem.FindControl("LinkButton1")).Text;
			// SelectionChanged �̺�Ʈ �߻�
			SelectionChanged(this, null);
		}
	}
}
