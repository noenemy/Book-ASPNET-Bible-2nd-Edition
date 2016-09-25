using System;
using System.Collections;
using System.ComponentModel;
using System.Web;
using System.Web.SessionState;
using System.Diagnostics;

namespace tiptech_cs 
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
		
		private string LogName = "MyLog";

		protected void Application_Start(Object sender, EventArgs e)
		{

			// 이벤트 로그 항목이 없으면 생성하기
			if (!EventLog.SourceExists(LogName))
				EventLog.CreateEventSource(LogName, LogName);
		}
 
		protected void Application_Error(Object sender, EventArgs e)
		{
			// 에러발생시 이벤트 로그에 저장하기
			string Message = "Url " + Request.Path + " Error: " + Server.GetLastError().ToString();
			EventLog Log = new EventLog();
			Log.Source = LogName;
			Log.WriteEntry(Message, EventLogEntryType.Error);
		}

		protected void Session_Start(Object sender, EventArgs e)
		{

		}

		protected void Application_BeginRequest(Object sender, EventArgs e)
		{

		}

		protected void Application_EndRequest(Object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(Object sender, EventArgs e)
		{

		}



		protected void Session_End(Object sender, EventArgs e)
		{

		}

		protected void Application_End(Object sender, EventArgs e)
		{

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

