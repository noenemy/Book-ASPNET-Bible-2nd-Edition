using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControl
{
	/// <summary>
	/// Summary description for TitleTextBox.
	/// </summary>
	public class TitleTextBox : Control, INamingContainer
	{
		public TitleTextBox()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		
		// Text 프로퍼티
		private string m_Text;
		public string Text
		{
			get
			{
				return m_Text;
			}
			set
			{
				m_Text = value;
			}
		}


		// Title 프로퍼티
		private string m_Title;
		public string Title
		{
			get
			{
				return m_Title;
			}
			set
			{
				m_Title = value;
			}
		}

		protected override void CreateChildControls()
		{
			// Label 컨트롤 추가하기
			Label Label1 = new Label();
			Label1.Width = Unit.Pixel(100);
			Label1.Text = m_Title;
			Controls.Add(Label1);

			// FlatTextBox 컨트롤 추가하기
			FlatTextBox FlatTextBox1 = new FlatTextBox();
			FlatTextBox1.Text = m_Text;
			Controls.Add(FlatTextBox1);

		}

	}
}
