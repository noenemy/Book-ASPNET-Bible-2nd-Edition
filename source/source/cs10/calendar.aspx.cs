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

namespace richcs
{
	/// <summary>
	/// calendar�� ���� ��� �����Դϴ�.
	/// </summary>
	public class calendar : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList comSelectionMode;
		protected System.Web.UI.WebControls.Calendar Calendar1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// ���⿡ ����� �ڵ带 ��ġ�Ͽ� �������� �ʱ�ȭ�մϴ�.
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �� ȣ���� ASP.NET Web Form �����̳ʿ� �ʿ��մϴ�.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{    
			this.comSelectionMode.SelectedIndexChanged += new System.EventHandler(this.comSelectionMode_SelectedIndexChanged);
			this.Calendar1.SelectionChanged += new System.EventHandler(this.Calendar1_SelectionChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void comSelectionMode_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Calendar ��Ʈ���� SelectionMode ����
			Calendar1.SelectionMode =(System.Web.UI.WebControls.CalendarSelectionMode)comSelectionMode.SelectedIndex;
		}

		private void Calendar1_SelectionChanged(object sender, System.EventArgs e)
		{
				if (Calendar1.SelectedDates.Count > 0) 	// ���õ� ���� ������	
				{		
					foreach (DateTime Day in Calendar1.SelectedDates)
					{			
						Response.Write(Day.ToShortDateString() + "<br>");
					}	
					Response.Write ("<hr");
				}
		}
	}
}
