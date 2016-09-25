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
	/// control_event�� ���� ��� �����Դϴ�.
	/// </summary>
	public class control_event : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.CheckBox CheckBox1;
		protected System.Web.UI.WebControls.CheckBox CheckBox2;
	
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
			this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
			this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void TextBox1_TextChanged(object sender, System.EventArgs e)
		{
			Response.Write("TextBox1��Ʈ�� : TextChanged �̺�Ʈ �߻�<br>");
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			Response.Write("Button1��Ʈ�� : Click �̺�Ʈ �߻�<br>");
		}

		private void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			Response.Write("CheckBox1��Ʈ�� : CheckedChanged �̺�Ʈ �߻�<br>");
		}

		private void CheckBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			Response.Write("CheckBox2��Ʈ�� : CheckedChanged �̺�Ʈ �߻�<br>");
		}
	}
}
