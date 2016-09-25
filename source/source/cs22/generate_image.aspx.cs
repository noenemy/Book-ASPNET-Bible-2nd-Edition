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
using System.Drawing.Imaging;

namespace tiptech_cs
{
	/// <summary>
	/// Summary description for generate_image.
	/// </summary>
	public class generate_image : System.Web.UI.Page
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
        
			// GDI+ 객체 초기화
			Bitmap objBitmap = new System.Drawing.Bitmap(Server.MapPath("snowman.jpg"));
			Graphics objGraphic = Graphics.FromImage(objBitmap);

			SolidBrush objBrush = new SolidBrush(Color.Navy);

			// 이미지에 문자열 그리기
			string strMessage = "여러분 새해에는 모두 부~~자 되세요.";
			objGraphic.DrawString(strMessage, new Font("dotum", 12, FontStyle.Bold), objBrush, 90, 290);

			strMessage = DateTime.Now.ToShortDateString() + " by Noenemy";
			objGraphic.DrawString(strMessage, new Font("gulim", 8, FontStyle.Italic), objBrush, 250, 310);

			// 메모리 이미지를 스트림으로 전송
			Response.ContentType = "image/jpeg";
			objBitmap.Save(Response.OutputStream, ImageFormat.Jpeg);

        	objGraphic.Dispose();
			objBitmap.Dispose();

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
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion
	}
}
