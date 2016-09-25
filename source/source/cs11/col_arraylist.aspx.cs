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
	/// Summary description for col_arraylist.
	/// </summary>
	public class col_arraylist : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList comArray;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here


	        if (!Page.IsPostBack)
			{

			    // ArrayList ������ ����
				ArrayList arr = new ArrayList();
				arr.Add("�հ浿");
				arr.Add("�ѵ���");
				arr.Add("������");
				arr.Add("������");

				// Dropdownlist ��Ʈ�� �����͹��ε�
				comArray.DataSource = arr;
				comArray.DataBind();

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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
