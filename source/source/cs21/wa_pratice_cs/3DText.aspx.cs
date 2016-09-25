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

namespace wa_pratice_cs
{
	/// <summary>
	/// Summary description for _3DText.
	/// </summary>
	public class Form1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList comFonts;
		protected System.Web.UI.WebControls.DropDownList comTypes;
		protected System.Web.UI.WebControls.DropDownList comTemplates;
		protected System.Web.UI.WebControls.TextBox txtText;
		protected System.Web.UI.WebControls.Button btnGenerate;
		protected System.Web.UI.WebControls.Image img3D;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here


			if (!Page.IsPostBack)
			{

				// �� ���� ��ü ����
				com.xara.ws.RenderServer3D ws = new com.xara.ws.RenderServer3D();

				// ����ü, �̹�������, ���ø� ������ ���
				comFonts.DataSource = ws.GetFonts();
				comTypes.DataSource = ws.GetExportTypes();
				comTemplates.DataSource = ws.GetTemplates();

				// ������ ���ε�
				Page.DataBind();
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			this.ID = "Form1";
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnGenerate_Click(object sender, System.EventArgs e)
		{

			// ���� ����
			string  Template, Text, TextColor, BGColor, Font, FontSize, ExportType;
			long Width, Height;
			string ImageURL;

			// �̹��� ������ ���� ������ ����
			Template = comTemplates.SelectedItem.Text;
			Text = txtText.Text;
			Font = comFonts.SelectedItem.Text;
			ExportType = comTypes.SelectedItem.Text;
			TextColor = "";  // �⺻�� ���
			BGColor = "";    // �⺻�� ���
			FontSize = "";   // �⺻�� ���

			// ������ ��ü ���� 
			com.xara.ws.RenderServer3D ws = new com.xara.ws.RenderServer3D();

			// RenderURL �� �޼ҵ� ȣ�� �� �̹��� URL ���
			ImageURL = ws.RenderURL(Template, Text, TextColor, BGColor, Font, FontSize, ExportType, out Width, out Height);

			// ������ �̹��� �������� ǥ���ϱ� 
			img3D.ImageUrl = ImageURL;
		}
	}
}
