using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;

namespace ws_practice_cs
{
	/// <summary>
	/// Summary description for UseSession.
	/// </summary>
	public class UseSession : System.Web.Services.WebService
	{
		public UseSession()
		{
			//CODEGEN: This call is required by the ASP.NET Web Services Designer
			InitializeComponent();
		}

		#region Component Designer generated code
		
		//Required by the Web Services Designer 
		private IContainer components = null;
				
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		
		#endregion

		// WEB SERVICE EXAMPLE
		// The HelloWorld() example service returns the string Hello World
		// To build, uncomment the following lines then save and build the project
		// To test this web service, press F5

//		[WebMethod]
//		public string HelloWorld()
//		{
//			return "Hello World";
//		}

		// ------------------------------------------------------------
		// GetCategories - 호출할 때마다 세션 카운트를 더해서 리턴한다.
		// return type : Integer
		// ------------------------------------------------------------
		[WebMethod(EnableSession=true)]
		public int GetSessionState()
		{
			if (Session["Count"] == null) 
				Session["Count"] = 0;
			
			Session["Count"] = (int)Session["Count"] + 1;

			return (int)Session["Count"];

		}
	}
}
