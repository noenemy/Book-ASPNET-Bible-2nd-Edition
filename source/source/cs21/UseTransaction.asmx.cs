using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.EnterpriseServices;

namespace ws_practice_cs
{
	/// <summary>
	/// Summary description for UseTransaction.
	/// </summary>
	public class UseTransaction : System.Web.Services.WebService
	{
		public UseTransaction()
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

		[WebMethod(TransactionOption=TransactionOption.RequiresNew)]
		public string TransactionTest()
		{
			// ���������� ����� SQL��
			string strSQL1 = "INSERT INTO region(regionid,regiondescription) VALUES(5,'���ʱ�')";
			// ���ܸ� �߻���ų SQL��
			string strSQL2 = "DELETE FROM unknown_table";

			SqlConnection conn = new SqlConnection("server=(local);database=Northwind;uid=sa;pwd=;");
			conn.Open();

			SqlCommand comm1 = new SqlCommand(strSQL1, conn);
			SqlCommand comm2 = new SqlCommand(strSQL2, conn);

			try
			{
				// comm1�� ���������� ����ȴ�.
				comm1.ExecuteNonQuery();

				// comm2�� unknown_table�� ã�� �� ���ٴ� ������ �߻��� ���̴�.
				// �� �� �޼ҵ�� Ʈ����ǿ� �����ϰ� �����Ƿ�
				// comm1���� ����� ����� �ڵ����� rollback �� ���̴�.
				comm2.ExecuteNonQuery();

				ContextUtil.SetComplete();

				return "Transaction Committed!";
			}
			catch (System.Exception ex)
			{
				ContextUtil.SetAbort();

				return "Transaction Rollbacked! : " + ex.Message;
			}
			finally
			{
				conn.Close();
			}

		}

//		[WebMethod]
//		public string HelloWorld()
//		{
//			return "Hello World";
//		}
	}
}
