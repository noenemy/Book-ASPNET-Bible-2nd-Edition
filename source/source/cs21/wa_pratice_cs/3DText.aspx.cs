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

				// 웹 서비스 객체 생성
				com.xara.ws.RenderServer3D ws = new com.xara.ws.RenderServer3D();

				// 글자체, 이미지형식, 템플릿 데이터 얻기
				comFonts.DataSource = ws.GetFonts();
				comTypes.DataSource = ws.GetExportTypes();
				comTemplates.DataSource = ws.GetTemplates();

				// 데이터 바인딩
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

			// 변수 선언
			string  Template, Text, TextColor, BGColor, Font, FontSize, ExportType;
			long Width, Height;
			string ImageURL;

			// 이미지 생성을 위한 변수값 설정
			Template = comTemplates.SelectedItem.Text;
			Text = txtText.Text;
			Font = comFonts.SelectedItem.Text;
			ExportType = comTypes.SelectedItem.Text;
			TextColor = "";  // 기본값 사용
			BGColor = "";    // 기본값 사용
			FontSize = "";   // 기본값 사용

			// 웹서비스 객체 생성 
			com.xara.ws.RenderServer3D ws = new com.xara.ws.RenderServer3D();

			// RenderURL 웹 메소드 호출 및 이미지 URL 얻기
			ImageURL = ws.RenderURL(Template, Text, TextColor, BGColor, Font, FontSize, ExportType, out Width, out Height);

			// 생성된 이미지 페이지에 표시하기 
			img3D.ImageUrl = ImageURL;
		}
	}
}
