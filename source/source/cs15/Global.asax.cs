using System;
using System.Collections;
using System.ComponentModel;
using System.Web;
using System.Web.SessionState;

namespace WebApp_cs 
{
	/// <summary>
	/// Summary description for Global.
	/// </summary>
	public class Global : System.Web.HttpApplication
	{
		public Global()
		{
			InitializeComponent();
		}	
		
		protected void Application_Start(Object sender, EventArgs e)
		{
			// 카운터를 위한 Application 변수 초기화
			Application["TotalCount"] = 0;   // 총 접속자수  
			Application["NowCount"] = 0;     // 현재 접속자수
		}
 
		protected void Session_Start(Object sender, EventArgs e)
		{
			// 카운터 증가시키기
			Application.Lock();
			Application["TotalCount"] = (int)Application["TotalCount"] + 1;
			Application["NowCount"] = (int)Application["NowCount"] + 1;
			Application.UnLock();
		}


		protected void Application_Error(Object sender, EventArgs e)
		{

		}

		protected void Session_End(Object sender, EventArgs e)
		{
			// 현재 접속자수 - 1
			Application.Lock();
			Application["NowCount"] = (int)Application["NowCount"] - 1;
			Application.UnLock();
		}

		protected void Application_End(Object sender, EventArgs e)
		{

		}

		protected void Application_BeginRequest(Object sender, EventArgs e) 
		{
			Response.Write("Application_BeginRequest<br>"); 
		}

		protected void Application_EndRequest(Object sender, EventArgs e) 
		{
			Response.Write("Application_EndRequest<br>");
		}

		protected void Application_AuthenticateRequest(Object sender, EventArgs e) 
		{
			Response.Write("Application_AuthenticateRequest<br>");
		}

		protected void Application_AuthoriseRequest(Object sender, EventArgs e) 
		{
			Response.Write("Application_AuthoriseRequest<br>");
		}

		protected void Application_ResolveRequestCache(Object sender, EventArgs e) 
		{
			Response.Write("Application_ResolveRequestCache<br>");
		}

		protected void Application_AcquireRequestState(Object sender, EventArgs e) 
		{
			Response.Write("Application_AcquireRequestState<br>");
		}

		protected void Application_PreRequestHandlerExecute(Object sender, EventArgs e) 
		{
			Response.Write("Application_PreRequestHandlerExecute<br>");
		}

		protected void Application_PostRequestHandlerExecute(Object sender, EventArgs e) 
		{
			Response.Write("Application_PostRequestHandlerExecute<br>");
		}

		protected void Application_ReleaseRequestState(Object sender, EventArgs e) 
		{
			Response.Write("Application_ReleaseRequestState<br>");
		}

		protected void Application_UpdateRequestCache(Object sender, EventArgs e) 
		{
			Response.Write("Application_UpdateRequestCache<br>");
		}
			
		#region Web Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
		}
		#endregion
	}
}

