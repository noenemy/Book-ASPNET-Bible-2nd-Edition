using System;
using System.Web.UI;

namespace CustomControl
{
	/// <summary>
	/// Summary description for HelloCustom.
	/// </summary>
	public class HelloCustom : Control
	{
		public HelloCustom() 
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

		protected override void Render(System.Web.UI.HtmlTextWriter writer)
		{
			writer.Write(m_Text);
		}
	}


}
