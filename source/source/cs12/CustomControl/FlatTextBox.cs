using System;
using System.Web.UI.WebControls;

namespace CustomControl
{
	/// <summary>
	/// Summary description for FlatTextBox.
	/// </summary>
	public class FlatTextBox : TextBox
	{
		public FlatTextBox() // 생성자
		{
			// TextBox 스타일 설정하기
			this.Style["border"] = "solid 1px black";
			this.Font.Name = "verdana";
			this.ForeColor = System.Drawing.Color.Navy;
			this.Font.Size = FontUnit.XSmall;
			this.BackColor = System.Drawing.Color.DeepPink;
		}
	}
}
