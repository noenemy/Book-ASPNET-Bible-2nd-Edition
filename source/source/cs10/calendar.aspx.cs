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
	/// calendar에 대한 요약 설명입니다.
	/// </summary>
	public class calendar : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList comSelectionMode;
		protected System.Web.UI.WebControls.Calendar Calendar1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 여기에 사용자 코드를 배치하여 페이지를 초기화합니다.
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
			this.comSelectionMode.SelectedIndexChanged += new System.EventHandler(this.comSelectionMode_SelectedIndexChanged);
			this.Calendar1.SelectionChanged += new System.EventHandler(this.Calendar1_SelectionChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void comSelectionMode_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Calendar 컨트롤의 SelectionMode 설정
			Calendar1.SelectionMode =(System.Web.UI.WebControls.CalendarSelectionMode)comSelectionMode.SelectedIndex;
		}

		private void Calendar1_SelectionChanged(object sender, System.EventArgs e)
		{
				if (Calendar1.SelectedDates.Count > 0) 	// 선택된 날이 있으면	
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
