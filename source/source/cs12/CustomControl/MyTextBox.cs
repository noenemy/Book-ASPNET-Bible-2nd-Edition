using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControl
{
	/// <summary>
	/// Summary description for MyTextBox.
	/// </summary>
	public class MyTextBox : WebControl, IPostBackDataHandler
	{
		// <input> 태그로 렌더링 되도록 지정
		public MyTextBox() : base("input") 
		{
			
			//
			// TODO: Add constructor logic here
			//
		}


		// Text 프로퍼티
//		private string m_Text;
//		public string Text
//		{
//			get
//			{
//				return m_Text;
//			}
//			set
//			{
//				m_Text = value;
//			}
//		}

		public string Text
		{
			get
			{
				if (ViewState["Text"] == null )
					return "";
				else
					return ViewState["Text"].ToString(); 
			}
			set
			{
				ViewState["Text"] = value;
			}
		}

		public event EventHandler TextChanged; // 이벤트 객체 생성

		protected override void AddAttributesToRender(System.Web.UI.HtmlTextWriter writer)
		{
			base.AddAttributesToRender(writer);
			// 렌더링할 때 Name, Type, Value 속성 추가하기
			writer.AddAttribute(HtmlTextWriterAttribute.Name, UniqueID);
			writer.AddAttribute(HtmlTextWriterAttribute.Type, "input");
			writer.AddAttribute(HtmlTextWriterAttribute.Value, Text);
		}

		bool IPostBackDataHandler.LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection)
		{
			bool EventFlag = false;
			if (Text != postCollection[postDataKey])
				  EventFlag = true;
			Text = postCollection[postDataKey]; // POST 데이터 가져오기
			return EventFlag; // 값이 변경되었으면 true 리턴

		}

		void IPostBackDataHandler.RaisePostDataChangedEvent()
		{
			TextChanged(this, EventArgs.Empty); // 이벤트 발생시키기
		}
	}
}
