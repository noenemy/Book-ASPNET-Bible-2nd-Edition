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
	/// schedule에 대한 요약 설명입니다.
	/// </summary>
	public class schedule : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Calendar Calendar1;
	
		string [][] arrSchedule;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// 여기에 사용자 코드를 배치하여 페이지를 초기화합니다.

			arrSchedule = new string[13][];	
			
			for (int n=0; n<13 ;n++)		
				arrSchedule[n] = new string[32];	
			
			arrSchedule[1][1] = "신정";	
			arrSchedule[1][10] = "강모 모임";	
			arrSchedule[1][20] = "친구 결혼식";	
			arrSchedule[1][26] = "동창회";	
			arrSchedule[2][13] = "졸업식";	
			arrSchedule[2][18] = "우수";	
			arrSchedule[2][28] = "원고 마감일";	
			arrSchedule[3][1] = "삼일절";	
			arrSchedule[4][2] = "혜미 생일";	
			arrSchedule[4][5] = "식목일";	
			arrSchedule[5][5] = "어린이날";	
			arrSchedule[10][3] = "개천절";	
			arrSchedule[10][20] = "noenemy 생일";	
			arrSchedule[12][25] = "크리스마스";
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
