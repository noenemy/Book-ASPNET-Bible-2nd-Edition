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

namespace intrinsic_cs1
{
	/// <summary>
	/// Summary description for table.
	/// </summary>
	public class table : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Table Table1;
		protected System.Web.UI.WebControls.Button Button1;
	
		public table()
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
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			// TableRow, TableCell 객체 생성
			TableRow Row = new TableRow();
			TableCell Cell1 = new TableCell();
			TableCell Cell2 = new TableCell();
			TableCell Cell3 = new TableCell();

			// TableCell 컬렉션을 TableRow 객체에 추가하기	
			Cell1.Text = "홍길동";
			Row.Cells.Add(Cell1);
			Cell2.Text = "hongkildong@dotnetxpert.com";
			Row.Cells.Add(Cell2);
			Cell3.Text = "065-101-1100";
			Row.Cells.Add(Cell3);

			// TableRow 컬렉션을 Table 객체에 추가하기
			Table1.Rows.Add(Row);
		}
	}
}
