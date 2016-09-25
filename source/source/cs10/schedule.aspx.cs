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
	/// schedule�� ���� ��� �����Դϴ�.
	/// </summary>
	public class schedule : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Calendar Calendar1;
	
		string [][] arrSchedule;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// ���⿡ ����� �ڵ带 ��ġ�Ͽ� �������� �ʱ�ȭ�մϴ�.

			arrSchedule = new string[13][];	
			
			for (int n=0; n<13 ;n++)		
				arrSchedule[n] = new string[32];	
			
			arrSchedule[1][1] = "����";	
			arrSchedule[1][10] = "���� ����";	
			arrSchedule[1][20] = "ģ�� ��ȥ��";	
			arrSchedule[1][26] = "��âȸ";	
			arrSchedule[2][13] = "������";	
			arrSchedule[2][18] = "���";	
			arrSchedule[2][28] = "���� ������";	
			arrSchedule[3][1] = "������";	
			arrSchedule[4][2] = "���� ����";	
			arrSchedule[4][5] = "�ĸ���";	
			arrSchedule[5][5] = "��̳�";	
			arrSchedule[10][3] = "��õ��";	
			arrSchedule[10][20] = "noenemy ����";	
			arrSchedule[12][25] = "ũ��������";
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
			this.Calendar1.DayRender += new System.Web.UI.WebControls.DayRenderEventHandler(this.Calendar1_DayRender);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Calendar1_DayRender(object sender, System.Web.UI.WebControls.DayRenderEventArgs e)
		{
			CalendarDay d;
			TableCell c;
			d = e.Day;
			c = e.Cell;
			
			if (d.IsOtherMonth)	
				c.Controls.Clear();
			else	
			{		
				string Memo = arrSchedule[d.Date.Month][d.Date.Day];
				if (Memo != "")		
					c.Controls.Add(new LiteralControl("<br>" + Memo));
			}
		}
	}
}
