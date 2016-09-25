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
		// <input> �±׷� ������ �ǵ��� ����
		public MyTextBox() : base("input") 
		{
			
			//
			// TODO: Add constructor logic here
			//
		}


		// Text ������Ƽ
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

		public event EventHandler TextChanged; // �̺�Ʈ ��ü ����

		protected override void AddAttributesToRender(System.Web.UI.HtmlTextWriter writer)
		{
			base.AddAttributesToRender(writer);
			// �������� �� Name, Type, Value �Ӽ� �߰��ϱ�
			writer.AddAttribute(HtmlTextWriterAttribute.Name, UniqueID);
			writer.AddAttribute(HtmlTextWriterAttribute.Type, "input");
			writer.AddAttribute(HtmlTextWriterAttribute.Value, Text);
		}

		bool IPostBackDataHandler.LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection)
		{
			bool EventFlag = false;
			if (Text != postCollection[postDataKey])
				  EventFlag = true;
			Text = postCollection[postDataKey]; // POST ������ ��������
			return EventFlag; // ���� ����Ǿ����� true ����

		}

		void IPostBackDataHandler.RaisePostDataChangedEvent()
		{
			TextChanged(this, EventArgs.Empty); // �̺�Ʈ �߻���Ű��
		}
	}
}
