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

namespace webform_cs
{
	/// <summary>
	/// control_event에 대한 요약 설명입니다.
	/// </summary>
	public class control_event : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.CheckBox CheckBox1;
		protected System.Web.UI.WebControls.CheckBox CheckBox2;
	
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
			this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
			this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void TextBox1_TextChanged(object sender, System.EventArgs e)
		{
			Response.Write("TextBox1컨트롤 : TextChanged 이벤트 발생<br>");
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			Response.Write("Button1컨트롤 : Click 이벤트 발생<br>");
		}

		private void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			Response.Write("CheckBox1컨트롤 : CheckedChanged 이벤트 발생<br>");
		}

		private void CheckBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			Response.Write("CheckBox2컨트롤 : CheckedChanged 이벤트 발생<br>");
		}
	}
}
